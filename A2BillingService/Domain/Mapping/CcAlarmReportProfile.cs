using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAlarmReportProfile
        : AutoMapper.Profile
    {
        public CcAlarmReportProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAlarmReport, A2BillingService.Domain.Models.CcAlarmReportReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAlarmReportCreateModel, A2BillingService.Data.Entities.CcAlarmReport>();
            CreateMap<A2BillingService.Data.Entities.CcAlarmReport, A2BillingService.Domain.Models.CcAlarmReportUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAlarmReportUpdateModel, A2BillingService.Data.Entities.CcAlarmReport>();
        }

    }
}
