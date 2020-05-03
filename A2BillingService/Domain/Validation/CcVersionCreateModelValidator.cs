using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcVersionCreateModelValidator
        : AbstractValidator<CcVersionCreateModel>
    {
        public CcVersionCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
