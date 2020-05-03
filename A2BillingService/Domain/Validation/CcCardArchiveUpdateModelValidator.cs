using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCardArchiveUpdateModelValidator
        : AbstractValidator<CcCardArchiveUpdateModel>
    {
        public CcCardArchiveUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
