using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success)
        {
            Massage = message;
           
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success {get; }

        public string Massage {get; }
    }
}
