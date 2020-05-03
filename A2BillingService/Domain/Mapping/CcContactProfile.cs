using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcContactProfile
        : AutoMapper.Profile
    {
        public CcContactProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcContact, A2BillingService.Domain.Models.CcContactReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcContactCreateModel, A2BillingService.Data.Entities.CcContact>();
            CreateMap<A2BillingService.Data.Entities.CcContact, A2BillingService.Domain.Models.CcContactUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcContactUpdateModel, A2BillingService.Data.Entities.CcContact>();
        }

    }
}
