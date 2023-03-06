using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helpers;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class PocHttpTrigger
    {
        [FunctionName(nameof(PocHttpTrigger))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req, ILogger _logger)
        {

            CrmServiceClient service = null;
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
                _logger.LogError("{Function} - service connection: {Exception}.", nameof(PocHttpTrigger), ex.ToString());
                service?.Dispose();

                return new NotFoundObjectResult(ex.Message);
            }

            try
            {
                string jsonContext = await req.ReadAsStringAsync();
                _logger.LogInformation("{jsonContext}", jsonContext);

                FunctionProcess.ProcessContext(_logger, Common.GetContext(jsonContext), service);
                return new OkObjectResult(string.Empty);
            }
            catch (Exception ex)
            {
                _logger.LogError("{Function} - context processing: {Exception}.", nameof(PocHttpTrigger), ex.ToString());
                return new BadRequestObjectResult(ex.Message);
            }
            finally
            {
                service?.Dispose();
            }
        }
    }
}

