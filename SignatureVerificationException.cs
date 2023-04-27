﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CihanAbay
{
    public class SignatureVerificationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureVerificationException"/> class
        /// with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SignatureVerificationException(string message) : base(message)
        {
        }
    }
}