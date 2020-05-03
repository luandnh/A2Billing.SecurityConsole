using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcRemittanceRequestCreateModelValidator
        : AbstractValidator<CcRemittanceRequestCreateModel>
    {
        public CcRemittanceRequestCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
