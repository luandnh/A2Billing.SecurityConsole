using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcVoucherCreateModelValidator
        : AbstractValidator<CcVoucherCreateModel>
    {
        public CcVoucherCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
