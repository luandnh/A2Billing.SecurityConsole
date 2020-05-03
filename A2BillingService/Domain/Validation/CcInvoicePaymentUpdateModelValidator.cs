using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoicePaymentUpdateModelValidator
        : AbstractValidator<CcInvoicePaymentUpdateModel>
    {
        public CcInvoicePaymentUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
