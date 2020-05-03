using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCallArchiveProfile
        : AutoMapper.Profile
    {
        public CcCallArchiveProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCallArchive, A2BillingService.Domain.Models.CcCallArchiveReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallArchiveCreateModel, A2BillingService.Data.Entities.CcCallArchive>();
            CreateMap<A2BillingService.Data.Entities.CcCallArchive, A2BillingService.Domain.Models.CcCallArchiveUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallArchiveUpdateModel, A2BillingService.Data.Entities.CcCallArchive>();
        }

    }
}
