﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public DataResult(T data,bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(bool success) : base(success)
        {
            Data = Data;
        }

        public T Data { get; }
    }
}