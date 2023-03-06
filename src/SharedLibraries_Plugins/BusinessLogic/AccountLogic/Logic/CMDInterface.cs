using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Helpers;
using SharedLibraries_Plugins.Repos.BoschSites;
using SharedLibraries_Plugins.Repos.ConfigurationParameters;
using SharedLibraries_Plugins.Repos.Countries;
using SharedLibraries_Plugins.Repos.CustomerMasterDataExchange;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic
{
    public class CMDInterface
    {
        private ITracingService tracingService;
        private Entity entityTarget;
        private Account accountToUpdate;
        private Entity postImage;
        private CountryRepos countryRepos;
        private ConfigurationParameterRepos configurationParameterRepos;
        private BoschSiteRepos boschSiteRepos;
        private CustomerMasterDataExchangeRepos customerMasterDataExchageRepos;

        public CMDInterface(ITracingService _tracingService, Entity _entityTarget, Account _accountToUpdate,
                            Entity _postImage, CountryRepos _countryRepos, ConfigurationParameterRepos _configurationParameterRepos, BoschSiteRepos _boschSiteRepos, CustomerMasterDataExchangeRepos _customerMasterDataExchageRepos)
        {
            this.tracingService = _tracingService;
            this.postImage = _postImage;
            this.entityTarget = _entityTarget;
            this.accountToUpdate = _accountToUpdate;
            this.countryRepos = _countryRepos;
            this.configurationParameterRepos = _configurationParameterRepos;
            this.boschSiteRepos = _boschSiteRepos;
            this.customerMasterDataExchageRepos = _customerMasterDataExchageRepos;
        }

        public Account CMDInterface_Logic()
        {
            tracingService.Trace("CMDInterface_Logic --> Started");

            string brand = Enum.GetName(typeof(btt_Brands), ((OptionSetValue)postImage.Attributes[Account.Fields.rbtt_Brand]).Value);
            brand = brand[0].ToString().ToUpper() + brand.Substring(1).ToLower();
            string countryISO = countryRepos.retrieveCountryById(boschSiteRepos.retrieveBoschSiteById(postImage.GetAttributeValue<EntityReference>(Account.Fields.rbtt_SalesOrganization).Id).GetAttributeValue<EntityReference>(rbtt_productionplants.Fields.rbtt_Country).Id).rbtt_ISO3166_Alpha_2;
            string erpNumber = postImage.Attributes.Contains(Account.Fields.rbtt_ERPCustomerNumber) ?
                              (postImage.Attributes.Contains(Account.Fields.rbtt_ERPShiptoNumber) ? postImage.Attributes[Account.Fields.rbtt_ERPShiptoNumber].ToString() : postImage.Attributes[Account.Fields.rbtt_ERPCustomerNumber].ToString()) :
                              (postImage.Attributes.Contains(Account.Fields.rbtt_ERPShiptoNumber) ? postImage.Attributes[Account.Fields.rbtt_ERPShiptoNumber].ToString() : string.Empty);
            string ActualCustomerCountry = postImage.Contains(Account.Fields.orb_countryid) ? ((EntityReference)postImage.Attributes[Account.Fields.orb_countryid]).Name.ToString() : string.Empty;

            string configParamsStartsWith = "Customer Master Data Exchange";

            List<rbtt_configurations> retrievedConfigurationParameters = configurationParameterRepos.retrieveMultipleConfigByStartsWithName(configParamsStartsWith);

            if (retrievedConfigurationParameters != null)
            {
                tracingService.Trace("--- RequestCMD ---");

                RequestCMD requestCMD = new RequestCMD(tracingService, brand, countryISO, erpNumber, retrievedConfigurationParameters);
                requestCMD.setupRequestCMD();

                requestCMD.registerCustomer();

                var getCustomerUpdateReference = requestCMD.getCustomerInfo();

                if (getCustomerUpdateReference != null)
                {
                    #region Address
                    tracingService.Trace("\n\rUpdating the Customer Address information");
                    if (getCustomerUpdateReference.GetCustomerInformationResponse.Address != null)
                    {
                        #region Name

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Name1, Account.Fields.Name))
                            accountToUpdate.Attributes[Account.Fields.Name] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Name1;

                        #endregion Name
                        #region Name 2

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Name2, Account.Fields.Btt_accountname))
                            accountToUpdate.Attributes[Account.Fields.Btt_accountname] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Name2;
                        else
                            accountToUpdate.Attributes[Account.Fields.Btt_accountname] = null;

                        #endregion Name 2
                        #region Street

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Street, Account.Fields.Address1_Line1))
                            accountToUpdate.Attributes[Account.Fields.Address1_Line1] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Street;
                        else
                            accountToUpdate.Attributes[Account.Fields.Address1_Line1] = null;

                        #endregion Street
                        #region Street 2

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Street2, Account.Fields.Address1_Line2))
                            accountToUpdate.Attributes[Account.Fields.Address1_Line2] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Street2;
                        else
                            accountToUpdate.Attributes[Account.Fields.Address1_Line2] = null;

                        #endregion Street 2
                        #region Street 3

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Street3, Account.Fields.Address1_Line3))
                            accountToUpdate.Attributes[Account.Fields.Address1_Line3] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Street3;
                        else
                            accountToUpdate.Attributes[Account.Fields.Address1_Line3] = null;

                        #endregion Street 3
                        #region House Number
                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber, Account.Fields.rbtt_Housenumber))
                        {
                            if (entityTarget.Attributes.Contains(Account.Fields.rbtt_Housenumber))
                            {
                                string[] currentHouseNumber = entityTarget.Attributes[Account.Fields.rbtt_Housenumber].ToString().Split('-');
                                if (!currentHouseNumber[0].Equals(getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber))
                                {
                                    accountToUpdate.Attributes[Account.Fields.rbtt_Housenumber] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber;
                                    if (!string.IsNullOrWhiteSpace(getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber2))
                                        if (currentHouseNumber.Length == 2)
                                        {
                                            if (!currentHouseNumber[1].Equals(getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber2))
                                                accountToUpdate.Attributes[Account.Fields.rbtt_Housenumber] += "-" + getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber2;
                                        }
                                        else
                                            accountToUpdate.Attributes[Account.Fields.rbtt_Housenumber] += "-" + getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber2;
                                }
                            }
                            else
                            {
                                accountToUpdate.Attributes[Account.Fields.rbtt_Housenumber] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber;
                                if (!string.IsNullOrWhiteSpace(getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber2))
                                    accountToUpdate.Attributes[Account.Fields.rbtt_Housenumber] += "-" + getCustomerUpdateReference.GetCustomerInformationResponse.Address.HouseNumber2;
                            }
                        }
                        else
                            accountToUpdate.Attributes[Account.Fields.rbtt_Housenumber] = null;

                        #endregion House Number
                        #region Postal Code

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.PostalCode, Account.Fields.Address1_PostalCode))
                            accountToUpdate.Attributes[Account.Fields.Address1_PostalCode] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.PostalCode;
                        else
                            accountToUpdate.Attributes[Account.Fields.Address1_PostalCode] = null;

                        #endregion Postal Code
                        #region City

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.City, Account.Fields.Address1_City))
                            accountToUpdate.Attributes[Account.Fields.Address1_City] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.City;
                        else
                            accountToUpdate.Attributes[Account.Fields.Address1_City] = null;

                        #endregion City
                        #region Phone

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Phone, Account.Fields.Telephone1))
                            accountToUpdate.Attributes[Account.Fields.Telephone1] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Phone;
                        else
                            accountToUpdate.Attributes[Account.Fields.Telephone1] = null;

                        #endregion Phone
                        #region Email

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Email, Account.Fields.EMailAddress1))
                            accountToUpdate.Attributes[Account.Fields.EMailAddress1] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Email;
                        else
                            accountToUpdate.Attributes[Account.Fields.EMailAddress1] = null;

                        #endregion Email
                        #region Fax

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Fax, Account.Fields.Fax))
                            accountToUpdate.Attributes[Account.Fields.Fax] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Fax;
                        else
                            accountToUpdate.Attributes[Account.Fields.Fax] = null;

                        #endregion Fax
                        #region Wesite

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Website, Account.Fields.WebSiteURL))
                            accountToUpdate.Attributes[Account.Fields.WebSiteURL] = getCustomerUpdateReference.GetCustomerInformationResponse.Address.Website;
                        else
                            accountToUpdate.Attributes[Account.Fields.WebSiteURL] = null;

                        #endregion Website
                        #region Setting the Customer Country

                        if (!string.IsNullOrWhiteSpace(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Country))
                        {
                            Entity NewCountry = countryRepos.retrieveCountryByIso(getCustomerUpdateReference.GetCustomerInformationResponse.Address.Country);
                            tracingService.Trace("\n\nNew Customer Country = " + NewCountry.Attributes[Orb_country.Fields.Orb_name] + "\n\n");
                            tracingService.Trace("\n\nOLD Customer Country = " + ActualCustomerCountry + "\n\n");
                            if (!ActualCustomerCountry.Equals(NewCountry.Attributes[Orb_country.Fields.Orb_name]))
                                accountToUpdate.Attributes[Account.Fields.orb_countryid] = new EntityReference(NewCountry.LogicalName, NewCountry.Id);
                        }
                        else
                            accountToUpdate.Attributes[Account.Fields.orb_countryid] = null;

                        #endregion Setting the Customer Country
                    }
                    #endregion Address

                    #region Bank Details
                    tracingService.Trace("\n\rUpdating the Customer Bank information");
                    if (getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails != null)
                    {
                        #region AccountNumber

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails.AccountNumber, Account.Fields.AccountNumber))
                            accountToUpdate.Attributes[Account.Fields.AccountNumber] = getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails.AccountNumber;
                        else
                            accountToUpdate.Attributes[Account.Fields.AccountNumber] = null;

                        #endregion AccountNumber
                        #region Code

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails.Code, Account.Fields.rbtt_Code))
                            accountToUpdate.Attributes[Account.Fields.rbtt_Code] = getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails.Code;
                        else
                            accountToUpdate.Attributes[Account.Fields.rbtt_Code] = null;

                        #endregion Code
                        #region Name

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails.Name, Account.Fields.rbtt_Name))
                            accountToUpdate.Attributes[Account.Fields.rbtt_Name] = getCustomerUpdateReference.GetCustomerInformationResponse.BankDetails.Name;
                        else
                            accountToUpdate.Attributes[Account.Fields.rbtt_Name] = null;

                        #endregion Name
                    }

                    #endregion Bank Details

                    #region Status
                    tracingService.Trace("\n\rUpdating the Customer Status information");
                    if (getCustomerUpdateReference.GetCustomerInformationResponse.Status != null)
                    {
                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Status.Blocked, Account.Fields.rbtt_IsBlocked))
                            accountToUpdate.Attributes[Account.Fields.rbtt_IsBlocked] = getCustomerUpdateReference.GetCustomerInformationResponse.Status.Blocked == "No" ? false : true;
                    }
                    else
                        accountToUpdate.Attributes[Account.Fields.rbtt_IsBlocked] = null;

                    #endregion Status

                    #region Relations
                    tracingService.Trace("\n\rUpdating the Customer Relations information");
                    if (getCustomerUpdateReference.GetCustomerInformationResponse.Relations != null)
                    {
                        #region Role

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Relations.Role, Account.Fields.rbtt_RelationsRole))
                            accountToUpdate.Attributes[Account.Fields.rbtt_RelationsRole] = getCustomerUpdateReference.GetCustomerInformationResponse.Relations.Role;
                        else
                            accountToUpdate.Attributes[Account.Fields.rbtt_RelationsRole] = null;

                        #endregion Role
                        #region Number

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Relations.Number, Account.Fields.rbtt_RelationsNumber))
                            accountToUpdate.Attributes[Account.Fields.rbtt_RelationsNumber] = getCustomerUpdateReference.GetCustomerInformationResponse.Relations.Number;
                        else
                            accountToUpdate.Attributes[Account.Fields.rbtt_RelationsNumber] = null;

                        #endregion Number
                        #region Email

                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.Relations.Email, Account.Fields.rbtt_RelationsEmail))
                            accountToUpdate.Attributes[Account.Fields.rbtt_RelationsEmail] = "SAPOwner=" + getCustomerUpdateReference.GetCustomerInformationResponse.Relations.Email;
                        else
                            accountToUpdate.Attributes[Account.Fields.rbtt_RelationsEmail] = null;

                        #endregion Email
                    }

                    #endregion Relations

                    #region SalesTaxIdentNumber
                    tracingService.Trace("\n\rUpdating the Customer TAX information");
                    if (getCustomerUpdateReference.GetCustomerInformationResponse.SalesTaxIdentNumber != null)
                    {
                        if (checkIfNullOrEmpty(getCustomerUpdateReference.GetCustomerInformationResponse.SalesTaxIdentNumber, Account.Fields.Orb_vatnumber))
                            accountToUpdate.Attributes[Account.Fields.Orb_vatnumber] = getCustomerUpdateReference.GetCustomerInformationResponse.SalesTaxIdentNumber;
                        else
                            accountToUpdate.Attributes[Account.Fields.Orb_vatnumber] = null;
                    }

                    #endregion SalesTaxIdentNumber
                }

                rbtt_customermasterdataexchange CMDEToBeUpdated = customerMasterDataExchageRepos.GetCMDEByAccountId(postImage.Id);
                if (CMDEToBeUpdated != null)
                {
                    tracingService.Trace("\n\rUpdating the linked Customer Master Data Exchange Request - CMDE = " + CMDEToBeUpdated.Id.ToString());
                    CMDEToBeUpdated.rbtt_MDCStatus.Value = (int)rbtt_customermasterdataexchange_rbtt_MDCStatus.Approved;
                    CMDEToBeUpdated.StateCode = rbtt_customermasterdataexchangeState.Inactive;
                    tracingService.Trace("\n\rImplementing the Changes to the linked Customer Master Data Exchange Request");
                    customerMasterDataExchageRepos.updateCMDE(CMDEToBeUpdated);
                }
                else
                {
                    tracingService.Trace("GetCMDEByAccountId --> Not Found");
                }
            }

            tracingService.Trace("CMDInterface_Logic --> Ended");

            return accountToUpdate;
        }

        private bool checkIfNullOrEmpty(string fieldObject, string entityField)
        {
            if ((!entityTarget.Attributes.Contains(entityField) && !string.IsNullOrWhiteSpace(fieldObject)) ||
                (entityTarget.Attributes.Contains(entityField) && !entityTarget.Attributes[entityField].Equals(fieldObject)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}