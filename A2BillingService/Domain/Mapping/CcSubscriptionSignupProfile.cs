using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSubscriptionSignupProfile
        : AutoMapper.Profile
    {
        public CcSubscriptionSignupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSubscriptionSignup, A2BillingService.Domain.Models.CcSubscriptionSignupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSubscriptionSignupCreateModel, A2BillingService.Data.Entities.CcSubscriptionSignup>();
            CreateMap<A2BillingService.Data.Entities.CcSubscriptionSignup, A2BillingService.Domain.Models.CcSubscriptionSignupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSubscriptionSignupUpdateModel, A2BillingService.Data.Entities.CcSubscriptionSignup>();
        }

    }
}
