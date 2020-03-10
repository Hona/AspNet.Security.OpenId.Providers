﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OpenId.Events
{
    public class OpenIdRedirectContext : PropertiesContext<OpenIdAuthenticationOptions>
    {
        public OpenIdRedirectContext(HttpContext context,
            AuthenticationScheme scheme,
            OpenIdAuthenticationOptions options,
            AuthenticationProperties properties,
            OpenIdAuthenticationMessage message)
            : base(context, scheme, options, properties)
        {
            ProtocolMessage = message;
        }

        /// <summary>
        /// Gets or sets the protocol message that has been generated by the handler up to this point.
        /// </summary>
        public OpenIdAuthenticationMessage ProtocolMessage { get; set; }
    }
}
