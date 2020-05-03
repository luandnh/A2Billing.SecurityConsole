using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardHistoryCreateModelValidator
        : AbstractValidator<CcCardHistoryCreateModel>
    {
        public CcCardHistoryCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
