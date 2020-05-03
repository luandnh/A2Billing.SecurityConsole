using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcBackupCreateModelValidator
        : AbstractValidator<CcBackupCreateModel>
    {
        public CcBackupCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
