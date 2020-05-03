using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcBillingCustomerCreateModelValidator
        : AbstractValidator<CcBillingCustomerCreateModel>
    {
        public CcBillingCustomerCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
