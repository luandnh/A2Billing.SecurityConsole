using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAutorefillReportCreateModelValidator
        : AbstractValidator<CcAutorefillReportCreateModel>
    {
        public CcAutorefillReportCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
