using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedLibraries_Plugins.Models;
using System;

namespace SharedLibraries_Plugins
{
    public class DeliveryNotes
    {
        public static Entity DN(Entity DN, deliveryCollection obj, Entity DeliveryNote, IOrganizationService service)
        {
            if (!DN.Id.Equals(Guid.Empty))
                DeliveryNote.Id = DN.Id;

            if (obj.deliveryNoteId != null)
                if (DN.Attributes.Contains("rbtt_delivernote_id"))
                {
                    if (!DN.Attributes["rbtt_delivernote_id"].Equals(obj.deliveryNoteId))
                        DeliveryNote.Attributes["rbtt_delivernote_id"] = obj.deliveryNoteId;
                }
                else
                    DeliveryNote.Attributes["rbtt_delivernote_id"] = obj.deliveryNoteId;

            DateTime deliveryCreationDate;
            if (obj.deliveryCreationDate != null && DateTime.TryParse(obj.deliveryCreationDate.ToString(), out deliveryCreationDate))
                if (DateTime.Compare(deliveryCreationDate, DateTime.Parse("01/01/1753")) > 0)
                {
                    if (DN.Attributes.Contains("rbtt_erpcreatedate"))
                    {
                        if (DateTime.Compare((DateTime)DN.Attributes["rbtt_erpcreatedate"], deliveryCreationDate) != 0)
                            DeliveryNote.Attributes["rbtt_erpcreatedate"] = deliveryCreationDate;
                    }
                    else
                        DeliveryNote.Attributes["rbtt_erpcreatedate"] = deliveryCreationDate;
                }

            DateTime deliveryDate;
            if (obj.deliveryDate != null && DateTime.TryParse(obj.deliveryDate.ToString(), out deliveryDate))
                if (DateTime.Compare(deliveryDate, DateTime.Parse("01/01/1753")) > 0)
                {
                    if (DN.Attributes.Contains("rbtt_deliverdate"))
                    {
                        if (DateTime.Compare((DateTime)DN.Attributes["rbtt_deliverdate"], deliveryDate) != 0)
                            DeliveryNote.Attributes["rbtt_deliverdate"] = deliveryDate;
                    }
                    else
                        DeliveryNote.Attributes["rbtt_deliverdate"] = deliveryDate;
                }

            if (obj.invoiceId != null)
                if (DN.Attributes.Contains("rbtt_invoice"))
                {
                    if (!DN.Attributes["rbtt_invoice"].Equals(obj.invoiceId))
                        DeliveryNote.Attributes["rbtt_invoice"] = obj.invoiceId;
                }
                else
                    DeliveryNote.Attributes["rbtt_invoice"] = obj.invoiceId;

            if (obj.orderId != null)
                if (DN.Attributes.Contains("rbtt_order"))
                {
                    if (!DN.Attributes["rbtt_order"].Equals(obj.orderId))
                        DeliveryNote.Attributes["rbtt_order"] = obj.orderId;
                }
                else
                    DeliveryNote.Attributes["rbtt_order"] = obj.orderId;

            if (obj.plantOrg != null)
            {
                Guid BS = BoschSite(obj.plantOrg.ToString(), service);
                if (BS != Guid.Empty)
                {
                    if (DN.Attributes.Contains("rbtt_outbountlocation"))
                    {
                        if (!((EntityReference)DN.Attributes["rbtt_outbountlocation"]).Id.Equals(BS))
                            DeliveryNote.Attributes["rbtt_outbountlocation"] = new EntityReference("rbtt_productionplants", BS);
                    }
                    else
                        DeliveryNote.Attributes["rbtt_outbountlocation"] = new EntityReference("rbtt_productionplants", BS);
                }
            }

            if (obj.salesOrg != null)
            {
                Guid BS = BoschSite(obj.plantOrg.ToString(), service);
                if (BS != Guid.Empty)
                {
                    if (DN.Attributes.Contains("rbtt_salesorganization"))
                    {
                        if (!((EntityReference)DN.Attributes["rbtt_salesorganization"]).Id.Equals(BS))
                            DeliveryNote.Attributes["rbtt_salesorganization"] = new EntityReference("rbtt_productionplants", BS);
                    }
                    else
                        DeliveryNote.Attributes["rbtt_salesorganization"] = new EntityReference("rbtt_productionplants", BS);
                }
            }

            if (obj.shipToParty != null)
            {
                if (obj.shipToParty.boschid != null && obj.shipToParty.erpCustomerId == null)
                {
                    Guid contact = Contact(obj.shipToParty.boschid.ToString(), service);
                    if (contact != Guid.Empty)
                    {
                        if (DN.Attributes.Contains("rbtt_shiptoparty"))
                        {
                            if (!((EntityReference)DN.Attributes["rbtt_shiptoparty"]).Id.Equals(contact))
                                DeliveryNote.Attributes["rbtt_shiptoparty"] = new EntityReference("contact", contact);
                        }
                        else
                            DeliveryNote.Attributes["rbtt_shiptoparty"] = new EntityReference("contact", contact);
                    }
                }
                else
                {
                    Entity account = Account(obj.shipToParty.erpCustomerId.ToString(), obj.shipToParty.vatid != null ? obj.shipToParty.vatid.ToString() : string.Empty, service);
                    if (account.Id != Guid.Empty)
                    {
                        if (DN.Attributes.Contains("rbtt_shiptoparty"))
                        {
                            if (!((EntityReference)DN.Attributes["rbtt_shiptoparty"]).Id.Equals(account.Id))
                            {
                                DeliveryNote.Attributes["rbtt_shiptoparty"] = new EntityReference("account", account.Id);
                                DeliveryNote.Attributes["ownerid"] = new EntityReference("systemuser", ((EntityReference)account.Attributes["ownerid"]).Id);
                            }
                        }
                        else
                        {
                            DeliveryNote.Attributes["rbtt_shiptoparty"] = new EntityReference("account", account.Id);
                            DeliveryNote.Attributes["ownerid"] = new EntityReference("systemuser", ((EntityReference)account.Attributes["ownerid"]).Id);
                        }
                    }
                }
            }

            return DeliveryNote;
        }

        public static Guid BoschSite(string Plant, IOrganizationService service)
        {
            ConditionExpression condition1 = new ConditionExpression();
            condition1.AttributeName = "rbtt_plantsap";
            condition1.Operator = ConditionOperator.Equal;
            condition1.Values.Add(Plant);

            FilterExpression filter1 = new FilterExpression();
            filter1.AddCondition(condition1);

            QueryExpression query = new QueryExpression("rbtt_productionplants");
            query.ColumnSet = new ColumnSet("rbtt_plantsap");
            query.Criteria.AddFilter(filter1);

            EntityCollection find = service.RetrieveMultiple(query);

            if (find.Entities.Count.Equals(0))
                throw new ApplicationException("The needed Bosch Site do not Exist in the system\n Plant= " + Plant);
            if (find.Entities.Count > 1)
                throw new ApplicationException("More than one Bosch Site were finded in the system\n Plant= " + Plant);

            return find.Entities[0].Id;
        }

        public static Guid Contact(string BoschId, IOrganizationService service)
        {
            ConditionExpression condition1 = new ConditionExpression();
            condition1.AttributeName = "rbtt_ciamid";
            condition1.Operator = ConditionOperator.Equal;
            condition1.Values.Add(BoschId);

            FilterExpression filter1 = new FilterExpression();
            filter1.AddCondition(condition1);

            QueryExpression query = new QueryExpression("contact");
            query.ColumnSet = new ColumnSet("contactid");
            query.Criteria.AddFilter(filter1);

            EntityCollection find = service.RetrieveMultiple(query);

            if (find.Entities.Count.Equals(0))
                throw new ApplicationException("The needed Contact do not Exist in the system\n BoschId= " + BoschId);
            if (find.Entities.Count > 1)
                throw new ApplicationException("More than one Contact were finded in the system\n BoschId= " + BoschId);

            return find.Entities[0].Id;
        }

        public static Entity Account(string erpCustomerId, string vatid, IOrganizationService service)
        {
            ConditionExpression condition1 = new ConditionExpression();
            condition1.AttributeName = "rbtt_erpcustomernumber";
            condition1.Operator = ConditionOperator.Equal;
            condition1.Values.Add(RemoveLeftZeros(erpCustomerId));

            ConditionExpression condition2 = new ConditionExpression();
            condition2.AttributeName = "orb_vatnumber";
            condition2.Operator = ConditionOperator.Equal;
            condition2.Values.Add(vatid);

            ConditionExpression condition3 = new ConditionExpression();
            condition3.AttributeName = "statecode";
            condition3.Operator = ConditionOperator.Equal;
            condition3.Values.Add(0);

            FilterExpression filter1 = new FilterExpression();
            filter1.AddCondition(condition1);
            filter1.AddCondition(condition2);
            filter1.FilterOperator = LogicalOperator.Or;

            FilterExpression filter2 = new FilterExpression();
            filter2.AddCondition(condition3);

            QueryExpression query = new QueryExpression("account");
            query.ColumnSet = new ColumnSet("accountid", "ownerid");
            query.Criteria.AddFilter(filter1);
            query.Criteria.AddFilter(filter2);
            query.Criteria.FilterOperator = LogicalOperator.And;

            EntityCollection find = service.RetrieveMultiple(query);

            if (find.Entities.Count.Equals(0))
                throw new ApplicationException("The needed Account do not Exist in the system\n erpCustomerId= " + erpCustomerId + "\n vatid= " + vatid);
            if (find.Entities.Count > 1)
                throw new ApplicationException("More than one Account were finded in the system\n erpCustomerId= " + erpCustomerId + "\n vatid= " + vatid);

            return find.Entities[0];
        }

        public static void DNI(Entity DNI, Guid DeliverNote, itemCollection obj2, applianceCollection obj3, IOrganizationService service)
        {
            ConditionExpression conditionAppliance = new ConditionExpression();
            conditionAppliance.AttributeName = "rbtt_rawserialnumber";
            conditionAppliance.Operator = ConditionOperator.Equal;
            if (obj2.scannRule != null)
            {
                if (obj2.scannRule == "2600 rule" && obj3.specialSn != null)
                    conditionAppliance.Values.Add(obj3.specialSn);
                else
                    conditionAppliance.Values.Add(obj3.serialNumber);
            }
            else
                conditionAppliance.Values.Add(obj3.serialNumber);

            FilterExpression filterAppliance = new FilterExpression();
            filterAppliance.AddCondition(conditionAppliance);

            QueryExpression queryAppliance = new QueryExpression("rbtt_appliance");
            queryAppliance.ColumnSet = new ColumnSet("rbtt_serialnumber", "rbtt_fakesnsap", "rbtt_pttequipmentid", "rbtt_rawserialnumber");
            queryAppliance.Criteria.AddFilter(filterAppliance);

            EntityCollection findAppliance = service.RetrieveMultiple(queryAppliance);
            Entity Appliance = new Entity("rbtt_appliance");

            if (findAppliance.Entities.Count.Equals(0))
                throw new ApplicationException("The needed Appliance do not Exist in the system\n TTNT= " + obj2.ttnr + "\n scannRule= " + obj2.scannRule + "\n serialNumber= " + obj3.serialNumber + "\n specialSn=" + obj3.specialSn);
            if (findAppliance.Entities.Count > 1)
                throw new ApplicationException("More than one Appliance were finded in the system\n TTNT= " + obj2.ttnr + "\n scannRule= " + obj2.scannRule + "\n serialNumber= " + obj3.serialNumber + "\n specialSn=" + obj3.specialSn);

            Appliance.Id = findAppliance.Entities[0].Id;

            if (obj2.scannRule != null)
            {
                if (obj2.scannRule == "2600 rule" && obj3.specialSn != null && obj3.serialNumber != null)
                {
                    if (findAppliance.Entities[0].Attributes.Contains("rbtt_fakesnsap"))
                    {
                        if (!findAppliance.Entities[0].Attributes["rbtt_fakesnsap"].Equals(obj3.serialNumber))
                        {
                            Appliance.Attributes["rbtt_fakesnsap"] = obj3.serialNumber;
                            service.Update(Appliance);
                        }
                    }
                    else
                    {
                        Appliance.Attributes["rbtt_fakesnsap"] = obj3.serialNumber;
                        service.Update(Appliance);
                    }
                }
            }

            ConditionExpression conditionDNI1 = new ConditionExpression();
            conditionDNI1.AttributeName = "rbtt_position";
            conditionDNI1.Operator = ConditionOperator.Equal;
            conditionDNI1.Values.Add(obj2.position);

            ConditionExpression conditionDNI2 = new ConditionExpression();
            conditionDNI2.AttributeName = "rbtt_appliance";
            conditionDNI2.Operator = ConditionOperator.Equal;
            conditionDNI2.Values.Add(findAppliance.Entities[0].Id);

            FilterExpression filterDNI1 = new FilterExpression();
            filterDNI1.AddCondition(conditionDNI1);
            filterDNI1.AddCondition(conditionDNI2);
            filterDNI1.FilterOperator = LogicalOperator.And;

            QueryExpression queryDNI = new QueryExpression("rbtt_delivernoteitem");
            queryDNI.ColumnSet = new ColumnSet(true);
            queryDNI.Criteria.AddFilter(filterDNI1);

            LinkEntity link = new LinkEntity
            {
                LinkFromEntityName = "rbtt_delivernoteitem",
                LinkToEntityName = "rbtt_delivernote",
                LinkFromAttributeName = "rbtt_delivernoteid",
                LinkToAttributeName = "rbtt_delivernoteid"
            };

            ConditionExpression condition = new ConditionExpression();
            condition.AttributeName = "rbtt_delivernoteid";
            condition.Operator = ConditionOperator.Equal;
            condition.Values.Add(DeliverNote);

            link.LinkCriteria.AddCondition(condition);
            queryDNI.LinkEntities.Add(link);

            EntityCollection findDNI = service.RetrieveMultiple(queryDNI);
            Entity DeliveryNoteItem = new Entity("rbtt_delivernoteitem");

            if (findDNI.Entities.Count > 0)
            {
                DNI.Id = findDNI.Entities[0].Id;

                if (!DeliverNote.Equals(Guid.Empty))
                    DNI.Attributes["rbtt_delivernoteid"] = new EntityReference("rbtt_delivernote", DeliverNote);

                if (obj2.position >= 0)
                    if (findDNI.Entities[0].Attributes.Contains("rbtt_position"))
                    {
                        if (!obj2.position.Equals(findDNI.Entities[0].Attributes["rbtt_position"].ToString()))
                            DNI.Attributes["rbtt_position"] = obj2.position;
                    }
                    else
                    {
                        DNI.Attributes["rbtt_position"] = obj2.position;
                    }

                if (obj2.scannRule != null)
                    if (findDNI.Entities[0].Attributes.Contains("rbtt_scannrule"))
                    {
                        if (!obj2.scannRule.Equals(findDNI.Entities[0].Attributes["rbtt_scannrule"].ToString()))
                            DNI.Attributes["rbtt_scannrule"] = obj2.scannRule;
                    }
                    else
                    {
                        DNI.Attributes["rbtt_scannrule"] = obj2.scannRule;
                    }

                if (obj3.scann != null)
                    if (findDNI.Entities[0].Attributes.Contains("rbtt_scann"))
                    {
                        if (!obj3.scann.Equals(findDNI.Entities[0].Attributes["rbtt_scann"].ToString()))
                            DNI.Attributes["rbtt_scann"] = obj3.scann;
                    }
                    else
                    {
                        DNI.Attributes["rbtt_scann"] = obj3.scann;
                    }

                if (obj3.serialNumber != null)
                    if (findDNI.Entities[0].Attributes.Contains("rbtt_appliance"))
                    {
                        if (!findAppliance.Entities[0].Id.Equals(((EntityReference)findDNI.Entities[0].Attributes["rbtt_appliance"]).Id))
                            DNI.Attributes["rbtt_appliance"] = new EntityReference("rbtt_appliance", findAppliance.Entities[0].Id);
                    }
                    else
                    {
                        DNI.Attributes["rbtt_appliance"] = new EntityReference("rbtt_appliance", findAppliance.Entities[0].Id);
                    }

                if (obj2.ttnr != null)
                {
                    ConditionExpression conditionProd = new ConditionExpression();
                    conditionProd.AttributeName = "productnumber";
                    conditionProd.Operator = ConditionOperator.Equal;
                    conditionProd.Values.Add(obj2.ttnr);

                    FilterExpression filterProd = new FilterExpression();
                    filterProd.AddCondition(conditionProd);

                    QueryExpression queryPro = new QueryExpression("product");
                    queryPro.ColumnSet = new ColumnSet("productid");
                    queryPro.Criteria.AddFilter(filterProd);

                    EntityCollection findPro = service.RetrieveMultiple(queryPro);

                    if (findPro.Entities.Count.Equals(0))
                        throw new ApplicationException("The needed Product do not Exist in the system\n TTNT= " + obj2.ttnr + "\n scannRule= " + obj2.scannRule + "\n serialNumber= " + obj3.serialNumber + "\n specialSn=" + obj3.specialSn);
                    if (findPro.Entities.Count > 1)
                        throw new ApplicationException("More than one Product were finded in the system\n TTNT= " + obj2.ttnr + "\n scannRule= " + obj2.scannRule + "\n serialNumber= " + obj3.serialNumber + "\n specialSn=" + obj3.specialSn);

                    if (findDNI.Entities[0].Attributes.Contains("rbtt_product"))
                    {
                        if (!findPro.Entities[0].Id.Equals(((EntityReference)findDNI.Entities[0].Attributes["rbtt_product"]).Id))
                            DNI.Attributes["rbtt_product"] = new EntityReference("product", findPro.Entities[0].Id);
                    }
                    else
                    {
                        DNI.Attributes["rbtt_product"] = new EntityReference("product", findPro.Entities[0].Id);
                    }
                }
                service.Update(DNI);
            }
            else
            {
                if (!DeliverNote.Equals(Guid.Empty))
                    DNI.Attributes["rbtt_delivernoteid"] = new EntityReference("rbtt_delivernote", DeliverNote);

                if (obj2.position >= 0)
                    DNI.Attributes["rbtt_position"] = obj2.position;

                if (obj2.scannRule != null)
                    DNI.Attributes["rbtt_scannrule"] = obj2.scannRule;

                if (obj3.scann != null)
                    DNI.Attributes["rbtt_scann"] = obj3.scann;

                if (obj3.serialNumber != null)
                    DNI.Attributes["rbtt_appliance"] = new EntityReference("rbtt_appliance", findAppliance.Entities[0].Id);

                if (obj2.ttnr != null)
                {
                    ConditionExpression conditionProd = new ConditionExpression();
                    conditionProd.AttributeName = "productnumber";
                    conditionProd.Operator = ConditionOperator.Equal;
                    conditionProd.Values.Add(obj2.ttnr);

                    FilterExpression filterProd = new FilterExpression();
                    filterProd.AddCondition(conditionProd);

                    QueryExpression queryPro = new QueryExpression("product");
                    queryPro.ColumnSet = new ColumnSet("productid");
                    queryPro.Criteria.AddFilter(filterProd);

                    EntityCollection findPro = service.RetrieveMultiple(queryPro);

                    if (findPro.Entities.Count.Equals(0))
                        throw new ApplicationException("The needed Product do not Exist in the system\n TTNT= " + obj2.ttnr + "\n scannRule= " + obj2.scannRule + "\n serialNumber= " + obj3.serialNumber + "\n specialSn=" + obj3.specialSn);
                    if (findPro.Entities.Count > 1)
                        throw new ApplicationException("More than one Product were finded in the system\n TTNT= " + obj2.ttnr + "\n scannRule= " + obj2.scannRule + "\n serialNumber= " + obj3.serialNumber + "\n specialSn=" + obj3.specialSn);

                    DNI.Attributes["rbtt_product"] = new EntityReference("product", findPro.Entities[0].Id);
                }

                service.Create(DNI);
            }
        }

        public static string RemoveLeftZeros(string value)
        {
            if (value == null)
                return string.Empty;

            return value.TrimStart(new Char[] { '0' });
        }
    }
}