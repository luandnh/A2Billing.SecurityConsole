using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcBillingCustomerProfile
        : AutoMapper.Profile
    {
        public CcBillingCustomerProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcBillingCustomer, A2BillingService.Domain.Models.CcBillingCustomerReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcBillingCustomerCreateModel, A2BillingService.Data.Entities.CcBillingCustomer>();
            CreateMap<A2BillingService.Data.Entities.CcBillingCustomer, A2BillingService.Domain.Models.CcBillingCustomerUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcBillingCustomerUpdateModel, A2BillingService.Data.Entities.CcBillingCustomer>();
        }

    }
}
