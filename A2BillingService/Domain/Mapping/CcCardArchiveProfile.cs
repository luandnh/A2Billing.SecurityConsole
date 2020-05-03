using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardArchiveProfile
        : AutoMapper.Profile
    {
        public CcCardArchiveProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardArchive, A2BillingService.Domain.Models.CcCardArchiveReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardArchiveCreateModel, A2BillingService.Data.Entities.CcCardArchive>();
            CreateMap<A2BillingService.Data.Entities.CcCardArchive, A2BillingService.Domain.Models.CcCardArchiveUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardArchiveUpdateModel, A2BillingService.Data.Entities.CcCardArchive>();
        }

    }
}
