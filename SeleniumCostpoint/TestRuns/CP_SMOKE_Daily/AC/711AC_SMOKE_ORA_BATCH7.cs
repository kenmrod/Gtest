using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_SMOKE_ORA_BATCH7 : SeleniumTestRun
    {
        public CP711AC_SMOKE_ORA_BATCH7(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new GLPUPFS_SMOKE());
				AddTestScripts(new GLPUPRS_SMOKE());
				AddTestScripts(new GLQAACTI_SMOKE());
				AddTestScripts(new GLQBKINQ_SMOKE());
				AddTestScripts(new GLQCOMP_SMOKE());
				AddTestScripts(new GLQINQ_SMOKE());
				AddTestScripts(new GLRACT_SMOKE());
				AddTestScripts(new GLRBKREC_SMOKE());
				AddTestScripts(new GLRBKSUM__SMOKE());
				AddTestScripts(new GLRBUDG_SMOKE());
				AddTestScripts(new GLRFSD_SMOKE());
				AddTestScripts(new GLRFSS_SMOKE());
				AddTestScripts(new GLRFS_SMOKE());
				AddTestScripts(new GLRGLDET_SMOKE());
				AddTestScripts(new GLRGLSUM_SMOKE());
				AddTestScripts(new GLRIECTS_SMOKE());
				AddTestScripts(new GLRINTER_SMOKE());
				AddTestScripts(new GLRJEA_SMOKE());
				AddTestScripts(new GLRJE_SMOKE());
				AddTestScripts(new GLRLHGL_SMOKE());
				AddTestScripts(new GLRORACT_SMOKE());
				AddTestScripts(new GLRORG_SMOKE());
				AddTestScripts(new GLRPEND_SMOKE());
				AddTestScripts(new GLRPJDET_SMOKE());
				AddTestScripts(new GLRPSTSM_SMOKE());
				AddTestScripts(new GLRPTBAL_SMOKE());
				AddTestScripts(new GLRSAVAT_SMOKE());
				AddTestScripts(new GLRSTMT_SMOKE());
				AddTestScripts(new GLRTBAL_SMOKE());
				AddTestScripts(new GLRUNASN_SMOKE());
				AddTestScripts(new MUMACCTS_SMOKE());
				AddTestScripts(new MUMCSTAT_SMOKE());
				AddTestScripts(new MUMDRATE_SMOKE());
				AddTestScripts(new MUMPRATE_SMOKE());
				AddTestScripts(new MUMRDT_SMOKE());
				AddTestScripts(new MUMRGRP_SMOKE());
				AddTestScripts(new MUMRPD_SMOKE());
				AddTestScripts(new MUMSETNG_SMOKE());
				AddTestScripts(new MUPCONV3_SMOKE());
				AddTestScripts(new MUPTOOL1_SMOKE());
				AddTestScripts(new MUPUPRT_SMOKE());
				AddTestScripts(new MURRPD_SMOKE());
				AddTestScripts(new POMACSET_SMOKE());
				AddTestScripts(new POMAPSET_SMOKE());
				AddTestScripts(new POMPOVCH_SMOKE());
				AddTestScripts(new POPACCR_SMOKE());
				AddTestScripts(new POPDISCR_SMOKE());
				AddTestScripts(new POPDM_SMOKE());
				AddTestScripts(new POPPOVCH_SMOKE());
				AddTestScripts(new POPSCACC_SMOKE());
				AddTestScripts(new POPSCVCH_SMOKE());
				AddTestScripts(new PORDM_SMOKE());
				AddTestScripts(new SYMCISCD_SMOKE());
		           
        }
    }
}
