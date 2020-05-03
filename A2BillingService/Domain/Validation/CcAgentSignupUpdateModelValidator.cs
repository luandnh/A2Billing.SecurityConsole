using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAgentSignupUpdateModelValidator
        : AbstractValidator<CcAgentSignupUpdateModel>
    {
        public CcAgentSignupUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
