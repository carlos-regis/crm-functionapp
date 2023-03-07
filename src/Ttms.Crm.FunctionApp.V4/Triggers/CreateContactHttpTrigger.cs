using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.V4.Services;

[assembly: InternalsVisibleTo("Ttms.Crm.FunctionApp.UnitTests")]
namespace Ttms.Crm.FunctionApp.V4.Triggers
{
    public static class CreateContactHttpTrigger
    {
        [FunctionName(nameof(CreateContactHttpTrigger))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("{Function} function processed a request.", nameof(CreateContactHttpTrigger));
            ServiceClient service = null;

            try
            {
                CrmConnection crmConnection = new(log);
                service = crmConnection.Connect("CrmConnectionString");
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Could not connect to dataverse - {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                service?.Dispose();

                return new ObjectResult(ex.Message)
                {
                    StatusCode = 401
                };
            }

            string firstName = req.Query["firstname"];
            string lastName = req.Query["lastname"];
            string email = req.Query["email"];

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            string requestBody = await req.ReadAsStringAsync();
            dynamic requestData = JsonConvert.DeserializeObject(requestBody);
            firstName ??= requestData?.firstName;
            lastName ??= requestData?.lastName;
            email ??= requestData?.email;




            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
