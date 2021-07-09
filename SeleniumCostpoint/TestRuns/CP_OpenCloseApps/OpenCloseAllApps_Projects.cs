 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_Projects : SeleniumTestRun
    {
        public OpenCloseAllApps_Projects(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_AOMCBPYC());
			AddTestScripts(new OpenCloseApp_AOMMICEC());
			AddTestScripts(new OpenCloseApp_AOMMICOR());
			AddTestScripts(new OpenCloseApp_AOMMICPJ());
			AddTestScripts(new OpenCloseApp_AOMMICRS());
			AddTestScripts(new OpenCloseApp_AOMPLMAP());
			AddTestScripts(new OpenCloseApp_AOMPLNST());
			AddTestScripts(new OpenCloseApp_AOPPLNCP());
			AddTestScripts(new OpenCloseApp_BLMADSC());
			AddTestScripts(new OpenCloseApp_BLMBFRM());
			AddTestScripts(new OpenCloseApp_BLMCDSC());
			AddTestScripts(new OpenCloseApp_BLMCLOSE());
			AddTestScripts(new OpenCloseApp_BLMCPBIL());
			AddTestScripts(new OpenCloseApp_BLMEUBRC());
			AddTestScripts(new OpenCloseApp_BLMGBILL());
			AddTestScripts(new OpenCloseApp_BLMINFO());
			AddTestScripts(new OpenCloseApp_BLMMAB());
			AddTestScripts(new OpenCloseApp_BLMMNBIL());
			AddTestScripts(new OpenCloseApp_BLMMPCB());
			AddTestScripts(new OpenCloseApp_BLMOPEN());
			AddTestScripts(new OpenCloseApp_BLMPBS());
			AddTestScripts(new OpenCloseApp_BLMPCLOS());
			AddTestScripts(new OpenCloseApp_BLMPDSC());
			AddTestScripts(new OpenCloseApp_BLMPJPRD());
			AddTestScripts(new OpenCloseApp_BLMPROGP());
			AddTestScripts(new OpenCloseApp_BLMSETNG());
			AddTestScripts(new OpenCloseApp_BLMSUBPP());
			AddTestScripts(new OpenCloseApp_BLMTAXAL());
			AddTestScripts(new OpenCloseApp_BLMTAXCD());
			AddTestScripts(new OpenCloseApp_BLMUHIST());
			AddTestScripts(new OpenCloseApp_BLMUSAGE());
			AddTestScripts(new OpenCloseApp_BLMUSGRP());
			AddTestScripts(new OpenCloseApp_BLMWAWF());
			AddTestScripts(new OpenCloseApp_BLPAOBD());
			AddTestScripts(new OpenCloseApp_BLPGBILL());
			AddTestScripts(new OpenCloseApp_BLPWAWF());
			AddTestScripts(new OpenCloseApp_BLPWHCD());
			AddTestScripts(new OpenCloseApp_BLQSTDHS());
			AddTestScripts(new OpenCloseApp_BLR1034());
			AddTestScripts(new OpenCloseApp_BLRACRN());
			AddTestScripts(new OpenCloseApp_BLRIRBIL());
			AddTestScripts(new OpenCloseApp_BLRMBIL());
			AddTestScripts(new OpenCloseApp_BLROBD());
			AddTestScripts(new OpenCloseApp_BLRPBIL());
			AddTestScripts(new OpenCloseApp_BLRRBIL());
			AddTestScripts(new OpenCloseApp_BPMPBETC());
			AddTestScripts(new OpenCloseApp_BPPMASS());
			AddTestScripts(new OpenCloseApp_BPQBBUD());
			AddTestScripts(new OpenCloseApp_BPQBETC());
			AddTestScripts(new OpenCloseApp_IWMALLOC());
			AddTestScripts(new OpenCloseApp_IWMEXPMP());
			AddTestScripts(new OpenCloseApp_IWMPROJ());
			AddTestScripts(new OpenCloseApp_IWMSUSP());
			AddTestScripts(new OpenCloseApp_PJM533FM());
			AddTestScripts(new OpenCloseApp_PJMACGRP());
			AddTestScripts(new OpenCloseApp_PJMALGRP());
			AddTestScripts(new OpenCloseApp_PJMALJNL());
			AddTestScripts(new OpenCloseApp_PJMALTHS());
			AddTestScripts(new OpenCloseApp_PJMALTPJ());
			AddTestScripts(new OpenCloseApp_PJMALTPY());
			AddTestScripts(new OpenCloseApp_PJMALTRP());
			AddTestScripts(new OpenCloseApp_PJMBASE());
			AddTestScripts(new OpenCloseApp_PJMBASIC());
			AddTestScripts(new OpenCloseApp_PJMBCEIL());
			AddTestScripts(new OpenCloseApp_PJMBDGLC());
			AddTestScripts(new OpenCloseApp_PJMBDPER());
			AddTestScripts(new OpenCloseApp_PJMBDPLC());
			AddTestScripts(new OpenCloseApp_PJMBDREV());
			AddTestScripts(new OpenCloseApp_PJMBDTOT());
			AddTestScripts(new OpenCloseApp_PJMBLIR());
			AddTestScripts(new OpenCloseApp_PJMBUDCO());
			AddTestScripts(new OpenCloseApp_PJMBURDT());
			AddTestScripts(new OpenCloseApp_PJMBURFE());
			AddTestScripts(new OpenCloseApp_PJMCEIL());
			AddTestScripts(new OpenCloseApp_PJMCLIN());
			AddTestScripts(new OpenCloseApp_PJMCOST());
			AddTestScripts(new OpenCloseApp_PJMCSSR());
			AddTestScripts(new OpenCloseApp_PJMCSSRB());
			AddTestScripts(new OpenCloseApp_PJMCSTFE());
			AddTestScripts(new OpenCloseApp_PJMECEIL());
			AddTestScripts(new OpenCloseApp_PJMETCD());
			AddTestScripts(new OpenCloseApp_PJMGLCE());
			AddTestScripts(new OpenCloseApp_PJMGLCP());
			AddTestScripts(new OpenCloseApp_PJMHCEIL());
			AddTestScripts(new OpenCloseApp_PJMLIB());
			AddTestScripts(new OpenCloseApp_PJMMJAS());
			AddTestScripts(new OpenCloseApp_PJMMJCHS());
			AddTestScripts(new OpenCloseApp_PJMMJLHS());
			AddTestScripts(new OpenCloseApp_PJMMLPAO());
			AddTestScripts(new OpenCloseApp_PJMMMO());
			AddTestScripts(new OpenCloseApp_PJMMOD());
			AddTestScripts(new OpenCloseApp_PJMPAW());
			AddTestScripts(new OpenCloseApp_PJMPLC());
			AddTestScripts(new OpenCloseApp_PJMPLCE());
			AddTestScripts(new OpenCloseApp_PJMPLCP());
			AddTestScripts(new OpenCloseApp_PJMPLCPJ());
			AddTestScripts(new OpenCloseApp_PJMPLCRT());
			AddTestScripts(new OpenCloseApp_PJMPOOL());
			AddTestScripts(new OpenCloseApp_PJMPOW());
			AddTestScripts(new OpenCloseApp_PJMPRSEQ());
			AddTestScripts(new OpenCloseApp_PJMPTSET());
			AddTestScripts(new OpenCloseApp_PJMPWFRT());
			AddTestScripts(new OpenCloseApp_PJMPYCST());
			AddTestScripts(new OpenCloseApp_PJMPYGL());
			AddTestScripts(new OpenCloseApp_PJMPYLAB());
			AddTestScripts(new OpenCloseApp_PJMPYTM());
			AddTestScripts(new OpenCloseApp_PJMPYUNT());
			AddTestScripts(new OpenCloseApp_PJMQWBS());
			AddTestScripts(new OpenCloseApp_PJMRAMT());
			AddTestScripts(new OpenCloseApp_PJMREV());
			AddTestScripts(new OpenCloseApp_PJMSALCD());
			AddTestScripts(new OpenCloseApp_PJMSETNG());
			AddTestScripts(new OpenCloseApp_PJMTEXT());
			AddTestScripts(new OpenCloseApp_PJMTMSEQ());
			AddTestScripts(new OpenCloseApp_PJMUDINF());
			AddTestScripts(new OpenCloseApp_PJMUDLAB());
			AddTestScripts(new OpenCloseApp_PJMUNBDP());
			AddTestScripts(new OpenCloseApp_PJMVCEIL());
			AddTestScripts(new OpenCloseApp_PJMVEWRK());
			AddTestScripts(new OpenCloseApp_PJMVNWRK());
			AddTestScripts(new OpenCloseApp_PJMWORK());
			AddTestScripts(new OpenCloseApp_PJPBLDRA());
			AddTestScripts(new OpenCloseApp_PJPCKAO());
			AddTestScripts(new OpenCloseApp_PJPCKSEG());
			AddTestScripts(new OpenCloseApp_PJPCOMPL());
			AddTestScripts(new OpenCloseApp_PJPCOMPP());
			AddTestScripts(new OpenCloseApp_PJPCOMPR());
			AddTestScripts(new OpenCloseApp_PJPDISIN());
			AddTestScripts(new OpenCloseApp_PJPFIXIN());
			AddTestScripts(new OpenCloseApp_PJPMADD());
			AddTestScripts(new OpenCloseApp_PJPREALL());
			AddTestScripts(new OpenCloseApp_PJPSYNCH());
			AddTestScripts(new OpenCloseApp_PJPUPPOA());
			AddTestScripts(new OpenCloseApp_PJQETC());
			AddTestScripts(new OpenCloseApp_PJQPROJ());
			AddTestScripts(new OpenCloseApp_PJQPROJL());
			AddTestScripts(new OpenCloseApp_PJQPROJP());
			AddTestScripts(new OpenCloseApp_PJRLABSM());
			AddTestScripts(new OpenCloseApp_PJRNLD());
			AddTestScripts(new OpenCloseApp_PJRPROJ());
			AddTestScripts(new OpenCloseApp_PJRREVW());
			AddTestScripts(new OpenCloseApp_PJRTMA());
			AddTestScripts(new OpenCloseApp_SMMAINVC());
			AddTestScripts(new OpenCloseApp_SMMMINVC());
			AddTestScripts(new OpenCloseApp_SMMSETA());
			AddTestScripts(new OpenCloseApp_SMMSUBC());
			AddTestScripts(new OpenCloseApp_SMMWRK());
			AddTestScripts(new OpenCloseApp_SMPWRKA());
			AddTestScripts(new OpenCloseApp_SMQWA());
			AddTestScripts(new OpenCloseApp_AOPCBLAB());
			AddTestScripts(new OpenCloseApp_AOPMICDN());
			AddTestScripts(new OpenCloseApp_AOPPPLAB());
			AddTestScripts(new OpenCloseApp_BLMADDR());
			AddTestScripts(new OpenCloseApp_BLMBHIST());
			AddTestScripts(new OpenCloseApp_BLMBLCYC());
			AddTestScripts(new OpenCloseApp_BLMCASH());
			AddTestScripts(new OpenCloseApp_BLMCTADR());
			AddTestScripts(new OpenCloseApp_BLMEDI());
			AddTestScripts(new OpenCloseApp_BLMEDIST());							
		}
    }
	
}
