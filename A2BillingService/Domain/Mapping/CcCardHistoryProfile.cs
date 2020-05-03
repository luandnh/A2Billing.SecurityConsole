using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardHistoryProfile
        : AutoMapper.Profile
    {
        public CcCardHistoryProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardHistory, A2BillingService.Domain.Models.CcCardHistoryReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardHistoryCreateModel, A2BillingService.Data.Entities.CcCardHistory>();
            CreateMap<A2BillingService.Data.Entities.CcCardHistory, A2BillingService.Domain.Models.CcCardHistoryUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardHistoryUpdateModel, A2BillingService.Data.Entities.CcCardHistory>();
        }

    }
}
