using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcInvoicePaymentProfile
        : AutoMapper.Profile
    {
        public CcInvoicePaymentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcInvoicePayment, A2BillingService.Domain.Models.CcInvoicePaymentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoicePaymentCreateModel, A2BillingService.Data.Entities.CcInvoicePayment>();
            CreateMap<A2BillingService.Data.Entities.CcInvoicePayment, A2BillingService.Domain.Models.CcInvoicePaymentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoicePaymentUpdateModel, A2BillingService.Data.Entities.CcInvoicePayment>();
        }

    }
}
