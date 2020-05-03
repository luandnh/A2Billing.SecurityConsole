using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcUiAuthenProfile
        : AutoMapper.Profile
    {
        public CcUiAuthenProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcUiAuthen, A2BillingService.Domain.Models.CcUiAuthenReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcUiAuthenCreateModel, A2BillingService.Data.Entities.CcUiAuthen>();
            CreateMap<A2BillingService.Data.Entities.CcUiAuthen, A2BillingService.Domain.Models.CcUiAuthenUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcUiAuthenUpdateModel, A2BillingService.Data.Entities.CcUiAuthen>();
        }

    }
}
