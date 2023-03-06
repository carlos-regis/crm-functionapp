using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.ProductRegistrations
{
    public class ProductRegistrationRepos : IProductRegistrationRepos
    {
        private CrmContext crmContext;

        public ProductRegistrationRepos(CrmContext _crmContext) { this.crmContext = _crmContext; }

        public void createProductRegistration(Orb_machine productRegistration)
        {
            crmContext.AddObject(productRegistration);
            crmContext.SaveChanges();
        }

        public List<Orb_machine> retrieveMultipleProductRegistraionsByAccountIdAndYTD(Guid accountId, int YTD)
        {
            int currentYear = 0;

            if (YTD == 0)
                currentYear = DateTime.UtcNow.Date.AddYears(YTD).Year;
            else
                currentYear = DateTime.UtcNow.Date.AddYears(-YTD).Year;

            List<Orb_machine> productRegistrationList = (from e in crmContext.CreateQuery(Orb_machine.EntityLogicalName).ToList()
                                                         .Where(ne => ne.Contains(Orb_machine.Fields.rbtt_InstallationDate) && ne.GetAttributeValue<DateTime>(Orb_machine.Fields.rbtt_InstallationDate).Date.Year == currentYear &&
                                                                      ne.Contains(Orb_machine.Fields.rbtt_AccountId) && ne.GetAttributeValue<EntityReference>(Orb_machine.Fields.rbtt_AccountId).Id == accountId)
                                                         select new Orb_machine
                                                         {
                                                             Id = e.Id,
                                                             rbtt_InstallationDate = e.GetAttributeValue<DateTime>(Orb_machine.Fields.rbtt_InstallationDate)
                                                         }
                                                         ).ToList();

            return productRegistrationList;
        }

        public List<Orb_machine> retrieveMultipleProductRegistrations()
        {
            List<Orb_machine> productRegistrationList = (from pr in crmContext.Orb_machineSet
                                                         select new Orb_machine
                                                         {
                                                             Id = pr.Id,
                                                             rbtt_ExternalRegistrationNumber = pr.rbtt_ExternalRegistrationNumber,
                                                             rbtt_ExternalAccountNumber = pr.rbtt_ExternalAccountNumber,
                                                             rbtt_AccountId = pr.rbtt_AccountId,
                                                             rbtt_ExternalContactNumber = pr.rbtt_ExternalContactNumber,
                                                             rbtt_ContactId = pr.rbtt_ContactId,
                                                             rbtt_registered = pr.rbtt_registered,
                                                             rbtt_RegistrationType = pr.rbtt_RegistrationType,
                                                             rbtt_RegistrationReason = pr.rbtt_RegistrationReason,
                                                             rbtt_RegistrationDate = pr.rbtt_RegistrationDate,
                                                             rbtt_Technology = pr.rbtt_Technology,
                                                             rbtt_Points = pr.rbtt_Points,
                                                             rbtt_InstallationDate = pr.rbtt_InstallationDate,
                                                             rbtt_ManufacturingDate = pr.rbtt_ManufacturingDate,
                                                             rbtt_BasicGarantyEndDate = pr.rbtt_BasicGarantyEndDate,
                                                             rbtt_InterestedInExtendedGaranty = pr.rbtt_InterestedInExtendedGaranty,
                                                             rbtt_ExtendedGarantyEndDate = pr.rbtt_ExtendedGarantyEndDate,
                                                             rbtt_TotalGarantyEndDate = pr.rbtt_TotalGarantyEndDate,
                                                             rbtt_InterestedInMaintenance = pr.rbtt_InterestedInMaintenance,
                                                             btt_installerid = pr.btt_installerid,
                                                             Btt_installationcertnumber = pr.Btt_installationcertnumber,
                                                             rbtt_serialnumber = pr.rbtt_serialnumber,
                                                             rbtt_LocationContact = pr.rbtt_LocationContact,
                                                             Btt_locationname = pr.Btt_locationname,
                                                             Btt_LocationStreet = pr.Btt_LocationStreet,
                                                             rbtt_Street2 = pr.rbtt_Street2,
                                                             rbtt_Address1_HouseNumber = pr.rbtt_Address1_HouseNumber,
                                                             rbtt_Address1_PostalCode = pr.rbtt_Address1_PostalCode,
                                                             rbtt_Address1_City = pr.rbtt_Address1_City,
                                                             rbtt_Country = pr.rbtt_Country,
                                                             rbtt_Address1Latitude = pr.rbtt_Address1Latitude,
                                                             rbtt_Address1Longitude = pr.rbtt_Address1Longitude,
                                                             Btt_status = pr.Btt_status,
                                                             rbtt_StartUpdoneby = pr.rbtt_StartUpdoneby,
                                                             rbtt_StartUpdate = pr.rbtt_StartUpdate,
                                                             OwnerId = pr.OwnerId,
                                                             ModifiedOn = pr.ModifiedOn
                                                         }).ToList();
            return productRegistrationList;
        }

        public Orb_machine retrieveProductRegistrationById(Guid id)
        {
            Orb_machine productRegistration = (from pr in crmContext.Orb_machineSet
                                               where pr.Id == id
                                               select new Orb_machine
                                               {
                                                   Id = pr.Id,
                                                   rbtt_ExternalRegistrationNumber = pr.rbtt_ExternalRegistrationNumber,
                                                   rbtt_ExternalAccountNumber = pr.rbtt_ExternalAccountNumber,
                                                   rbtt_AccountId = pr.rbtt_AccountId,
                                                   rbtt_ExternalContactNumber = pr.rbtt_ExternalContactNumber,
                                                   rbtt_ContactId = pr.rbtt_ContactId,
                                                   rbtt_registered = pr.rbtt_registered,
                                                   rbtt_RegistrationType = pr.rbtt_RegistrationType,
                                                   rbtt_RegistrationReason = pr.rbtt_RegistrationReason,
                                                   rbtt_RegistrationDate = pr.rbtt_RegistrationDate,
                                                   rbtt_Technology = pr.rbtt_Technology,
                                                   rbtt_Points = pr.rbtt_Points,
                                                   rbtt_InstallationDate = pr.rbtt_InstallationDate,
                                                   rbtt_ManufacturingDate = pr.rbtt_ManufacturingDate,
                                                   rbtt_BasicGarantyEndDate = pr.rbtt_BasicGarantyEndDate,
                                                   rbtt_InterestedInExtendedGaranty = pr.rbtt_InterestedInExtendedGaranty,
                                                   rbtt_ExtendedGarantyEndDate = pr.rbtt_ExtendedGarantyEndDate,
                                                   rbtt_TotalGarantyEndDate = pr.rbtt_TotalGarantyEndDate,
                                                   rbtt_InterestedInMaintenance = pr.rbtt_InterestedInMaintenance,
                                                   btt_installerid = pr.btt_installerid,
                                                   Btt_installationcertnumber = pr.Btt_installationcertnumber,
                                                   rbtt_serialnumber = pr.rbtt_serialnumber,
                                                   rbtt_LocationContact = pr.rbtt_LocationContact,
                                                   Btt_locationname = pr.Btt_locationname,
                                                   Btt_LocationStreet = pr.Btt_LocationStreet,
                                                   rbtt_Street2 = pr.rbtt_Street2,
                                                   rbtt_Address1_HouseNumber = pr.rbtt_Address1_HouseNumber,
                                                   rbtt_Address1_PostalCode = pr.rbtt_Address1_PostalCode,
                                                   rbtt_Address1_City = pr.rbtt_Address1_City,
                                                   rbtt_Country = pr.rbtt_Country,
                                                   rbtt_Address1Latitude = pr.rbtt_Address1Latitude,
                                                   rbtt_Address1Longitude = pr.rbtt_Address1Longitude,
                                                   Btt_status = pr.Btt_status,
                                                   rbtt_StartUpdoneby = pr.rbtt_StartUpdoneby,
                                                   rbtt_StartUpdate = pr.rbtt_StartUpdate,
                                                   OwnerId = pr.OwnerId,
                                                   ModifiedOn = pr.ModifiedOn
                                               }).FirstOrDefault();
            return productRegistration;
        }

        public List<Orb_machine> retrieveMultipleProductRegistrationByApplianceId(Guid applianceId)
        {
            List<Orb_machine> productRegistrationList = (from pr in crmContext.Orb_machineSet
                                                         where pr.rbtt_serialnumber.Id == applianceId
                                                         where pr.StateCode == Orb_machineState.Active
                                                         select new Orb_machine
                                                         {
                                                             Id = pr.Id,
                                                             StateCode = pr.StateCode,
                                                             StatusCode = pr.StatusCode
                                                         }).ToList();
            return productRegistrationList;
        }

        public Orb_machine retrieveProductRegstrationByExternalId(string id)
        {
            Orb_machine productRegistration = (from pr in crmContext.Orb_machineSet
                                               where pr.rbtt_ExternalRegistrationNumber == id
                                               select new Orb_machine
                                               {
                                                   Id = pr.Id,
                                                   rbtt_ExternalRegistrationNumber = pr.rbtt_ExternalRegistrationNumber,
                                                   rbtt_ExternalAccountNumber = pr.rbtt_ExternalAccountNumber,
                                                   rbtt_AccountId = pr.rbtt_AccountId,
                                                   rbtt_ExternalContactNumber = pr.rbtt_ExternalContactNumber,
                                                   rbtt_ContactId = pr.rbtt_ContactId,
                                                   rbtt_registered = pr.rbtt_registered,
                                                   rbtt_RegistrationType = pr.rbtt_RegistrationType,
                                                   rbtt_RegistrationReason = pr.rbtt_RegistrationReason,
                                                   rbtt_RegistrationDate = pr.rbtt_RegistrationDate,
                                                   rbtt_Technology = pr.rbtt_Technology,
                                                   rbtt_Points = pr.rbtt_Points,
                                                   rbtt_InstallationDate = pr.rbtt_InstallationDate,
                                                   rbtt_ManufacturingDate = pr.rbtt_ManufacturingDate,
                                                   rbtt_BasicGarantyEndDate = pr.rbtt_BasicGarantyEndDate,
                                                   rbtt_InterestedInExtendedGaranty = pr.rbtt_InterestedInExtendedGaranty,
                                                   rbtt_ExtendedGarantyEndDate = pr.rbtt_ExtendedGarantyEndDate,
                                                   rbtt_TotalGarantyEndDate = pr.rbtt_TotalGarantyEndDate,
                                                   rbtt_InterestedInMaintenance = pr.rbtt_InterestedInMaintenance,
                                                   btt_installerid = pr.btt_installerid,
                                                   Btt_installationcertnumber = pr.Btt_installationcertnumber,
                                                   rbtt_serialnumber = pr.rbtt_serialnumber,
                                                   rbtt_LocationContact = pr.rbtt_LocationContact,
                                                   Btt_locationname = pr.Btt_locationname,
                                                   Btt_LocationStreet = pr.Btt_LocationStreet,
                                                   rbtt_Street2 = pr.rbtt_Street2,
                                                   rbtt_Address1_HouseNumber = pr.rbtt_Address1_HouseNumber,
                                                   rbtt_Address1_PostalCode = pr.rbtt_Address1_PostalCode,
                                                   rbtt_Address1_City = pr.rbtt_Address1_City,
                                                   rbtt_Country = pr.rbtt_Country,
                                                   rbtt_Address1Latitude = pr.rbtt_Address1Latitude,
                                                   rbtt_Address1Longitude = pr.rbtt_Address1Longitude,
                                                   Btt_status = pr.Btt_status,
                                                   rbtt_StartUpdoneby = pr.rbtt_StartUpdoneby,
                                                   rbtt_StartUpdate = pr.rbtt_StartUpdate,
                                                   OwnerId = pr.OwnerId,
                                                   ModifiedOn = pr.ModifiedOn
                                               }).FirstOrDefault();
            return productRegistration;
        }

        public void updateProductRegistration(Orb_machine productRegistration)
        {
            if (!crmContext.IsAttached(productRegistration))
            {
                crmContext.Attach(productRegistration);
            }
            crmContext.UpdateObject(productRegistration);
            crmContext.SaveChanges();
        }
    }
}
