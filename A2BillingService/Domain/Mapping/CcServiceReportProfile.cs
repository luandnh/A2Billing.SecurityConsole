using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcServiceReportProfile
        : AutoMapper.Profile
    {
        public CcServiceReportProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcServiceReport, A2BillingService.Domain.Models.CcServiceReportReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcServiceReportCreateModel, A2BillingService.Data.Entities.CcServiceReport>();
            CreateMap<A2BillingService.Data.Entities.CcServiceReport, A2BillingService.Domain.Models.CcServiceReportUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcServiceReportUpdateModel, A2BillingService.Data.Entities.CcServiceReport>();
        }

    }
}
