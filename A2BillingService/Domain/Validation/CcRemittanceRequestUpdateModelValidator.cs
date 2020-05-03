using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcRemittanceRequestUpdateModelValidator
        : AbstractValidator<CcRemittanceRequestUpdateModel>
    {
        public CcRemittanceRequestUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
