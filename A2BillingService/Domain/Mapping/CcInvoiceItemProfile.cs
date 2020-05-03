using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcInvoiceItemProfile
        : AutoMapper.Profile
    {
        public CcInvoiceItemProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcInvoiceItem, A2BillingService.Domain.Models.CcInvoiceItemReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoiceItemCreateModel, A2BillingService.Data.Entities.CcInvoiceItem>();
            CreateMap<A2BillingService.Data.Entities.CcInvoiceItem, A2BillingService.Domain.Models.CcInvoiceItemUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoiceItemUpdateModel, A2BillingService.Data.Entities.CcInvoiceItem>();
        }

    }
}
