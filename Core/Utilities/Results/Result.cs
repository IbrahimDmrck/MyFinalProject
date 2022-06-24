using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
      //şu imzanın yanındaki this şu demek:"ben 2 parametreli bir metot çalıştırdım biri bende yok ama bu sınıf içinde parametresi bu olan bir metot var onu da çağır"
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public string Message{get; }

        public bool Success{ get;}
    }
}
