using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardGroupUpdateModelValidator
        : AbstractValidator<CcCardGroupUpdateModel>
    {
        public CcCardGroupUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
