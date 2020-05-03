using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcReceiptCreateModelValidator
        : AbstractValidator<CcReceiptCreateModel>
    {
        public CcReceiptCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
