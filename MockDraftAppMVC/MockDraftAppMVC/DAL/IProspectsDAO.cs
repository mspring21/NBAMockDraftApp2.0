﻿using MockDraftAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockDraftAppMVC.DAL
{
    public interface IProspectsDAO
    {
        List<Prospect> GetProspect();
    }
}
