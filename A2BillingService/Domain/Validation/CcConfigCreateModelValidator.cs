using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcConfigCreateModelValidator
        : AbstractValidator<CcConfigCreateModel>
    {
        public CcConfigCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
