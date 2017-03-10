﻿using System;
using System.Threading.Tasks;
using Microsoft.HealthVault.Clients;
using Microsoft.HealthVault.Configuration;
using Microsoft.HealthVault.Person;
using Microsoft.HealthVault.PlatformInformation;
using Microsoft.HealthVault.Record;
using Microsoft.HealthVault.Transport;

namespace Microsoft.HealthVault.Connection
{
    /// <summary>
    /// Represents a connection for an application to the HealthVault service
    /// for operations
    /// </summary>
    public interface IHealthVaultConnection
    {
        /// <summary>
        /// The HealthVault web-service instance.
        /// </summary>
        HealthServiceInstance ServiceInstance { get; }

        /// <summary>
        /// Gets or sets the application configuration.
        /// </summary>
        /// <value>
        /// The application configuration.
        /// </value>
        IConfiguration ApplicationConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the session credential.
        /// </summary>
        /// <value>
        /// The session credential.
        /// </value>
        SessionCredential SessionCredential { get; }

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        Guid ApplicationId { get; }

        /// <summary>
        /// Gets a client of a given type.
        /// </summary>
        /// <typeparam name="TClient">The type of the client to retrieve</typeparam>
        /// <returns>A client instance</returns>
        TClient GetClient<TClient>()
            where TClient : IClient;

        /// <summary>
        /// A client that can be used to access information about the platform.
        /// </summary>
        IPlatformClient PlatformClient { get; }

        /// <summary>
        /// A client that can be used to access information and records associated with the currently athenticated user.
        /// </summary>
        IPersonClient PersonClient { get; }

        /// <summary>
        /// A client that can be used to access vocabularies.
        /// </summary>
        IVocabularyClient VocabularyClient { get; }

        /// <summary>
        /// Gets a client that can be used to access things associated with a particular record.
        /// </summary>
        /// <param name="record">The record to associate the thing client with</param>
        /// <returns>An instance implementing IThingClient</returns>
        IThingClient GetThingClient(HealthRecordInfo record);

        /// <summary>
        /// Gets a client that can be used to access action plans associated with a particular record
        /// </summary>
        /// <param name="record">The record to associate the action plan client with</param>
        /// <returns>An instance implementing IActionPlanClient</returns>
        IActionPlanClient GetActionPlanClient(HealthRecordInfo record);

        /// <summary>
        /// Authenticates the connection.
        /// </summary>
        /// <remarks> This should depend on application platform - SODA vs WEB </remarks>
        Task AuthenticateAsync();

        /// <summary>
        /// Makes Web request call to HealthVault service 
        /// for specified method name and method version
        /// </summary>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="methodVersion">The method version.</param>
        /// <param name="parameters">Method parameters</param>
        /// <param name="recordId">Record Id</param>
        /// <returns>HealthServiceResponseData</returns>
        Task<HealthServiceResponseData> ExecuteAsync(
            string methodName,
            int methodVersion,
            string parameters = null,
            Guid? recordId = null);
    }
}