using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcServerManagerProfile
        : AutoMapper.Profile
    {
        public CcServerManagerProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcServerManager, A2BillingService.Domain.Models.CcServerManagerReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcServerManagerCreateModel, A2BillingService.Data.Entities.CcServerManager>();
            CreateMap<A2BillingService.Data.Entities.CcServerManager, A2BillingService.Domain.Models.CcServerManagerUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcServerManagerUpdateModel, A2BillingService.Data.Entities.CcServerManager>();
        }

    }
}
