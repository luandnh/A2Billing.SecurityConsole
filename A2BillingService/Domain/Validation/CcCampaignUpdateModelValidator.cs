using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCampaignUpdateModelValidator
        : AbstractValidator<CcCampaignUpdateModel>
    {
        public CcCampaignUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
