namespace Ttms.Crm.FunctionApp.Common
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
