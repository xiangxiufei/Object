using System.Collections.Generic;

namespace Object.Domain.Shared
{
    public interface IListResult<T>
    {
        IReadOnlyList<T> List { get; set; }
    }
}