using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcReceiptProfile
        : AutoMapper.Profile
    {
        public CcReceiptProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcReceipt, A2BillingService.Domain.Models.CcReceiptReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcReceiptCreateModel, A2BillingService.Data.Entities.CcReceipt>();
            CreateMap<A2BillingService.Data.Entities.CcReceipt, A2BillingService.Domain.Models.CcReceiptUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcReceiptUpdateModel, A2BillingService.Data.Entities.CcReceipt>();
        }

    }
}
