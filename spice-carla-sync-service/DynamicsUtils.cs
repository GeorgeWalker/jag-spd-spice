﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Gov.Jag.Spice.CarlaSync.models;
using Gov.Jag.Spice.Interfaces;
using Gov.Jag.Spice.Interfaces.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using SpdSync.models;
using SpiceCarlaSync.models;

namespace Gov.Jag.Spice.CarlaSync
{
    public class DynamicsUtils
    {
        private IDynamicsClient _dynamicsClient;
        private IConfiguration Configuration { get; }
        private ILogger _logger { get; }

        public DynamicsUtils(IConfiguration configuration, ILoggerFactory loggerFactory, IDynamicsClient dynamicsClient)
        {
            Configuration = configuration;
            _dynamicsClient = dynamicsClient;
            _logger = loggerFactory.CreateLogger(typeof(DynamicsUtils));
        }

        /// <summary>
        /// Import requests to Dynamics.
        /// </summary>
        /// <returns></returns>
        public void ImportApplicationRequests(List<ApplicationScreeningRequest> requests)
        {
            try
            {
                foreach (ApplicationScreeningRequest applicationRequest in requests)
                {
                    // TODO Look up if company exists already
                    MicrosoftDynamicsCRMspiceCompany company = _dynamicsClient.Companies.Create(new MicrosoftDynamicsCRMspiceCompany()
                    {
                        SpiceName = applicationRequest.ApplicantAccount.Name,
                        //SpiceBusinesstypes = applicationRequest.,
                        SpiceStreet = applicationRequest.BusinessAddress.AddressStreet1,
                        SpiceCity = applicationRequest.BusinessAddress.City,
                        SpiceProvince = applicationRequest.BusinessAddress.StateProvince,
                        SpiceCountry = applicationRequest.BusinessAddress.Country,
                        SpicePostalcode = applicationRequest.BusinessAddress.Postal
                    });

                    // Contact person
                    string uniqueFilter = "externaluseridentifier eq '" + applicationRequest.ContactPerson.ContactId + "'";
                    ContactsGetResponseModel contactResponse = _dynamicsClient.Contacts.Get(1, filter: uniqueFilter);
                    MicrosoftDynamicsCRMcontact contactPerson;
                    if (contactResponse.Value.Count > 0)
                    {
                        contactPerson = contactResponse.Value[0];
                    }
                    else
                    {
                        contactPerson = _dynamicsClient.Contacts.Create(new MicrosoftDynamicsCRMcontact()
                        {
                            Externaluseridentifier = applicationRequest.ContactPerson.ContactId,
                            Firstname = applicationRequest.ContactPerson.FirstName,
                            Middlename = applicationRequest.ContactPerson.MiddleName,
                            Lastname = applicationRequest.ContactPerson.LastName,
                            Emailaddress1 = applicationRequest.ContactPerson.Email,
                            Telephone1 = applicationRequest.ContactPerson.PhoneNumber
                        });
                    }


                    uniqueFilter = "spice_carla_account eq '" + applicationRequest.ApplicantAccount.AccountId + "'";
                    AccountsGetResponseModel accountResponse = _dynamicsClient.Accounts.Get(1, filter: uniqueFilter);
                    MicrosoftDynamicsCRMaccount account;
                    if (accountResponse.Value.Count > 0)
                    {
                        account = accountResponse.Value[0];
                    }
                    else
                    {
                        account = _dynamicsClient.Accounts.Create(new MicrosoftDynamicsCRMaccount()
                        {
                            Name = applicationRequest.ApplicantAccount.Name,
                            Address1Line1 = applicationRequest.BusinessAddress.AddressStreet1,
                            Address1City = applicationRequest.BusinessAddress.City,
                            Address1Country = applicationRequest.BusinessAddress.Country,
                            Address1Postalcode = applicationRequest.BusinessAddress.Postal,
                            SpiceLcrbjobid = applicationRequest.RecordIdentifier,
                            SpiceParcelidnumber = applicationRequest.Establishment.ParcelId,
                            SpiceBccorpregnumber = applicationRequest.ApplicantAccount.BCIncorporationNumber,
                            SpiceCompanyIdOdataBind = _dynamicsClient.GetEntityURI("spice_companies", company.SpiceCompanyid),
                            PrimaryContactIdOdataBind = _dynamicsClient.GetEntityURI("contacts", contactPerson.Contactid)
                        });
                    }

                    string accountEntityUri = _dynamicsClient.GetEntityURI("accounts", account.Accountid);

                    string servicesFilter = "spice_name eq 'Cannabis Applicant (Business)'";
                    var service = _dynamicsClient.Serviceses.Get(filter: servicesFilter).Value[0];

                    string clientFilter = "spice_name eq 'LCRB'";
                    var client = _dynamicsClient.Ministries.Get(filter: clientFilter).Value[0];
                    string clientEntityUri = _dynamicsClient.GetEntityURI("spice_ministries", client.SpiceMinistryid);

                    MicrosoftDynamicsCRMincident incident = _dynamicsClient.Incidents.Create(new MicrosoftDynamicsCRMincident()
                    {
                        SpiceCannabisapplicanttype = (int)CannabisApplicantType.Business,
                        SpiceApplicanttype = (int)SpiceApplicantType.Cannabis,
                        Prioritycode = (int)PriorityCode.Normal,
                        CustomerIdAccountOdataBind = accountEntityUri,
                        SpiceServiceIdODataBind = _dynamicsClient.GetEntityURI("spice_serviceses", service.SpiceServicesid),
                        SpiceClientIdODataBind = clientEntityUri
                    });

                    foreach (var associate in applicationRequest.Associates)
                    {
                        CreateAssociate(clientEntityUri, accountEntityUri, incident.Incidentid, associate);
                    }

                }
            }
            catch (OdataerrorException e)
            {
                _logger.LogError(e.Message);
            }
        }

        internal void ImportWorkerRequests(List<WorkerScreeningRequest> requests)
        {
            try
            {
                foreach (WorkerScreeningRequest workerRequest in requests)
                {
                    MicrosoftDynamicsCRMcontact contact = new MicrosoftDynamicsCRMcontact()
                    {
                        Firstname = workerRequest.Contact.FirstName,
                        Middlename = workerRequest.Contact.MiddleName,
                        Lastname = workerRequest.Contact.LastName,
                        Emailaddress1 = workerRequest.Contact.Email,
                        Telephone1 = workerRequest.Contact.PhoneNumber,
                        SpiceDateofbirth = workerRequest.BirthDate,
                        SpiceBirthplace = workerRequest.Birthplace,
                        SpiceSelfdisclosed = workerRequest.SelfDisclosure == GeneralYesNo.Yes,
                        Address1Line1 = workerRequest.Contact.Address.AddressStreet1,
                        Address1Line2 = workerRequest.Contact.Address.AddressStreet2,
                        Address1Line3 = workerRequest.Contact.Address.AddressStreet3,
                        Address1City = workerRequest.Contact.Address.City,
                        Address1Postalcode = workerRequest.Contact.Address.Postal,
                        Address1Stateorprovince = workerRequest.Contact.Address.StateProvince,
                        Address1Country = workerRequest.Contact.Address.Country,
                        SpiceContactSpicePreviousaddresses = new List<MicrosoftDynamicsCRMspicePreviousaddresses>(),
                        SpiceContactSpiceAliases = new List<MicrosoftDynamicsCRMspiceAliases>(),
                    };
                    if ((int)workerRequest.Gender != 0)
                    {
                        contact.Gendercode = (int)workerRequest.Gender;
                    }

                    foreach (var address in workerRequest.PreviousAddresses)
                    {
                        contact.SpiceContactSpicePreviousaddresses.Add(new MicrosoftDynamicsCRMspicePreviousaddresses()
                        {
                            SpiceName = address.AddressStreet1,
                            SpiceCity = address.City,
                            SpiceStateprovince = address.StateProvince,
                            SpiceZippostalcode = address.Postal,
                            SpiceCountry = address.Country,
                            SpiceStartdate = address.FromDate,
                            SpiceEnddate = address.ToDate
                        });
                    }

                    foreach (var alias in workerRequest.Aliases)
                    {
                        contact.SpiceContactSpiceAliases.Add(new MicrosoftDynamicsCRMspiceAliases()
                        {
                            SpiceName = alias.GivenName,
                            SpiceMiddlename = alias.SecondName,
                            SpiceLastname = alias.Surname,
                        });
                    }

                    contact = _dynamicsClient.Contacts.Create(contact);

                    string servicesFilter = "spice_name eq 'Cannabis Worker'";
                    var service = _dynamicsClient.Serviceses.Get(filter: servicesFilter).Value[0];

                    string clientFilter = "spice_name eq 'LCRB'";
                    var client = _dynamicsClient.Ministries.Get(filter: clientFilter).Value[0];

                    MicrosoftDynamicsCRMincident incident = _dynamicsClient.Incidents.Create(new MicrosoftDynamicsCRMincident()
                    {
                        SpiceCannabisapplicanttype = (int)CannabisApplicantType.Worker,
                        SpiceApplicanttype = (int)SpiceApplicantType.Cannabis,
                        Prioritycode = (int)PriorityCode.Normal,
                        SpiceServiceIdODataBind = _dynamicsClient.GetEntityURI("spice_serviceses", service.SpiceServicesid),
                        SpiceClientIdODataBind = _dynamicsClient.GetEntityURI("spice_ministries", client.SpiceMinistryid),
                        CustomerIdODataBind = _dynamicsClient.GetEntityURI("contacts", contact.Contactid)
                    });
                }
            }
            catch (OdataerrorException e)
            {
                _logger.LogError(e.Message);
            }
        }

        public void CreateAssociate(string clientEntityUri, string accountEntityUri, string screeningId, LegalEntity associateEntity)
        {
            if (associateEntity.IsIndividual)
            {
                // Contact
                string uniqueFilter = "externaluseridentifier eq '" + associateEntity.Contact.ContactId + "'";
                ContactsGetResponseModel contactResponse = _dynamicsClient.Contacts.Get(1, filter: uniqueFilter);
                MicrosoftDynamicsCRMcontact associate;
                if (contactResponse.Value.Count > 0)
                {
                    associate = contactResponse.Value[0];
                }
                else
                {
                    associate = new MicrosoftDynamicsCRMcontact()
                    {
                        Firstname = associateEntity.Contact.FirstName,
                        Middlename = associateEntity.Contact.MiddleName,
                        Lastname = associateEntity.Contact.LastName,
                        Emailaddress1 = associateEntity.Contact.Email,
                        Telephone1 = associateEntity.Contact.PhoneNumber,
                        SpiceDriverslicencenum = associateEntity.Contact.DriversLicenceNumber,
                        SpiceBcidcardnumber = associateEntity.Contact.BCIdCardNumber,
                        SpiceDateofbirth = associateEntity.Contact.BirthDate.Value.UtcDateTime,
                        SpiceBirthplace = associateEntity.Contact.Birthplace,
                        SpiceSelfdisclosed = associateEntity.Contact.SelfDisclosure == GeneralYesNo.Yes,
                        Address1Line1 = associateEntity.Contact.Address.AddressStreet1,
                        Address1Line2 = associateEntity.Contact.Address.AddressStreet2,
                        Address1Line3 = associateEntity.Contact.Address.AddressStreet3,
                        Address1City = associateEntity.Contact.Address.City,
                        Address1Postalcode = associateEntity.Contact.Address.Postal,
                        Address1Stateorprovince = associateEntity.Contact.Address.StateProvince,
                        Address1Country = associateEntity.Contact.Address.Country,
                        SpiceContactSpicePreviousaddresses = new List<MicrosoftDynamicsCRMspicePreviousaddresses>(),
                        SpiceContactSpiceAliases = new List<MicrosoftDynamicsCRMspiceAliases>(),
                        SpicePositiontitle = associateEntity.Title
                    };

                    if ((int)associateEntity.Contact.Gender != 0)
                    {
                        associate.Gendercode = (int)associateEntity.Contact.Gender;
                    }

                    foreach (var address in associateEntity.PreviousAddresses)
                    {
                        associate.SpiceContactSpicePreviousaddresses.Add(new MicrosoftDynamicsCRMspicePreviousaddresses()
                        {
                            SpiceName = address.AddressStreet1,
                            SpiceCity = address.City,
                            SpiceStateprovince = address.StateProvince,
                            SpiceZippostalcode = address.Postal,
                            SpiceCountry = address.Country,
                            SpiceStartdate = address.FromDate,
                            SpiceEnddate = address.ToDate
                        });
                    }

                    foreach (var alias in associateEntity.Aliases)
                    {
                        associate.SpiceContactSpiceAliases.Add(new MicrosoftDynamicsCRMspiceAliases()
                        {
                            SpiceName = alias.GivenName,
                            SpiceMiddlename = alias.SecondName,
                            SpiceLastname = alias.Surname,
                        });
                    }
                    associate = _dynamicsClient.Contacts.Create(associate);
                }


                MicrosoftDynamicsCRMspiceAccountcaseassignment accountContact = _dynamicsClient.Accountcaseassignments.Create(new MicrosoftDynamicsCRMspiceAccountcaseassignment()
                {
                    SpiceName = associateEntity.Contact.FirstName,
                    SpiceBusinessIdODataBind = accountEntityUri,
                    SpiceContactCaseAssignmentIdODataBind = _dynamicsClient.GetEntityURI("contacts", associate.Contactid),
                    SpicePosition = GetLegalEntityPositions(associateEntity.Positions)
                });

                string servicesFilter = "spice_name eq 'Cannabis Associate'";
                var service = _dynamicsClient.Serviceses.Get(filter: servicesFilter).Value[0];

                MicrosoftDynamicsCRMincident incident = new MicrosoftDynamicsCRMincident()
                {
                    SpiceApplicanttype = (int)SpiceApplicantType.Cannabis,
                    SpiceCannabisapplicanttype = (int)CannabisApplicantType.Associate,
                    CustomerIdODataBind = _dynamicsClient.GetEntityURI("contacts", associate.Contactid),
                    ParentCaseIdOdataBind = _dynamicsClient.GetEntityURI("incidents", screeningId),
                    SpiceServiceIdODataBind = _dynamicsClient.GetEntityURI("spice_serviceses", service.SpiceServicesid),
                    SpiceClientIdODataBind = clientEntityUri
                };

                MicrosoftDynamicsCRMincident createdIncident = _dynamicsClient.Incidents.Create(incident);
            }
            else
            {
                foreach (var associate in associateEntity.Account.Associates)
                {
                    CreateAssociate(clientEntityUri, accountEntityUri, screeningId, associate);
                }
            }
        }

        public string GetLegalEntityPositions(List<string> positions)
        {
            List<int> positionValues = new List<int>();
            foreach (var position in positions)
            {
                if (position == "director")
                {
                    positionValues.Add((int)Positions.Director);
                }
                if (position == "officer")
                {
                    positionValues.Add((int)Positions.Officer);
                }
                if (position == "senior manager")
                {
                    positionValues.Add((int)Positions.SeniorManager);
                }
                if (position == "key personnel")
                {
                    positionValues.Add((int)Positions.KeyPersonnel);
                }
                if (position == "shareholder")
                {
                    positionValues.Add((int)Positions.Shareholder);
                }
                if (position == "owner")
                {
                    positionValues.Add((int)Positions.Owner);
                }
                if (position == "trustee")
                {
                    positionValues.Add((int)Positions.Trustee);
                }
                if (position == "deemed associate")
                {
                    positionValues.Add((int)Positions.DeemedAssociate);
                }
                if (position == "partner")
                {
                    positionValues.Add((int)Positions.Partner);
                }
            }
            return string.Join(", ", positionValues);
        }
    }
}
