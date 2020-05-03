using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPaymentsProfile
        : AutoMapper.Profile
    {
        public CcPaymentsProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPayments, A2BillingService.Domain.Models.CcPaymentsReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentsCreateModel, A2BillingService.Data.Entities.CcPayments>();
            CreateMap<A2BillingService.Data.Entities.CcPayments, A2BillingService.Domain.Models.CcPaymentsUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentsUpdateModel, A2BillingService.Data.Entities.CcPayments>();
        }

    }
}
