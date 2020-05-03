using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcConfigGroupCreateModelValidator
        : AbstractValidator<CcConfigGroupCreateModel>
    {
        public CcConfigGroupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
