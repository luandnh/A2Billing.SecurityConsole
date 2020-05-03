using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCallCreateModelValidator
        : AbstractValidator<CcCallCreateModel>
    {
        public CcCallCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
