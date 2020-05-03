using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCampaignConfigProfile
        : AutoMapper.Profile
    {
        public CcCampaignConfigProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCampaignConfig, A2BillingService.Domain.Models.CcCampaignConfigReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignConfigCreateModel, A2BillingService.Data.Entities.CcCampaignConfig>();
            CreateMap<A2BillingService.Data.Entities.CcCampaignConfig, A2BillingService.Domain.Models.CcCampaignConfigUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignConfigUpdateModel, A2BillingService.Data.Entities.CcCampaignConfig>();
        }

    }
}
