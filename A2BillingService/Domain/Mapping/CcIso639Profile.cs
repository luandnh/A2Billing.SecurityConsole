using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcIso639Profile
        : AutoMapper.Profile
    {
        public CcIso639Profile()
        {
            CreateMap<A2BillingService.Data.Entities.CcIso639, A2BillingService.Domain.Models.CcIso639ReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcIso639CreateModel, A2BillingService.Data.Entities.CcIso639>();
            CreateMap<A2BillingService.Data.Entities.CcIso639, A2BillingService.Domain.Models.CcIso639UpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcIso639UpdateModel, A2BillingService.Data.Entities.CcIso639>();
        }

    }
}
