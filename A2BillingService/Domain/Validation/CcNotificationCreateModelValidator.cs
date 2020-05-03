using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcNotificationCreateModelValidator
        : AbstractValidator<CcNotificationCreateModel>
    {
        public CcNotificationCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
