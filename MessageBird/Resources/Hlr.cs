﻿using MessageBird.Objects;
using Newtonsoft.Json;

namespace MessageBird.Resources
{
    sealed class Hlr : Resource
    {
        public Hlr(Objects.Hlr hlr)
            : base("hlr", hlr)
        {
        }
    }
}
