﻿using System;
using Bicimad.Core.DomainObjects.Interfaces;

namespace Bicimad.Core.DomainObjects
{
    public class ApiUser : IEntity
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Token { get; set; } //Token that we generate.

        public string ApiKey { get; set; } //GUID

        public string UserId { get; set; } // User who owns the token.

        public virtual User User { get; set; }
    }
}