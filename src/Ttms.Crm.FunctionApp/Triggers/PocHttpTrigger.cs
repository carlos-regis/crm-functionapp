using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Net;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helper;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class PocHttpTrigger
    {
        private readonly ILogger _logger;

        public PocHttpTrigger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<PocHttpTrigger>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        [Function(nameof(PocHttpTrigger))]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req)
        {

            CrmServiceClient service = null;
            try
            {
                CrmConnection crmConnection = new CrmConnection(_logger);
                service = crmConnection.Connect("crmConnectionString");

                _logger.LogInformation(string.Format("Microsoft Dynamics CRM version {0}.", Common.GetVersion(service)));
                _logger.LogInformation(string.Format("Organization Id: {0}.", service.ConnectedOrgId));
                _logger.LogInformation(string.Format("Logged on user is {0}.", Common.GetUserFullName(service)));

            }
            catch (Exception ex)
            {
                _logger.LogError(string.Format("{0} - service connection: {1}.", nameof(PocHttpTrigger), ex.ToString()));
                service?.Dispose();

                return req.CreateResponse(HttpStatusCode.NotFound);
            }

            try
            {
                string jsonContent = await req.ReadAsStringAsync();
                _logger.LogInformation(jsonContent);

                FunctionProcess.ProcessContext(_logger, Common.GetContext(_logger, jsonContent), service);
                return req.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Format("{0} - context processing: {1}.", nameof(PocHttpTrigger), ex.ToString()));
                return req.CreateResponse(HttpStatusCode.BadRequest);
            }
            finally
            {
                service?.Dispose();
            }
        }
    }
}

