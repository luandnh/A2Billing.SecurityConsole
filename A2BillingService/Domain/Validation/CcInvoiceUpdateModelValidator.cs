using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoiceUpdateModelValidator
        : AbstractValidator<CcInvoiceUpdateModel>
    {
        public CcInvoiceUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
