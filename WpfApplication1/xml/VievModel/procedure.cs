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
    public class procedure
    {
        public string Title { get; set; }
        public ObservableCollection<step> steps { get; set; }
        public XElement VerdictUri { get; set; }
        public XElement OverUri { get; set; }

        public procedure(xmlTree acIte)
        {
            this.Title = acIte.Title;
            this.VerdictUri = acIte.URIVerdict;
            this.OverUri = acIte.URIVerdictOveride;
            this.steps = new ObservableCollection<step>();
            foreach (var ele in acIte.tree)
            {
                step tmp = new step(ele);
                steps.Add(tmp);
            }
        }
    }
    

}
