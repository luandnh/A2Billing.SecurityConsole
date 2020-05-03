using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardSubscriptionUpdateModelValidator
        : AbstractValidator<CcCardSubscriptionUpdateModel>
    {
        public CcCardSubscriptionUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
