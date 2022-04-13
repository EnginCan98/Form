using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
    
        public Result(bool success, string message) : this(success)  //burada this 2. constructor u calıştırır.yani buradaki succes anlamı vardır.
        {
            Message = message;   
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
