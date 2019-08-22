using NBAAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAAPP.DAL
{
    public interface IProspectsDAO
    {
        List<Prospect> GetAllProspects();
        List<Prospect> GetAllProspectsAvailableForDraft(int status);
        List<Prospect> GetAllDraftedProspects(int status);
        List<Prospect> GetTopFourProspectsAvailableForDraft(int status);
        void UpdateStatusOfDraftedPlayer(int id, string teamDrafted);
        Prospect GetProspectById(int id);
    }
}
