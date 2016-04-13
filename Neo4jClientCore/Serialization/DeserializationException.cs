﻿using System;

namespace Neo4jClient.Serialization
{
    public class DeserializationException : ApplicationException
    {
        public DeserializationException(string message)
            : base(message)
        {}

        public DeserializationException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
