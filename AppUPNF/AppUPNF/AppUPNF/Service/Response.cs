﻿using System;
namespace AppUPNF.Service
{
    public class Response
    {
        public Response()
        {
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
