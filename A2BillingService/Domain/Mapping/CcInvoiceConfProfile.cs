using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcInvoiceConfProfile
        : AutoMapper.Profile
    {
        public CcInvoiceConfProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcInvoiceConf, A2BillingService.Domain.Models.CcInvoiceConfReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoiceConfCreateModel, A2BillingService.Data.Entities.CcInvoiceConf>();
            CreateMap<A2BillingService.Data.Entities.CcInvoiceConf, A2BillingService.Domain.Models.CcInvoiceConfUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcInvoiceConfUpdateModel, A2BillingService.Data.Entities.CcInvoiceConf>();
        }

    }
}
