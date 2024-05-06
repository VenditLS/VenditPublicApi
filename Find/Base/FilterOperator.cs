namespace VenditPublicSdk.Find.Base
{
    /// <summary>
    /// Operator that will be used to Intersect (And) or Add (Or) individual filtered results.
    /// </summary>
    public enum FilterOperator
    {
        /// <summary>
        /// Intersect all results with each other (only return common results).
        /// </summary>
        And = 0,

        /// <summary>
        /// Merge all results adding items from each filter.
        /// </summary>
        Or = 1
    }
}
