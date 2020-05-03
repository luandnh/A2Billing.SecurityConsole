using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardSeriaUpdateModelValidator
        : AbstractValidator<CcCardSeriaUpdateModel>
    {
        public CcCardSeriaUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
