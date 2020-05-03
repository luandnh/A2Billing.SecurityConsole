using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace A2BillingService.Data
{
    public partial class Mya2billingContext : DbContext
    {
        public Mya2billingContext(DbContextOptions<Mya2billingContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<A2BillingService.Data.Entities.CcAgentCommission> CcAgentCommissions { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcAgent> CcAgents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcAgentSignup> CcAgentSignups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcAgentTariffgroup> CcAgentTariffgroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcAlarmReport> CcAlarmReports { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcAlarm> CcAlarms { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcAutorefillReport> CcAutorefillReports { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcBackup> CcBackups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcBillingCustomer> CcBillingCustomers { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCallArchive> CcCallArchives { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCallbackSpool> CcCallbackSpools { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCallerid> CcCallerids { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCallplanLcr> CcCallplanLcrs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCall> CcCalls { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCampaignconfCardgroup> CcCampaignconfCardgroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCampaignConfig> CcCampaignConfigs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCampaignPhonebook> CcCampaignPhonebooks { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCampaignPhonestatus> CcCampaignPhonestatuses { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCampaign> CcCampaigns { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardArchive> CcCardArchives { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardGroup> CcCardGroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardgroupService> CcCardgroupServices { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardHistory> CcCardHistories { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardPackageOffer> CcCardPackageOffers { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCard> CcCards { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardSeria> CcCardSeria { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCardSubscription> CcCardSubscriptions { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCharge> CcCharges { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcConfigGroup> CcConfigGroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcConfig> CcConfigs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcConfiguration> CcConfigurations { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcContact> CcContacts { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCountry> CcCountries { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcCurrencies> CcCurrencies { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcDidDestination> CcDidDestinations { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcDidgroup> CcDidgroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcDid> CcDids { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcDidUse> CcDidUses { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcEpaymentLogAgent> CcEpaymentLogAgents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcEpaymentLog> CcEpaymentLogs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcIaxBuddies> CcIaxBuddies { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcInvoiceConf> CcInvoiceConfs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcInvoiceItem> CcInvoiceItems { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcInvoicePayment> CcInvoicePayments { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcInvoice> CcInvoices { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcIso639> CcIso639s { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcLogpaymentAgent> CcLogpaymentAgents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcLogpayment> CcLogpayments { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcLogrefillAgent> CcLogrefillAgents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcLogrefill> CcLogrefills { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcMessageAgent> CcMessageAgents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcMonitor> CcMonitors { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcNotificationAdmin> CcNotificationAdmins { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcNotification> CcNotifications { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcOutboundCidGroup> CcOutboundCidGroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcOutboundCidList> CcOutboundCidLists { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPackageGroup> CcPackageGroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPackageOffer> CcPackageOffers { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPackageRate> CcPackageRates { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPackgroupPackage> CcPackgroupPackages { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPaymentMethods> CcPaymentMethods { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPayments> CcPayments { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPaymentsAgent> CcPaymentsAgents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPaymentsStatus> CcPaymentsStatuses { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPaypal> CcPaypals { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPhonebook> CcPhonebooks { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPhonenumber> CcPhonenumbers { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcPrefix> CcPrefixes { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcProvider> CcProviders { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcRatecard> CcRatecards { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcReceiptItem> CcReceiptItems { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcReceipt> CcReceipts { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcRemittanceRequest> CcRemittanceRequests { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcRestrictedPhonenumber> CcRestrictedPhonenumbers { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcServerGroup> CcServerGroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcServerManager> CcServerManagers { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcServiceReport> CcServiceReports { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcService> CcServices { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSipBuddies> CcSipBuddies { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSipBuddiesEmpty> CcSipBuddiesEmpties { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSpeeddial> CcSpeeddials { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcStatusLog> CcStatusLogs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSubscriptionService> CcSubscriptionServices { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSubscriptionSignup> CcSubscriptionSignups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSupportComponent> CcSupportComponents { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSupport> CcSupports { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcSystemLog> CcSystemLogs { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTariffgroupPlan> CcTariffgroupPlans { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTariffgroup> CcTariffgroups { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTariffplan> CcTariffplans { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTemplatemail> CcTemplatemails { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTicketComment> CcTicketComments { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTicket> CcTickets { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTimezone> CcTimezones { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcTrunk> CcTrunks { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcUiAuthen> CcUiAuthens { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcVersion> CcVersions { get; set; }

        public virtual DbSet<A2BillingService.Data.Entities.CcVoucher> CcVouchers { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAgentCommissionMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAgentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAgentSignupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAgentTariffgroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAlarmMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAlarmReportMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcAutorefillReportMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcBackupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcBillingCustomerMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCallArchiveMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCallbackSpoolMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCalleridMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCallMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCallplanLcrMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCampaignconfCardgroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCampaignConfigMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCampaignMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCampaignPhonebookMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCampaignPhonestatusMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardArchiveMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardGroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardgroupServiceMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardHistoryMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardPackageOfferMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardSeriaMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCardSubscriptionMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcChargeMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcConfigGroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcConfigMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcConfigurationMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcContactMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCountryMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcCurrenciesMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcDidDestinationMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcDidgroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcDidMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcDidUseMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcEpaymentLogAgentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcEpaymentLogMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcIaxBuddiesMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcInvoiceConfMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcInvoiceItemMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcInvoiceMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcInvoicePaymentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcIso639Map());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcLogpaymentAgentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcLogpaymentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcLogrefillAgentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcLogrefillMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcMessageAgentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcMonitorMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcNotificationAdminMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcNotificationMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcOutboundCidGroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcOutboundCidListMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPackageGroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPackageOfferMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPackageRateMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPackgroupPackageMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPaymentMethodsMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPaymentsAgentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPaymentsMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPaymentsStatusMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPaypalMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPhonebookMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPhonenumberMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcPrefixMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcProviderMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcRatecardMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcReceiptItemMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcReceiptMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcRemittanceRequestMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcRestrictedPhonenumberMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcServerGroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcServerManagerMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcServiceMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcServiceReportMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSipBuddiesEmptyMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSipBuddiesMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSpeeddialMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcStatusLogMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSubscriptionServiceMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSubscriptionSignupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSupportComponentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSupportMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcSystemLogMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTariffgroupMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTariffgroupPlanMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTariffplanMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTemplatemailMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTicketCommentMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTicketMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTimezoneMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcTrunkMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcUiAuthenMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcVersionMap());
            modelBuilder.ApplyConfiguration(new A2BillingService.Data.Mapping.CcVoucherMap());
            #endregion
        }
    }
}
