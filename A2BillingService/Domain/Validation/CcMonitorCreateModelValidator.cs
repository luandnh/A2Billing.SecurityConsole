using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcMonitorCreateModelValidator
        : AbstractValidator<CcMonitorCreateModel>
    {
        public CcMonitorCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
