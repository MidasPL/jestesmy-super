using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlData.Model
{
    public class XmlData
    {
       public XDocument xmlfile;

       public XmlData(string path)
        {
            xmlfile = XDocument.Load(path);
        }
       public string getMainName()
       {
           return this.xmlfile.Element("SandboxExchangeFormat").Element("TestOrder").Element("Name").Value;
       }
       public string getSecName()
       {
           return this.xmlfile.Element("SandboxExchangeFormat").Element("TestOrder").Element("TestOrder").Element("Name").Value;
       }
       public string getThName()
       {
           return this.xmlfile.Element("SandboxExchangeFormat").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("Name").Value;
       }
       public string getFoName()
       {
           return this.xmlfile.Element("SandboxExchangeFormat").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("Name").Value;
       }
       public string getTestSuiteName()
       {
           return this.xmlfile.Element("SandboxExchangeFormat").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("TestSuite").Element("Name").Value;
       }
       public IEnumerable<XElement> getTestCases()
       {
           return this.xmlfile.Element("SandboxExchangeFormat").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("TestOrder").Element("TestSuite").Elements("ATC");
       }
        public string getTestCaseName(XElement ATC)
       {
           return ATC.Element("Name").Value;
       }
        public string getTestCaseReq(XElement ATC)
        {
            string result = "";
            foreach (var element in ATC.Elements("Requirement"))
            {
                result += element.Element("ID").Value +";";
            }
            return result;
        }
        public string getTestCaseDate(XElement ATC)
        {
            return ATC.Element("ExecutionDate").Value;
        }
        public string getTestCaseTester(XElement ATC)
        {
            return ATC.Element("Tester").Value;
        }
        public XElement getURITestCaseVerdict(XElement ATC) //get URI adress to OverrideInformation tag
        {
            return ATC.Element("Verdict");
        }

        public XElement getURITestCaseComment(XElement ATC) //get URI adress to OverrideInformation tag
        {
            return ATC.Element("OverrideInformation");
        }
        public XElement getURITestCaseOverrideVerdictActive(XElement ATC) //get URI adress to OverrideVerdict tag
        {
            return ATC.Element("OverrideVerdictActive");
        }
        public IEnumerable<XElement> getTestProcedures(XElement ATC)
        {
            return ATC.Elements("Procedure");
        }
        public string getProcedureName(XElement Procedure)
        {
            return Procedure.Element("ProcedureName").Value;
        }
        public XElement getURIProcedureOverrideVerdictActive(XElement Procedure) //get URI adress to procedure OverrideVerdict tag
        {
            return Procedure.Element("OverrideVerdictActive");
        }
        public XElement getURITestProcedureVerdict(XElement Procedure) //get URI adress to procedure OverrideInformation tag
        {
            return Procedure.Element("Verdict");
        }
        public IEnumerable<XElement> getTestSteps(XElement Procedure)
        {
            return Procedure.Elements("Result");
        }
        public string getTestStepNum(XElement TestStep)
        {
            return TestStep.Element("SequenceNumber").Value;
        }
        public string getTestStepAction(XElement TestStep)
        {
            return TestStep.Element("Action").Value;
        }
        public string getTestStepExResult(XElement TestStep)
        {
            return TestStep.Element("ExpectedResult").Value;
        }
        public string getTestStepAcResult(XElement TestStep)
        {
            return TestStep.Element("Result").Value;
        }
        public XElement getURITestStepVerdict(XElement TestStep) //get URI adress to TestStep Verdict tag
        {
            return TestStep.Element("Verdict");
        }
    }
}
