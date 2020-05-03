using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTariffplanUpdateModelValidator
        : AbstractValidator<CcTariffplanUpdateModel>
    {
        public CcTariffplanUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
