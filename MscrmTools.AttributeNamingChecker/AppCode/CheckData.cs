using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MscrmTools.AttributeNamingChecker.AppCode
{
    public class CheckData
    {
        public bool CheckSchemaName { get; set; }
        public int Count { get; set; }
        public List<AttributeMetadata> InvalidAttributes { get; } = new List<AttributeMetadata>();
        public decimal Percentage { get; set; }
        public string RegExp { get; set; }
        public string Type { get; set; }

        public List<AttributeMetadata> ValidAttributes { get; } = new List<AttributeMetadata>();

        public void Analyse(List<EntityMetadata> emds, Settings settings)
        {
            var whiteList = string.IsNullOrEmpty(settings.WhiteList) ? new string[0] : settings.WhiteList?.Split(',');
            var blackList = string.IsNullOrEmpty(settings.BlackList) ? new string[0] : settings.BlackList?.Split(',');

            Regex regexp;
            if (CheckSchemaName)
            {
                regexp = new Regex(RegExp);
            }
            else
            {
                regexp = new Regex(RegExp, RegexOptions.IgnoreCase);
            }

            foreach (var emd in emds)
            {
                foreach (var amd in emd.Attributes.Where(a => Type == "All" || a.AttributeType?.ToString() == Type))
                {
                    if (whiteList.Length > 0 && !whiteList.Any(x => amd.LogicalName.StartsWith(x))) continue;
                    if (blackList.Length > 0 && blackList.Any(x => amd.LogicalName.StartsWith(x))) continue;

                    if (regexp.IsMatch(CheckSchemaName ? amd.SchemaName : amd.LogicalName))
                    {
                        ValidAttributes.Add(amd);
                    }
                    else
                    {
                        InvalidAttributes.Add(amd);
                    }
                }
            }

            Count = ValidAttributes.Count + InvalidAttributes.Count;

            Percentage = Count == 0 ? 0 : ValidAttributes.Count * 100 / (ValidAttributes.Count + InvalidAttributes.Count);
        }
    }
}