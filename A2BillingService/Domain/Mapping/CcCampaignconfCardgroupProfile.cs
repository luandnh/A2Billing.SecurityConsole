using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCampaignconfCardgroupProfile
        : AutoMapper.Profile
    {
        public CcCampaignconfCardgroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCampaignconfCardgroup, A2BillingService.Domain.Models.CcCampaignconfCardgroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignconfCardgroupCreateModel, A2BillingService.Data.Entities.CcCampaignconfCardgroup>();
            CreateMap<A2BillingService.Data.Entities.CcCampaignconfCardgroup, A2BillingService.Domain.Models.CcCampaignconfCardgroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignconfCardgroupUpdateModel, A2BillingService.Data.Entities.CcCampaignconfCardgroup>();
        }

    }
}
