using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCampaignCreateModelValidator
        : AbstractValidator<CcCampaignCreateModel>
    {
        public CcCampaignCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
