using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCampaignPhonebookProfile
        : AutoMapper.Profile
    {
        public CcCampaignPhonebookProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCampaignPhonebook, A2BillingService.Domain.Models.CcCampaignPhonebookReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignPhonebookCreateModel, A2BillingService.Data.Entities.CcCampaignPhonebook>();
            CreateMap<A2BillingService.Data.Entities.CcCampaignPhonebook, A2BillingService.Domain.Models.CcCampaignPhonebookUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignPhonebookUpdateModel, A2BillingService.Data.Entities.CcCampaignPhonebook>();
        }

    }
}
