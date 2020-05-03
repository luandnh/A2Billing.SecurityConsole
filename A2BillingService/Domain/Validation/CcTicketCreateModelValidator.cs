using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTicketCreateModelValidator
        : AbstractValidator<CcTicketCreateModel>
    {
        public CcTicketCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
