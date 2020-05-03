using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcReceiptItemCreateModelValidator
        : AbstractValidator<CcReceiptItemCreateModel>
    {
        public CcReceiptItemCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
