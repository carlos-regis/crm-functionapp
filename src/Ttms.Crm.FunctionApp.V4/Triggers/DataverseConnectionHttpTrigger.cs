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
using Ttms.Crm.FunctionApp.V4.Services;

namespace Ttms.Crm.FunctionApp.V4.Triggers
{
    public class DataverseConnectionHttpTrigger
    {
        [FunctionName(nameof(DataverseConnectionHttpTrigger))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            ServiceClient service = null;

            try
            {
                CrmConnection crmConnection = new(log, "CrmConnectionString");
                service = crmConnection.Connect();

                log.LogInformation("Microsoft Dynamics CRM version {Version}.", Utils.GetVersion(service));
                log.LogInformation("Organization Id: {Id}.", service.ConnectedOrgId);
                log.LogInformation("Logged on user is {FullName}.", Utils.GetUserFullName(service));
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Could not connect to dataverse - {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                service?.Dispose();

                return new UnauthorizedObjectResult(ex.Message);
            }

            try
            {
                string jsonContext = await req.ReadAsStringAsync();
                log.LogInformation("{jsonContext}", jsonContext);

                FunctionProcess.ProcessContext(log, Utils.GetContext(jsonContext), service);

                Entity contact = new("contact")
                {
                    ["firstname"] = "Rey",
                    ["lastname"] = "Dynamics CRM"
                };

                Guid _contactid = service.Create(contact);

                return new OkObjectResult(string.Format("Account id: {0}", _contactid.ToString()));
            }
            catch (Exception ex)
            {
                log.LogError("{Function} - context processing: {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                return new BadRequestObjectResult(ex.Message);
            }
            finally
            {
                service?.Dispose();
            }
        }
    }
}
