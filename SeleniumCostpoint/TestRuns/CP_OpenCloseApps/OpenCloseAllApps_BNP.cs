 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_BNP : SeleniumTestRun
    {
        public OpenCloseAllApps_BNP(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_BNP_BAMINSTALL());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAM1());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAM2());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAO3());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAP4());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAU10());
			AddTestScripts(new OpenCloseApp_BNP_BAMPBA());
			AddTestScripts(new OpenCloseApp_BNP_BAPMAU1());
			AddTestScripts(new OpenCloseApp_BNP_BGMAOM3());
			AddTestScripts(new OpenCloseApp_BNP_BGMBOIX());
			AddTestScripts(new OpenCloseApp_BNP_BGMBOM5());
			AddTestScripts(new OpenCloseApp_BNP_BGMBPIR());
			AddTestScripts(new OpenCloseApp_BNP_BGMBPIX());
			AddTestScripts(new OpenCloseApp_BNP_BGMBPMU());
			AddTestScripts(new OpenCloseApp_BNP_BGMBPUX());
			AddTestScripts(new OpenCloseApp_BNP_BGMOUP());
			AddTestScripts(new OpenCloseApp_BNP_BGPBPI6());
			AddTestScripts(new OpenCloseApp_BNP_BGPBPUE());
			AddTestScripts(new OpenCloseApp_BNP_BGQBOLX());
			AddTestScripts(new OpenCloseApp_BNP_BGQBOP6());
			AddTestScripts(new OpenCloseApp_BNP_BGQBPA13());
			AddTestScripts(new OpenCloseApp_BNP_BGQBPA15());
			AddTestScripts(new OpenCloseApp_BNP_BGQBPA16());
			AddTestScripts(new OpenCloseApp_BNP_BGQBPA17());
			AddTestScripts(new OpenCloseApp_BNP_BGQBPL3());
			AddTestScripts(new OpenCloseApp_BNP_BGQEOR());
			AddTestScripts(new OpenCloseApp_BNP_CAQCOT1());
			AddTestScripts(new OpenCloseApp_BNP_CAQCOT13());
			AddTestScripts(new OpenCloseApp_BNP_CAQCOT2());
			AddTestScripts(new OpenCloseApp_BNP_CAQCPA12());
			AddTestScripts(new OpenCloseApp_BNP_CAQCPA1X());
			AddTestScripts(new OpenCloseApp_BNP_CAQCPA5());
			AddTestScripts(new OpenCloseApp_BNP_CAQCPA6());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOL1());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOL2());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOL3());
			AddTestScripts(new OpenCloseApp_BNP_CAQXONX());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOP1());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOP2());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOP3());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOR1());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOR2());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOR3());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA1());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA10());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA2());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA3());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA4());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA9());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPL1());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPL2());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPT1());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPT3());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPT5());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPT6());
			AddTestScripts(new OpenCloseApp_BNP_NBMBPNB());
			AddTestScripts(new OpenCloseApp_BNP_NBPNBUE());
			AddTestScripts(new OpenCloseApp_BNP_NBQMNBBC());
			AddTestScripts(new OpenCloseApp_BNP_NBQNBBS());
			AddTestScripts(new OpenCloseApp_BNP_NBQSNBBS());
			AddTestScripts(new OpenCloseApp_BNP_OAMAOM1());
			AddTestScripts(new OpenCloseApp_BNP_OAPAOI1());
			AddTestScripts(new OpenCloseApp_BNP_OAQAOCX());
			AddTestScripts(new OpenCloseApp_BNP_OAQAOM4());
			AddTestScripts(new OpenCloseApp_BNP_OAQAOR4());
			AddTestScripts(new OpenCloseApp_BNP_OAQAOR6());
			AddTestScripts(new OpenCloseApp_BNP_OAQAPSX());
			AddTestScripts(new OpenCloseApp_BNP_OAQAPT1());
			AddTestScripts(new OpenCloseApp_BNP_OAQXOPX());
			AddTestScripts(new OpenCloseApp_BNP_SRQSOA1());
			AddTestScripts(new OpenCloseApp_BNP_SRQSOA2());
			AddTestScripts(new OpenCloseApp_BNP_SRQSOA3());
			AddTestScripts(new OpenCloseApp_BNP_SRQSPA11());
			AddTestScripts(new OpenCloseApp_BNP_SRQSPA12());
			AddTestScripts(new OpenCloseApp_BNP_SRQSPA5());
			AddTestScripts(new OpenCloseApp_BNP_SRQSPA6());
			AddTestScripts(new OpenCloseApp_BNP_SRQSPA7());
			AddTestScripts(new OpenCloseApp_BNP_SRQSPA8());
			AddTestScripts(new OpenCloseApp_PJMBURDT());
			AddTestScripts(new OpenCloseApp_SYMGRP());
			AddTestScripts(new OpenCloseApp_SYMUSR());
			AddTestScripts(new OpenCloseApp_BNP_BAMCURPD());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAM10());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAM16());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAM8());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAO7());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAP1());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAP10());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAP2());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAP9());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAU1());
			AddTestScripts(new OpenCloseApp_BNP_BAMMAU9());
			AddTestScripts(new OpenCloseApp_BNP_BAPMAP12());
			AddTestScripts(new OpenCloseApp_BNP_BAPREFRESH());
			AddTestScripts(new OpenCloseApp_BNP_BAQMAU6());
			AddTestScripts(new OpenCloseApp_BNP_CAMXPM2());
			AddTestScripts(new OpenCloseApp_BNP_CAMXPM4());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOL4());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOL5());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOP4());
			AddTestScripts(new OpenCloseApp_BNP_CAQXOP5());
			AddTestScripts(new OpenCloseApp_BNP_CAQXPA8());
			AddTestScripts(new OpenCloseApp_BNP_NBQNPI8());
			AddTestScripts(new OpenCloseApp_BNP_OAMAOM2());
			AddTestScripts(new OpenCloseApp_BNP_OAPAOI2());
			AddTestScripts(new OpenCloseApp_BNP_OAPAOM5());
			AddTestScripts(new OpenCloseApp_BNP_OAQAOP4());
			AddTestScripts(new OpenCloseApp_BNP_OAQAOP5());
			AddTestScripts(new OpenCloseApp_BNP_PVRPPA14());
			AddTestScripts(new OpenCloseApp_BPMAGLC());
			AddTestScripts(new OpenCloseApp_BPMAPLC());
			AddTestScripts(new OpenCloseApp_PJPIMPPL());
		}
    }
	
}
