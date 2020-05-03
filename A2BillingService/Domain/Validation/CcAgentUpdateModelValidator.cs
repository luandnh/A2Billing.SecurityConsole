using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAgentUpdateModelValidator
        : AbstractValidator<CcAgentUpdateModel>
    {
        public CcAgentUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
