namespace Ttms.Crm.FunctionApp.V4.Common
{
    public class GenericResult
    {
        public bool Succeeded { get; set; }
        public string ErrorMessage { get; set; }

        public static GenericResult Success()
        {
            return new GenericResult()
            {
                Succeeded = true,
                ErrorMessage = "Success"
            };
        }
    }
}
