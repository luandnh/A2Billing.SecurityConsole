using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTimezoneCreateModelValidator
        : AbstractValidator<CcTimezoneCreateModel>
    {
        public CcTimezoneCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
