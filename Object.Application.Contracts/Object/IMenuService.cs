using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Object
{
    public interface IMenuService
    {
        Task<Response<List<MenuTree>>> GetMenuTree(string userName);

        Task<string> GetMenu(string type);
    }

    public class MenuTree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public List<MenuTree> Children { get; set; }
    }

    public class MenuList
    {
        public int Id { get; set; }
        public string AuthName { get; set; }
        public string Level { get; set; }
        public string Pid { get; set; }
        public string Path { get; set; }
    }
}