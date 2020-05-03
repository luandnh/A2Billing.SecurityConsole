using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcStatusLogProfile
        : AutoMapper.Profile
    {
        public CcStatusLogProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcStatusLog, A2BillingService.Domain.Models.CcStatusLogReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcStatusLogCreateModel, A2BillingService.Data.Entities.CcStatusLog>();
            CreateMap<A2BillingService.Data.Entities.CcStatusLog, A2BillingService.Domain.Models.CcStatusLogUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcStatusLogUpdateModel, A2BillingService.Data.Entities.CcStatusLog>();
        }

    }
}
