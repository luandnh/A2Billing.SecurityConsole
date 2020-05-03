using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPackageRateCreateModelValidator
        : AbstractValidator<CcPackageRateCreateModel>
    {
        public CcPackageRateCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
