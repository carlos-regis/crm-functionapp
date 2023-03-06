using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.V4.Helpers;

namespace Ttms.Crm.FunctionApp.V4.Triggers
{
    public class DataverseConnectionHttpTrigger
    {
        [FunctionName(nameof(DataverseConnectionHttpTrigger))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req, ILogger _logger)
        {
            ServiceClient service = null;

            try
            {
                CrmConnection crmConnection = new(_logger);
                service = crmConnection.Connect("CrmConnectionString");

                _logger.LogInformation("Microsoft Dynamics CRM version {Version}.", Common.GetVersion(service));
                _logger.LogInformation("Organization Id: {Id}.", service.ConnectedOrgId);
                _logger.LogInformation("Logged on user is {FullName}.", Common.GetUserFullName(service));
            }
            catch (Exception ex)
            {
                _logger.LogError("{Function} - service connection: {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                service?.Dispose();

                return new NotFoundObjectResult(ex.Message);
            }

            try
            {
                string jsonContext = await req.ReadAsStringAsync();
                _logger.LogInformation("{jsonContext}", jsonContext);

                FunctionProcess.ProcessContext(_logger, Common.GetContext(jsonContext), service);

                Entity contact = new("contact")
                {
                    ["firstname"] = "Rey",
                    ["lastname"] = "Dynamics CRM"
                };

                Guid _contactid = service.Create(contact);

                return new OkObjectResult(string.Format("Contact id: {0}", _contactid.ToString()));
            }
            catch (Exception ex)
            {
                _logger.LogError("{Function} - context processing: {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                return new BadRequestObjectResult(ex.Message);
            }
            finally
            {
                service?.Dispose();
            }
        }
    }
}
