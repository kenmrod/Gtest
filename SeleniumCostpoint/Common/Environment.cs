using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCostpoint.Common
{
    public class Environment
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string UserInterface { get; set; }
    }

    public static class Environments
    {
        public static Environment[] EnvironmentList = new Environment[]
            {
                new Environment()
                {
                    Id = "default",
                    Url = "http://makapp02/cpweb",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO11Q1",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM14",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM14",
                    UserInterface =""
                }

                 ,new Environment()
                {
                    Id = "C71MQCM14AE",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER123",
                    Database = "C71MQCM14AE",
                    UserInterface =""
                }

                 ,new Environment()
                {
                    Id = "C71MQCM14ALT",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM14ALT",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM14BE2E",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM14BE2E",
                    UserInterface =""
                }

                 ,new Environment()
                {
                    Id = "C71MQCM14RU6Q",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM14RU6Q",
                    UserInterface =""
                }

                 ,new Environment()
                {
                    Id = "C71MQCM16",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM16",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM16AE",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM16AE",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM17BSFS",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM17BSFS",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM17PEB1",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM17PEB1",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM17PER1",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM17PER1",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCM17RSFS",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM17RSFS",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO11",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO11",
                    UserInterface =""
                }

                 ,new Environment()
                {
                    Id = "C71MQCO11BE2E",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO11BE2E",
                    UserInterface =""
                }

                  ,new Environment()
                {
                    Id = "C71MQCO11Q1",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO11Q1",
                    UserInterface =""
                }

                   ,new Environment()
                {
                    Id = "C71MQCO11RGU5",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO11RGU5",
                    UserInterface =""
                }

                   ,new Environment()
                {
                    Id = "C71MQCO12AE",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSERq",
                    Database = "C71MQCO12AE",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO12AE2",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSERq",
                    Database = "C71MQCO12AE2",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO12AE3",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSERq",
                    Database = "C71MQCO12AE3",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO12AE4",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12AE4",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO12AE5",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12AE5",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO12AEHQ",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSE",
                    Database = "C71MQCO12AEHQ",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C71MQCO12AUB2",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSE",
                    Database = "C71MQCO12AUB2",
                    UserInterface =""
                }                

                  ,new Environment()
                {
                    Id = "C71MQCO12AUTO",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12AUTO",
                    UserInterface =""
                }

                  ,new Environment()
                {
                    Id = "C71MQCO12AUTOTEST",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSE",
                    Database = "C71MQCO12AUTOTEST",
                    UserInterface =""
                }

                  ,new Environment()
                {
                    Id = "C71MQCO12BSFS",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12BSFS",
                    UserInterface =""
                }

                  ,new Environment()
                {
                    Id = "C71MQCO12PEB1",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12PEB1",
                    UserInterface =""
                }

                  ,new Environment()
                {
                    Id = "C71MQCO12PER1",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12PER1",
                    UserInterface =""
                }

                  ,new Environment()
                {
                    Id = "C71MQCO12RSFS",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCO12RSFS",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C711AUTOTESTREGM14",
                    Url = "http://ashapp324vs/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C711AUTOTESTREGM14",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "C711AUTOTESTREGO12",
                    Url = "http://ashapp324vs/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C711AUTOTESTREGO12",
                    UserInterface =""
                }
                
                ,new Environment()
                {
                    Id = "CP_DAILY_C71MQCO12AEHQ",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER123",
                    Database = "C71MQCO12AEHQ",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "CP_DAILY_C71MQCM16AE",
                    Url = "http://makapp02/cpweb/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71MQCM16AE",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "CP_STAGING_C71STAGEM",
                    Url = "http://ashapt577vs:7009/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71STAGEM",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "CP_STAGING_C71STAGEO",
                    Url = "http://ashapt577vs:7009/",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C71STAGEO",
                    UserInterface =""
                }
                            
                ,new Environment()
                {
                    Id = "TE_DAILY_TE10QCO12AUTOTEST",
                    Url = "http://ashapt62/cpweb/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10QCO12AUTOTEST",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "TE_DAILY_T10QCM16AUTOTEST",
                    Url = "http://ashapt62/cpweb/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "T10QCM16AUTOTEST",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "TE_REG_MSS_TE10AUTOTEST",
                    Url = "http://ASHAPT38VS:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10AUTOTEST",
                    UserInterface =""
                }

                ,new Environment()
                {
                    Id = "TE_REG_ORA_TE10AUTOTEST",
                    Url = "http://ASHAPT22VS:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10AUTOTEST",
                    UserInterface =""
                }
                 ,new Environment()
                {
                    Id = "TE_DAILY_TE10QCO12AUTOTEST_CLASSIC",
                    Url = "http://ashapt62/cpweb/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10QCO12AUTOTEST",
                    UserInterface ="classic"
                }

                ,new Environment()
                {
                    Id = "TE_DAILY_T10QCM16AUTOTEST_CLASSIC",
                    Url = "http://ashapt62/cpweb/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "T10QCM16AUTOTEST",
                    UserInterface ="classic"
                }

                ,new Environment()
                {
                    Id = "TE_REG_MSS_TE10AUTOTEST_CLASSIC",
                    Url = "http://ASHAPT38VS:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10AUTOTEST",
                    UserInterface ="classic"
                }

                ,new Environment()
                {
                    Id = "TE_REG_ORA_TE10AUTOTEST_CLASSIC",
                    Url = "http://ASHAPT22VS:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10AUTOTEST",
                    UserInterface ="classic"
                }
                //
                 ,new Environment()
                {
                    Id = "TE_DAILY_TE10QCO12AUTOTEST_NEW",
                    Url = "http://ashapt62/cpweb/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10QCO12AUTOTEST",
                    UserInterface ="new"
                }

                ,new Environment()
                {
                    Id = "TE_DAILY_T10QCM16AUTOTEST_NEW",
                    Url = "http://ashapt62/cpweb/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "T10QCM16AUTOTEST",
                    UserInterface ="new"
                }

                ,new Environment()
                {
                    Id = "TE_REG_MSS_TE10AUTOTEST_NEW",
                    Url = "http://ASHAPT38VS:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10AUTOTEST",
                    UserInterface ="new"
                }

                ,new Environment()
                {
                    Id = "TE_REG_ORA_TE10AUTOTEST_NEW",
                    Url = "http://ASHAPT22VS:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "TE10AUTOTEST",
                    UserInterface ="new"
                }

                ,new Environment()
                {
                    Id = "TE_DCO_C711T10CLDAUTOTEST_NEW",
                    Url = "http://ashv0478:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C711T10CLDAUTOTEST",
                    UserInterface ="new"
                }

                ,new Environment()
                {
                    Id = "TE_DCO_C711T10CLDAUTOTEST_CLASSIC",
                    Url = "http://ashv0478:7009/cploginform.htm",
                    UserName = "CPSUPERUSER",
                    Password = "CPSUPERUSER",
                    Database = "C711T10CLDAUTOTEST",
                    UserInterface ="classic"
                }

                /* Copy and uncomment below to add new env. Do not delete this block, just copy */

                //,new Environment()
                //{
                //    Id = "NEW",
                //    Url = "",
                //    UserName = "",
                //    Password = "",
                //    Database = ""
                //}
            };
    }
}
