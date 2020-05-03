using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTicketCommentCreateModelValidator
        : AbstractValidator<CcTicketCommentCreateModel>
    {
        public CcTicketCommentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
