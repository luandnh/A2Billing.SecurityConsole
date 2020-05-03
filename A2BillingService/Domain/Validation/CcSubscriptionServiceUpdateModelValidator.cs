using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcSubscriptionServiceUpdateModelValidator
        : AbstractValidator<CcSubscriptionServiceUpdateModel>
    {
        public CcSubscriptionServiceUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
