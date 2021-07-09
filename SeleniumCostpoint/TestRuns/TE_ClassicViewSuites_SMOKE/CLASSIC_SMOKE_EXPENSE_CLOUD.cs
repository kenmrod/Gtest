using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CLASSIC_SMOKE_EXPENSE_CLOUD : SeleniumTestRun
    {
        public CLASSIC_SMOKE_EXPENSE_CLOUD(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME, "TE_DCO_C711T10CLDAUTOTEST_CLASSIC");
            AddTestScripts(new EPMEXPAUTH_SMOKE());
            AddTestScripts(new EPMEXPAUTHAPPROVE_SMOKE());
            AddTestScripts(new EPMEXPAUTHRPT_SMOKE());
            AddTestScripts(new EPMEXPRPT_SMOKE());
            AddTestScripts(new EPMEXPRPTAPPROVE_SMOKE());
            AddTestScripts(new EPMEXPREPRPT_SMOKE());
            AddTestScripts(new EPROUTAGING_SMOKE());
            AddTestScripts(new EPREXPAUTHSTATUS_SMOKE());
            AddTestScripts(new EPREXPRPTSTATUS_SMOKE());
            AddTestScripts(new EPMCOMMITINQUIRY_SMOKE());
            AddTestScripts(new EPRCOMMITSTATUS_SMOKE());
            AddTestScripts(new EPMEXPBATCHTYPE_SMOKE());
            AddTestScripts(new EPMIMPEXP_SMOKE());
            AddTestScripts(new EPPEXPORTEXP_SMOKE());
            AddTestScripts(new EPPEXPORTCOMMIT_SMOKE());
            AddTestScripts(new EPPCOMPUTECOMMIT_SMOKE());
            AddTestScripts(new EPMCONFIG_SMOKE());
            AddTestScripts(new EPMCURRENCY_SMOKE());
            AddTestScripts(new EPMMIE_SMOKE());
            AddTestScripts(new EPMPROVIDERS_SMOKE());
            AddTestScripts(new EPMEXPCHGTYPE_SMOKE());
            AddTestScripts(new EPMPAYMETHOD_SMOKE());
            AddTestScripts(new EPMCURSCH_SMOKE());
            AddTestScripts(new EPMPERDIEMSCH_SMOKE());
            AddTestScripts(new EPMTAXSCH_SMOKE());
            AddTestScripts(new EPMEXPTYPE_SMOKE());
            AddTestScripts(new EPMEXPREPTYPE_SMOKE());
            AddTestScripts(new EPMEXPENSECLASS_SMOKE());
            AddTestScripts(new EPQCLREXPRPT_SMOKE());
            AddTestScripts(new EPQCLREPAUTH_SMOKE());
            AddTestScripts(new EPMEXPUTIL_SMOKE());
            AddTestScripts(new EPMADVUTIL_SMOKE());
            AddTestScripts(new EPMPAYUTIL_SMOKE());
            AddTestScripts(new EPQCHGEXPSTAT_SMOKE());
            AddTestScripts(new EPPBARPROCESSOR_SMOKE());
        }
    }
}
