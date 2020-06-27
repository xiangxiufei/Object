namespace Object.Domain.Shared
{
    public class Response<T>
    {
        public int status { get; set; } = 200;

        public string msg { get; set; } = "服务器异常";

        public T data { get; set; }
    }
}