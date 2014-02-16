using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xml.Data;

namespace xml.Model
{
    public class WrapUpXmltree
    {
        public xmlTree tree { set; get; }
        public WrapUpXmltree(XML list)
        {
            this.tree = new xmlTree();
            foreach(var file in list.XMLfiles)
            {

                xmlTree MainEle = new xmlTree() { Title = file.getMainName() };
                xmlTree SecEle = new xmlTree() { Title = file.getSecName() };
                xmlTree ThEle = new xmlTree() { Title = file.getThName() };
                xmlTree FoEle = new xmlTree() { Title = file.getFoName() };
                xmlTree TestSuite = new xmlTree() { Title = file.getTestSuiteName() };
                foreach(var TestCases in file.getTestCases())
                {
                    xmlTree TestCase = new xmlTree() { Title = file.getTestCaseName(TestCases), Req = file.getTestCaseReq(TestCases), URIVerdict = file.getURITestCaseVerdict(TestCases), Date = file.getTestCaseDate(TestCases), Tester = file.getTestCaseTester(TestCases), URIComment = file.getURITestCaseComment(TestCases),URIVerdictOveride = file.getURITestCaseOverrideVerdictActive(TestCases) };
                    foreach(var Procedure in file.getTestProcedures(TestCases))
                    {
                        xmlTree Proc = new xmlTree() { Title = file.getProcedureName(Procedure), URIVerdictOveride = file.getURIProcedureOverrideVerdictActive(Procedure), URIVerdict = file.getURITestProcedureVerdict(Procedure) };
                        foreach(var Step in file.getTestSteps(Procedure))
                        {
                            Proc.tree.Add(new xmlTree() { Num = file.getTestStepNum(Step),Title=file.getTestStepAction(Step), Action = file.getTestStepAction(Step), ExResult = file.getTestStepExResult(Step), AcResult = file.getTestStepAcResult(Step), URIVerdict = file.getURITestStepVerdict(Step) });
                        }
                        TestCase.tree.Add(Proc);
                    }
                    TestSuite.tree.Add(TestCase);
                }
                FoEle.tree.Add(TestSuite);
                ThEle.tree.Add(FoEle);
                SecEle.tree.Add(ThEle);
                MainEle.tree.Add(SecEle);
                this.tree.tree.Add(MainEle);
            }
        }
    }
}
