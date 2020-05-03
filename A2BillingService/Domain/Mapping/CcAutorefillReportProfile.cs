using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAutorefillReportProfile
        : AutoMapper.Profile
    {
        public CcAutorefillReportProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAutorefillReport, A2BillingService.Domain.Models.CcAutorefillReportReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAutorefillReportCreateModel, A2BillingService.Data.Entities.CcAutorefillReport>();
            CreateMap<A2BillingService.Data.Entities.CcAutorefillReport, A2BillingService.Domain.Models.CcAutorefillReportUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAutorefillReportUpdateModel, A2BillingService.Data.Entities.CcAutorefillReport>();
        }

    }
}
