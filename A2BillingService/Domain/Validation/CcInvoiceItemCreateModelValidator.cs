using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoiceItemCreateModelValidator
        : AbstractValidator<CcInvoiceItemCreateModel>
    {
        public CcInvoiceItemCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
