namespace VenditPublicSdk.Find.Base
{
    public interface IResultsReply
    {
        /// <summary>
        /// The pagination offset of this result
        /// </summary>
        /// <example>0</example>
        uint PaginationOffset { get; set; }

        /// <summary>
        /// The total number of results
        /// </summary>
        /// <example>3</example>
        uint PaginationRowCount { get; set; }
    }

    /// <summary>
    /// Contains a collection of primary keys and pagination information
    /// </summary>
    public class BaseResultsReply<TPrimaryKey> : IResultsReply
    {
        /// <summary>
        /// Primary keys (IDs of items)
        /// </summary>
        /// <example>[142, 304, 599]</example>
        public TPrimaryKey[] Results { get; set; }

        /// <summary>
        /// The pagination offset of this result
        /// </summary>
        /// <example>0</example>
        public uint PaginationOffset { get; set; }

        /// <summary>
        /// The total number of results
        /// </summary>
        /// <example>3</example>
        public uint PaginationRowCount { get; set; }
    }
}
