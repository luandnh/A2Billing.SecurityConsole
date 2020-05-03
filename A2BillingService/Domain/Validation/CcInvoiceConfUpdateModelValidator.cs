using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoiceConfUpdateModelValidator
        : AbstractValidator<CcInvoiceConfUpdateModel>
    {
        public CcInvoiceConfUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
