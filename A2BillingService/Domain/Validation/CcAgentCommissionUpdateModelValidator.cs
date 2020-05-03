using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAgentCommissionUpdateModelValidator
        : AbstractValidator<CcAgentCommissionUpdateModel>
    {
        public CcAgentCommissionUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
