using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.BoschSites;
using SharedLibraries_Plugins.Repos.Products;
using SharedLibraries_Plugins.Repos.Users;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.ApplianceLogic.Logic
{
    public class SerialNumberValidation
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private rbtt_appliance applianceToUpdate;
        private Entity preImage;
        private string contextUserId;
        private UserRepos userRepos;
        private BoschSiteRepos boschSiteRepos;
        private ProductRepos productRepos;

        #endregion Variables

        #region Constructor
        public SerialNumberValidation(ITracingService _tracingService, Entity _entity, rbtt_appliance _applianceToUpdate, Entity _preImage, string _contextUserId, UserRepos _userRepos, BoschSiteRepos _boschSiteRepos, ProductRepos _productRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.applianceToUpdate = _applianceToUpdate;
            this.preImage = _preImage;
            this.contextUserId = _contextUserId;
            this.userRepos = _userRepos;
            this.boschSiteRepos = _boschSiteRepos;
            this.productRepos = _productRepos;
        }
        #endregion

        #region Logic

        public rbtt_appliance SerialNumberValidation_Logic()
        {
            tracingService.Trace("SerialNumberValidation_Logic --> Started");

            string serialNumber = string.Empty;
            DateTime manufacturedDate = new DateTime();

            serialNumber = entity.Attributes.Contains(rbtt_appliance.Fields.rbtt_serialnumber) ?
                            entity.GetAttributeValue<string>(rbtt_appliance.Fields.rbtt_serialnumber).Replace(" ", "").Replace("-", "").Replace("+", "").Trim() :
                            preImage.GetAttributeValue<string>(rbtt_appliance.Fields.rbtt_serialnumber).Replace(" ", "").Replace("-", "").Replace("+", "").Trim();

            manufacturedDate = entity.Attributes.Contains(rbtt_appliance.Fields.rbtt_ManufacturingDate) ?
                                entity.GetAttributeValue<DateTime>(rbtt_appliance.Fields.rbtt_ManufacturingDate) :
                                preImage.GetAttributeValue<DateTime>(rbtt_appliance.Fields.rbtt_ManufacturingDate);

            var retrievedUser = userRepos.retrieveUserByDomainName(@"DE\TTD1WE");

            if (contextUserId.Equals(retrievedUser.Id.ToString()))
                applianceToUpdate.Attributes[rbtt_appliance.Fields.StatusCode] = new OptionSetValue((int)rbtt_appliance_StatusCode.Active);
            else
            {
                applianceToUpdate.Attributes[rbtt_appliance.Fields.StatusCode] = setStatusReason(serialNumber, manufacturedDate);

                if (!entity.Attributes.Contains(rbtt_appliance.Fields.rbtt_RawSerialNumber))
                    applianceToUpdate.Attributes[rbtt_appliance.Fields.rbtt_RawSerialNumber] = serialNumber;
            }
            tracingService.Trace("SerialNumberValidation_Logic --> Ended");

            return applianceToUpdate;
        }

        #endregion

        #region Private Methods
        private OptionSetValue setStatusReason(string serialNumber, DateTime manufacturedDate)
        {
            OptionSetValue spamStatusCode = new OptionSetValue((int)rbtt_appliance_StatusCode.SPAM);

            string plantSAP = serialNumber.Substring(0, 4);

            var retrievedBoschSite = boschSiteRepos.retrieveBoschSiteByPlantSAP(plantSAP);

            if (retrievedBoschSite == null ||
                serialNumber.Length < 14 || serialNumber.Length > 31)
                return spamStatusCode;

            string md = serialNumber.Substring(4, 3);
            string[,] N41A_A4 = new string[24, 13] {
                                                    {"Year","Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"},
                                                    {"2007","781","782","783","784","785","786","787","788","789","790","791","792"},
                                                    {"2008","881","882","883","884","885","886","887","888","889","890","891","892"},
                                                    {"2009","981","982","983","984","985","986","987","988","989","990","991","992"},
                                                    {"2010","001","002","003","004","005","006","007","008","009","010","011","012"},
                                                    {"2011","101","102","103","104","105","106","107","108","109","110","111","112"},
                                                    {"2012","201","202","203","204","205","206","207","208","209","210","211","212"},
                                                    {"2013","301","302","303","304","305","306","307","308","309","310","311","312"},
                                                    {"2014","417","418","419","420","453","454","455","456","457","458","459","460"},
                                                    {"2015","517","518","519","520","553","554","555","556","557","558","559","560"},
                                                    {"2016","617","618","619","620","653","654","655","656","657","658","659","660"},
                                                    {"2017","717","718","719","720","753","754","755","756","757","758","759","760"},
                                                    {"2018","817","818","819","820","853","854","855","856","857","858","859","860"},
                                                    {"2019","917","918","919","920","953","954","955","956","957","958","959","960"},
                                                    {"2020","037","038","039","040","073","074","075","076","077","078","079","080"},
                                                    {"2021","137","138","139","140","173","174","175","176","177","178","179","180"},
                                                    {"2022","237","238","239","240","273","274","275","276","277","278","279","280"},
                                                    {"2023","337","338","339","340","373","374","375","376","377","378","379","380"},
                                                    {"2024","437","438","439","440","473","474","475","476","477","478","479","480"},
                                                    {"2025","537","538","539","540","573","574","575","576","577","578","579","580"},
                                                    {"2026","637","638","639","640","673","674","675","676","677","678","679","680"},
                                                    {"2027","737","738","739","740","773","774","775","776","777","778","779","780"},
                                                    {"2028","837","838","839","840","873","874","875","876","877","878","879","880"},
                                                    {"2029","937","938","939","940","973","974","975","976","977","978","979","980"}
                                                  };

            string year = manufacturedDate.Year.ToString();
            string month = manufacturedDate.ToString("MMM");
            string N41A_A4_Value = null;

            for (int i = 0; i < 13; ++i)
            {
                if (N41A_A4[0, i] == month)
                {
                    for (int j = 0; j < 24; ++j)
                    {
                        if (N41A_A4[j, 0] == year)
                        {
                            N41A_A4_Value = N41A_A4[j, i];
                        }
                    }
                }
            }

            int Counter;

            if (!md.Equals(N41A_A4_Value) || N41A_A4_Value.Equals(null) || !int.TryParse(serialNumber.Substring(7, 6), out Counter))
                return spamStatusCode;

            string productNumber = serialNumber.Substring(13, serialNumber.Length - 13);

            var retrievedProduct = productRepos.retrieveProductByTTNr(productNumber);

            if (retrievedProduct == null)
                return spamStatusCode;

            OptionSetValue pendingForValidation = new OptionSetValue((int)rbtt_appliance_StatusCode.PendingforValidation);

            return pendingForValidation;

        }
        #endregion
    }
}
