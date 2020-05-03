using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCampaignConfigCreateModelValidator
        : AbstractValidator<CcCampaignConfigCreateModel>
    {
        public CcCampaignConfigCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
