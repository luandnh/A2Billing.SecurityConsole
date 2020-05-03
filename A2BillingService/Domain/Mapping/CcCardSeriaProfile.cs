using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardSeriaProfile
        : AutoMapper.Profile
    {
        public CcCardSeriaProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardSeria, A2BillingService.Domain.Models.CcCardSeriaReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardSeriaCreateModel, A2BillingService.Data.Entities.CcCardSeria>();
            CreateMap<A2BillingService.Data.Entities.CcCardSeria, A2BillingService.Domain.Models.CcCardSeriaUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardSeriaUpdateModel, A2BillingService.Data.Entities.CcCardSeria>();
        }

    }
}
