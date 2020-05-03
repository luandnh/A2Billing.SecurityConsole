using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcStatusLogCreateModelValidator
        : AbstractValidator<CcStatusLogCreateModel>
    {
        public CcStatusLogCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
