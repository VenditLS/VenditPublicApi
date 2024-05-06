namespace VenditPublicSdk.Find.Base
{
    public interface IBaseFilter
    {
        /// <summary>
        /// Value used as filter criteria (required for most FilterComparisons)
        /// </summary>
        /// <example>"SearchText"</example>
        object Value { get; set; }

        /// <summary>
        /// Only used with the BETWEEN Comparison
        /// </summary>
        /// <example>999</example>
        object Value2 { get; set; }

        /// <summary>
        /// Type of filter
        /// </summary>
        /// <example>11</example>
        FilterComparison FilterComparison { get; set; }
    }

    /// <summary>
    /// Filter criteria for a search (Find) operation
    /// </summary>
    public abstract class BaseFilter<TFieldsEnum> : IBaseFilter
    {
        public BaseFilter(TFieldsEnum field, object value, FilterComparison filterComparison)
        {
            Field            = field;
            Value            = value;
            Value2           = null;
            FilterComparison = filterComparison;
        }

        public BaseFilter(TFieldsEnum field, object value, object value2, FilterComparison filterComparison)
        {
            Field = field;
            Value = value;
            Value2 = value2;
            FilterComparison = filterComparison;
        }

        /// <summary>
        /// Name of the field to filter on
        /// </summary>
        public TFieldsEnum Field { get; set; }

        /// <summary>
        /// Value used as filter criteria (required for most FilterComparisons)
        /// </summary>
        /// <example>"SearchText"</example>
        public object Value { get; set; }

        /// <summary>
        /// Only used with the BETWEEN Comparison
        /// </summary>
        /// <example>999</example>
        public object Value2 { get; set; }

        /// <summary>
        /// Type of filter
        /// </summary>
        /// <example>11</example>
        public FilterComparison FilterComparison { get; set; }
    }
}
