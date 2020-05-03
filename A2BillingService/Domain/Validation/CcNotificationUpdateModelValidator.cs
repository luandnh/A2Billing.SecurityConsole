using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcNotificationUpdateModelValidator
        : AbstractValidator<CcNotificationUpdateModel>
    {
        public CcNotificationUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
