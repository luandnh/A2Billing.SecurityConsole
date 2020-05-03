using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcVersionUpdateModelValidator
        : AbstractValidator<CcVersionUpdateModel>
    {
        public CcVersionUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
