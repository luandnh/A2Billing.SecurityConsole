using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCalleridProfile
        : AutoMapper.Profile
    {
        public CcCalleridProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCallerid, A2BillingService.Domain.Models.CcCalleridReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCalleridCreateModel, A2BillingService.Data.Entities.CcCallerid>();
            CreateMap<A2BillingService.Data.Entities.CcCallerid, A2BillingService.Domain.Models.CcCalleridUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCalleridUpdateModel, A2BillingService.Data.Entities.CcCallerid>();
        }

    }
}
