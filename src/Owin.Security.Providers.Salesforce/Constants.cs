namespace Owin.Security.Providers.Salesforce
{
    public static class Constants
    {
        public const string DefaultAuthenticationType = "Salesforce";

        public const string EnvironmentAuthenticationProperty = "Environment";
        public const string ProductionEnvironment = "Production";
        public const string SandboxEnvironment = "Sandbox";

        public const string AuthorizationEndpointProperty = "AuthorizationEndpoint";
        public const string TokenEndpointProperty = "TokenEndpoint";
    }
}