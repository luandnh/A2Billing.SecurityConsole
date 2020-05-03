using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCampaignPhonestatusProfile
        : AutoMapper.Profile
    {
        public CcCampaignPhonestatusProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCampaignPhonestatus, A2BillingService.Domain.Models.CcCampaignPhonestatusReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignPhonestatusCreateModel, A2BillingService.Data.Entities.CcCampaignPhonestatus>();
            CreateMap<A2BillingService.Data.Entities.CcCampaignPhonestatus, A2BillingService.Domain.Models.CcCampaignPhonestatusUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCampaignPhonestatusUpdateModel, A2BillingService.Data.Entities.CcCampaignPhonestatus>();
        }

    }
}
