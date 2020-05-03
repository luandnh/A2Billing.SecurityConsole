using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcNotificationProfile
        : AutoMapper.Profile
    {
        public CcNotificationProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcNotification, A2BillingService.Domain.Models.CcNotificationReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcNotificationCreateModel, A2BillingService.Data.Entities.CcNotification>();
            CreateMap<A2BillingService.Data.Entities.CcNotification, A2BillingService.Domain.Models.CcNotificationUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcNotificationUpdateModel, A2BillingService.Data.Entities.CcNotification>();
        }

    }
}
