using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcBillingCustomerUpdateModelValidator
        : AbstractValidator<CcBillingCustomerUpdateModel>
    {
        public CcBillingCustomerUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
