using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcLogpaymentCreateModelValidator
        : AbstractValidator<CcLogpaymentCreateModel>
    {
        public CcLogpaymentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
