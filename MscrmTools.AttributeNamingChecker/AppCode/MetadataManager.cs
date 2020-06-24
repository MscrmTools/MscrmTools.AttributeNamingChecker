using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MscrmTools.AttributeNamingChecker.AppCode
{
    internal class MetadataManager
    {
        private readonly IOrganizationService _service;

        public MetadataManager(IOrganizationService service)
        {
            _service = service;
        }

        public List<EntityMetadata> GetEntities(List<Entity> solutions, Settings settings)
        {
            var components = _service.RetrieveMultiple(new QueryExpression("solutioncomponent")
            {
                ColumnSet = new ColumnSet("objectid", "componenttype"),
                NoLock = true,
                Criteria = new FilterExpression(LogicalOperator.Or)
                {
                    Filters =
                        {
                            new FilterExpression
                            {
                                Conditions =
                                {
                                    new ConditionExpression("solutionid", ConditionOperator.In, solutions.Select(s => s.Id).ToArray()),
                                    new ConditionExpression("componenttype", ConditionOperator.Equal, 2)
                                }
                            },
                            new FilterExpression
                            {
                                Conditions =
                                {
                                    new ConditionExpression("solutionid", ConditionOperator.In, solutions.Select(s => s.Id).ToArray()),
                                    new ConditionExpression("componenttype", ConditionOperator.Equal, 1),
                                    new ConditionExpression("rootcomponentbehavior", ConditionOperator.Equal, 0)
                                }
                            }
                        }
                }
            }).Entities;

            var listEntities = components.Where(c => c.GetAttributeValue<OptionSetValue>("componenttype").Value == 1).Select(component => component.GetAttributeValue<Guid>("objectid"))
                .ToList();

            var listAttributes = components.Where(c => c.GetAttributeValue<OptionSetValue>("componenttype").Value == 2).Select(component => component.GetAttributeValue<Guid>("objectid"))
                .ToList();

            var entities = new List<EntityMetadata>();

            if (listEntities.Count > 0)
            {
                EntityQueryExpression entityQueryExpression = new EntityQueryExpression
                {
                    Criteria = new MetadataFilterExpression(LogicalOperator.And)
                    {
                        Conditions =
                        {
                            new MetadataConditionExpression("MetadataId",MetadataConditionOperator.In, listEntities.ToArray()),
                        }
                    },
                    Properties = new MetadataPropertiesExpression
                    {
                        AllProperties = false,
                        PropertyNames = { "DisplayName", "LogicalName", "Attributes", "ObjectTypeCode" }
                    },
                    AttributeQuery = new AttributeQueryExpression
                    {
                        // Récupération de l'attribut spécifié
                        Properties = new MetadataPropertiesExpression
                        {
                            AllProperties = false,
                            PropertyNames = { "DisplayName", "SchemaName", "LogicalName", "EntityLogicalName" }
                        },
                        Criteria = new MetadataFilterExpression
                        {
                            Conditions =
                                {
                                    new MetadataConditionExpression("IsCustomAttribute", MetadataConditionOperator.Equals, true),
                                }
                        }
                    }
                };

                if (settings.ExportUnmanagedOnly)
                {
                    entityQueryExpression.AttributeQuery.Criteria.Conditions.Add(new MetadataConditionExpression("IsManaged", MetadataConditionOperator.Equals, false));
                }

                RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                {
                    Query = entityQueryExpression,
                    ClientVersionStamp = null
                };
                var response = (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

                entities.AddRange(response.EntityMetadata.ToList());
            }

            if (listAttributes.Count > 0)
            {
                EntityQueryExpression entityQueryExpression = new EntityQueryExpression
                {
                    Properties = new MetadataPropertiesExpression
                    {
                        AllProperties = false,
                        PropertyNames = { "DisplayName", "LogicalName", "Attributes", "ObjectTypeCode" }
                    },
                    AttributeQuery = new AttributeQueryExpression
                    {
                        // Récupération de l'attribut spécifié
                        Properties = new MetadataPropertiesExpression
                        {
                            AllProperties = false,
                            PropertyNames = { "DisplayName", "SchemaName", "LogicalName", "EntityLogicalName" }
                        },
                        Criteria = new MetadataFilterExpression
                        {
                            Conditions =
                                {
                                    new MetadataConditionExpression("IsCustomAttribute", MetadataConditionOperator.Equals, true),
                                    new MetadataConditionExpression("MetadataId", MetadataConditionOperator.In, listAttributes.ToArray())
                                }
                        }
                    }
                };

                if (settings.ExportUnmanagedOnly)
                {
                    entityQueryExpression.AttributeQuery.Criteria.Conditions.Add(new MetadataConditionExpression("IsManaged", MetadataConditionOperator.Equals, false));
                }

                RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                {
                    Query = entityQueryExpression,
                    ClientVersionStamp = null
                };
                var response = (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

                entities.AddRange(response.EntityMetadata.ToList());
            }

            return entities;
        }
    }
}