using Microsoft.Xrm.Sdk;
using System;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.V4.Accounts
{
    public class UpdateAccountCommand
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        private readonly IOrganizationService _service;

        public UpdateAccountCommand(IOrganizationService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.Update(new Account()
            {
                Id = AccountId,
                Name = Name
            });
        }
    }
}
