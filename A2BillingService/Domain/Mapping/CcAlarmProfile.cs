using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAlarmProfile
        : AutoMapper.Profile
    {
        public CcAlarmProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAlarm, A2BillingService.Domain.Models.CcAlarmReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAlarmCreateModel, A2BillingService.Data.Entities.CcAlarm>();
            CreateMap<A2BillingService.Data.Entities.CcAlarm, A2BillingService.Domain.Models.CcAlarmUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAlarmUpdateModel, A2BillingService.Data.Entities.CcAlarm>();
        }

    }
}
