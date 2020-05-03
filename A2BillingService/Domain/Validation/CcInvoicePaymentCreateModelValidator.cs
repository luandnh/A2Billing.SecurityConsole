using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoicePaymentCreateModelValidator
        : AbstractValidator<CcInvoicePaymentCreateModel>
    {
        public CcInvoicePaymentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
