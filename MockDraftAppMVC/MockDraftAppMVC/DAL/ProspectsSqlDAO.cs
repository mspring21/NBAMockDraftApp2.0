using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockDraftAppMVC.DAL
{
    public class ProspectsSqlDAO
    {
        private readonly string connectionString;

        public ProspectsSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
