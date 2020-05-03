using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcEpaymentLogAgentCreateModelValidator
        : AbstractValidator<CcEpaymentLogAgentCreateModel>
    {
        public CcEpaymentLogAgentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
