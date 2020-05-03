using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcLogpaymentProfile
        : AutoMapper.Profile
    {
        public CcLogpaymentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcLogpayment, A2BillingService.Domain.Models.CcLogpaymentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogpaymentCreateModel, A2BillingService.Data.Entities.CcLogpayment>();
            CreateMap<A2BillingService.Data.Entities.CcLogpayment, A2BillingService.Domain.Models.CcLogpaymentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogpaymentUpdateModel, A2BillingService.Data.Entities.CcLogpayment>();
        }

    }
}
