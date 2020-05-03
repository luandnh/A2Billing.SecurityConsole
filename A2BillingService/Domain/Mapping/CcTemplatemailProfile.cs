using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTemplatemailProfile
        : AutoMapper.Profile
    {
        public CcTemplatemailProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTemplatemail, A2BillingService.Domain.Models.CcTemplatemailReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTemplatemailCreateModel, A2BillingService.Data.Entities.CcTemplatemail>();
            CreateMap<A2BillingService.Data.Entities.CcTemplatemail, A2BillingService.Domain.Models.CcTemplatemailUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTemplatemailUpdateModel, A2BillingService.Data.Entities.CcTemplatemail>();
        }

    }
}
