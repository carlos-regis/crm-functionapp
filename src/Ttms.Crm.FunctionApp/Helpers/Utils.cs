using System;

namespace Ttms.Crm.FunctionApp.Helpers
{
    public static class Utils
    {
        /// <summary>Get variable stored for local and remote in application settings.</summary>
        /// <param name="envVarName"></param>
        /// <returns>The value associated with the environment variable</returns>
        public static string GetEnvironmentVariables(string envVarName)
        {
            return Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.Process);
        }
    }
}
