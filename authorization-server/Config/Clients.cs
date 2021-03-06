using System.Collections.Generic;
using IdentityServer4.Models;

namespace AuthorizationServer
{
    public static class Clients
    {
        public static IEnumerable<Client> Get() => new List<Client>
            {
                new Client
                {
                    ClientId = "ruby",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes =  {"jwt-otp"},

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "sensitive.read" }
                }
            };
    }
}