using Object.Domain.Shared;
using Volo.Abp.Data;

namespace Object.EntityFrameworkCore
{
    public class ObjectConnectionStringAttribute : ConnectionStringNameAttribute
    {
        private static readonly string db = AppSettings.ConnectionStringName;

        public ObjectConnectionStringAttribute(string name = "") : base(db)
        {
            Name = string.IsNullOrEmpty(name) ? db : name;
        }

        public new string Name { get; }
    }
}