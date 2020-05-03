using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcDidProfile
        : AutoMapper.Profile
    {
        public CcDidProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcDid, A2BillingService.Domain.Models.CcDidReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidCreateModel, A2BillingService.Data.Entities.CcDid>();
            CreateMap<A2BillingService.Data.Entities.CcDid, A2BillingService.Domain.Models.CcDidUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidUpdateModel, A2BillingService.Data.Entities.CcDid>();
        }

    }
}
