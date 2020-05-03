using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcOutboundCidGroupProfile
        : AutoMapper.Profile
    {
        public CcOutboundCidGroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcOutboundCidGroup, A2BillingService.Domain.Models.CcOutboundCidGroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcOutboundCidGroupCreateModel, A2BillingService.Data.Entities.CcOutboundCidGroup>();
            CreateMap<A2BillingService.Data.Entities.CcOutboundCidGroup, A2BillingService.Domain.Models.CcOutboundCidGroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcOutboundCidGroupUpdateModel, A2BillingService.Data.Entities.CcOutboundCidGroup>();
        }

    }
}
