using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class CustomType
    {
        /* "TypeName": "MyType",
           "TypeMethods": "Available",
           "ConnectionTimeOut":  15   */

        public string TypeName { get; set; }
        public string TypeMethods { get; set; }
        public int ConnectionTimeOut { get; set; }
    }
}
