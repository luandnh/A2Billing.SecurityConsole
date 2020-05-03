using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcContactCreateModelValidator
        : AbstractValidator<CcContactCreateModel>
    {
        public CcContactCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
