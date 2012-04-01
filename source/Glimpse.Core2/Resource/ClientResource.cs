﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Glimpse.Core2.Extensibility;
using Glimpse.Core2.Framework;
using Glimpse.Core2.ResourceResult;

namespace Glimpse.Core2.Resource
{
    public class Client : FileResource
    {
        internal const string InternalName = "glimpse.js";

        public Client()
        {
            ResourceName = "Glimpse.Core2.glimpse.js";
            ResourceType = @"application/x-javascript";
            Name = InternalName;
        }
    }
}