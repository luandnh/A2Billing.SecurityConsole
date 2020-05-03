using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcEpaymentLogProfile
        : AutoMapper.Profile
    {
        public CcEpaymentLogProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcEpaymentLog, A2BillingService.Domain.Models.CcEpaymentLogReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcEpaymentLogCreateModel, A2BillingService.Data.Entities.CcEpaymentLog>();
            CreateMap<A2BillingService.Data.Entities.CcEpaymentLog, A2BillingService.Domain.Models.CcEpaymentLogUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcEpaymentLogUpdateModel, A2BillingService.Data.Entities.CcEpaymentLog>();
        }

    }
}
