 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_Projects2 : SeleniumTestRun
    {
        public OpenCloseAllApps_Projects2(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_BLMGPO());
			AddTestScripts(new OpenCloseApp_BLMOTH());
			AddTestScripts(new OpenCloseApp_BLMSHFRM());
			AddTestScripts(new OpenCloseApp_BLMSTTXT());
			AddTestScripts(new OpenCloseApp_BLMUBRC());
			AddTestScripts(new OpenCloseApp_BLMWBS());
			AddTestScripts(new OpenCloseApp_BLMWHCD());
			AddTestScripts(new OpenCloseApp_BLPACRN());
			AddTestScripts(new OpenCloseApp_BLPCASHB());
			AddTestScripts(new OpenCloseApp_BLPCUSPD());
			AddTestScripts(new OpenCloseApp_BLPEDI());
			AddTestScripts(new OpenCloseApp_BLPGEN());
			AddTestScripts(new OpenCloseApp_BLPLMTRN());
			AddTestScripts(new OpenCloseApp_BLPMANB());
			AddTestScripts(new OpenCloseApp_BLPMPCB());
			AddTestScripts(new OpenCloseApp_BLPOBDFC());
			AddTestScripts(new OpenCloseApp_BLPPOBD());
			AddTestScripts(new OpenCloseApp_BLPPRO());
			AddTestScripts(new OpenCloseApp_BLPPROGP());
			AddTestScripts(new OpenCloseApp_BLPPROJB());
			AddTestScripts(new OpenCloseApp_BLPRBIL());
			AddTestScripts(new OpenCloseApp_BLPREVB());
			AddTestScripts(new OpenCloseApp_BLPSELCT());
			AddTestScripts(new OpenCloseApp_BLPSUBPP());
			AddTestScripts(new OpenCloseApp_BLPUMB());
			AddTestScripts(new OpenCloseApp_BLPUNBIL());
			AddTestScripts(new OpenCloseApp_BLPUPCUR());
			AddTestScripts(new OpenCloseApp_BLPUPOBD());
			AddTestScripts(new OpenCloseApp_BLPUPPLC());
			AddTestScripts(new OpenCloseApp_BLPUPTAX());
			AddTestScripts(new OpenCloseApp_BLPUPUU());
			AddTestScripts(new OpenCloseApp_BLPUSAGE());
			AddTestScripts(new OpenCloseApp_BLRBREG());
			AddTestScripts(new OpenCloseApp_BLRCPROD());
			AddTestScripts(new OpenCloseApp_BLRMPCB());
			AddTestScripts(new OpenCloseApp_BLRPJPRD());
			AddTestScripts(new OpenCloseApp_BLRUEDIT());
			AddTestScripts(new OpenCloseApp_BLRUHIST());
			AddTestScripts(new OpenCloseApp_BLRUNBIL());
			AddTestScripts(new OpenCloseApp_BPMAGLC());
			AddTestScripts(new OpenCloseApp_BPMAPLC());
			AddTestScripts(new OpenCloseApp_BPMPDDAY());
			AddTestScripts(new OpenCloseApp_BPMRVSN());
			AddTestScripts(new OpenCloseApp_BPMSET());
			AddTestScripts(new OpenCloseApp_BPPBRECL());
			AddTestScripts(new OpenCloseApp_BPPETCUP());
			AddTestScripts(new OpenCloseApp_BPPMBRT());
			AddTestScripts(new OpenCloseApp_BPPREV());
			AddTestScripts(new OpenCloseApp_BPRLBETC());
			AddTestScripts(new OpenCloseApp_BPRPJBUD());
			AddTestScripts(new OpenCloseApp_BPRPJETC());
			AddTestScripts(new OpenCloseApp_BPRPJEV());
			AddTestScripts(new OpenCloseApp_BPRPJSUB());
			AddTestScripts(new OpenCloseApp_IWMLOC());
			AddTestScripts(new OpenCloseApp_IWPALLOC());
			AddTestScripts(new OpenCloseApp_IWPEXPRT());
			AddTestScripts(new OpenCloseApp_IWPIMPRT());
			AddTestScripts(new OpenCloseApp_IWPPOST());
			AddTestScripts(new OpenCloseApp_IWPUPLD());
			AddTestScripts(new OpenCloseApp_PJM533FY());
			AddTestScripts(new OpenCloseApp_PJM533PD());
			AddTestScripts(new OpenCloseApp_PJM533PJ());
			AddTestScripts(new OpenCloseApp_PJMAGLC());
			AddTestScripts(new OpenCloseApp_PJMAPLC());
			AddTestScripts(new OpenCloseApp_PJMCOGS());
			AddTestScripts(new OpenCloseApp_PJMCOSTA());
			AddTestScripts(new OpenCloseApp_PJMDELIV());
			AddTestScripts(new OpenCloseApp_PJMEVDISC());
			AddTestScripts(new OpenCloseApp_PJMEVSTAT());
			AddTestScripts(new OpenCloseApp_PJMGOVT());
			AddTestScripts(new OpenCloseApp_PJMMODDC());
			AddTestScripts(new OpenCloseApp_PJMPAO());
			AddTestScripts(new OpenCloseApp_PJMPERFOB());
			AddTestScripts(new OpenCloseApp_PJMPTYPE());
			AddTestScripts(new OpenCloseApp_PJMQORG());
			AddTestScripts(new OpenCloseApp_PJMQPAG());
			AddTestScripts(new OpenCloseApp_PJMQPJAP());
			AddTestScripts(new OpenCloseApp_PJMQPROJ());
			AddTestScripts(new OpenCloseApp_PJMQSETA());
			AddTestScripts(new OpenCloseApp_PJMQTPLT());
			AddTestScripts(new OpenCloseApp_PJMTCEIL());
			AddTestScripts(new OpenCloseApp_PJP533PR());
			AddTestScripts(new OpenCloseApp_PJPAAFC());
			AddTestScripts(new OpenCloseApp_PJPABJP());
			AddTestScripts(new OpenCloseApp_PJPAIPRJ());
			AddTestScripts(new OpenCloseApp_PJPALBUD());
			AddTestScripts(new OpenCloseApp_PJPALCST());
			AddTestScripts(new OpenCloseApp_PJPALTP());
			AddTestScripts(new OpenCloseApp_PJPAPPIC());
			AddTestScripts(new OpenCloseApp_PJPBBCR());
			AddTestScripts(new OpenCloseApp_PJPBREAL());
			AddTestScripts(new OpenCloseApp_PJPCHORG());
			AddTestScripts(new OpenCloseApp_PJPCKUN());
			AddTestScripts(new OpenCloseApp_PJPCOGS());
			AddTestScripts(new OpenCloseApp_PJPCOPY());
			AddTestScripts(new OpenCloseApp_PJPCRETC());
			AddTestScripts(new OpenCloseApp_PJPCRLNK());
			AddTestScripts(new OpenCloseApp_PJPCRRPT());
			AddTestScripts(new OpenCloseApp_PJPCSSR());
			AddTestScripts(new OpenCloseApp_PJPCSSRU());
			AddTestScripts(new OpenCloseApp_PJPCSTR());
			AddTestScripts(new OpenCloseApp_PJPETCR());
			AddTestScripts(new OpenCloseApp_PJPETCU());
			AddTestScripts(new OpenCloseApp_PJPEXCPT());
			AddTestScripts(new OpenCloseApp_PJPGOAL());
			AddTestScripts(new OpenCloseApp_PJPGPLAB());
			AddTestScripts(new OpenCloseApp_PJPIMPPL());
			AddTestScripts(new OpenCloseApp_PJPINBRD());
			AddTestScripts(new OpenCloseApp_PJPLDRAT());
			AddTestScripts(new OpenCloseApp_PJPMBRT());
			AddTestScripts(new OpenCloseApp_PJPMENDP());
			AddTestScripts(new OpenCloseApp_PJPMJALC());
			AddTestScripts(new OpenCloseApp_PJPMJAS());
			AddTestScripts(new OpenCloseApp_PJPOBT());
			AddTestScripts(new OpenCloseApp_PJPPARMS());
			AddTestScripts(new OpenCloseApp_PJPPERF());
			AddTestScripts(new OpenCloseApp_PJPPLSUM());
			AddTestScripts(new OpenCloseApp_PJPPOOLP());
			AddTestScripts(new OpenCloseApp_PJPPOP());
			AddTestScripts(new OpenCloseApp_PJPPOSTP());
			AddTestScripts(new OpenCloseApp_PJPPOSTR());
			AddTestScripts(new OpenCloseApp_PJPPREP());
			AddTestScripts(new OpenCloseApp_PJPPREV());
			AddTestScripts(new OpenCloseApp_PJPPTRAN());
			AddTestScripts(new OpenCloseApp_PJPPUR());
			AddTestScripts(new OpenCloseApp_PJPPURGE());
			AddTestScripts(new OpenCloseApp_PJPQPREP());
			AddTestScripts(new OpenCloseApp_PJPREPTP());
			AddTestScripts(new OpenCloseApp_PJPREVP());
			AddTestScripts(new OpenCloseApp_PJPSGOAL());
			AddTestScripts(new OpenCloseApp_PJPSTLVL());
			AddTestScripts(new OpenCloseApp_PJPTOTU());
			AddTestScripts(new OpenCloseApp_PJPUPLAB());
			AddTestScripts(new OpenCloseApp_PJPUPPSR());
			AddTestScripts(new OpenCloseApp_PJPUPPY());
			AddTestScripts(new OpenCloseApp_PJPUPTHT());
			AddTestScripts(new OpenCloseApp_PJPUPVAL());
			AddTestScripts(new OpenCloseApp_PJR533RP());
			AddTestScripts(new OpenCloseApp_PJRALJNL());
			AddTestScripts(new OpenCloseApp_PJRBASIC());
			AddTestScripts(new OpenCloseApp_PJRCSSR());
			AddTestScripts(new OpenCloseApp_PJRETC());
			AddTestScripts(new OpenCloseApp_PJRETCH());
			AddTestScripts(new OpenCloseApp_PJRFORM());
			AddTestScripts(new OpenCloseApp_PJRORCST());
			AddTestScripts(new OpenCloseApp_PJRPAG());
			AddTestScripts(new OpenCloseApp_PJRPOOL());
			AddTestScripts(new OpenCloseApp_PJRPRLIS());
			AddTestScripts(new OpenCloseApp_PJRPWF());
			AddTestScripts(new OpenCloseApp_PJRREV());
			AddTestScripts(new OpenCloseApp_PJRSCTR());
			AddTestScripts(new OpenCloseApp_PJRSETUP());
			AddTestScripts(new OpenCloseApp_PJRSVCST());
			AddTestScripts(new OpenCloseApp_POPCOMM());
			AddTestScripts(new OpenCloseApp_SMMSETNG());
			AddTestScripts(new OpenCloseApp_SMMWROLE());
			AddTestScripts(new OpenCloseApp_SMPINVC());
			AddTestScripts(new OpenCloseApp_SMRINVC());
			AddTestScripts(new OpenCloseApp_SMRWRK());
		}
    }
	
}
