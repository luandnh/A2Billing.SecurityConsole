using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAgentSignupProfile
        : AutoMapper.Profile
    {
        public CcAgentSignupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAgentSignup, A2BillingService.Domain.Models.CcAgentSignupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentSignupCreateModel, A2BillingService.Data.Entities.CcAgentSignup>();
            CreateMap<A2BillingService.Data.Entities.CcAgentSignup, A2BillingService.Domain.Models.CcAgentSignupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentSignupUpdateModel, A2BillingService.Data.Entities.CcAgentSignup>();
        }

    }
}
