using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace MyFirstDataServices
{
    [DataServiceKey("Id")]
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }

    }
}