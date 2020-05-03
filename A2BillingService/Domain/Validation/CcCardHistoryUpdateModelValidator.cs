using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardHistoryUpdateModelValidator
        : AbstractValidator<CcCardHistoryUpdateModel>
    {
        public CcCardHistoryUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
