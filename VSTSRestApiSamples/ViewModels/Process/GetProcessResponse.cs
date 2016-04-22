﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsRestApiSamples.ViewModels.Process
{

    public class GetProcessResponse
    {
        public class Process : BaseViewModel
        {
            public string id { get; set; }
            public string description { get; set; }
            public bool isDefault { get; set; }
            public _Links _links { get; set; }
            public string url { get; set; }
            public string name { get; set; }
        }

        public class _Links
        {
            public Self self { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
        }
    }
}
