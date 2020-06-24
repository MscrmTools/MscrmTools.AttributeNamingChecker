using System.ComponentModel;

namespace MscrmTools.AttributeNamingChecker
{
    public enum NameToCompare
    {
        Logical,
        Schema
    }

    public class AttributeRegExp
    {
        public string AttributeType { get; set; }
        public string Regex { get; set; }
    }

    /// <summary>
    /// This class can help you to store settings for your plugin
    /// </summary>
    /// <remarks>
    /// This class must be XML serializable
    /// </remarks>
    public class Settings
    {
        [Category("Processing")]
        [DisplayName("Regular expression for all attributes")]
        [Description("Specify the regular expression to use against all attributes. Specific expressions by attribute type can be added in the grid on the right")]
        public string AllAttributesRegExp { get; set; } = @"^(?!new_)\w+$";

        [Browsable(false)]
        public AttributeRegExp[] AttrRegEx { get; set; }

        [Category("Processing")]
        [DisplayName("Customization prefix blacklist")]
        [Description("Define customization prefix to exclude from search (comma separated)")]
        public string BlackList { get; set; }

        [Category("Processing")]
        [DisplayName("Analyze only unmanaged attributes")]
        [Description("")]
        public bool ExportUnmanagedOnly { get; set; } = true;

        [Category("Processing")]
        [DisplayName("Attribute source name")]
        [Description("Specify the name to use againt regular expression(s) to validate it")]
        public NameToCompare NameToCompare { get; set; }

        [Category("Score levels")]
        [DisplayName("Valid")]
        [Description("Specify the percentage above which the score is considered valid")]
        public int ValidLevel { get; set; } = 95;

        [Category("Score levels")]
        [DisplayName("Acceptable")]
        [Description("Specify the percentage above which the score is considered acceptable. A value under this score is considered as bad")]
        public int WarningLevel { get; set; } = 80;

        [Category("Processing")]
        [DisplayName("Customization prefix whitelist")]
        [Description("Define customization prefix to include in search (comma separated)")]
        public string WhiteList { get; set; }
    }
}