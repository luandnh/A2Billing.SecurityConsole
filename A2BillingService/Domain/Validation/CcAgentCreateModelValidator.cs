using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcAgentCreateModelValidator
        : AbstractValidator<CcAgentCreateModel>
    {
        public CcAgentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
