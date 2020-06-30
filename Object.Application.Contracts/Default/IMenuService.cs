using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Default
{
    public interface IMenuService
    {
        Task<Response<List<MenuTree>>> GetMenuTree(string userName);
    }

    public class MenuTree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public List<MenuTree> Children { get; set; }
    }
}