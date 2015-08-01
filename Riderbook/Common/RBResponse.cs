using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Riderbook.Common
{
    public class RBResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public string Data { get; set; }
        public object Object { get; set; }

        public RBResponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public RBResponse(bool isSuccess, string message, object data)
        {
            
            IsSuccess = isSuccess;
            Message = message;
            Object = data;
        }

        public RBResponse(bool isSuccess, string message, string title)
        {
            IsSuccess = isSuccess;
            Message = message;
            Title = title;
        }

        public RBResponse(bool isSuccess, string message, string title, string data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Title = title;
            Data = data;
        }
    }
}