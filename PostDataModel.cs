using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace separate_app
{
    internal class PostDataModel
    {
        public string HostUrl { get; set; }
        public string MacAddress { get; set; }
        public string[] SiteNames { get; set; }
    }
}
