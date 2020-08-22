namespace Object.Domain.Shared
{
    public class Response<T>
    {
        public int Status { get; set; } = 200;

        public string Msg { get; set; } = "";

        public T Data { get; set; }

        public void Success(T data, string msg = "")
        {
            this.Status = 200;
            this.Msg = msg;
            this.Data = data;
        }
    }
}