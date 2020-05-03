using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTicketUpdateModelValidator
        : AbstractValidator<CcTicketUpdateModel>
    {
        public CcTicketUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
