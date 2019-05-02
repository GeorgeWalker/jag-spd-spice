// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// quotedetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMquotedetail
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquotedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquotedetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquotedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquotedetail(string quotedetailname = default(string), string _parentbundleidrefValue = default(string), string description = default(string), string _owninguserValue = default(string), string shiptoName = default(string), string quotedetailid = default(string), string shiptoContactname = default(string), string _modifiedbyValue = default(string), object baseamountBase = default(object), int? sequencenumber = default(int?), string shiptoFax = default(string), object exchangerate = default(object), string parentbundleid = default(string), string _salesrepidValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string productassociationid = default(string), object priceperunit = default(object), int? propertyconfigurationstatus = default(int?), bool? ispriceoverridden = default(bool?), int? producttypecode = default(int?), string productname = default(string), object tax = default(object), string _owningbusinessunitValue = default(string), string _productidValue = default(string), object manualdiscountamountBase = default(object), object extendedamountBase = default(object), object manualdiscountamount = default(object), int? timezoneruleversionnumber = default(int?), object extendedamount = default(object), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? requestdeliveryby = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string _owningteamValue = default(string), string shiptoTelephone = default(string), bool? willcall = default(bool?), string productdescription = default(string), object volumediscountamount = default(object), object baseamount = default(object), string shiptoAddressid = default(string), string shiptoPostalcode = default(string), string _quoteidValue = default(string), string shiptoStateorprovince = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object quantity = default(object), int? lineitemnumber = default(int?), string shiptoCity = default(string), object taxBase = default(object), long? versionnumber = default(long?), string shiptoCountry = default(string), bool? isproductoverridden = default(bool?), string _uomidValue = default(string), object priceperunitBase = default(object), string shiptoLine2 = default(string), object volumediscountamountBase = default(object), string shiptoLine1 = default(string), int? quotestatecode = default(int?), int? pricingerrorcode = default(int?), string _owneridValue = default(string), int? shiptoFreighttermscode = default(int?), string _modifiedonbehalfbyValue = default(string), string shiptoLine3 = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> quoteDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> quoteDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> quotedetailMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> quoteDetailProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quoteDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> quotedetailPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> quoteDetailDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), MicrosoftDynamicsCRMquotedetail parentbundleidQuotedetail = default(MicrosoftDynamicsCRMquotedetail), IList<MicrosoftDynamicsCRMquotedetail> quotedetailParentQuotedetail = default(IList<MicrosoftDynamicsCRMquotedetail>), MicrosoftDynamicsCRMsystemuser salesrepid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMsalesorderdetail> msdynQuotedetailSalesorderdetail = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), MicrosoftDynamicsCRMquotedetail parentbundleidrefQuotedetail = default(MicrosoftDynamicsCRMquotedetail), IList<MicrosoftDynamicsCRMquotedetail> quotedetailParentrefQuotedetail = default(IList<MicrosoftDynamicsCRMquotedetail>))
        {
            Quotedetailname = quotedetailname;
            this._parentbundleidrefValue = _parentbundleidrefValue;
            Description = description;
            this._owninguserValue = _owninguserValue;
            ShiptoName = shiptoName;
            Quotedetailid = quotedetailid;
            ShiptoContactname = shiptoContactname;
            this._modifiedbyValue = _modifiedbyValue;
            BaseamountBase = baseamountBase;
            Sequencenumber = sequencenumber;
            ShiptoFax = shiptoFax;
            Exchangerate = exchangerate;
            Parentbundleid = parentbundleid;
            this._salesrepidValue = _salesrepidValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Productassociationid = productassociationid;
            Priceperunit = priceperunit;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            Ispriceoverridden = ispriceoverridden;
            Producttypecode = producttypecode;
            Productname = productname;
            Tax = tax;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._productidValue = _productidValue;
            ManualdiscountamountBase = manualdiscountamountBase;
            ExtendedamountBase = extendedamountBase;
            Manualdiscountamount = manualdiscountamount;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Extendedamount = extendedamount;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Requestdeliveryby = requestdeliveryby;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            ShiptoTelephone = shiptoTelephone;
            Willcall = willcall;
            Productdescription = productdescription;
            Volumediscountamount = volumediscountamount;
            Baseamount = baseamount;
            ShiptoAddressid = shiptoAddressid;
            ShiptoPostalcode = shiptoPostalcode;
            this._quoteidValue = _quoteidValue;
            ShiptoStateorprovince = shiptoStateorprovince;
            Modifiedon = modifiedon;
            Quantity = quantity;
            Lineitemnumber = lineitemnumber;
            ShiptoCity = shiptoCity;
            TaxBase = taxBase;
            Versionnumber = versionnumber;
            ShiptoCountry = shiptoCountry;
            Isproductoverridden = isproductoverridden;
            this._uomidValue = _uomidValue;
            PriceperunitBase = priceperunitBase;
            ShiptoLine2 = shiptoLine2;
            VolumediscountamountBase = volumediscountamountBase;
            ShiptoLine1 = shiptoLine1;
            Quotestatecode = quotestatecode;
            Pricingerrorcode = pricingerrorcode;
            this._owneridValue = _owneridValue;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            ShiptoLine3 = shiptoLine3;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            QuoteDetailSyncErrors = quoteDetailSyncErrors;
            QuoteDetailAsyncOperations = quoteDetailAsyncOperations;
            QuotedetailMailboxTrackingFolders = quotedetailMailboxTrackingFolders;
            QuoteDetailProcessSessions = quoteDetailProcessSessions;
            QuoteDetailBulkDeleteFailures = quoteDetailBulkDeleteFailures;
            QuotedetailPrincipalobjectattributeaccess = quotedetailPrincipalobjectattributeaccess;
            Transactioncurrencyid = transactioncurrencyid;
            Productid = productid;
            ProductassociationidProductassociation = productassociationidProductassociation;
            Quoteid = quoteid;
            QuoteDetailDynamicpropertyinstance = quoteDetailDynamicpropertyinstance;
            ParentbundleidQuotedetail = parentbundleidQuotedetail;
            QuotedetailParentQuotedetail = quotedetailParentQuotedetail;
            Salesrepid = salesrepid;
            Uomid = uomid;
            MsdynQuotedetailSalesorderdetail = msdynQuotedetailSalesorderdetail;
            ParentbundleidrefQuotedetail = parentbundleidrefQuotedetail;
            QuotedetailParentrefQuotedetail = quotedetailParentrefQuotedetail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetailname")]
        public string Quotedetailname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentbundleidref_value")]
        public string _parentbundleidrefValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetailid")]
        public string Quotedetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_contactname")]
        public string ShiptoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public object BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesrepid_value")]
        public string _salesrepidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public object Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productname")]
        public string Productname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public object Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public object ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public object ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public object Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public object Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestdeliveryby")]
        public System.DateTimeOffset? Requestdeliveryby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public object Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public object Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_addressid")]
        public string ShiptoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public object Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public object TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public object PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public object VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotestatecode")]
        public int? Quotestatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QuoteDetailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuoteDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> QuotedetailMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> QuoteDetailProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuoteDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> QuotedetailPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteDetail_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> QuoteDetailDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail ParentbundleidQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_parent_quotedetail")]
        public IList<MicrosoftDynamicsCRMquotedetail> QuotedetailParentQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesrepid")]
        public MicrosoftDynamicsCRMsystemuser Salesrepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_quotedetail_salesorderdetail")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> MsdynQuotedetailSalesorderdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleidref_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail ParentbundleidrefQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotedetail_parentref_quotedetail")]
        public IList<MicrosoftDynamicsCRMquotedetail> QuotedetailParentrefQuotedetail { get; set; }

    }
}
