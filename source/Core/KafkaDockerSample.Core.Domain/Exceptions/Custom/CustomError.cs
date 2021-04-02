﻿using System.Net;

namespace KafkaDockerSample.Core.Domain.Exceptions.Custom
{
    public abstract class CustomError
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; }

        public CustomError(HttpStatusCode statusCode, string error)
        {
            StatusCode = statusCode;
            Message = error;
        }
    }
}