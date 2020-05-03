using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardgroupServiceCreateModelValidator
        : AbstractValidator<CcCardgroupServiceCreateModel>
    {
        public CcCardgroupServiceCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
