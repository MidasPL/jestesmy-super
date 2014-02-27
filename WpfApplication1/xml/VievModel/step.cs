using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using xml.Model;
using xml.Data;
using xmlData.Model;

namespace xml.VievModel
{
    public class step
    {
        public string num { get; set; }
        public string Action { get; set; }
        public string ExRes { get; set; }
        public string ACRes { get; set; }

        public XElement VerdictUri { get; set; }
        public step(xmlTree acIte)
        {
            this.num = acIte.Num;
            this.Action = acIte.Action;
            this.ExRes = acIte.ExResult;
            this.ACRes = acIte.AcResult;
            this.VerdictUri = acIte.URIVerdict;

        }
    }
}
