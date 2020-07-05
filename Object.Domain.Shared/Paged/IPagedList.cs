namespace Object.Domain.Shared
{
    public interface IPagedList<T> : IListResult<T>, IHasTotalCount
    {
    }
}