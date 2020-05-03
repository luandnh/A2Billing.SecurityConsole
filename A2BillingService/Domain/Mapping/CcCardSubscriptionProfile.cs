using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardSubscriptionProfile
        : AutoMapper.Profile
    {
        public CcCardSubscriptionProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardSubscription, A2BillingService.Domain.Models.CcCardSubscriptionReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardSubscriptionCreateModel, A2BillingService.Data.Entities.CcCardSubscription>();
            CreateMap<A2BillingService.Data.Entities.CcCardSubscription, A2BillingService.Domain.Models.CcCardSubscriptionUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardSubscriptionUpdateModel, A2BillingService.Data.Entities.CcCardSubscription>();
        }

    }
}
