namespace RecruitingWeb.Controllers
{
    internal class PaginatedResultSet<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
        public object Items { get; set; }
    }
}