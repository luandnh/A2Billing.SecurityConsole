using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcConfigurationCreateModelValidator
        : AbstractValidator<CcConfigurationCreateModel>
    {
        public CcConfigurationCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
