using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.Object
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class Menu : Entity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }

        public int Sort { get; set; }

        public int Level { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}