﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EntriesApi.Model;

namespace EntriesApi.Services
{
    public class RequestManager
    {
        IRestService restService;
        public RequestManager(IRestService service)
        {
            restService = service;
        }
        public Task<List<EntryModel>> GetEntrieModels()
        {
            return restService.GetDataAsync();
        }
    }
}
