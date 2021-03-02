using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //const

        public Result(bool success, string message):this(success)//*-* bu class //constructor
        {
            Message = message;
            
        }

        public Result(bool success)
        {
            
            Success = success;
        }


        public string Message { get; }

        public bool Success { get; }
    }
}