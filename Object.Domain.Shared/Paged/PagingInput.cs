namespace Object.Domain.Shared
{
    public class PagingInput
    {
        public string Query { get; set; }
        public int PageNum { get; set; }
        public int PageSize { get; set; }
    }
}