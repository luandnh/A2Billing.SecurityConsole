using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTariffplanCreateModelValidator
        : AbstractValidator<CcTariffplanCreateModel>
    {
        public CcTariffplanCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
