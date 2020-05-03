using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSystemLogProfile
        : AutoMapper.Profile
    {
        public CcSystemLogProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSystemLog, A2BillingService.Domain.Models.CcSystemLogReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSystemLogCreateModel, A2BillingService.Data.Entities.CcSystemLog>();
            CreateMap<A2BillingService.Data.Entities.CcSystemLog, A2BillingService.Domain.Models.CcSystemLogUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSystemLogUpdateModel, A2BillingService.Data.Entities.CcSystemLog>();
        }

    }
}
