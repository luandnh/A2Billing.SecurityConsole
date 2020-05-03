using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPaymentMethodsProfile
        : AutoMapper.Profile
    {
        public CcPaymentMethodsProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPaymentMethods, A2BillingService.Domain.Models.CcPaymentMethodsReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentMethodsCreateModel, A2BillingService.Data.Entities.CcPaymentMethods>();
            CreateMap<A2BillingService.Data.Entities.CcPaymentMethods, A2BillingService.Domain.Models.CcPaymentMethodsUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentMethodsUpdateModel, A2BillingService.Data.Entities.CcPaymentMethods>();
        }

    }
}
