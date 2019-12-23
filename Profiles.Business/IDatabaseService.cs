﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiles.Business
{
    public interface IDatabaseService
    {
        List<Profile> Profiles { get; }

        List<Profile> GetProfiles();
    }
}
