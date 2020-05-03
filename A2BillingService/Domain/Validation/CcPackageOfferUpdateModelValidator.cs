using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPackageOfferUpdateModelValidator
        : AbstractValidator<CcPackageOfferUpdateModel>
    {
        public CcPackageOfferUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
