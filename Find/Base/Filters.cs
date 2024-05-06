using System.ComponentModel;

namespace VenditPublicSdk.Find.Base
{
    public interface IBaseFilters
    {
        /// <summary>
        /// The pagination offset, should be 0 for the first request, 100 to get the 2nd page etc...
        /// </summary>
        /// <example>0</example>
        uint PaginationOffset { get; set; }

        /// <summary>
        /// Operator that will be used to Intersect (And) or Add (Or) individual filtered results.
        /// </summary>
        [DefaultValue(FilterOperator.And)]
        FilterOperator Operator { get; set; }

        /// <summary>
        /// Number of filters
        /// </summary>
        int Count { get; }
    }

    /// <summary>
    /// Collection of criteria filters
    /// </summary>
    public abstract class BaseFilters<TFieldsEnum, TFilter> : IBaseFilters
    where TFilter : BaseFilter<TFieldsEnum>
    where TFieldsEnum : struct
    {
        public BaseFilters(params TFilter[] filters)
        {
            FieldFilters = filters;
        }

        /// <summary>
        /// List of criteria, note that the weight (cost) of a call increases with each added criteria Filter
        /// </summary>
        public TFilter[] FieldFilters { get; set; }

        /// <summary>
        /// The pagination offset, should be 0 for the first request, 100 to get the 2nd page etc...
        /// </summary>
        /// <example>0</example>
        public uint PaginationOffset { get; set; } = 0;

        /// <summary>
        /// Operator that will be used to Intersect (And) or Add (Or) individual filtered results.
        /// </summary>
        [DefaultValue(FilterOperator.And)]
        public FilterOperator Operator { get; set; } = FilterOperator.And;

        /// <summary>
        /// Number of filters
        /// </summary>
        public int Count
        {
            get { return FieldFilters.Length; }
        }
    }
}
