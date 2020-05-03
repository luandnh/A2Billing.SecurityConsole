using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcSubscriptionSignupCreateModelValidator
        : AbstractValidator<CcSubscriptionSignupCreateModel>
    {
        public CcSubscriptionSignupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
