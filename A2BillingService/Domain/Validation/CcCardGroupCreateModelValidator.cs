using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardGroupCreateModelValidator
        : AbstractValidator<CcCardGroupCreateModel>
    {
        public CcCardGroupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
