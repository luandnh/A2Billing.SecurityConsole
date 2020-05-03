using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcVoucherProfile
        : AutoMapper.Profile
    {
        public CcVoucherProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcVoucher, A2BillingService.Domain.Models.CcVoucherReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcVoucherCreateModel, A2BillingService.Data.Entities.CcVoucher>();
            CreateMap<A2BillingService.Data.Entities.CcVoucher, A2BillingService.Domain.Models.CcVoucherUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcVoucherUpdateModel, A2BillingService.Data.Entities.CcVoucher>();
        }

    }
}
