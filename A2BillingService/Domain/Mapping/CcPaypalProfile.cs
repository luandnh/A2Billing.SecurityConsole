using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPaypalProfile
        : AutoMapper.Profile
    {
        public CcPaypalProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPaypal, A2BillingService.Domain.Models.CcPaypalReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaypalCreateModel, A2BillingService.Data.Entities.CcPaypal>();
            CreateMap<A2BillingService.Data.Entities.CcPaypal, A2BillingService.Domain.Models.CcPaypalUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaypalUpdateModel, A2BillingService.Data.Entities.CcPaypal>();
        }

    }
}
