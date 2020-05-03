using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTicketCommentProfile
        : AutoMapper.Profile
    {
        public CcTicketCommentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTicketComment, A2BillingService.Domain.Models.CcTicketCommentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTicketCommentCreateModel, A2BillingService.Data.Entities.CcTicketComment>();
            CreateMap<A2BillingService.Data.Entities.CcTicketComment, A2BillingService.Domain.Models.CcTicketCommentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTicketCommentUpdateModel, A2BillingService.Data.Entities.CcTicketComment>();
        }

    }
}
