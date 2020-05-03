using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTicketCommentUpdateModelValidator
        : AbstractValidator<CcTicketCommentUpdateModel>
    {
        public CcTicketCommentUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
