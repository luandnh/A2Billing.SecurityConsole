using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardProfile
        : AutoMapper.Profile
    {
        public CcCardProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCard, A2BillingService.Domain.Models.CcCardReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardCreateModel, A2BillingService.Data.Entities.CcCard>();
            CreateMap<A2BillingService.Data.Entities.CcCard, A2BillingService.Domain.Models.CcCardUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardUpdateModel, A2BillingService.Data.Entities.CcCard>();
        }

    }
}
