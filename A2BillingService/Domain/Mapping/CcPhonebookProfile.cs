using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPhonebookProfile
        : AutoMapper.Profile
    {
        public CcPhonebookProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPhonebook, A2BillingService.Domain.Models.CcPhonebookReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPhonebookCreateModel, A2BillingService.Data.Entities.CcPhonebook>();
            CreateMap<A2BillingService.Data.Entities.CcPhonebook, A2BillingService.Domain.Models.CcPhonebookUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPhonebookUpdateModel, A2BillingService.Data.Entities.CcPhonebook>();
        }

    }
}
