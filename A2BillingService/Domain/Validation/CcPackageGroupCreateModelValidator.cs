using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPackageGroupCreateModelValidator
        : AbstractValidator<CcPackageGroupCreateModel>
    {
        public CcPackageGroupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
