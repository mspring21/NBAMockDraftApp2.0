using NBAAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAAPP.DAL
{
    public interface ITeamDAO
    {
        List<Team> GetDraftOrder();
    }
}
