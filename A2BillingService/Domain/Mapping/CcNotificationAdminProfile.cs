using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcNotificationAdminProfile
        : AutoMapper.Profile
    {
        public CcNotificationAdminProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcNotificationAdmin, A2BillingService.Domain.Models.CcNotificationAdminReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcNotificationAdminCreateModel, A2BillingService.Data.Entities.CcNotificationAdmin>();
            CreateMap<A2BillingService.Data.Entities.CcNotificationAdmin, A2BillingService.Domain.Models.CcNotificationAdminUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcNotificationAdminUpdateModel, A2BillingService.Data.Entities.CcNotificationAdmin>();
        }

    }
}
