using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoiceConfCreateModelValidator
        : AbstractValidator<CcInvoiceConfCreateModel>
    {
        public CcInvoiceConfCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
