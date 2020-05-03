using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcConfigGroupUpdateModelValidator
        : AbstractValidator<CcConfigGroupUpdateModel>
    {
        public CcConfigGroupUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
