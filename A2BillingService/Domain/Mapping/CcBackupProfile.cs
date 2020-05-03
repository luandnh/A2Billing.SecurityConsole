using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcBackupProfile
        : AutoMapper.Profile
    {
        public CcBackupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcBackup, A2BillingService.Domain.Models.CcBackupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcBackupCreateModel, A2BillingService.Data.Entities.CcBackup>();
            CreateMap<A2BillingService.Data.Entities.CcBackup, A2BillingService.Domain.Models.CcBackupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcBackupUpdateModel, A2BillingService.Data.Entities.CcBackup>();
        }

    }
}
