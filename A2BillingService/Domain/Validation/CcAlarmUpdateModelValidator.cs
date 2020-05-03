using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAlarmUpdateModelValidator
        : AbstractValidator<CcAlarmUpdateModel>
    {
        public CcAlarmUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
