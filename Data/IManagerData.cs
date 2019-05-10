using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    interface IManagerData
    {
        Task<bool> Connect();
        Task<DataTable> getTable(string query);
        Task<DataTable> getTable(string storedProcedure, List<sqlParameters> List);

        Task<bool> Execute(string query);
        Task<bool> Execute(string storedProcedure, List<sqlParameters> List);
    }
}
