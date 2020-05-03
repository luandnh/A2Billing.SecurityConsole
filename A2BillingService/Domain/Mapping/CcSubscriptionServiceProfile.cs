using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSubscriptionServiceProfile
        : AutoMapper.Profile
    {
        public CcSubscriptionServiceProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSubscriptionService, A2BillingService.Domain.Models.CcSubscriptionServiceReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSubscriptionServiceCreateModel, A2BillingService.Data.Entities.CcSubscriptionService>();
            CreateMap<A2BillingService.Data.Entities.CcSubscriptionService, A2BillingService.Domain.Models.CcSubscriptionServiceUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSubscriptionServiceUpdateModel, A2BillingService.Data.Entities.CcSubscriptionService>();
        }

    }
}
