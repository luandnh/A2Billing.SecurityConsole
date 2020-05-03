using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPackageGroupUpdateModelValidator
        : AbstractValidator<CcPackageGroupUpdateModel>
    {
        public CcPackageGroupUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
