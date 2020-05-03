using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcInvoiceItemUpdateModelValidator
        : AbstractValidator<CcInvoiceItemUpdateModel>
    {
        public CcInvoiceItemUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
