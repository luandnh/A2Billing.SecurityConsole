using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcMessageAgentUpdateModelValidator
        : AbstractValidator<CcMessageAgentUpdateModel>
    {
        public CcMessageAgentUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
