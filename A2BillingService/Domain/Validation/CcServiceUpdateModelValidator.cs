using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcServiceUpdateModelValidator
        : AbstractValidator<CcServiceUpdateModel>
    {
        public CcServiceUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
