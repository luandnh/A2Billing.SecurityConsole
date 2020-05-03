using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoiceCreateModelValidator
        : AbstractValidator<CcInvoiceCreateModel>
    {
        public CcInvoiceCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
