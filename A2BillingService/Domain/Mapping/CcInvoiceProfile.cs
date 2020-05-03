using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcInvoiceProfile
        : AutoMapper.Profile
    {
        public CcInvoiceProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcInvoice, A2BillingService.Domain.Models.CcInvoiceReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoiceCreateModel, A2BillingService.Data.Entities.CcInvoice>();
            CreateMap<A2BillingService.Data.Entities.CcInvoice, A2BillingService.Domain.Models.CcInvoiceUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoiceUpdateModel, A2BillingService.Data.Entities.CcInvoice>();
        }

    }
}
