using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appBackCService.DataObjects
{
    public class Customer: EntityData
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}