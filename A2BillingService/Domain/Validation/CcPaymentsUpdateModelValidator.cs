using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentsUpdateModelValidator
        : AbstractValidator<CcPaymentsUpdateModel>
    {
        public CcPaymentsUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
