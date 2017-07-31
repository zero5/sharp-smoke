using System;

namespace Smoke
{
    public partial class Xss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Params["name"];

            Response.Write(foo0(name));
        }

        public string foo0(string strparam)
        {
            return foo1(strparam.Replace("1", ""));
        }

        public string foo1(string strparam)
        {
            return foo2(strparam.Replace("2", ""));
        }

        public string foo2(string strparam)
        {
            return foo3(strparam.Replace("3", ""));
        }

        public string foo3(string strparam)
        {
            return foo4(strparam.Replace("4", ""));
        }

        public string foo4(string strparam)
        {
            return foo5(strparam.Replace("5", ""));
        }

        public string foo5(string strparam)
        {
            return foo6(strparam.Replace("6", ""));
        }

        public string foo6(string strparam)
        {
            return foo7(strparam.Replace("7", ""));
        }

        public string foo7(string strparam)
        {
            return foo8(strparam.Replace("8", ""));
        }

        public string foo8(string strparam)
        {
            return foo9(strparam.Replace("9", ""));
        }

        public string foo9(string strparam)
        {
            return foo10(strparam.Replace("10", ""));
        }

        public string foo10(string strparam)
        {
            return foo11(strparam.Replace("11", ""));
        }

        public string foo11(string strparam)
        {
            return foo12(strparam.Replace("12", ""));
        }

        public string foo12(string strparam)
        {
            return foo13(strparam.Replace("13", ""));
        }

        public string foo13(string strparam)
        {
            return foo14(strparam.Replace("14", ""));
        }

        public string foo14(string strparam)
        {
            return foo15(strparam.Replace("15", ""));
        }

        public string foo15(string strparam)
        {
            return foo16(strparam.Replace("16", ""));
        }

        public string foo16(string strparam)
        {
            return foo17(strparam.Replace("17", ""));
        }

        public string foo17(string strparam)
        {
            return foo18(strparam.Replace("18", ""));
        }

        public string foo18(string strparam)
        {
            return foo19(strparam.Replace("19", ""));
        }

        public string foo19(string strparam)
        {
            return foo20(strparam.Replace("20", ""));
        }

        public string foo20(string strparam)
        {
            return foo21(strparam.Replace("21", ""));
        }

        public string foo21(string strparam)
        {
            return foo22(strparam.Replace("22", ""));
        }

        public string foo22(string strparam)
        {
            return foo23(strparam.Replace("23", ""));
        }

        public string foo23(string strparam)
        {
            return foo24(strparam.Replace("24", ""));
        }

        public string foo24(string strparam)
        {
            return foo25(strparam.Replace("25", ""));
        }

        public string foo25(string strparam)
        {
            return foo26(strparam.Replace("26", ""));
        }

        public string foo26(string strparam)
        {
            return foo27(strparam.Replace("27", ""));
        }

        public string foo27(string strparam)
        {
            return foo28(strparam.Replace("28", ""));
        }

        public string foo28(string strparam)
        {
            return foo29(strparam.Replace("29", ""));
        }

        public string foo29(string strparam)
        {
            return foo30(strparam.Replace("30", ""));
        }

        public string foo30(string strparam)
        {
            return foo31(strparam.Replace("31", ""));
        }

        public string foo31(string strparam)
        {
            return foo32(strparam.Replace("32", ""));
        }

        public string foo32(string strparam)
        {
            return foo33(strparam.Replace("33", ""));
        }

        public string foo33(string strparam)
        {
            return foo34(strparam.Replace("34", ""));
        }

        public string foo34(string strparam)
        {
            return foo35(strparam.Replace("35", ""));
        }

        public string foo35(string strparam)
        {
            return foo36(strparam.Replace("36", ""));
        }

        public string foo36(string strparam)
        {
            return foo37(strparam.Replace("37", ""));
        }

        public string foo37(string strparam)
        {
            return foo38(strparam.Replace("38", ""));
        }

        public string foo38(string strparam)
        {
            return foo39(strparam.Replace("39", ""));
        }

        public string foo39(string strparam)
        {
            return foo40(strparam.Replace("40", ""));
        }

        public string foo40(string strparam)
        {
            return foo41(strparam.Replace("41", ""));
        }

        public string foo41(string strparam)
        {
            return foo42(strparam.Replace("42", ""));
        }

        public string foo42(string strparam)
        {
            return foo43(strparam.Replace("43", ""));
        }

        public string foo43(string strparam)
        {
            return foo44(strparam.Replace("44", ""));
        }

        public string foo44(string strparam)
        {
            return foo45(strparam.Replace("45", ""));
        }

        public string foo45(string strparam)
        {
            return foo46(strparam.Replace("46", ""));
        }

        public string foo46(string strparam)
        {
            return foo47(strparam.Replace("47", ""));
        }

        public string foo47(string strparam)
        {
            return foo48(strparam.Replace("48", ""));
        }

        public string foo48(string strparam)
        {
            return foo49(strparam.Replace("49", ""));
        }

        public string foo49(string strparam)
        {
            return foo50(strparam.Replace("50", ""));
        }

        public string foo50(string strparam)
        {
            return foo51(strparam.Replace("51", ""));
        }

        public string foo51(string strparam)
        {
            return foo52(strparam.Replace("52", ""));
        }

        public string foo52(string strparam)
        {
            return foo53(strparam.Replace("53", ""));
        }

        public string foo53(string strparam)
        {
            return foo54(strparam.Replace("54", ""));
        }

        public string foo54(string strparam)
        {
            return foo55(strparam.Replace("55", ""));
        }

        public string foo55(string strparam)
        {
            return foo56(strparam.Replace("56", ""));
        }

        public string foo56(string strparam)
        {
            return foo57(strparam.Replace("57", ""));
        }

        public string foo57(string strparam)
        {
            return foo58(strparam.Replace("58", ""));
        }

        public string foo58(string strparam)
        {
            return foo59(strparam.Replace("59", ""));
        }

        public string foo59(string strparam)
        {
            return foo60(strparam.Replace("60", ""));
        }

        public string foo60(string strparam)
        {
            return foo61(strparam.Replace("61", ""));
        }

        public string foo61(string strparam)
        {
            return foo62(strparam.Replace("62", ""));
        }

        public string foo62(string strparam)
        {
            return foo63(strparam.Replace("63", ""));
        }

        public string foo63(string strparam)
        {
            return foo64(strparam.Replace("64", ""));
        }

        public string foo64(string strparam)
        {
            return foo65(strparam.Replace("65", ""));
        }

        public string foo65(string strparam)
        {
            return foo66(strparam.Replace("66", ""));
        }

        public string foo66(string strparam)
        {
            return foo67(strparam.Replace("67", ""));
        }

        public string foo67(string strparam)
        {
            return foo68(strparam.Replace("68", ""));
        }

        public string foo68(string strparam)
        {
            return foo69(strparam.Replace("69", ""));
        }

        public string foo69(string strparam)
        {
            return foo70(strparam.Replace("70", ""));
        }

        public string foo70(string strparam)
        {
            return foo71(strparam.Replace("71", ""));
        }

        public string foo71(string strparam)
        {
            return foo72(strparam.Replace("72", ""));
        }

        public string foo72(string strparam)
        {
            return foo73(strparam.Replace("73", ""));
        }

        public string foo73(string strparam)
        {
            return foo74(strparam.Replace("74", ""));
        }

        public string foo74(string strparam)
        {
            return foo75(strparam.Replace("75", ""));
        }

        public string foo75(string strparam)
        {
            return foo76(strparam.Replace("76", ""));
        }

        public string foo76(string strparam)
        {
            return foo77(strparam.Replace("77", ""));
        }

        public string foo77(string strparam)
        {
            return foo78(strparam.Replace("78", ""));
        }

        public string foo78(string strparam)
        {
            return foo79(strparam.Replace("79", ""));
        }

        public string foo79(string strparam)
        {
            return foo80(strparam.Replace("80", ""));
        }

        public string foo80(string strparam)
        {
            return foo81(strparam.Replace("81", ""));
        }

        public string foo81(string strparam)
        {
            return foo82(strparam.Replace("82", ""));
        }

        public string foo82(string strparam)
        {
            return foo83(strparam.Replace("83", ""));
        }

        public string foo83(string strparam)
        {
            return foo84(strparam.Replace("84", ""));
        }

        public string foo84(string strparam)
        {
            return foo85(strparam.Replace("85", ""));
        }

        public string foo85(string strparam)
        {
            return foo86(strparam.Replace("86", ""));
        }

        public string foo86(string strparam)
        {
            return foo87(strparam.Replace("87", ""));
        }

        public string foo87(string strparam)
        {
            return foo88(strparam.Replace("88", ""));
        }

        public string foo88(string strparam)
        {
            return foo89(strparam.Replace("89", ""));
        }

        public string foo89(string strparam)
        {
            return foo90(strparam.Replace("90", ""));
        }

        public string foo90(string strparam)
        {
            return foo91(strparam.Replace("91", ""));
        }

        public string foo91(string strparam)
        {
            return foo92(strparam.Replace("92", ""));
        }

        public string foo92(string strparam)
        {
            return foo93(strparam.Replace("93", ""));
        }

        public string foo93(string strparam)
        {
            return foo94(strparam.Replace("94", ""));
        }

        public string foo94(string strparam)
        {
            return foo95(strparam.Replace("95", ""));
        }

        public string foo95(string strparam)
        {
            return foo96(strparam.Replace("96", ""));
        }

        public string foo96(string strparam)
        {
            return foo97(strparam.Replace("97", ""));
        }

        public string foo97(string strparam)
        {
            return foo98(strparam.Replace("98", ""));
        }

        public string foo98(string strparam)
        {
            return foo99(strparam.Replace("99", ""));
        }

        public string foo99(string strparam)
        {
            return foo100(strparam.Replace("100", ""));
        }
        
        public string foo100(string strparam)
        {
            return strparam;
        }

    }
}