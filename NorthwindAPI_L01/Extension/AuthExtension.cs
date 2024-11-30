using Microsoft.AspNetCore.Authentication;
using NorthwindAPI_L01.Auth;

namespace NorthwindAPI_L01.Extension
{
    public static class AuthExtension
    {
        public static AuthenticationBuilder AddApiKeySupport(this AuthenticationBuilder authBuilder, Action<ApiKeyAuthenticationOptions> options)
        {
            return authBuilder.AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>(
                ApiKeyAuthenticationOptions.DefaultScheme, options);
        }

    }
}
