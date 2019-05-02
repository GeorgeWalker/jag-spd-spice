// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Exportrequestincidentset.
    /// </summary>
    public static partial class ExportrequestincidentsetExtensions
    {
            /// <summary>
            /// Get entities from spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static ExportrequestincidentsetGetResponseModel Get(this IExportrequestincidentset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExportrequestincidentsetGetResponseModel> GetAsync(this IExportrequestincidentset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMspiceExportrequestIncident Create(this IExportrequestincidentset operations, MicrosoftDynamicsCRMspiceExportrequestIncident body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceExportrequestIncident> CreateAsync(this IExportrequestincidentset operations, MicrosoftDynamicsCRMspiceExportrequestIncident body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from spice_exportrequest_incidentset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestIncidentid'>
            /// key: spice_exportrequest_incidentid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceExportrequestIncident GetByKey(this IExportrequestincidentset operations, string spiceExportrequestIncidentid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(spiceExportrequestIncidentid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from spice_exportrequest_incidentset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestIncidentid'>
            /// key: spice_exportrequest_incidentid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceExportrequestIncident> GetByKeyAsync(this IExportrequestincidentset operations, string spiceExportrequestIncidentid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(spiceExportrequestIncidentid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete entity from spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestIncidentid'>
            /// key: spice_exportrequest_incidentid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IExportrequestincidentset operations, string spiceExportrequestIncidentid, string ifMatch = default(string))
            {
                operations.DeleteAsync(spiceExportrequestIncidentid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestIncidentid'>
            /// key: spice_exportrequest_incidentid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExportrequestincidentset operations, string spiceExportrequestIncidentid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(spiceExportrequestIncidentid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestIncidentid'>
            /// key: spice_exportrequest_incidentid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IExportrequestincidentset operations, string spiceExportrequestIncidentid, MicrosoftDynamicsCRMspiceExportrequestIncident body)
            {
                operations.UpdateAsync(spiceExportrequestIncidentid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in spice_exportrequest_incidentset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestIncidentid'>
            /// key: spice_exportrequest_incidentid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IExportrequestincidentset operations, string spiceExportrequestIncidentid, MicrosoftDynamicsCRMspiceExportrequestIncident body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(spiceExportrequestIncidentid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
