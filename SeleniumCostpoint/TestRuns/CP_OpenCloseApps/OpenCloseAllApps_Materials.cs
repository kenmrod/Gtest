 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_Materials : SeleniumTestRun
    {
        public OpenCloseAllApps_Materials(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_AOPCPMO());
			AddTestScripts(new OpenCloseApp_AOPEPAD());
			AddTestScripts(new OpenCloseApp_AOPEPIA());
			AddTestScripts(new OpenCloseApp_AOPEPITM());
			AddTestScripts(new OpenCloseApp_AOPEPPAO());
			AddTestScripts(new OpenCloseApp_AOPEPRQE());
			AddTestScripts(new OpenCloseApp_AOPEPVN());
			AddTestScripts(new OpenCloseApp_APMVEND());
			AddTestScripts(new OpenCloseApp_ARMCUST());
			AddTestScripts(new OpenCloseApp_BMMCID());
			AddTestScripts(new OpenCloseApp_BMMEBOM1());
			AddTestScripts(new OpenCloseApp_BMMEBOM2());
			AddTestScripts(new OpenCloseApp_BMMEICN());
			AddTestScripts(new OpenCloseApp_BMMERELS());
			AddTestScripts(new OpenCloseApp_BMMMBOM1());
			AddTestScripts(new OpenCloseApp_BMMMBOM2());
			AddTestScripts(new OpenCloseApp_BMMMDOC());
			AddTestScripts(new OpenCloseApp_BMMMRELS());
			AddTestScripts(new OpenCloseApp_BMMRDOC());
			AddTestScripts(new OpenCloseApp_BMMSET());
			AddTestScripts(new OpenCloseApp_BMPCOST());
			AddTestScripts(new OpenCloseApp_BMPMCC());
			AddTestScripts(new OpenCloseApp_BMQSMLB());
			AddTestScripts(new OpenCloseApp_BMQWU());
			AddTestScripts(new OpenCloseApp_BMRSLMLB());
			AddTestScripts(new OpenCloseApp_BMRSUMBM());
			AddTestScripts(new OpenCloseApp_ECMAMAIN());
			AddTestScripts(new OpenCloseApp_ECMAPPR());
			AddTestScripts(new OpenCloseApp_ECMECAPP());
			AddTestScripts(new OpenCloseApp_ECMECAPT());
			AddTestScripts(new OpenCloseApp_ECMECN());
			AddTestScripts(new OpenCloseApp_ECMIGRP());
			AddTestScripts(new OpenCloseApp_ECMPRAPP());
			AddTestScripts(new OpenCloseApp_ECMSET());
			AddTestScripts(new OpenCloseApp_ECMTYPE());
			AddTestScripts(new OpenCloseApp_ECMUDFL());
			AddTestScripts(new OpenCloseApp_ECQECNST());
			AddTestScripts(new OpenCloseApp_INMCSADJ());
			AddTestScripts(new OpenCloseApp_INMISSU1());
			AddTestScripts(new OpenCloseApp_INMLOXFR());
			AddTestScripts(new OpenCloseApp_INMMOISS());
			AddTestScripts(new OpenCloseApp_INMMSRC());
			AddTestScripts(new OpenCloseApp_INMPAISS());
			AddTestScripts(new OpenCloseApp_INMPARSV());
			AddTestScripts(new OpenCloseApp_INMPAXFR());
			AddTestScripts(new OpenCloseApp_INMPCACT());
			AddTestScripts(new OpenCloseApp_INMPCLST());
			AddTestScripts(new OpenCloseApp_INMPORSV());
			AddTestScripts(new OpenCloseApp_INMPROJ());
			AddTestScripts(new OpenCloseApp_INMQTADJ());
			AddTestScripts(new OpenCloseApp_INMRQST());
			AddTestScripts(new OpenCloseApp_INMSCADJ());
			AddTestScripts(new OpenCloseApp_INMSRLT());
			AddTestScripts(new OpenCloseApp_INMWHSE());
			AddTestScripts(new OpenCloseApp_INPPCDSC());
			AddTestScripts(new OpenCloseApp_INPPPV());
			AddTestScripts(new OpenCloseApp_INPUID());
			AddTestScripts(new OpenCloseApp_INQHSTPR());
			AddTestScripts(new OpenCloseApp_INQPINV());
			AddTestScripts(new OpenCloseApp_INQSRLT());
			AddTestScripts(new OpenCloseApp_MEMPBOM());
			AddTestScripts(new OpenCloseApp_MEMPROP());
			AddTestScripts(new OpenCloseApp_MEMPRPLI());
			AddTestScripts(new OpenCloseApp_MEMPRPLS());
			AddTestScripts(new OpenCloseApp_MEMRFQS());
			AddTestScripts(new OpenCloseApp_MEPMCC());
			AddTestScripts(new OpenCloseApp_MEPPBOM());
			AddTestScripts(new OpenCloseApp_MEQITEM());
			AddTestScripts(new OpenCloseApp_MEQPWU());
			AddTestScripts(new OpenCloseApp_MRMACTM());
			AddTestScripts(new OpenCloseApp_MRMDTPT());
			AddTestScripts(new OpenCloseApp_MRMIAPEG());
			AddTestScripts(new OpenCloseApp_MRMMEXPD());
			AddTestScripts(new OpenCloseApp_MRMSET());
			AddTestScripts(new OpenCloseApp_MRQPINV());
			AddTestScripts(new OpenCloseApp_MRQSPA());
			AddTestScripts(new OpenCloseApp_MRRBMAM());
			AddTestScripts(new OpenCloseApp_MSMACTM());
			AddTestScripts(new OpenCloseApp_MSMMPS());
			AddTestScripts(new OpenCloseApp_MSMPLRT());
			AddTestScripts(new OpenCloseApp_MSPCPY());
			AddTestScripts(new OpenCloseApp_MSQPINV());
			AddTestScripts(new OpenCloseApp_MSQRCAP());
			AddTestScripts(new OpenCloseApp_OEMAMORT());
			AddTestScripts(new OpenCloseApp_OEMAPPRP());
			AddTestScripts(new OpenCloseApp_OEMAPPRT());
			AddTestScripts(new OpenCloseApp_OEMAPPSO());
			AddTestScripts(new OpenCloseApp_OEMINVC1());
			AddTestScripts(new OpenCloseApp_OEMINVC2());
			AddTestScripts(new OpenCloseApp_OEMISSU1());
			AddTestScripts(new OpenCloseApp_OEMISSU2());
			AddTestScripts(new OpenCloseApp_OEMNTSO1());
			AddTestScripts(new OpenCloseApp_OEMNTSO2());
			AddTestScripts(new OpenCloseApp_OEMRFU());
			AddTestScripts(new OpenCloseApp_OEMSHIP());
			AddTestScripts(new OpenCloseApp_OEMUDL());
			AddTestScripts(new OpenCloseApp_OEPEDIIN());
			AddTestScripts(new OpenCloseApp_OEPGRQ());
			AddTestScripts(new OpenCloseApp_OEPRFID());
			AddTestScripts(new OpenCloseApp_OEPWAWF());
			AddTestScripts(new OpenCloseApp_OEQSALES());
			AddTestScripts(new OpenCloseApp_OEQSTAT());
			AddTestScripts(new OpenCloseApp_OER250I());
			AddTestScripts(new OpenCloseApp_OER250PS());
			AddTestScripts(new OpenCloseApp_OERACKN());
			AddTestScripts(new OpenCloseApp_OERBLOG());
			AddTestScripts(new OpenCloseApp_OERINVC());
			AddTestScripts(new OpenCloseApp_OERPCKSL());
			AddTestScripts(new OpenCloseApp_OERPICK());
			AddTestScripts(new OpenCloseApp_OERSHLAB());
			AddTestScripts(new OpenCloseApp_OERW250());
			AddTestScripts(new OpenCloseApp_OERW250P());
			AddTestScripts(new OpenCloseApp_PCMCOMP());
			AddTestScripts(new OpenCloseApp_PCMIAPEG());
			AddTestScripts(new OpenCloseApp_PCMINSP());
			AddTestScripts(new OpenCloseApp_PCMMEXPD());
			AddTestScripts(new OpenCloseApp_PCMMOISS());
			AddTestScripts(new OpenCloseApp_PCMMOMNT());
			AddTestScripts(new OpenCloseApp_PCMNETG());
			AddTestScripts(new OpenCloseApp_PCMPLNR());
			AddTestScripts(new OpenCloseApp_PCMPMFG());
			AddTestScripts(new OpenCloseApp_PCMRELMO());
			AddTestScripts(new OpenCloseApp_PCMSCRQ());
			AddTestScripts(new OpenCloseApp_PCMSFCAL());
			AddTestScripts(new OpenCloseApp_PCPMRR());
			AddTestScripts(new OpenCloseApp_PCPWIPV());
			AddTestScripts(new OpenCloseApp_PCQMOST());
			AddTestScripts(new OpenCloseApp_PCQPINV());
			AddTestScripts(new OpenCloseApp_PDMGOODS());
			AddTestScripts(new OpenCloseApp_PDMITMRU());
			AddTestScripts(new OpenCloseApp_PDMLICAGR());
			AddTestScripts(new OpenCloseApp_PDMPART());
			AddTestScripts(new OpenCloseApp_PDMPOPT());
			AddTestScripts(new OpenCloseApp_PDMPPCAT());
			AddTestScripts(new OpenCloseApp_PDMPRJPD());
			AddTestScripts(new OpenCloseApp_PDMPRPT());
			AddTestScripts(new OpenCloseApp_PDMSALES());
			AddTestScripts(new OpenCloseApp_PDMSCGRP());
			AddTestScripts(new OpenCloseApp_PDMSERV());
			AddTestScripts(new OpenCloseApp_PDMTEXT());
			AddTestScripts(new OpenCloseApp_PDMUDIL());
			AddTestScripts(new OpenCloseApp_PDMUOM());
			AddTestScripts(new OpenCloseApp_PDMUSML());
			AddTestScripts(new OpenCloseApp_PDMWARR());
			AddTestScripts(new OpenCloseApp_PDPCONV());
			AddTestScripts(new OpenCloseApp_PDQINQ());
			AddTestScripts(new OpenCloseApp_PDQMFR());
			AddTestScripts(new OpenCloseApp_PDQPSLOG());
			AddTestScripts(new OpenCloseApp_PODBUYER());
			AddTestScripts(new OpenCloseApp_POMBACT());
			AddTestScripts(new OpenCloseApp_POMBRNCH());
			AddTestScripts(new OpenCloseApp_POMBUY());
			AddTestScripts(new OpenCloseApp_POMEXPD());
			AddTestScripts(new OpenCloseApp_POMMAIN());
			AddTestScripts(new OpenCloseApp_POMRELS());
			AddTestScripts(new OpenCloseApp_POMSCST());
			AddTestScripts(new OpenCloseApp_POMSTAT());
			AddTestScripts(new OpenCloseApp_POQCHNG());
			AddTestScripts(new OpenCloseApp_POQCOMM());
			AddTestScripts(new OpenCloseApp_POQITEM());
			AddTestScripts(new OpenCloseApp_POQSTAT());
			AddTestScripts(new OpenCloseApp_PORPPO());
			AddTestScripts(new OpenCloseApp_PPMBUYAL());
			AddTestScripts(new OpenCloseApp_PPMBUYAS());
			AddTestScripts(new OpenCloseApp_PPMNTRQ1());
			AddTestScripts(new OpenCloseApp_PPMNTRQ2());
			AddTestScripts(new OpenCloseApp_PPMPOHDR());
			AddTestScripts(new OpenCloseApp_PPMQREQ());
			AddTestScripts(new OpenCloseApp_PPMQTI());
			AddTestScripts(new OpenCloseApp_PPMQTV());
			AddTestScripts(new OpenCloseApp_PPMRFQI());
			AddTestScripts(new OpenCloseApp_PPMRFQV());
			AddTestScripts(new OpenCloseApp_PPMRQAPL());
			AddTestScripts(new OpenCloseApp_PPMRQAPP());
			AddTestScripts(new OpenCloseApp_PPMRQAPT());
			AddTestScripts(new OpenCloseApp_PPMRQAPX());
			AddTestScripts(new OpenCloseApp_PPMRQLN());
			AddTestScripts(new OpenCloseApp_PPPGPO());
			AddTestScripts(new OpenCloseApp_PPQITEM());
			AddTestScripts(new OpenCloseApp_PPQRQSTS());
			AddTestScripts(new OpenCloseApp_PPQVNDP());
			AddTestScripts(new OpenCloseApp_PPQVQT());
			AddTestScripts(new OpenCloseApp_RCMINSP());
			AddTestScripts(new OpenCloseApp_RCMMSRC());
			AddTestScripts(new OpenCloseApp_RCMPORC());
			AddTestScripts(new OpenCloseApp_RCMRTRN());
			AddTestScripts(new OpenCloseApp_RCQSTAT());
			AddTestScripts(new OpenCloseApp_RUMEQUIP());
			AddTestScripts(new OpenCloseApp_RUMKEYR());
			AddTestScripts(new OpenCloseApp_RUMLABOP());
			AddTestScripts(new OpenCloseApp_RUMROUT());
			AddTestScripts(new OpenCloseApp_RUMRROUT());
			AddTestScripts(new OpenCloseApp_RUMSUBOP());
			AddTestScripts(new OpenCloseApp_RUMWCM());
			AddTestScripts(new OpenCloseApp_RUQROUT());
			AddTestScripts(new OpenCloseApp_RURROUT());
			AddTestScripts(new OpenCloseApp_SPDSP());							
		}
    }
	
}