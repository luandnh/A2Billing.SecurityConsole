using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPackageRateUpdateModelValidator
        : AbstractValidator<CcPackageRateUpdateModel>
    {
        public CcPackageRateUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
