﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp14
{
    public class Language
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int IDFamily {  get; set; }

        public virtual Family Family { get; set; }
    }
}
