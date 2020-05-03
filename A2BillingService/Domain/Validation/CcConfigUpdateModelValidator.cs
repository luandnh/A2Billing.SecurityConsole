using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcConfigUpdateModelValidator
        : AbstractValidator<CcConfigUpdateModel>
    {
        public CcConfigUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
