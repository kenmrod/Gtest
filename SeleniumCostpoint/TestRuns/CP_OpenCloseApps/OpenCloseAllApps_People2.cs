 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_People2 : SeleniumTestRun
    {
        public OpenCloseAllApps_People2(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
            AddTestScripts(new OpenCloseApp_LDQTHF());
            AddTestScripts(new OpenCloseApp_LDRMIS());
            AddTestScripts(new OpenCloseApp_PRMDED());
            AddTestScripts(new OpenCloseApp_PRMDEDSC());
            AddTestScripts(new OpenCloseApp_PRMDGL());
            AddTestScripts(new OpenCloseApp_PRMEBOND());
            AddTestScripts(new OpenCloseApp_PRMEBT());
            AddTestScripts(new OpenCloseApp_PRMEGARN());
            AddTestScripts(new OpenCloseApp_PRMEIC());
            AddTestScripts(new OpenCloseApp_PRMERF());
            AddTestScripts(new OpenCloseApp_PRMETAX());
            AddTestScripts(new OpenCloseApp_PRMEXTAX());
            AddTestScripts(new OpenCloseApp_PRMFLVY());
            AddTestScripts(new OpenCloseApp_PRMFTI());
            AddTestScripts(new OpenCloseApp_PRMFTT());
            AddTestScripts(new OpenCloseApp_PRMLSD());
            AddTestScripts(new OpenCloseApp_PRMLTI());
            AddTestScripts(new OpenCloseApp_PRMLTT());
            AddTestScripts(new OpenCloseApp_PRMMC());
            AddTestScripts(new OpenCloseApp_PRMPAYTT());
            AddTestScripts(new OpenCloseApp_PRMPRPD());
            AddTestScripts(new OpenCloseApp_PRMPRSET());
            AddTestScripts(new OpenCloseApp_PRMPTF());
            AddTestScripts(new OpenCloseApp_PRMRTAX());
            AddTestScripts(new OpenCloseApp_PRMSMW());
            AddTestScripts(new OpenCloseApp_PRMSSD());
            AddTestScripts(new OpenCloseApp_PRMSTAC());
            AddTestScripts(new OpenCloseApp_PRMSTI());
            AddTestScripts(new OpenCloseApp_PRMSTT());
            AddTestScripts(new OpenCloseApp_PRMW2());
            AddTestScripts(new OpenCloseApp_PRMWC());
            AddTestScripts(new OpenCloseApp_PRMWCMC());
            AddTestScripts(new OpenCloseApp_PRMXBANK());
            AddTestScripts(new OpenCloseApp_PRPAPVCH());
            AddTestScripts(new OpenCloseApp_PRPCNTRY());
            AddTestScripts(new OpenCloseApp_PRPCPR());
            AddTestScripts(new OpenCloseApp_PRPCW2());
            AddTestScripts(new OpenCloseApp_PRPPDCLS());
            AddTestScripts(new OpenCloseApp_PRPSEXLI());
            AddTestScripts(new OpenCloseApp_PRQBADT());
            AddTestScripts(new OpenCloseApp_PRQBHS());
            AddTestScripts(new OpenCloseApp_PRQEBT());
            AddTestScripts(new OpenCloseApp_PRQECNT());
            AddTestScripts(new OpenCloseApp_PRQEDED());
            AddTestScripts(new OpenCloseApp_PRQEGARN());
            AddTestScripts(new OpenCloseApp_PRQEHIS());
            AddTestScripts(new OpenCloseApp_PRQEINFO());
            AddTestScripts(new OpenCloseApp_PRQERF());
            AddTestScripts(new OpenCloseApp_PRQETAX());
            AddTestScripts(new OpenCloseApp_PRQPTF());
            AddTestScripts(new OpenCloseApp_PRRW2());
            AddTestScripts(new OpenCloseApp_AOMADPMP());
            AddTestScripts(new OpenCloseApp_AOMESSAL());
            AddTestScripts(new OpenCloseApp_AOMESSGS());
            AddTestScripts(new OpenCloseApp_AOMESSRB());
            AddTestScripts(new OpenCloseApp_AOMPYCHX());
            AddTestScripts(new OpenCloseApp_AOMSUSTP());
            AddTestScripts(new OpenCloseApp_AOPADPTS());
            AddTestScripts(new OpenCloseApp_AOPCDCTS());
            AddTestScripts(new OpenCloseApp_AOPESSDB());
            AddTestScripts(new OpenCloseApp_AOPESSPG());
            AddTestScripts(new OpenCloseApp_AOPESSUD());
            AddTestScripts(new OpenCloseApp_AOPPCXTS());
            AddTestScripts(new OpenCloseApp_AOPUTLDL());
            AddTestScripts(new OpenCloseApp_AOPUTLEL());
            AddTestScripts(new OpenCloseApp_AOPUTLTS());
            AddTestScripts(new OpenCloseApp_APMCLRCD());
            AddTestScripts(new OpenCloseApp_APMSCSET());
            AddTestScripts(new OpenCloseApp_EMMCITZN());
            AddTestScripts(new OpenCloseApp_EMMEEOI());
            AddTestScripts(new OpenCloseApp_EMMIDDEFAULT());
            AddTestScripts(new OpenCloseApp_EMMREHIREELIG());
            AddTestScripts(new OpenCloseApp_EMMTERMRSN());
            AddTestScripts(new OpenCloseApp_EMPHRSDAT());
            AddTestScripts(new OpenCloseApp_EMPTMUI());
            AddTestScripts(new OpenCloseApp_EMPTOOLKIT());
            AddTestScripts(new OpenCloseApp_ESMCUSTTXT());
            AddTestScripts(new OpenCloseApp_ESPSELFSERVUTIL());
            AddTestScripts(new OpenCloseApp_HAMFEED());
            AddTestScripts(new OpenCloseApp_HAMJBGRP());
            AddTestScripts(new OpenCloseApp_HAPAAPLN());
            AddTestScripts(new OpenCloseApp_HAREROST());
            AddTestScripts(new OpenCloseApp_HARJOBGP());
            AddTestScripts(new OpenCloseApp_HARNHIRE());
            AddTestScripts(new OpenCloseApp_HARPROF());
            AddTestScripts(new OpenCloseApp_HARPROG());
            AddTestScripts(new OpenCloseApp_HARPROMO());
            AddTestScripts(new OpenCloseApp_HARTERM());
            AddTestScripts(new OpenCloseApp_HARTRAIN());
            AddTestScripts(new OpenCloseApp_HARTRANS());
            AddTestScripts(new OpenCloseApp_HARUTIL());
            AddTestScripts(new OpenCloseApp_HARWORK());
            AddTestScripts(new OpenCloseApp_HBMADEP());
            AddTestScripts(new OpenCloseApp_HBMBTYPE());
            AddTestScripts(new OpenCloseApp_HBMCOVOP());
            AddTestScripts(new OpenCloseApp_HBMDCSET());
            AddTestScripts(new OpenCloseApp_HBMEDEP());
            AddTestScripts(new OpenCloseApp_HBMEQEV());
            AddTestScripts(new OpenCloseApp_HBMFTE());
            AddTestScripts(new OpenCloseApp_HBMHSET());
            AddTestScripts(new OpenCloseApp_HBMMCSET());
            AddTestScripts(new OpenCloseApp_HBMMEDSV());
            AddTestScripts(new OpenCloseApp_HBMQEVNT());
            AddTestScripts(new OpenCloseApp_HBMRDEPR());
            AddTestScripts(new OpenCloseApp_HBMRMEDR());
            AddTestScripts(new OpenCloseApp_HBRCEN());
            AddTestScripts(new OpenCloseApp_HBRCVG());
            AddTestScripts(new OpenCloseApp_HBREBEN());
            AddTestScripts(new OpenCloseApp_HBREDEP());
            AddTestScripts(new OpenCloseApp_HBREFSA());
            AddTestScripts(new OpenCloseApp_HBREMED());
            AddTestScripts(new OpenCloseApp_HKMDED());
            AddTestScripts(new OpenCloseApp_HKPLOAD());
            AddTestScripts(new OpenCloseApp_HPMANAT());
            AddTestScripts(new OpenCloseApp_HPMAPPL());
            AddTestScripts(new OpenCloseApp_HPMAREQ());
            AddTestScripts(new OpenCloseApp_HPMASTEP());
            AddTestScripts(new OpenCloseApp_HPMAWD());
            AddTestScripts(new OpenCloseApp_HPMCRSE());
            AddTestScripts(new OpenCloseApp_HPMDEGRE());
            AddTestScripts(new OpenCloseApp_HPMDOC());
            AddTestScripts(new OpenCloseApp_HPMDRUG());
            AddTestScripts(new OpenCloseApp_HPMEAWD());
            AddTestScripts(new OpenCloseApp_HPMEDOC());
            AddTestScripts(new OpenCloseApp_HPMEDRUG());
            AddTestScripts(new OpenCloseApp_HPMELIC());
            AddTestScripts(new OpenCloseApp_HPMEPROP());
            AddTestScripts(new OpenCloseApp_HPMESTAT());
            AddTestScripts(new OpenCloseApp_HPMEVEH());
            AddTestScripts(new OpenCloseApp_HPMF());
            AddTestScripts(new OpenCloseApp_HPMHRORG());
            AddTestScripts(new OpenCloseApp_HPMINJ());
            AddTestScripts(new OpenCloseApp_HPMINTID());
            AddTestScripts(new OpenCloseApp_HPMPHOTO());
            AddTestScripts(new OpenCloseApp_HPMPROF());
            AddTestScripts(new OpenCloseApp_HPMPROP());
            AddTestScripts(new OpenCloseApp_HPMREQA());
            AddTestScripts(new OpenCloseApp_HPMREQR());
            AddTestScripts(new OpenCloseApp_HPMSECID());
            AddTestScripts(new OpenCloseApp_HPMSET());
            AddTestScripts(new OpenCloseApp_HPMSKILL());
            AddTestScripts(new OpenCloseApp_HPMSLVL());
            AddTestScripts(new OpenCloseApp_HPMSTUDY());
            AddTestScripts(new OpenCloseApp_HPMTRNL());
            AddTestScripts(new OpenCloseApp_HPMTRNPS());
            AddTestScripts(new OpenCloseApp_HPMTRNS());
            AddTestScripts(new OpenCloseApp_HPMWCFR());
            AddTestScripts(new OpenCloseApp_HPPAWD());
            AddTestScripts(new OpenCloseApp_HPRACCHS());
            AddTestScripts(new OpenCloseApp_HPREAWD());
            AddTestScripts(new OpenCloseApp_HPRFREAS());
            AddTestScripts(new OpenCloseApp_HPROSHA());
            AddTestScripts(new OpenCloseApp_HPRPOS());
            AddTestScripts(new OpenCloseApp_HPRPROG());
        }
    }
}
