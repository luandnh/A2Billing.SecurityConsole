using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardArchiveCreateModelValidator
        : AbstractValidator<CcCardArchiveCreateModel>
    {
        public CcCardArchiveCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
