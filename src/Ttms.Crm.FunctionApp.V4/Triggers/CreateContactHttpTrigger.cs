using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.V4.Common;
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
                CrmConnection crmConnection = new(log, "CrmConnectionString");
                service = crmConnection.Connect();
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Could not connect to dataverse - {Exception}.", nameof(CreateContactHttpTrigger), ex.ToString());
                service?.Dispose();

                return new UnauthorizedObjectResult(ex.Message);
            }

            try
            {
                string requestBody = await req.ReadAsStringAsync();
                JsonElement requestData = JsonSerializer.Deserialize<JsonElement>(requestBody);
                string firstName = requestData
                    .GetProperty("firstName")
                    .GetString();

                string lastName = requestData
                    .GetProperty("lastName")
                    .GetString();

                string email = requestData
                    .GetProperty("email")
                    .GetString();

                GenericResult result = await CreateContactAsync(service, firstName, lastName, email);
                return new OkObjectResult(JsonSerializer.Serialize(result));
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: context processing - {Exception}.", nameof(CreateContactHttpTrigger), ex.ToString());
                return new BadRequestObjectResult(ex.Message);
            }
            finally
            {
                service?.Dispose();
            }
        }

        internal static async Task<GenericResult> CreateContactAsync(ServiceClient service,
                                                                     string firstName,
                                                                     string lastName,
                                                                     string email)
        {
            await service.CreateAsync(new Contact()
            {
                ["firstname"] = firstName,
                ["lastname"] = lastName,
                ["emailaddress1"] = email
            });

            return GenericResult.Success();
        }

        internal static GenericResult CreateContact(ServiceClient service,
                                                    string firstName,
                                                    string lastName,
                                                    string email)
        {
            service.Create(new Entity("contact")
            {
                ["firstname"] = firstName,
                ["lastname"] = lastName,
                ["emailaddress1"] = email
            });

            return GenericResult.Success();
        }

        internal static GenericResult CreateContactRequest(ServiceClient service,
                                                           string firstName,
                                                           string lastName,
                                                           string email)
        {
            service.Execute(new CreateRequest()
            {
                Target =
                new Entity("contact")
                {
                    ["firstname"] = firstName,
                    ["lastname"] = lastName,
                    ["emailaddress1"] = email
                }
            });

            return GenericResult.Success();
        }
    }
}
