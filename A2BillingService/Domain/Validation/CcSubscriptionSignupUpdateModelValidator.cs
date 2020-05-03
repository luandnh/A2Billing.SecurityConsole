using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcSubscriptionSignupUpdateModelValidator
        : AbstractValidator<CcSubscriptionSignupUpdateModel>
    {
        public CcSubscriptionSignupUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
