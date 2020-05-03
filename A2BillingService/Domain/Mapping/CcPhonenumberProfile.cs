using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPhonenumberProfile
        : AutoMapper.Profile
    {
        public CcPhonenumberProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPhonenumber, A2BillingService.Domain.Models.CcPhonenumberReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPhonenumberCreateModel, A2BillingService.Data.Entities.CcPhonenumber>();
            CreateMap<A2BillingService.Data.Entities.CcPhonenumber, A2BillingService.Domain.Models.CcPhonenumberUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPhonenumberUpdateModel, A2BillingService.Data.Entities.CcPhonenumber>();
        }

    }
}
