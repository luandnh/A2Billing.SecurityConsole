using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPaymentsStatusProfile
        : AutoMapper.Profile
    {
        public CcPaymentsStatusProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPaymentsStatus, A2BillingService.Domain.Models.CcPaymentsStatusReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentsStatusCreateModel, A2BillingService.Data.Entities.CcPaymentsStatus>();
            CreateMap<A2BillingService.Data.Entities.CcPaymentsStatus, A2BillingService.Domain.Models.CcPaymentsStatusUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentsStatusUpdateModel, A2BillingService.Data.Entities.CcPaymentsStatus>();
        }

    }
}
