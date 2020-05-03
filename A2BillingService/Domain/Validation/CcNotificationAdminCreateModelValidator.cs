using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcNotificationAdminCreateModelValidator
        : AbstractValidator<CcNotificationAdminCreateModel>
    {
        public CcNotificationAdminCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
