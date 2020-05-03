using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSupportComponentProfile
        : AutoMapper.Profile
    {
        public CcSupportComponentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSupportComponent, A2BillingService.Domain.Models.CcSupportComponentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSupportComponentCreateModel, A2BillingService.Data.Entities.CcSupportComponent>();
            CreateMap<A2BillingService.Data.Entities.CcSupportComponent, A2BillingService.Domain.Models.CcSupportComponentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSupportComponentUpdateModel, A2BillingService.Data.Entities.CcSupportComponent>();
        }

    }
}
