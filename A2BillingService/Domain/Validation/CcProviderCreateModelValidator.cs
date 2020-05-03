using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcProviderCreateModelValidator
        : AbstractValidator<CcProviderCreateModel>
    {
        public CcProviderCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
