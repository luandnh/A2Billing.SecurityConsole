using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcIso639CreateModelValidator
        : AbstractValidator<CcIso639CreateModel>
    {
        public CcIso639CreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
