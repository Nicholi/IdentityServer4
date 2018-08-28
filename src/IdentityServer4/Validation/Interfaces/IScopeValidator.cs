using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServer4.Validation.Interfaces
{
    /// <summary>
    /// Interface for the scope validator
    /// </summary>
    public interface IScopeValidator
    {
        /// <summary>
        /// Gets a value indicating whether this instance contains identity scopes
        /// </summary>
        /// <value>
        ///   <c>true</c> if it contains identity scopes; otherwise, <c>false</c>.
        /// </value>
        bool ContainsOpenIdScopes { get; }

        /// <summary>
        /// Gets a value indicating whether this instance contains API scopes.
        /// </summary>
        /// <value>
        ///   <c>true</c> if it contains API scopes; otherwise, <c>false</c>.
        /// </value>
        bool ContainsApiResourceScopes { get; }

        /// <summary>
        /// Gets a value indicating whether this instance contains the offline access scope.
        /// </summary>
        /// <value>
        ///   <c>true</c> if it contains the offline access scope; otherwise, <c>false</c>.
        /// </value>
        bool ContainsOfflineAccessScope { get; }

        /// <summary>
        /// Gets the requested resources.
        /// </summary>
        /// <value>
        /// The requested resources.
        /// </value>
        Resources RequestedResources { get; }

        /// <summary>
        /// Gets the granted resources.
        /// </summary>
        /// <value>
        /// The granted resources.
        /// </value>
        Resources GrantedResources { get; }

        /// <summary>
        /// Validates the required scopes.
        /// </summary>
        /// <param name="consentedScopes">The consented scopes.</param>
        /// <returns></returns>
        bool ValidateRequiredScopes(IEnumerable<string> consentedScopes);

        /// <summary>
        /// Sets the consented scopes.
        /// </summary>
        /// <param name="consentedScopes">The consented scopes.</param>
        void SetConsentedScopes(IEnumerable<string> consentedScopes);

        /// <summary>
        /// Valides given scopes
        /// </summary>
        /// <param name="requestedScopes">The requested scopes.</param>
        /// <returns></returns>
        Task<bool> AreScopesValidAsync(IEnumerable<string> requestedScopes);

        /// <summary>
        /// Checks is scopes are allowed.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="requestedScopes">The requested scopes.</param>
        /// <returns></returns>
        Task<bool> AreScopesAllowedAsync(Client client, IEnumerable<string> requestedScopes);

        /// <summary>
        /// Determines whether the response type is valid.
        /// </summary>
        /// <param name="responseType">Type of the response.</param>
        /// <returns>
        ///   <c>true</c> if the response type is valid; otherwise, <c>false</c>.
        /// </returns>
        bool IsResponseTypeValid(string responseType);
    }
}
