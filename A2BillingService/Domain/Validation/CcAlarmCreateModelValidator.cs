using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAlarmCreateModelValidator
        : AbstractValidator<CcAlarmCreateModel>
    {
        public CcAlarmCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
