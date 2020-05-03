using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcMessageAgentCreateModelValidator
        : AbstractValidator<CcMessageAgentCreateModel>
    {
        public CcMessageAgentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
