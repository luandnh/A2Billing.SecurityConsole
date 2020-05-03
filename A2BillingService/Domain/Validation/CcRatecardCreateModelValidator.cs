using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcRatecardCreateModelValidator
        : AbstractValidator<CcRatecardCreateModel>
    {
        public CcRatecardCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
