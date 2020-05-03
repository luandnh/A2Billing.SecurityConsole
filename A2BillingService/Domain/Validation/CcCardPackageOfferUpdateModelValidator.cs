using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardPackageOfferUpdateModelValidator
        : AbstractValidator<CcCardPackageOfferUpdateModel>
    {
        public CcCardPackageOfferUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
