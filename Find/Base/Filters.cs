using System.ComponentModel;
using System.Xml.Serialization;

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

        /// <summary>
        /// Will call GetMultiple and add the results to the reply, this will set a cap of maximum 30 to PageSize
        /// </summary>
        public bool IncludeEntities { get; set; } = false;

        /// <summary>
        /// See the GetWithDetails documentation of the specific entity for more information (if supported), this will add to the cost of the call and is only relevant if IncludeEntities is true.
        /// <para>Every detail flag that is set adds one or more joins to the query, so the maximum PageSize is reduced accordingly:
        /// starting at 30 it is lowered by 2 for each flag set in this value, never going below 5.</para>
        /// <para>For example: 1 flag caps the PageSize to 28, 2 flags to 26, 5 flags to 20, and 13 or more flags to 5.</para>
        /// </summary>
        public long EntityDetails { get; set; } = 0;

        /// <summary>
        /// The maximum number of items to include in a single page of results.
        /// <para>If IncludeEntities is true, then the maximum will be limited to 30. Setting EntityDetails lowers that maximum
        /// by 2 for every flag that is set in it (with an absolute minimum of 5), because each requested detail adds joins to the query.</para>
        /// <para>A higher requested PageSize is silently reduced to the applicable maximum, use the PaginationOffset to fetch the remaining results.</para>
        /// </summary>
        public uint PageSize { get; set; } = 100;
    }
}
