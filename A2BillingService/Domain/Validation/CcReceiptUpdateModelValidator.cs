using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcReceiptUpdateModelValidator
        : AbstractValidator<CcReceiptUpdateModel>
    {
        public CcReceiptUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
