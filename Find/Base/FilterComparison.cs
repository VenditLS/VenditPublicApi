using System.ComponentModel;

namespace VenditPublicSdk.Find
{
    public enum FilterComparison
    {
        /// <summary>
        /// =
        /// </summary>
        [Description("=")]
        Equals = 0,

        /// <summary>
        /// &lt;&gt;
        /// </summary>
        [Description("<>")]
        NotEquals = 1,

        /// <summary>
        /// &gt;
        /// </summary>
        [Description(">")]
        GreaterThan = 2,

        /// <summary>
        /// &lt;
        /// </summary>
        [Description("<")]
        LessThan = 3,

        /// <summary>
        /// &gt;=
        /// </summary>
        [Description(">=")]
        GreaterOrEqual = 4,

        /// <summary>
        /// &lt;=
        /// </summary>
        [Description("<=")]
        LessOrEqual = 5,

        [Description("LIKE")]
        Like = 6,

        /// <summary>
        /// Ignores Value
        /// </summary>
        [Description("IS NULL")]
        IsNull = 7,

        /// <summary>
        /// Ignores Value
        /// </summary>
        [Description("IS NOT NULL")]
        IsNotNull = 8,

        /// <summary>
        /// LIKE "%..."
        /// </summary>
        [Description("LIKE '{0}%'")]
        StartsWith = 9,

        /// <summary>
        /// LIKE "%..."
        /// </summary>
        [Description("LIKE '%{0}'")]
        EndsWith = 10,

        /// <summary>
        /// LIKE "%..%"
        /// </summary>
        [Description("LIKE '%{0}%'")]
        Contains = 11,

        /// <summary>
        /// BETWEEN Value AND Value2
        /// </summary>
        [Description("BETWEEN")]
        Between = 12,

        /// <summary>
        /// NOT LIKE "..."
        /// </summary>
        [Description("NOT LIKE")]
        NotLike = 13,

        /// <summary>
        /// NOT LIKE "...%"
        /// </summary>
        [Description("NOT LIKE '{0}%'")]
        NotStartsWith = 14,

        /// <summary>
        /// NOT LIKE "%..."
        /// </summary>
        [Description("NOT LIKE '%{0}'")]
        NotEndsWith = 15,

        /// <summary>
        /// NOT LIKE "%..%"
        /// </summary>
        [Description("NOT LIKE '%{0}%'")]
        NotContains = 16,

        /// <summary>
        /// NOT BETWEEN Value AND Value2
        /// </summary>
        [Description("NOT BETWEEN")]
        NotBetween = 17,
    }
}
