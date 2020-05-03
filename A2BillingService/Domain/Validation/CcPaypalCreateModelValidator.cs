using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaypalCreateModelValidator
        : AbstractValidator<CcPaypalCreateModel>
    {
        public CcPaypalCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
