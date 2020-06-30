namespace Object.Domain.Shared.Extensions
{
    public static class StringExtensions
    {
        public static string ToStringX(this object obj)
        {
            return obj == null ? "" : obj.ToString();
        }
    }
}