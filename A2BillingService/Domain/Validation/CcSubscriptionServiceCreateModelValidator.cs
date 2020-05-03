using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcSubscriptionServiceCreateModelValidator
        : AbstractValidator<CcSubscriptionServiceCreateModel>
    {
        public CcSubscriptionServiceCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
