using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCallUpdateModelValidator
        : AbstractValidator<CcCallUpdateModel>
    {
        public CcCallUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
