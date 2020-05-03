using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardCreateModelValidator
        : AbstractValidator<CcCardCreateModel>
    {
        public CcCardCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
