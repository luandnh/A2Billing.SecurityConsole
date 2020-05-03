using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCampaignConfigUpdateModelValidator
        : AbstractValidator<CcCampaignConfigUpdateModel>
    {
        public CcCampaignConfigUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
