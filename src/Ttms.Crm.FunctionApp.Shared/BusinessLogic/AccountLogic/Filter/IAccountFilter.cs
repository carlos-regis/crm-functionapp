using Microsoft.Xrm.Sdk;

namespace Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Filter
{
    public interface IAccountFilter
    {
        bool ValidateCMD(Entity entity, Entity preImage);
        bool ValidateABCStatus(Entity entity, Entity postImage);
        bool ValidateAutoNrGenerator(Entity entity);
        bool ValidateCountVisitPlans(Entity entity);
        bool ValidatePhonePrefix(Entity entity);
    }
}
