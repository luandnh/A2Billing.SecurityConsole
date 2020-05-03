using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcRestrictedPhonenumberProfile
        : AutoMapper.Profile
    {
        public CcRestrictedPhonenumberProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcRestrictedPhonenumber, A2BillingService.Domain.Models.CcRestrictedPhonenumberReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcRestrictedPhonenumberCreateModel, A2BillingService.Data.Entities.CcRestrictedPhonenumber>();
            CreateMap<A2BillingService.Data.Entities.CcRestrictedPhonenumber, A2BillingService.Domain.Models.CcRestrictedPhonenumberUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcRestrictedPhonenumberUpdateModel, A2BillingService.Data.Entities.CcRestrictedPhonenumber>();
        }

    }
}
