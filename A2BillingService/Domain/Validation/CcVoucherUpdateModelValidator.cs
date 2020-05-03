using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcVoucherUpdateModelValidator
        : AbstractValidator<CcVoucherUpdateModel>
    {
        public CcVoucherUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
