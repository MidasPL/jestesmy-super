using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using xml.Data;
namespace xml.Model
{
    public class xmlTree
    {
        public string Title { get; set; }
        public XElement URIComment {get; set;}
        public XElement URIVerdict { get; set; }
        public XElement URIVerdictOveride { get; set; }
        public string Req { get; set; }
        public string Tester { get; set; }
        public string Action { get; set; }
        public string ExResult { get; set; }
        public string AcResult { get; set; }
        public string Num { get; set; }
        public string Date { get; set; }
        public ObservableCollection<xmlTree> tree { get; set; }
        
        public xmlTree()
        {
            this.tree = new ObservableCollection<xmlTree>();
 
        }
    }



    

}
