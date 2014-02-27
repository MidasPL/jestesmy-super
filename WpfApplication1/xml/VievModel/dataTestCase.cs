using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using xml.Model;
using xml.Data;
using xmlData.Model;
using System.Collections.ObjectModel;

namespace xml.VievModel
{
    public class dataTestCase
    {
        public string Title { get; set; }
        public string req { get; set; }
        public string date { get; set; }
        public string tester { get; set; }
        public string ID { get; set; }
        public ObservableCollection<procedure> procedures { get; set; }
        public XElement VerdictUri { get; set; }
        public XElement OverUri { get; set; }
        public XElement ComenntUri { get; set; }


        public dataTestCase(xmlTree acIte)
        {
            this.Title = acIte.Title;
            this.req = acIte.Req;
            this.date = acIte.Date;
            this.tester = acIte.Tester;
            this.ID = acIte.ID;
            this.VerdictUri = acIte.URIVerdict;
            this.OverUri = acIte.URIVerdictOveride;
            this.ComenntUri = acIte.URIComment;
            this.procedures = new ObservableCollection<procedure>();
            foreach(var ele in acIte.tree)
            {
                procedure tmp = new procedure(ele);
                procedures.Add(tmp);
            }

        }
    }
}
