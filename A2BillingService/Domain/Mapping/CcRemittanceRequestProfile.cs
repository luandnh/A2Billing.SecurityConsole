using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcRemittanceRequestProfile
        : AutoMapper.Profile
    {
        public CcRemittanceRequestProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcRemittanceRequest, A2BillingService.Domain.Models.CcRemittanceRequestReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcRemittanceRequestCreateModel, A2BillingService.Data.Entities.CcRemittanceRequest>();
            CreateMap<A2BillingService.Data.Entities.CcRemittanceRequest, A2BillingService.Domain.Models.CcRemittanceRequestUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcRemittanceRequestUpdateModel, A2BillingService.Data.Entities.CcRemittanceRequest>();
        }

    }
}
