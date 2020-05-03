using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentsAgentCreateModelValidator
        : AbstractValidator<CcPaymentsAgentCreateModel>
    {
        public CcPaymentsAgentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
