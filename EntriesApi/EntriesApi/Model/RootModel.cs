﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntriesApi.Model
{
    public class RootModel
    {
        public int count { get; set; }
        public List<EntryModel> entries { get; set; }
    }
}
