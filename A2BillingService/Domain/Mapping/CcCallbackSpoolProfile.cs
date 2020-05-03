using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCallbackSpoolProfile
        : AutoMapper.Profile
    {
        public CcCallbackSpoolProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCallbackSpool, A2BillingService.Domain.Models.CcCallbackSpoolReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallbackSpoolCreateModel, A2BillingService.Data.Entities.CcCallbackSpool>();
            CreateMap<A2BillingService.Data.Entities.CcCallbackSpool, A2BillingService.Domain.Models.CcCallbackSpoolUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallbackSpoolUpdateModel, A2BillingService.Data.Entities.CcCallbackSpool>();
        }

    }
}
