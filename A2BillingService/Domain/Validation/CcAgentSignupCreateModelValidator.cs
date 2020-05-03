using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAgentSignupCreateModelValidator
        : AbstractValidator<CcAgentSignupCreateModel>
    {
        public CcAgentSignupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
