﻿using System;
using System.Collections.Generic;

namespace Accelerider.Windows.Models
{
    public class ModuleMetadata
    {
        public long Id { get; set; }

        public string TargetPlatform { get; set; }

        public string Authors { get; set; }

        public Uri LogoUrl { get; set; }

        public string Description { get; set; }

        public double Rate { get; set; }

        public long DownloadCount { get; set; }

        public string Checksum { get; set; }

        public string ModuleName { get; set; }

        public string ModuleType { get; set; }

        public IList<string> Dependencies { get; set; }
    }
}
