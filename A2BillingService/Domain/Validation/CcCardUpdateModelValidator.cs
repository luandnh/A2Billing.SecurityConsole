using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardUpdateModelValidator
        : AbstractValidator<CcCardUpdateModel>
    {
        public CcCardUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
