using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Models;
using Ttms.Crm.FunctionApp.Services.Contracts;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class CreateContactHttpTrigger
    {
        private readonly ICrmService _crmService;

        public CreateContactHttpTrigger(ICrmService crmService)
        {
            _crmService = crmService ?? throw new ArgumentNullException(nameof(crmService));
        }

        [FunctionName(nameof(CreateContactHttpTrigger))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("The {Function} function processed a request.", nameof(CreateContactHttpTrigger));

            try
            {
                string requestBody = await req.ReadAsStringAsync();
                JsonElement requestData = JsonSerializer.Deserialize<JsonElement>(requestBody);

                // TODO: Refactor to return as per Operation Result pattern
                return new JsonResult(await CreateContactAsync(CreateEntity(requestData)));
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Could not get contact from the organization service - {Exception}.", nameof(CreateContactHttpTrigger), ex.ToString());
                return new BadRequestObjectResult(ex.Message);
            }
        }

        internal static Entity CreateEntity(JsonElement requestData)
        {
            string firstName = requestData
                                    .GetProperty("firstName")
                                    .GetString();

            string lastName = requestData
                                    .GetProperty("lastName")
                                    .GetString();

            string email = requestData
                                    .GetProperty("email")
                                    .GetString();

            return new Entity("contact")
            {
                ["firstname"] = firstName,
                ["lastname"] = lastName,
                ["emailaddress1"] = email
            };
        }

        internal async Task<CrmResponse> CreateContactAsync(Entity entity)
        {
            return new CrmResponse
            {
                Id = await _crmService.CreateAsync(entity)
            };
        }
    }
}
