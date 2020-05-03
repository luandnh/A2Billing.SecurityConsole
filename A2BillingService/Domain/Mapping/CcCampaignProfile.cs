using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCampaignProfile
        : AutoMapper.Profile
    {
        public CcCampaignProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCampaign, A2BillingService.Domain.Models.CcCampaignReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignCreateModel, A2BillingService.Data.Entities.CcCampaign>();
            CreateMap<A2BillingService.Data.Entities.CcCampaign, A2BillingService.Domain.Models.CcCampaignUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignUpdateModel, A2BillingService.Data.Entities.CcCampaign>();
        }

    }
}
