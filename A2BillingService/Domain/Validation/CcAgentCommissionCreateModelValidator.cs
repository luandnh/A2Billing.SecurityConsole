using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAgentCommissionCreateModelValidator
        : AbstractValidator<CcAgentCommissionCreateModel>
    {
        public CcAgentCommissionCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
