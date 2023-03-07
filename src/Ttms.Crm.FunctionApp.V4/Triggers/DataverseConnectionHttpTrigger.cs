using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using System;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helpers;
using Ttms.Crm.FunctionApp.Services;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public static class DataverseConnectionHttpTrigger
    {
        [FunctionName(nameof(DataverseConnectionHttpTrigger))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            ServiceClient service = null;

            try
            {
                CrmConnection crmConnection = new(log, "CrmConnectionString");
                service = crmConnection.Connect();

                log.LogInformation("Microsoft Dynamics CRM version {Version}.", CrmUtils.GetVersion(service));
                log.LogInformation("Organization Id: {Id}.", service.ConnectedOrgId);
                log.LogInformation("Logged on user is {FullName}.", CrmUtils.GetUserFullName(service));
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

                FunctionProcess.ProcessContext(log, CrmUtils.GetContext(jsonContext), service);

                return new OkObjectResult("Success");
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
