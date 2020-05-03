using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardSeriaCreateModelValidator
        : AbstractValidator<CcCardSeriaCreateModel>
    {
        public CcCardSeriaCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
