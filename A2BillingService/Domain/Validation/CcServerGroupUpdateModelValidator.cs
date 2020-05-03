using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcServerGroupUpdateModelValidator
        : AbstractValidator<CcServerGroupUpdateModel>
    {
        public CcServerGroupUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
