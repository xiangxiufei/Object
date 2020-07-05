using System.Collections.Generic;

namespace Object.Domain.Shared
{
    public class ListResult<T> : IListResult<T>
    {
        private IReadOnlyList<T> list;

        public IReadOnlyList<T> List
        {
            get => list ?? (list = new List<T>());
            set => list = value;
        }

        public ListResult()
        {
        }

        public ListResult(IReadOnlyList<T> list)
        {
            List = list;
        }
    }
}