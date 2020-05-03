using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPackageOfferCreateModelValidator
        : AbstractValidator<CcPackageOfferCreateModel>
    {
        public CcPackageOfferCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
