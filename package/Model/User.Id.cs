﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidnightLizard.Commons.Domain.Model
{
    public class UserId : DomainEntityId<string>
    {
        protected UserId() : base()
        {
        }

        public UserId(string id) : base(id)
        {
        }
    }
}
