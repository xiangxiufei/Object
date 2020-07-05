﻿namespace Object.Domain.Shared
{
    public class Response<T>
    {
        public int status { get; set; } = 200;

        public string msg { get; set; } = "";

        public T data { get; set; }

        public void Success(T data, string msg = "")
        {
            this.status = 200;
            this.msg = msg;
            this.data = data;
        }
    }
}