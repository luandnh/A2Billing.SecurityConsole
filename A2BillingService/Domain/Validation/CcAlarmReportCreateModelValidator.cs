using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAlarmReportCreateModelValidator
        : AbstractValidator<CcAlarmReportCreateModel>
    {
        public CcAlarmReportCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
