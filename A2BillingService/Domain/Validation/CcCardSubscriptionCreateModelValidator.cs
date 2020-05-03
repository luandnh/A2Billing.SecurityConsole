using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardSubscriptionCreateModelValidator
        : AbstractValidator<CcCardSubscriptionCreateModel>
    {
        public CcCardSubscriptionCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
