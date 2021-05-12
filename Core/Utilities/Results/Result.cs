using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string  message):this(success)//succes in de çalışması için iki parametre gönderen için 
        {
            Massage = message;            
        }
        public Result(bool success)
        {           
            Success = success;
        }
        public bool Success { get; }

        public string Massage { get; }
    }
}
