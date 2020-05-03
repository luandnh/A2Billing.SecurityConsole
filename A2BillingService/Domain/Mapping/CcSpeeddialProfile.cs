using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSpeeddialProfile
        : AutoMapper.Profile
    {
        public CcSpeeddialProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSpeeddial, A2BillingService.Domain.Models.CcSpeeddialReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSpeeddialCreateModel, A2BillingService.Data.Entities.CcSpeeddial>();
            CreateMap<A2BillingService.Data.Entities.CcSpeeddial, A2BillingService.Domain.Models.CcSpeeddialUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSpeeddialUpdateModel, A2BillingService.Data.Entities.CcSpeeddial>();
        }

    }
}
