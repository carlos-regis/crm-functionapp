using Newtonsoft.Json.Serialization;

namespace Ttms.Crm.FunctionApp.UnitTests.Helpers.Serialization
{
    public class LowerCaseDictionaryKeysContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            if (propertyName == "Key" || propertyName == "Value")
            {
                return char.ToLower(propertyName[0]) + propertyName[1..];
            }

            return propertyName;
        }
    }
}
