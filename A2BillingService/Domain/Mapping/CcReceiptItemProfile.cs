using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcReceiptItemProfile
        : AutoMapper.Profile
    {
        public CcReceiptItemProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcReceiptItem, A2BillingService.Domain.Models.CcReceiptItemReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcReceiptItemCreateModel, A2BillingService.Data.Entities.CcReceiptItem>();
            CreateMap<A2BillingService.Data.Entities.CcReceiptItem, A2BillingService.Domain.Models.CcReceiptItemUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcReceiptItemUpdateModel, A2BillingService.Data.Entities.CcReceiptItem>();
        }

    }
}
