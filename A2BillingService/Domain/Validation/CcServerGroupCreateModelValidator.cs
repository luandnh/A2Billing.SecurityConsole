using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcServerGroupCreateModelValidator
        : AbstractValidator<CcServerGroupCreateModel>
    {
        public CcServerGroupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
