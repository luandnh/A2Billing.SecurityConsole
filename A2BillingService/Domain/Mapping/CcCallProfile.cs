using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCallProfile
        : AutoMapper.Profile
    {
        public CcCallProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCall, A2BillingService.Domain.Models.CcCallReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallCreateModel, A2BillingService.Data.Entities.CcCall>();
            CreateMap<A2BillingService.Data.Entities.CcCall, A2BillingService.Domain.Models.CcCallUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallUpdateModel, A2BillingService.Data.Entities.CcCall>();
        }

    }
}
