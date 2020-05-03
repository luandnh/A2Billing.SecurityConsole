using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcOutboundCidListProfile
        : AutoMapper.Profile
    {
        public CcOutboundCidListProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcOutboundCidList, A2BillingService.Domain.Models.CcOutboundCidListReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcOutboundCidListCreateModel, A2BillingService.Data.Entities.CcOutboundCidList>();
            CreateMap<A2BillingService.Data.Entities.CcOutboundCidList, A2BillingService.Domain.Models.CcOutboundCidListUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcOutboundCidListUpdateModel, A2BillingService.Data.Entities.CcOutboundCidList>();
        }

    }
}
