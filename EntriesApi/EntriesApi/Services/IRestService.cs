using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EntriesApi.Model;

namespace EntriesApi.Services
{
    public interface IRestService
    {
        Task<List<EntryModel>> GetDataAsync();
    }
}
