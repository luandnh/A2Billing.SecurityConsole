using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaypalUpdateModelValidator
        : AbstractValidator<CcPaypalUpdateModel>
    {
        public CcPaypalUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
