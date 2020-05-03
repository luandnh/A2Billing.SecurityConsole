using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcReceiptItemUpdateModelValidator
        : AbstractValidator<CcReceiptItemUpdateModel>
    {
        public CcReceiptItemUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
