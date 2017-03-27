﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.HealthVault.Connection
{
    internal class MessageHandlerFactory : IMessageHandlerFactory
    {
        public HttpClientHandler Create()
        {
            return new HttpClientHandler();
        }
    }
}