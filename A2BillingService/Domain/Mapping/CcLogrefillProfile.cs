using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcLogrefillProfile
        : AutoMapper.Profile
    {
        public CcLogrefillProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcLogrefill, A2BillingService.Domain.Models.CcLogrefillReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogrefillCreateModel, A2BillingService.Data.Entities.CcLogrefill>();
            CreateMap<A2BillingService.Data.Entities.CcLogrefill, A2BillingService.Domain.Models.CcLogrefillUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogrefillUpdateModel, A2BillingService.Data.Entities.CcLogrefill>();
        }

    }
}
