﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xmlData.Model;

namespace xml.Data
{
    public class XML
    {
        public List<XmlData> XMLfiles { get; set; }

       public void save()
       {
           foreach(var element in this.XMLfiles)
           {
               element.xmlfile.Save(element.path);
           }
       }
    
    }
}
