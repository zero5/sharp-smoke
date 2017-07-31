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
			return foo101(strparam.Replace("101", ""));
		}

		public string foo101(string strparam)
		{
			return foo102(strparam.Replace("102", ""));
		}

		public string foo102(string strparam)
		{
			return foo103(strparam.Replace("103", ""));
		}

		public string foo103(string strparam)
		{
			return foo104(strparam.Replace("104", ""));
		}

		public string foo104(string strparam)
		{
			return foo105(strparam.Replace("105", ""));
		}

		public string foo105(string strparam)
		{
			return foo106(strparam.Replace("106", ""));
		}

		public string foo106(string strparam)
		{
			return foo107(strparam.Replace("107", ""));
		}

		public string foo107(string strparam)
		{
			return foo108(strparam.Replace("108", ""));
		}

		public string foo108(string strparam)
		{
			return foo109(strparam.Replace("109", ""));
		}

		public string foo109(string strparam)
		{
			return foo110(strparam.Replace("110", ""));
		}

		public string foo110(string strparam)
		{
			return foo111(strparam.Replace("111", ""));
		}

		public string foo111(string strparam)
		{
			return foo112(strparam.Replace("112", ""));
		}

		public string foo112(string strparam)
		{
			return foo113(strparam.Replace("113", ""));
		}

		public string foo113(string strparam)
		{
			return foo114(strparam.Replace("114", ""));
		}

		public string foo114(string strparam)
		{
			return foo115(strparam.Replace("115", ""));
		}

		public string foo115(string strparam)
		{
			return foo116(strparam.Replace("116", ""));
		}

		public string foo116(string strparam)
		{
			return foo117(strparam.Replace("117", ""));
		}

		public string foo117(string strparam)
		{
			return foo118(strparam.Replace("118", ""));
		}

		public string foo118(string strparam)
		{
			return foo119(strparam.Replace("119", ""));
		}

		public string foo119(string strparam)
		{
			return foo120(strparam.Replace("120", ""));
		}

		public string foo120(string strparam)
		{
			return foo121(strparam.Replace("121", ""));
		}

		public string foo121(string strparam)
		{
			return foo122(strparam.Replace("122", ""));
		}

		public string foo122(string strparam)
		{
			return foo123(strparam.Replace("123", ""));
		}

		public string foo123(string strparam)
		{
			return foo124(strparam.Replace("124", ""));
		}

		public string foo124(string strparam)
		{
			return foo125(strparam.Replace("125", ""));
		}

		public string foo125(string strparam)
		{
			return foo126(strparam.Replace("126", ""));
		}

		public string foo126(string strparam)
		{
			return foo127(strparam.Replace("127", ""));
		}

		public string foo127(string strparam)
		{
			return foo128(strparam.Replace("128", ""));
		}

		public string foo128(string strparam)
		{
			return foo129(strparam.Replace("129", ""));
		}

		public string foo129(string strparam)
		{
			return foo130(strparam.Replace("130", ""));
		}

		public string foo130(string strparam)
		{
			return foo131(strparam.Replace("131", ""));
		}

		public string foo131(string strparam)
		{
			return foo132(strparam.Replace("132", ""));
		}

		public string foo132(string strparam)
		{
			return foo133(strparam.Replace("133", ""));
		}

		public string foo133(string strparam)
		{
			return foo134(strparam.Replace("134", ""));
		}

		public string foo134(string strparam)
		{
			return foo135(strparam.Replace("135", ""));
		}

		public string foo135(string strparam)
		{
			return foo136(strparam.Replace("136", ""));
		}

		public string foo136(string strparam)
		{
			return foo137(strparam.Replace("137", ""));
		}

		public string foo137(string strparam)
		{
			return foo138(strparam.Replace("138", ""));
		}

		public string foo138(string strparam)
		{
			return foo139(strparam.Replace("139", ""));
		}

		public string foo139(string strparam)
		{
			return foo140(strparam.Replace("140", ""));
		}

		public string foo140(string strparam)
		{
			return foo141(strparam.Replace("141", ""));
		}

		public string foo141(string strparam)
		{
			return foo142(strparam.Replace("142", ""));
		}

		public string foo142(string strparam)
		{
			return foo143(strparam.Replace("143", ""));
		}

		public string foo143(string strparam)
		{
			return foo144(strparam.Replace("144", ""));
		}

		public string foo144(string strparam)
		{
			return foo145(strparam.Replace("145", ""));
		}

		public string foo145(string strparam)
		{
			return foo146(strparam.Replace("146", ""));
		}

		public string foo146(string strparam)
		{
			return foo147(strparam.Replace("147", ""));
		}

		public string foo147(string strparam)
		{
			return foo148(strparam.Replace("148", ""));
		}

		public string foo148(string strparam)
		{
			return foo149(strparam.Replace("149", ""));
		}

		public string foo149(string strparam)
		{
			return foo150(strparam.Replace("150", ""));
		}

		public string foo150(string strparam)
		{
			return foo151(strparam.Replace("151", ""));
		}

		public string foo151(string strparam)
		{
			return foo152(strparam.Replace("152", ""));
		}

		public string foo152(string strparam)
		{
			return foo153(strparam.Replace("153", ""));
		}

		public string foo153(string strparam)
		{
			return foo154(strparam.Replace("154", ""));
		}

		public string foo154(string strparam)
		{
			return foo155(strparam.Replace("155", ""));
		}

		public string foo155(string strparam)
		{
			return foo156(strparam.Replace("156", ""));
		}

		public string foo156(string strparam)
		{
			return foo157(strparam.Replace("157", ""));
		}

		public string foo157(string strparam)
		{
			return foo158(strparam.Replace("158", ""));
		}

		public string foo158(string strparam)
		{
			return foo159(strparam.Replace("159", ""));
		}

		public string foo159(string strparam)
		{
			return foo160(strparam.Replace("160", ""));
		}

		public string foo160(string strparam)
		{
			return foo161(strparam.Replace("161", ""));
		}

		public string foo161(string strparam)
		{
			return foo162(strparam.Replace("162", ""));
		}

		public string foo162(string strparam)
		{
			return foo163(strparam.Replace("163", ""));
		}

		public string foo163(string strparam)
		{
			return foo164(strparam.Replace("164", ""));
		}

		public string foo164(string strparam)
		{
			return foo165(strparam.Replace("165", ""));
		}

		public string foo165(string strparam)
		{
			return foo166(strparam.Replace("166", ""));
		}

		public string foo166(string strparam)
		{
			return foo167(strparam.Replace("167", ""));
		}

		public string foo167(string strparam)
		{
			return foo168(strparam.Replace("168", ""));
		}

		public string foo168(string strparam)
		{
			return foo169(strparam.Replace("169", ""));
		}

		public string foo169(string strparam)
		{
			return foo170(strparam.Replace("170", ""));
		}

		public string foo170(string strparam)
		{
			return foo171(strparam.Replace("171", ""));
		}

		public string foo171(string strparam)
		{
			return foo172(strparam.Replace("172", ""));
		}

		public string foo172(string strparam)
		{
			return foo173(strparam.Replace("173", ""));
		}

		public string foo173(string strparam)
		{
			return foo174(strparam.Replace("174", ""));
		}

		public string foo174(string strparam)
		{
			return foo175(strparam.Replace("175", ""));
		}

		public string foo175(string strparam)
		{
			return foo176(strparam.Replace("176", ""));
		}

		public string foo176(string strparam)
		{
			return foo177(strparam.Replace("177", ""));
		}

		public string foo177(string strparam)
		{
			return foo178(strparam.Replace("178", ""));
		}

		public string foo178(string strparam)
		{
			return foo179(strparam.Replace("179", ""));
		}

		public string foo179(string strparam)
		{
			return foo180(strparam.Replace("180", ""));
		}

		public string foo180(string strparam)
		{
			return foo181(strparam.Replace("181", ""));
		}

		public string foo181(string strparam)
		{
			return foo182(strparam.Replace("182", ""));
		}

		public string foo182(string strparam)
		{
			return foo183(strparam.Replace("183", ""));
		}

		public string foo183(string strparam)
		{
			return foo184(strparam.Replace("184", ""));
		}

		public string foo184(string strparam)
		{
			return foo185(strparam.Replace("185", ""));
		}

		public string foo185(string strparam)
		{
			return foo186(strparam.Replace("186", ""));
		}

		public string foo186(string strparam)
		{
			return foo187(strparam.Replace("187", ""));
		}

		public string foo187(string strparam)
		{
			return foo188(strparam.Replace("188", ""));
		}

		public string foo188(string strparam)
		{
			return foo189(strparam.Replace("189", ""));
		}

		public string foo189(string strparam)
		{
			return foo190(strparam.Replace("190", ""));
		}

		public string foo190(string strparam)
		{
			return foo191(strparam.Replace("191", ""));
		}

		public string foo191(string strparam)
		{
			return foo192(strparam.Replace("192", ""));
		}

		public string foo192(string strparam)
		{
			return foo193(strparam.Replace("193", ""));
		}

		public string foo193(string strparam)
		{
			return foo194(strparam.Replace("194", ""));
		}

		public string foo194(string strparam)
		{
			return foo195(strparam.Replace("195", ""));
		}

		public string foo195(string strparam)
		{
			return foo196(strparam.Replace("196", ""));
		}

		public string foo196(string strparam)
		{
			return foo197(strparam.Replace("197", ""));
		}

		public string foo197(string strparam)
		{
			return foo198(strparam.Replace("198", ""));
		}

		public string foo198(string strparam)
		{
			return foo199(strparam.Replace("199", ""));
		}

		public string foo199(string strparam)
		{
			return foo200(strparam.Replace("200", ""));
		}

		public string foo200(string strparam)
		{
			return foo201(strparam.Replace("201", ""));
		}

		public string foo201(string strparam)
		{
			return foo202(strparam.Replace("202", ""));
		}

		public string foo202(string strparam)
		{
			return foo203(strparam.Replace("203", ""));
		}

		public string foo203(string strparam)
		{
			return foo204(strparam.Replace("204", ""));
		}

		public string foo204(string strparam)
		{
			return foo205(strparam.Replace("205", ""));
		}

		public string foo205(string strparam)
		{
			return foo206(strparam.Replace("206", ""));
		}

		public string foo206(string strparam)
		{
			return foo207(strparam.Replace("207", ""));
		}

		public string foo207(string strparam)
		{
			return foo208(strparam.Replace("208", ""));
		}

		public string foo208(string strparam)
		{
			return foo209(strparam.Replace("209", ""));
		}

		public string foo209(string strparam)
		{
			return foo210(strparam.Replace("210", ""));
		}

		public string foo210(string strparam)
		{
			return foo211(strparam.Replace("211", ""));
		}

		public string foo211(string strparam)
		{
			return foo212(strparam.Replace("212", ""));
		}

		public string foo212(string strparam)
		{
			return foo213(strparam.Replace("213", ""));
		}

		public string foo213(string strparam)
		{
			return foo214(strparam.Replace("214", ""));
		}

		public string foo214(string strparam)
		{
			return foo215(strparam.Replace("215", ""));
		}

		public string foo215(string strparam)
		{
			return foo216(strparam.Replace("216", ""));
		}

		public string foo216(string strparam)
		{
			return foo217(strparam.Replace("217", ""));
		}

		public string foo217(string strparam)
		{
			return foo218(strparam.Replace("218", ""));
		}

		public string foo218(string strparam)
		{
			return foo219(strparam.Replace("219", ""));
		}

		public string foo219(string strparam)
		{
			return foo220(strparam.Replace("220", ""));
		}

		public string foo220(string strparam)
		{
			return foo221(strparam.Replace("221", ""));
		}

		public string foo221(string strparam)
		{
			return foo222(strparam.Replace("222", ""));
		}

		public string foo222(string strparam)
		{
			return foo223(strparam.Replace("223", ""));
		}

		public string foo223(string strparam)
		{
			return foo224(strparam.Replace("224", ""));
		}

		public string foo224(string strparam)
		{
			return foo225(strparam.Replace("225", ""));
		}

		public string foo225(string strparam)
		{
			return foo226(strparam.Replace("226", ""));
		}

		public string foo226(string strparam)
		{
			return foo227(strparam.Replace("227", ""));
		}

		public string foo227(string strparam)
		{
			return foo228(strparam.Replace("228", ""));
		}

		public string foo228(string strparam)
		{
			return foo229(strparam.Replace("229", ""));
		}

		public string foo229(string strparam)
		{
			return foo230(strparam.Replace("230", ""));
		}

		public string foo230(string strparam)
		{
			return foo231(strparam.Replace("231", ""));
		}

		public string foo231(string strparam)
		{
			return foo232(strparam.Replace("232", ""));
		}

		public string foo232(string strparam)
		{
			return foo233(strparam.Replace("233", ""));
		}

		public string foo233(string strparam)
		{
			return foo234(strparam.Replace("234", ""));
		}

		public string foo234(string strparam)
		{
			return foo235(strparam.Replace("235", ""));
		}

		public string foo235(string strparam)
		{
			return foo236(strparam.Replace("236", ""));
		}

		public string foo236(string strparam)
		{
			return foo237(strparam.Replace("237", ""));
		}

		public string foo237(string strparam)
		{
			return foo238(strparam.Replace("238", ""));
		}

		public string foo238(string strparam)
		{
			return foo239(strparam.Replace("239", ""));
		}

		public string foo239(string strparam)
		{
			return foo240(strparam.Replace("240", ""));
		}

		public string foo240(string strparam)
		{
			return foo241(strparam.Replace("241", ""));
		}

		public string foo241(string strparam)
		{
			return foo242(strparam.Replace("242", ""));
		}

		public string foo242(string strparam)
		{
			return foo243(strparam.Replace("243", ""));
		}

		public string foo243(string strparam)
		{
			return foo244(strparam.Replace("244", ""));
		}

		public string foo244(string strparam)
		{
			return foo245(strparam.Replace("245", ""));
		}

		public string foo245(string strparam)
		{
			return foo246(strparam.Replace("246", ""));
		}

		public string foo246(string strparam)
		{
			return foo247(strparam.Replace("247", ""));
		}

		public string foo247(string strparam)
		{
			return foo248(strparam.Replace("248", ""));
		}

		public string foo248(string strparam)
		{
			return foo249(strparam.Replace("249", ""));
		}

		public string foo249(string strparam)
		{
			return foo250(strparam.Replace("250", ""));
		}

		public string foo250(string strparam)
		{
			return foo251(strparam.Replace("251", ""));
		}

		public string foo251(string strparam)
		{
			return foo252(strparam.Replace("252", ""));
		}

		public string foo252(string strparam)
		{
			return foo253(strparam.Replace("253", ""));
		}

		public string foo253(string strparam)
		{
			return foo254(strparam.Replace("254", ""));
		}

		public string foo254(string strparam)
		{
			return foo255(strparam.Replace("255", ""));
		}

		public string foo255(string strparam)
		{
			return foo256(strparam.Replace("256", ""));
		}

		public string foo256(string strparam)
		{
			return foo257(strparam.Replace("257", ""));
		}

		public string foo257(string strparam)
		{
			return foo258(strparam.Replace("258", ""));
		}

		public string foo258(string strparam)
		{
			return foo259(strparam.Replace("259", ""));
		}

		public string foo259(string strparam)
		{
			return foo260(strparam.Replace("260", ""));
		}

		public string foo260(string strparam)
		{
			return foo261(strparam.Replace("261", ""));
		}

		public string foo261(string strparam)
		{
			return foo262(strparam.Replace("262", ""));
		}

		public string foo262(string strparam)
		{
			return foo263(strparam.Replace("263", ""));
		}

		public string foo263(string strparam)
		{
			return foo264(strparam.Replace("264", ""));
		}

		public string foo264(string strparam)
		{
			return foo265(strparam.Replace("265", ""));
		}

		public string foo265(string strparam)
		{
			return foo266(strparam.Replace("266", ""));
		}

		public string foo266(string strparam)
		{
			return foo267(strparam.Replace("267", ""));
		}

		public string foo267(string strparam)
		{
			return foo268(strparam.Replace("268", ""));
		}

		public string foo268(string strparam)
		{
			return foo269(strparam.Replace("269", ""));
		}

		public string foo269(string strparam)
		{
			return foo270(strparam.Replace("270", ""));
		}

		public string foo270(string strparam)
		{
			return foo271(strparam.Replace("271", ""));
		}

		public string foo271(string strparam)
		{
			return foo272(strparam.Replace("272", ""));
		}

		public string foo272(string strparam)
		{
			return foo273(strparam.Replace("273", ""));
		}

		public string foo273(string strparam)
		{
			return foo274(strparam.Replace("274", ""));
		}

		public string foo274(string strparam)
		{
			return foo275(strparam.Replace("275", ""));
		}

		public string foo275(string strparam)
		{
			return foo276(strparam.Replace("276", ""));
		}

		public string foo276(string strparam)
		{
			return foo277(strparam.Replace("277", ""));
		}

		public string foo277(string strparam)
		{
			return foo278(strparam.Replace("278", ""));
		}

		public string foo278(string strparam)
		{
			return foo279(strparam.Replace("279", ""));
		}

		public string foo279(string strparam)
		{
			return foo280(strparam.Replace("280", ""));
		}

		public string foo280(string strparam)
		{
			return foo281(strparam.Replace("281", ""));
		}

		public string foo281(string strparam)
		{
			return foo282(strparam.Replace("282", ""));
		}

		public string foo282(string strparam)
		{
			return foo283(strparam.Replace("283", ""));
		}

		public string foo283(string strparam)
		{
			return foo284(strparam.Replace("284", ""));
		}

		public string foo284(string strparam)
		{
			return foo285(strparam.Replace("285", ""));
		}

		public string foo285(string strparam)
		{
			return foo286(strparam.Replace("286", ""));
		}

		public string foo286(string strparam)
		{
			return foo287(strparam.Replace("287", ""));
		}

		public string foo287(string strparam)
		{
			return foo288(strparam.Replace("288", ""));
		}

		public string foo288(string strparam)
		{
			return foo289(strparam.Replace("289", ""));
		}

		public string foo289(string strparam)
		{
			return foo290(strparam.Replace("290", ""));
		}

		public string foo290(string strparam)
		{
			return foo291(strparam.Replace("291", ""));
		}

		public string foo291(string strparam)
		{
			return foo292(strparam.Replace("292", ""));
		}

		public string foo292(string strparam)
		{
			return foo293(strparam.Replace("293", ""));
		}

		public string foo293(string strparam)
		{
			return foo294(strparam.Replace("294", ""));
		}

		public string foo294(string strparam)
		{
			return foo295(strparam.Replace("295", ""));
		}

		public string foo295(string strparam)
		{
			return foo296(strparam.Replace("296", ""));
		}

		public string foo296(string strparam)
		{
			return foo297(strparam.Replace("297", ""));
		}

		public string foo297(string strparam)
		{
			return foo298(strparam.Replace("298", ""));
		}

		public string foo298(string strparam)
		{
			return foo299(strparam.Replace("299", ""));
		}

		public string foo299(string strparam)
		{
			return foo300(strparam.Replace("300", ""));
		}

		public string foo300(string strparam)
		{
			return foo301(strparam.Replace("301", ""));
		}

		public string foo301(string strparam)
		{
			return foo302(strparam.Replace("302", ""));
		}

		public string foo302(string strparam)
		{
			return foo303(strparam.Replace("303", ""));
		}

		public string foo303(string strparam)
		{
			return foo304(strparam.Replace("304", ""));
		}

		public string foo304(string strparam)
		{
			return foo305(strparam.Replace("305", ""));
		}

		public string foo305(string strparam)
		{
			return foo306(strparam.Replace("306", ""));
		}

		public string foo306(string strparam)
		{
			return foo307(strparam.Replace("307", ""));
		}

		public string foo307(string strparam)
		{
			return foo308(strparam.Replace("308", ""));
		}

		public string foo308(string strparam)
		{
			return foo309(strparam.Replace("309", ""));
		}

		public string foo309(string strparam)
		{
			return foo310(strparam.Replace("310", ""));
		}

		public string foo310(string strparam)
		{
			return foo311(strparam.Replace("311", ""));
		}

		public string foo311(string strparam)
		{
			return foo312(strparam.Replace("312", ""));
		}

		public string foo312(string strparam)
		{
			return foo313(strparam.Replace("313", ""));
		}

		public string foo313(string strparam)
		{
			return foo314(strparam.Replace("314", ""));
		}

		public string foo314(string strparam)
		{
			return foo315(strparam.Replace("315", ""));
		}

		public string foo315(string strparam)
		{
			return foo316(strparam.Replace("316", ""));
		}

		public string foo316(string strparam)
		{
			return foo317(strparam.Replace("317", ""));
		}

		public string foo317(string strparam)
		{
			return foo318(strparam.Replace("318", ""));
		}

		public string foo318(string strparam)
		{
			return foo319(strparam.Replace("319", ""));
		}

		public string foo319(string strparam)
		{
			return foo320(strparam.Replace("320", ""));
		}

		public string foo320(string strparam)
		{
			return foo321(strparam.Replace("321", ""));
		}

		public string foo321(string strparam)
		{
			return foo322(strparam.Replace("322", ""));
		}

		public string foo322(string strparam)
		{
			return foo323(strparam.Replace("323", ""));
		}

		public string foo323(string strparam)
		{
			return foo324(strparam.Replace("324", ""));
		}

		public string foo324(string strparam)
		{
			return foo325(strparam.Replace("325", ""));
		}

		public string foo325(string strparam)
		{
			return foo326(strparam.Replace("326", ""));
		}

		public string foo326(string strparam)
		{
			return foo327(strparam.Replace("327", ""));
		}

		public string foo327(string strparam)
		{
			return foo328(strparam.Replace("328", ""));
		}

		public string foo328(string strparam)
		{
			return foo329(strparam.Replace("329", ""));
		}

		public string foo329(string strparam)
		{
			return foo330(strparam.Replace("330", ""));
		}

		public string foo330(string strparam)
		{
			return foo331(strparam.Replace("331", ""));
		}

		public string foo331(string strparam)
		{
			return foo332(strparam.Replace("332", ""));
		}

		public string foo332(string strparam)
		{
			return foo333(strparam.Replace("333", ""));
		}

		public string foo333(string strparam)
		{
			return foo334(strparam.Replace("334", ""));
		}

		public string foo334(string strparam)
		{
			return foo335(strparam.Replace("335", ""));
		}

		public string foo335(string strparam)
		{
			return foo336(strparam.Replace("336", ""));
		}

		public string foo336(string strparam)
		{
			return foo337(strparam.Replace("337", ""));
		}

		public string foo337(string strparam)
		{
			return foo338(strparam.Replace("338", ""));
		}

		public string foo338(string strparam)
		{
			return foo339(strparam.Replace("339", ""));
		}

		public string foo339(string strparam)
		{
			return foo340(strparam.Replace("340", ""));
		}

		public string foo340(string strparam)
		{
			return foo341(strparam.Replace("341", ""));
		}

		public string foo341(string strparam)
		{
			return foo342(strparam.Replace("342", ""));
		}

		public string foo342(string strparam)
		{
			return foo343(strparam.Replace("343", ""));
		}

		public string foo343(string strparam)
		{
			return foo344(strparam.Replace("344", ""));
		}

		public string foo344(string strparam)
		{
			return foo345(strparam.Replace("345", ""));
		}

		public string foo345(string strparam)
		{
			return foo346(strparam.Replace("346", ""));
		}

		public string foo346(string strparam)
		{
			return foo347(strparam.Replace("347", ""));
		}

		public string foo347(string strparam)
		{
			return foo348(strparam.Replace("348", ""));
		}

		public string foo348(string strparam)
		{
			return foo349(strparam.Replace("349", ""));
		}

		public string foo349(string strparam)
		{
			return foo350(strparam.Replace("350", ""));
		}

		public string foo350(string strparam)
		{
			return foo351(strparam.Replace("351", ""));
		}

		public string foo351(string strparam)
		{
			return foo352(strparam.Replace("352", ""));
		}

		public string foo352(string strparam)
		{
			return foo353(strparam.Replace("353", ""));
		}

		public string foo353(string strparam)
		{
			return foo354(strparam.Replace("354", ""));
		}

		public string foo354(string strparam)
		{
			return foo355(strparam.Replace("355", ""));
		}

		public string foo355(string strparam)
		{
			return foo356(strparam.Replace("356", ""));
		}

		public string foo356(string strparam)
		{
			return foo357(strparam.Replace("357", ""));
		}

		public string foo357(string strparam)
		{
			return foo358(strparam.Replace("358", ""));
		}

		public string foo358(string strparam)
		{
			return foo359(strparam.Replace("359", ""));
		}

		public string foo359(string strparam)
		{
			return foo360(strparam.Replace("360", ""));
		}

		public string foo360(string strparam)
		{
			return foo361(strparam.Replace("361", ""));
		}

		public string foo361(string strparam)
		{
			return foo362(strparam.Replace("362", ""));
		}

		public string foo362(string strparam)
		{
			return foo363(strparam.Replace("363", ""));
		}

		public string foo363(string strparam)
		{
			return foo364(strparam.Replace("364", ""));
		}

		public string foo364(string strparam)
		{
			return foo365(strparam.Replace("365", ""));
		}

		public string foo365(string strparam)
		{
			return foo366(strparam.Replace("366", ""));
		}

		public string foo366(string strparam)
		{
			return foo367(strparam.Replace("367", ""));
		}

		public string foo367(string strparam)
		{
			return foo368(strparam.Replace("368", ""));
		}

		public string foo368(string strparam)
		{
			return foo369(strparam.Replace("369", ""));
		}

		public string foo369(string strparam)
		{
			return foo370(strparam.Replace("370", ""));
		}

		public string foo370(string strparam)
		{
			return foo371(strparam.Replace("371", ""));
		}

		public string foo371(string strparam)
		{
			return foo372(strparam.Replace("372", ""));
		}

		public string foo372(string strparam)
		{
			return foo373(strparam.Replace("373", ""));
		}

		public string foo373(string strparam)
		{
			return foo374(strparam.Replace("374", ""));
		}

		public string foo374(string strparam)
		{
			return foo375(strparam.Replace("375", ""));
		}

		public string foo375(string strparam)
		{
			return foo376(strparam.Replace("376", ""));
		}

		public string foo376(string strparam)
		{
			return foo377(strparam.Replace("377", ""));
		}

		public string foo377(string strparam)
		{
			return foo378(strparam.Replace("378", ""));
		}

		public string foo378(string strparam)
		{
			return foo379(strparam.Replace("379", ""));
		}

		public string foo379(string strparam)
		{
			return foo380(strparam.Replace("380", ""));
		}

		public string foo380(string strparam)
		{
			return foo381(strparam.Replace("381", ""));
		}

		public string foo381(string strparam)
		{
			return foo382(strparam.Replace("382", ""));
		}

		public string foo382(string strparam)
		{
			return foo383(strparam.Replace("383", ""));
		}

		public string foo383(string strparam)
		{
			return foo384(strparam.Replace("384", ""));
		}

		public string foo384(string strparam)
		{
			return foo385(strparam.Replace("385", ""));
		}

		public string foo385(string strparam)
		{
			return foo386(strparam.Replace("386", ""));
		}

		public string foo386(string strparam)
		{
			return foo387(strparam.Replace("387", ""));
		}

		public string foo387(string strparam)
		{
			return foo388(strparam.Replace("388", ""));
		}

		public string foo388(string strparam)
		{
			return foo389(strparam.Replace("389", ""));
		}

		public string foo389(string strparam)
		{
			return foo390(strparam.Replace("390", ""));
		}

		public string foo390(string strparam)
		{
			return foo391(strparam.Replace("391", ""));
		}

		public string foo391(string strparam)
		{
			return foo392(strparam.Replace("392", ""));
		}

		public string foo392(string strparam)
		{
			return foo393(strparam.Replace("393", ""));
		}

		public string foo393(string strparam)
		{
			return foo394(strparam.Replace("394", ""));
		}

		public string foo394(string strparam)
		{
			return foo395(strparam.Replace("395", ""));
		}

		public string foo395(string strparam)
		{
			return foo396(strparam.Replace("396", ""));
		}

		public string foo396(string strparam)
		{
			return foo397(strparam.Replace("397", ""));
		}

		public string foo397(string strparam)
		{
			return foo398(strparam.Replace("398", ""));
		}

		public string foo398(string strparam)
		{
			return foo399(strparam.Replace("399", ""));
		}

		public string foo399(string strparam)
		{
			return foo400(strparam.Replace("400", ""));
		}

		public string foo400(string strparam)
		{
			return foo401(strparam.Replace("401", ""));
		}

		public string foo401(string strparam)
		{
			return foo402(strparam.Replace("402", ""));
		}

		public string foo402(string strparam)
		{
			return foo403(strparam.Replace("403", ""));
		}

		public string foo403(string strparam)
		{
			return foo404(strparam.Replace("404", ""));
		}

		public string foo404(string strparam)
		{
			return foo405(strparam.Replace("405", ""));
		}

		public string foo405(string strparam)
		{
			return foo406(strparam.Replace("406", ""));
		}

		public string foo406(string strparam)
		{
			return foo407(strparam.Replace("407", ""));
		}

		public string foo407(string strparam)
		{
			return foo408(strparam.Replace("408", ""));
		}

		public string foo408(string strparam)
		{
			return foo409(strparam.Replace("409", ""));
		}

		public string foo409(string strparam)
		{
			return foo410(strparam.Replace("410", ""));
		}

		public string foo410(string strparam)
		{
			return foo411(strparam.Replace("411", ""));
		}

		public string foo411(string strparam)
		{
			return foo412(strparam.Replace("412", ""));
		}

		public string foo412(string strparam)
		{
			return foo413(strparam.Replace("413", ""));
		}

		public string foo413(string strparam)
		{
			return foo414(strparam.Replace("414", ""));
		}

		public string foo414(string strparam)
		{
			return foo415(strparam.Replace("415", ""));
		}

		public string foo415(string strparam)
		{
			return foo416(strparam.Replace("416", ""));
		}

		public string foo416(string strparam)
		{
			return foo417(strparam.Replace("417", ""));
		}

		public string foo417(string strparam)
		{
			return foo418(strparam.Replace("418", ""));
		}

		public string foo418(string strparam)
		{
			return foo419(strparam.Replace("419", ""));
		}

		public string foo419(string strparam)
		{
			return foo420(strparam.Replace("420", ""));
		}

		public string foo420(string strparam)
		{
			return foo421(strparam.Replace("421", ""));
		}

		public string foo421(string strparam)
		{
			return foo422(strparam.Replace("422", ""));
		}

		public string foo422(string strparam)
		{
			return foo423(strparam.Replace("423", ""));
		}

		public string foo423(string strparam)
		{
			return foo424(strparam.Replace("424", ""));
		}

		public string foo424(string strparam)
		{
			return foo425(strparam.Replace("425", ""));
		}

		public string foo425(string strparam)
		{
			return foo426(strparam.Replace("426", ""));
		}

		public string foo426(string strparam)
		{
			return foo427(strparam.Replace("427", ""));
		}

		public string foo427(string strparam)
		{
			return foo428(strparam.Replace("428", ""));
		}

		public string foo428(string strparam)
		{
			return foo429(strparam.Replace("429", ""));
		}

		public string foo429(string strparam)
		{
			return foo430(strparam.Replace("430", ""));
		}

		public string foo430(string strparam)
		{
			return foo431(strparam.Replace("431", ""));
		}

		public string foo431(string strparam)
		{
			return foo432(strparam.Replace("432", ""));
		}

		public string foo432(string strparam)
		{
			return foo433(strparam.Replace("433", ""));
		}

		public string foo433(string strparam)
		{
			return foo434(strparam.Replace("434", ""));
		}

		public string foo434(string strparam)
		{
			return foo435(strparam.Replace("435", ""));
		}

		public string foo435(string strparam)
		{
			return foo436(strparam.Replace("436", ""));
		}

		public string foo436(string strparam)
		{
			return foo437(strparam.Replace("437", ""));
		}

		public string foo437(string strparam)
		{
			return foo438(strparam.Replace("438", ""));
		}

		public string foo438(string strparam)
		{
			return foo439(strparam.Replace("439", ""));
		}

		public string foo439(string strparam)
		{
			return foo440(strparam.Replace("440", ""));
		}

		public string foo440(string strparam)
		{
			return foo441(strparam.Replace("441", ""));
		}

		public string foo441(string strparam)
		{
			return foo442(strparam.Replace("442", ""));
		}

		public string foo442(string strparam)
		{
			return foo443(strparam.Replace("443", ""));
		}

		public string foo443(string strparam)
		{
			return foo444(strparam.Replace("444", ""));
		}

		public string foo444(string strparam)
		{
			return foo445(strparam.Replace("445", ""));
		}

		public string foo445(string strparam)
		{
			return foo446(strparam.Replace("446", ""));
		}

		public string foo446(string strparam)
		{
			return foo447(strparam.Replace("447", ""));
		}

		public string foo447(string strparam)
		{
			return foo448(strparam.Replace("448", ""));
		}

		public string foo448(string strparam)
		{
			return foo449(strparam.Replace("449", ""));
		}

		public string foo449(string strparam)
		{
			return foo450(strparam.Replace("450", ""));
		}

		public string foo450(string strparam)
		{
			return foo451(strparam.Replace("451", ""));
		}

		public string foo451(string strparam)
		{
			return foo452(strparam.Replace("452", ""));
		}

		public string foo452(string strparam)
		{
			return foo453(strparam.Replace("453", ""));
		}

		public string foo453(string strparam)
		{
			return foo454(strparam.Replace("454", ""));
		}

		public string foo454(string strparam)
		{
			return foo455(strparam.Replace("455", ""));
		}

		public string foo455(string strparam)
		{
			return foo456(strparam.Replace("456", ""));
		}

		public string foo456(string strparam)
		{
			return foo457(strparam.Replace("457", ""));
		}

		public string foo457(string strparam)
		{
			return foo458(strparam.Replace("458", ""));
		}

		public string foo458(string strparam)
		{
			return foo459(strparam.Replace("459", ""));
		}

		public string foo459(string strparam)
		{
			return foo460(strparam.Replace("460", ""));
		}

		public string foo460(string strparam)
		{
			return foo461(strparam.Replace("461", ""));
		}

		public string foo461(string strparam)
		{
			return foo462(strparam.Replace("462", ""));
		}

		public string foo462(string strparam)
		{
			return foo463(strparam.Replace("463", ""));
		}

		public string foo463(string strparam)
		{
			return foo464(strparam.Replace("464", ""));
		}

		public string foo464(string strparam)
		{
			return foo465(strparam.Replace("465", ""));
		}

		public string foo465(string strparam)
		{
			return foo466(strparam.Replace("466", ""));
		}

		public string foo466(string strparam)
		{
			return foo467(strparam.Replace("467", ""));
		}

		public string foo467(string strparam)
		{
			return foo468(strparam.Replace("468", ""));
		}

		public string foo468(string strparam)
		{
			return foo469(strparam.Replace("469", ""));
		}

		public string foo469(string strparam)
		{
			return foo470(strparam.Replace("470", ""));
		}

		public string foo470(string strparam)
		{
			return foo471(strparam.Replace("471", ""));
		}

		public string foo471(string strparam)
		{
			return foo472(strparam.Replace("472", ""));
		}

		public string foo472(string strparam)
		{
			return foo473(strparam.Replace("473", ""));
		}

		public string foo473(string strparam)
		{
			return foo474(strparam.Replace("474", ""));
		}

		public string foo474(string strparam)
		{
			return foo475(strparam.Replace("475", ""));
		}

		public string foo475(string strparam)
		{
			return foo476(strparam.Replace("476", ""));
		}

		public string foo476(string strparam)
		{
			return foo477(strparam.Replace("477", ""));
		}

		public string foo477(string strparam)
		{
			return foo478(strparam.Replace("478", ""));
		}

		public string foo478(string strparam)
		{
			return foo479(strparam.Replace("479", ""));
		}

		public string foo479(string strparam)
		{
			return foo480(strparam.Replace("480", ""));
		}

		public string foo480(string strparam)
		{
			return foo481(strparam.Replace("481", ""));
		}

		public string foo481(string strparam)
		{
			return foo482(strparam.Replace("482", ""));
		}

		public string foo482(string strparam)
		{
			return foo483(strparam.Replace("483", ""));
		}

		public string foo483(string strparam)
		{
			return foo484(strparam.Replace("484", ""));
		}

		public string foo484(string strparam)
		{
			return foo485(strparam.Replace("485", ""));
		}

		public string foo485(string strparam)
		{
			return foo486(strparam.Replace("486", ""));
		}

		public string foo486(string strparam)
		{
			return foo487(strparam.Replace("487", ""));
		}

		public string foo487(string strparam)
		{
			return foo488(strparam.Replace("488", ""));
		}

		public string foo488(string strparam)
		{
			return foo489(strparam.Replace("489", ""));
		}

		public string foo489(string strparam)
		{
			return foo490(strparam.Replace("490", ""));
		}

		public string foo490(string strparam)
		{
			return foo491(strparam.Replace("491", ""));
		}

		public string foo491(string strparam)
		{
			return foo492(strparam.Replace("492", ""));
		}

		public string foo492(string strparam)
		{
			return foo493(strparam.Replace("493", ""));
		}

		public string foo493(string strparam)
		{
			return foo494(strparam.Replace("494", ""));
		}

		public string foo494(string strparam)
		{
			return foo495(strparam.Replace("495", ""));
		}

		public string foo495(string strparam)
		{
			return foo496(strparam.Replace("496", ""));
		}

		public string foo496(string strparam)
		{
			return foo497(strparam.Replace("497", ""));
		}

		public string foo497(string strparam)
		{
			return foo498(strparam.Replace("498", ""));
		}

		public string foo498(string strparam)
		{
			return foo499(strparam.Replace("499", ""));
		}

		public string foo499(string strparam)
		{
			return foo500(strparam.Replace("500", ""));
		}

		public string foo500(string strparam)
		{
			return foo501(strparam.Replace("501", ""));
		}

		public string foo501(string strparam)
		{
			return foo502(strparam.Replace("502", ""));
		}

		public string foo502(string strparam)
		{
			return foo503(strparam.Replace("503", ""));
		}

		public string foo503(string strparam)
		{
			return foo504(strparam.Replace("504", ""));
		}

		public string foo504(string strparam)
		{
			return foo505(strparam.Replace("505", ""));
		}

		public string foo505(string strparam)
		{
			return foo506(strparam.Replace("506", ""));
		}

		public string foo506(string strparam)
		{
			return foo507(strparam.Replace("507", ""));
		}

		public string foo507(string strparam)
		{
			return foo508(strparam.Replace("508", ""));
		}

		public string foo508(string strparam)
		{
			return foo509(strparam.Replace("509", ""));
		}

		public string foo509(string strparam)
		{
			return foo510(strparam.Replace("510", ""));
		}

		public string foo510(string strparam)
		{
			return foo511(strparam.Replace("511", ""));
		}

		public string foo511(string strparam)
		{
			return foo512(strparam.Replace("512", ""));
		}

		public string foo512(string strparam)
		{
			return foo513(strparam.Replace("513", ""));
		}

		public string foo513(string strparam)
		{
			return foo514(strparam.Replace("514", ""));
		}

		public string foo514(string strparam)
		{
			return foo515(strparam.Replace("515", ""));
		}

		public string foo515(string strparam)
		{
			return foo516(strparam.Replace("516", ""));
		}

		public string foo516(string strparam)
		{
			return foo517(strparam.Replace("517", ""));
		}

		public string foo517(string strparam)
		{
			return foo518(strparam.Replace("518", ""));
		}

		public string foo518(string strparam)
		{
			return foo519(strparam.Replace("519", ""));
		}

		public string foo519(string strparam)
		{
			return foo520(strparam.Replace("520", ""));
		}

		public string foo520(string strparam)
		{
			return foo521(strparam.Replace("521", ""));
		}

		public string foo521(string strparam)
		{
			return foo522(strparam.Replace("522", ""));
		}

		public string foo522(string strparam)
		{
			return foo523(strparam.Replace("523", ""));
		}

		public string foo523(string strparam)
		{
			return foo524(strparam.Replace("524", ""));
		}

		public string foo524(string strparam)
		{
			return foo525(strparam.Replace("525", ""));
		}

		public string foo525(string strparam)
		{
			return foo526(strparam.Replace("526", ""));
		}

		public string foo526(string strparam)
		{
			return foo527(strparam.Replace("527", ""));
		}

		public string foo527(string strparam)
		{
			return foo528(strparam.Replace("528", ""));
		}

		public string foo528(string strparam)
		{
			return foo529(strparam.Replace("529", ""));
		}

		public string foo529(string strparam)
		{
			return foo530(strparam.Replace("530", ""));
		}

		public string foo530(string strparam)
		{
			return foo531(strparam.Replace("531", ""));
		}

		public string foo531(string strparam)
		{
			return foo532(strparam.Replace("532", ""));
		}

		public string foo532(string strparam)
		{
			return foo533(strparam.Replace("533", ""));
		}

		public string foo533(string strparam)
		{
			return foo534(strparam.Replace("534", ""));
		}

		public string foo534(string strparam)
		{
			return foo535(strparam.Replace("535", ""));
		}

		public string foo535(string strparam)
		{
			return foo536(strparam.Replace("536", ""));
		}

		public string foo536(string strparam)
		{
			return foo537(strparam.Replace("537", ""));
		}

		public string foo537(string strparam)
		{
			return foo538(strparam.Replace("538", ""));
		}

		public string foo538(string strparam)
		{
			return foo539(strparam.Replace("539", ""));
		}

		public string foo539(string strparam)
		{
			return foo540(strparam.Replace("540", ""));
		}

		public string foo540(string strparam)
		{
			return foo541(strparam.Replace("541", ""));
		}

		public string foo541(string strparam)
		{
			return foo542(strparam.Replace("542", ""));
		}

		public string foo542(string strparam)
		{
			return foo543(strparam.Replace("543", ""));
		}

		public string foo543(string strparam)
		{
			return foo544(strparam.Replace("544", ""));
		}

		public string foo544(string strparam)
		{
			return foo545(strparam.Replace("545", ""));
		}

		public string foo545(string strparam)
		{
			return foo546(strparam.Replace("546", ""));
		}

		public string foo546(string strparam)
		{
			return foo547(strparam.Replace("547", ""));
		}

		public string foo547(string strparam)
		{
			return foo548(strparam.Replace("548", ""));
		}

		public string foo548(string strparam)
		{
			return foo549(strparam.Replace("549", ""));
		}

		public string foo549(string strparam)
		{
			return foo550(strparam.Replace("550", ""));
		}

		public string foo550(string strparam)
		{
			return foo551(strparam.Replace("551", ""));
		}

		public string foo551(string strparam)
		{
			return foo552(strparam.Replace("552", ""));
		}

		public string foo552(string strparam)
		{
			return foo553(strparam.Replace("553", ""));
		}

		public string foo553(string strparam)
		{
			return foo554(strparam.Replace("554", ""));
		}

		public string foo554(string strparam)
		{
			return foo555(strparam.Replace("555", ""));
		}

		public string foo555(string strparam)
		{
			return foo556(strparam.Replace("556", ""));
		}

		public string foo556(string strparam)
		{
			return foo557(strparam.Replace("557", ""));
		}

		public string foo557(string strparam)
		{
			return foo558(strparam.Replace("558", ""));
		}

		public string foo558(string strparam)
		{
			return foo559(strparam.Replace("559", ""));
		}

		public string foo559(string strparam)
		{
			return foo560(strparam.Replace("560", ""));
		}

		public string foo560(string strparam)
		{
			return foo561(strparam.Replace("561", ""));
		}

		public string foo561(string strparam)
		{
			return foo562(strparam.Replace("562", ""));
		}

		public string foo562(string strparam)
		{
			return foo563(strparam.Replace("563", ""));
		}

		public string foo563(string strparam)
		{
			return foo564(strparam.Replace("564", ""));
		}

		public string foo564(string strparam)
		{
			return foo565(strparam.Replace("565", ""));
		}

		public string foo565(string strparam)
		{
			return foo566(strparam.Replace("566", ""));
		}

		public string foo566(string strparam)
		{
			return foo567(strparam.Replace("567", ""));
		}

		public string foo567(string strparam)
		{
			return foo568(strparam.Replace("568", ""));
		}

		public string foo568(string strparam)
		{
			return foo569(strparam.Replace("569", ""));
		}

		public string foo569(string strparam)
		{
			return foo570(strparam.Replace("570", ""));
		}

		public string foo570(string strparam)
		{
			return foo571(strparam.Replace("571", ""));
		}

		public string foo571(string strparam)
		{
			return foo572(strparam.Replace("572", ""));
		}

		public string foo572(string strparam)
		{
			return foo573(strparam.Replace("573", ""));
		}

		public string foo573(string strparam)
		{
			return foo574(strparam.Replace("574", ""));
		}

		public string foo574(string strparam)
		{
			return foo575(strparam.Replace("575", ""));
		}

		public string foo575(string strparam)
		{
			return foo576(strparam.Replace("576", ""));
		}

		public string foo576(string strparam)
		{
			return foo577(strparam.Replace("577", ""));
		}

		public string foo577(string strparam)
		{
			return foo578(strparam.Replace("578", ""));
		}

		public string foo578(string strparam)
		{
			return foo579(strparam.Replace("579", ""));
		}

		public string foo579(string strparam)
		{
			return foo580(strparam.Replace("580", ""));
		}

		public string foo580(string strparam)
		{
			return foo581(strparam.Replace("581", ""));
		}

		public string foo581(string strparam)
		{
			return foo582(strparam.Replace("582", ""));
		}

		public string foo582(string strparam)
		{
			return foo583(strparam.Replace("583", ""));
		}

		public string foo583(string strparam)
		{
			return foo584(strparam.Replace("584", ""));
		}

		public string foo584(string strparam)
		{
			return foo585(strparam.Replace("585", ""));
		}

		public string foo585(string strparam)
		{
			return foo586(strparam.Replace("586", ""));
		}

		public string foo586(string strparam)
		{
			return foo587(strparam.Replace("587", ""));
		}

		public string foo587(string strparam)
		{
			return foo588(strparam.Replace("588", ""));
		}

		public string foo588(string strparam)
		{
			return foo589(strparam.Replace("589", ""));
		}

		public string foo589(string strparam)
		{
			return foo590(strparam.Replace("590", ""));
		}

		public string foo590(string strparam)
		{
			return foo591(strparam.Replace("591", ""));
		}

		public string foo591(string strparam)
		{
			return foo592(strparam.Replace("592", ""));
		}

		public string foo592(string strparam)
		{
			return foo593(strparam.Replace("593", ""));
		}

		public string foo593(string strparam)
		{
			return foo594(strparam.Replace("594", ""));
		}

		public string foo594(string strparam)
		{
			return foo595(strparam.Replace("595", ""));
		}

		public string foo595(string strparam)
		{
			return foo596(strparam.Replace("596", ""));
		}

		public string foo596(string strparam)
		{
			return foo597(strparam.Replace("597", ""));
		}

		public string foo597(string strparam)
		{
			return foo598(strparam.Replace("598", ""));
		}

		public string foo598(string strparam)
		{
			return foo599(strparam.Replace("599", ""));
		}

		public string foo599(string strparam)
		{
			return foo600(strparam.Replace("600", ""));
		}

		public string foo600(string strparam)
		{
			return foo601(strparam.Replace("601", ""));
		}

		public string foo601(string strparam)
		{
			return foo602(strparam.Replace("602", ""));
		}

		public string foo602(string strparam)
		{
			return foo603(strparam.Replace("603", ""));
		}

		public string foo603(string strparam)
		{
			return foo604(strparam.Replace("604", ""));
		}

		public string foo604(string strparam)
		{
			return foo605(strparam.Replace("605", ""));
		}

		public string foo605(string strparam)
		{
			return foo606(strparam.Replace("606", ""));
		}

		public string foo606(string strparam)
		{
			return foo607(strparam.Replace("607", ""));
		}

		public string foo607(string strparam)
		{
			return foo608(strparam.Replace("608", ""));
		}

		public string foo608(string strparam)
		{
			return foo609(strparam.Replace("609", ""));
		}

		public string foo609(string strparam)
		{
			return foo610(strparam.Replace("610", ""));
		}

		public string foo610(string strparam)
		{
			return foo611(strparam.Replace("611", ""));
		}

		public string foo611(string strparam)
		{
			return foo612(strparam.Replace("612", ""));
		}

		public string foo612(string strparam)
		{
			return foo613(strparam.Replace("613", ""));
		}

		public string foo613(string strparam)
		{
			return foo614(strparam.Replace("614", ""));
		}

		public string foo614(string strparam)
		{
			return foo615(strparam.Replace("615", ""));
		}

		public string foo615(string strparam)
		{
			return foo616(strparam.Replace("616", ""));
		}

		public string foo616(string strparam)
		{
			return foo617(strparam.Replace("617", ""));
		}

		public string foo617(string strparam)
		{
			return foo618(strparam.Replace("618", ""));
		}

		public string foo618(string strparam)
		{
			return foo619(strparam.Replace("619", ""));
		}

		public string foo619(string strparam)
		{
			return foo620(strparam.Replace("620", ""));
		}

		public string foo620(string strparam)
		{
			return foo621(strparam.Replace("621", ""));
		}

		public string foo621(string strparam)
		{
			return foo622(strparam.Replace("622", ""));
		}

		public string foo622(string strparam)
		{
			return foo623(strparam.Replace("623", ""));
		}

		public string foo623(string strparam)
		{
			return foo624(strparam.Replace("624", ""));
		}

		public string foo624(string strparam)
		{
			return foo625(strparam.Replace("625", ""));
		}

		public string foo625(string strparam)
		{
			return foo626(strparam.Replace("626", ""));
		}

		public string foo626(string strparam)
		{
			return foo627(strparam.Replace("627", ""));
		}

		public string foo627(string strparam)
		{
			return foo628(strparam.Replace("628", ""));
		}

		public string foo628(string strparam)
		{
			return foo629(strparam.Replace("629", ""));
		}

		public string foo629(string strparam)
		{
			return foo630(strparam.Replace("630", ""));
		}

		public string foo630(string strparam)
		{
			return foo631(strparam.Replace("631", ""));
		}

		public string foo631(string strparam)
		{
			return foo632(strparam.Replace("632", ""));
		}

		public string foo632(string strparam)
		{
			return foo633(strparam.Replace("633", ""));
		}

		public string foo633(string strparam)
		{
			return foo634(strparam.Replace("634", ""));
		}

		public string foo634(string strparam)
		{
			return foo635(strparam.Replace("635", ""));
		}

		public string foo635(string strparam)
		{
			return foo636(strparam.Replace("636", ""));
		}

		public string foo636(string strparam)
		{
			return foo637(strparam.Replace("637", ""));
		}

		public string foo637(string strparam)
		{
			return foo638(strparam.Replace("638", ""));
		}

		public string foo638(string strparam)
		{
			return foo639(strparam.Replace("639", ""));
		}

		public string foo639(string strparam)
		{
			return foo640(strparam.Replace("640", ""));
		}

		public string foo640(string strparam)
		{
			return foo641(strparam.Replace("641", ""));
		}

		public string foo641(string strparam)
		{
			return foo642(strparam.Replace("642", ""));
		}

		public string foo642(string strparam)
		{
			return foo643(strparam.Replace("643", ""));
		}

		public string foo643(string strparam)
		{
			return foo644(strparam.Replace("644", ""));
		}

		public string foo644(string strparam)
		{
			return foo645(strparam.Replace("645", ""));
		}

		public string foo645(string strparam)
		{
			return foo646(strparam.Replace("646", ""));
		}

		public string foo646(string strparam)
		{
			return foo647(strparam.Replace("647", ""));
		}

		public string foo647(string strparam)
		{
			return foo648(strparam.Replace("648", ""));
		}

		public string foo648(string strparam)
		{
			return foo649(strparam.Replace("649", ""));
		}

		public string foo649(string strparam)
		{
			return foo650(strparam.Replace("650", ""));
		}

		public string foo650(string strparam)
		{
			return foo651(strparam.Replace("651", ""));
		}

		public string foo651(string strparam)
		{
			return foo652(strparam.Replace("652", ""));
		}

		public string foo652(string strparam)
		{
			return foo653(strparam.Replace("653", ""));
		}

		public string foo653(string strparam)
		{
			return foo654(strparam.Replace("654", ""));
		}

		public string foo654(string strparam)
		{
			return foo655(strparam.Replace("655", ""));
		}

		public string foo655(string strparam)
		{
			return foo656(strparam.Replace("656", ""));
		}

		public string foo656(string strparam)
		{
			return foo657(strparam.Replace("657", ""));
		}

		public string foo657(string strparam)
		{
			return foo658(strparam.Replace("658", ""));
		}

		public string foo658(string strparam)
		{
			return foo659(strparam.Replace("659", ""));
		}

		public string foo659(string strparam)
		{
			return foo660(strparam.Replace("660", ""));
		}

		public string foo660(string strparam)
		{
			return foo661(strparam.Replace("661", ""));
		}

		public string foo661(string strparam)
		{
			return foo662(strparam.Replace("662", ""));
		}

		public string foo662(string strparam)
		{
			return foo663(strparam.Replace("663", ""));
		}

		public string foo663(string strparam)
		{
			return foo664(strparam.Replace("664", ""));
		}

		public string foo664(string strparam)
		{
			return foo665(strparam.Replace("665", ""));
		}

		public string foo665(string strparam)
		{
			return foo666(strparam.Replace("666", ""));
		}

		public string foo666(string strparam)
		{
			return foo667(strparam.Replace("667", ""));
		}

		public string foo667(string strparam)
		{
			return foo668(strparam.Replace("668", ""));
		}

		public string foo668(string strparam)
		{
			return foo669(strparam.Replace("669", ""));
		}

		public string foo669(string strparam)
		{
			return foo670(strparam.Replace("670", ""));
		}

		public string foo670(string strparam)
		{
			return foo671(strparam.Replace("671", ""));
		}

		public string foo671(string strparam)
		{
			return foo672(strparam.Replace("672", ""));
		}

		public string foo672(string strparam)
		{
			return foo673(strparam.Replace("673", ""));
		}

		public string foo673(string strparam)
		{
			return foo674(strparam.Replace("674", ""));
		}

		public string foo674(string strparam)
		{
			return foo675(strparam.Replace("675", ""));
		}

		public string foo675(string strparam)
		{
			return foo676(strparam.Replace("676", ""));
		}

		public string foo676(string strparam)
		{
			return foo677(strparam.Replace("677", ""));
		}

		public string foo677(string strparam)
		{
			return foo678(strparam.Replace("678", ""));
		}

		public string foo678(string strparam)
		{
			return foo679(strparam.Replace("679", ""));
		}

		public string foo679(string strparam)
		{
			return foo680(strparam.Replace("680", ""));
		}

		public string foo680(string strparam)
		{
			return foo681(strparam.Replace("681", ""));
		}

		public string foo681(string strparam)
		{
			return foo682(strparam.Replace("682", ""));
		}

		public string foo682(string strparam)
		{
			return foo683(strparam.Replace("683", ""));
		}

		public string foo683(string strparam)
		{
			return foo684(strparam.Replace("684", ""));
		}

		public string foo684(string strparam)
		{
			return foo685(strparam.Replace("685", ""));
		}

		public string foo685(string strparam)
		{
			return foo686(strparam.Replace("686", ""));
		}

		public string foo686(string strparam)
		{
			return foo687(strparam.Replace("687", ""));
		}

		public string foo687(string strparam)
		{
			return foo688(strparam.Replace("688", ""));
		}

		public string foo688(string strparam)
		{
			return foo689(strparam.Replace("689", ""));
		}

		public string foo689(string strparam)
		{
			return foo690(strparam.Replace("690", ""));
		}

		public string foo690(string strparam)
		{
			return foo691(strparam.Replace("691", ""));
		}

		public string foo691(string strparam)
		{
			return foo692(strparam.Replace("692", ""));
		}

		public string foo692(string strparam)
		{
			return foo693(strparam.Replace("693", ""));
		}

		public string foo693(string strparam)
		{
			return foo694(strparam.Replace("694", ""));
		}

		public string foo694(string strparam)
		{
			return foo695(strparam.Replace("695", ""));
		}

		public string foo695(string strparam)
		{
			return foo696(strparam.Replace("696", ""));
		}

		public string foo696(string strparam)
		{
			return foo697(strparam.Replace("697", ""));
		}

		public string foo697(string strparam)
		{
			return foo698(strparam.Replace("698", ""));
		}

		public string foo698(string strparam)
		{
			return foo699(strparam.Replace("699", ""));
		}

		public string foo699(string strparam)
		{
			return foo700(strparam.Replace("700", ""));
		}

		public string foo700(string strparam)
		{
			return foo701(strparam.Replace("701", ""));
		}

		public string foo701(string strparam)
		{
			return foo702(strparam.Replace("702", ""));
		}

		public string foo702(string strparam)
		{
			return foo703(strparam.Replace("703", ""));
		}

		public string foo703(string strparam)
		{
			return foo704(strparam.Replace("704", ""));
		}

		public string foo704(string strparam)
		{
			return foo705(strparam.Replace("705", ""));
		}

		public string foo705(string strparam)
		{
			return foo706(strparam.Replace("706", ""));
		}

		public string foo706(string strparam)
		{
			return foo707(strparam.Replace("707", ""));
		}

		public string foo707(string strparam)
		{
			return foo708(strparam.Replace("708", ""));
		}

		public string foo708(string strparam)
		{
			return foo709(strparam.Replace("709", ""));
		}

		public string foo709(string strparam)
		{
			return foo710(strparam.Replace("710", ""));
		}

		public string foo710(string strparam)
		{
			return foo711(strparam.Replace("711", ""));
		}

		public string foo711(string strparam)
		{
			return foo712(strparam.Replace("712", ""));
		}

		public string foo712(string strparam)
		{
			return foo713(strparam.Replace("713", ""));
		}

		public string foo713(string strparam)
		{
			return foo714(strparam.Replace("714", ""));
		}

		public string foo714(string strparam)
		{
			return foo715(strparam.Replace("715", ""));
		}

		public string foo715(string strparam)
		{
			return foo716(strparam.Replace("716", ""));
		}

		public string foo716(string strparam)
		{
			return foo717(strparam.Replace("717", ""));
		}

		public string foo717(string strparam)
		{
			return foo718(strparam.Replace("718", ""));
		}

		public string foo718(string strparam)
		{
			return foo719(strparam.Replace("719", ""));
		}

		public string foo719(string strparam)
		{
			return foo720(strparam.Replace("720", ""));
		}

		public string foo720(string strparam)
		{
			return foo721(strparam.Replace("721", ""));
		}

		public string foo721(string strparam)
		{
			return foo722(strparam.Replace("722", ""));
		}

		public string foo722(string strparam)
		{
			return foo723(strparam.Replace("723", ""));
		}

		public string foo723(string strparam)
		{
			return foo724(strparam.Replace("724", ""));
		}

		public string foo724(string strparam)
		{
			return foo725(strparam.Replace("725", ""));
		}

		public string foo725(string strparam)
		{
			return foo726(strparam.Replace("726", ""));
		}

		public string foo726(string strparam)
		{
			return foo727(strparam.Replace("727", ""));
		}

		public string foo727(string strparam)
		{
			return foo728(strparam.Replace("728", ""));
		}

		public string foo728(string strparam)
		{
			return foo729(strparam.Replace("729", ""));
		}

		public string foo729(string strparam)
		{
			return foo730(strparam.Replace("730", ""));
		}

		public string foo730(string strparam)
		{
			return foo731(strparam.Replace("731", ""));
		}

		public string foo731(string strparam)
		{
			return foo732(strparam.Replace("732", ""));
		}

		public string foo732(string strparam)
		{
			return foo733(strparam.Replace("733", ""));
		}

		public string foo733(string strparam)
		{
			return foo734(strparam.Replace("734", ""));
		}

		public string foo734(string strparam)
		{
			return foo735(strparam.Replace("735", ""));
		}

		public string foo735(string strparam)
		{
			return foo736(strparam.Replace("736", ""));
		}

		public string foo736(string strparam)
		{
			return foo737(strparam.Replace("737", ""));
		}

		public string foo737(string strparam)
		{
			return foo738(strparam.Replace("738", ""));
		}

		public string foo738(string strparam)
		{
			return foo739(strparam.Replace("739", ""));
		}

		public string foo739(string strparam)
		{
			return foo740(strparam.Replace("740", ""));
		}

		public string foo740(string strparam)
		{
			return foo741(strparam.Replace("741", ""));
		}

		public string foo741(string strparam)
		{
			return foo742(strparam.Replace("742", ""));
		}

		public string foo742(string strparam)
		{
			return foo743(strparam.Replace("743", ""));
		}

		public string foo743(string strparam)
		{
			return foo744(strparam.Replace("744", ""));
		}

		public string foo744(string strparam)
		{
			return foo745(strparam.Replace("745", ""));
		}

		public string foo745(string strparam)
		{
			return foo746(strparam.Replace("746", ""));
		}

		public string foo746(string strparam)
		{
			return foo747(strparam.Replace("747", ""));
		}

		public string foo747(string strparam)
		{
			return foo748(strparam.Replace("748", ""));
		}

		public string foo748(string strparam)
		{
			return foo749(strparam.Replace("749", ""));
		}

		public string foo749(string strparam)
		{
			return foo750(strparam.Replace("750", ""));
		}

		public string foo750(string strparam)
		{
			return foo751(strparam.Replace("751", ""));
		}

		public string foo751(string strparam)
		{
			return foo752(strparam.Replace("752", ""));
		}

		public string foo752(string strparam)
		{
			return foo753(strparam.Replace("753", ""));
		}

		public string foo753(string strparam)
		{
			return foo754(strparam.Replace("754", ""));
		}

		public string foo754(string strparam)
		{
			return foo755(strparam.Replace("755", ""));
		}

		public string foo755(string strparam)
		{
			return foo756(strparam.Replace("756", ""));
		}

		public string foo756(string strparam)
		{
			return foo757(strparam.Replace("757", ""));
		}

		public string foo757(string strparam)
		{
			return foo758(strparam.Replace("758", ""));
		}

		public string foo758(string strparam)
		{
			return foo759(strparam.Replace("759", ""));
		}

		public string foo759(string strparam)
		{
			return foo760(strparam.Replace("760", ""));
		}

		public string foo760(string strparam)
		{
			return foo761(strparam.Replace("761", ""));
		}

		public string foo761(string strparam)
		{
			return foo762(strparam.Replace("762", ""));
		}

		public string foo762(string strparam)
		{
			return foo763(strparam.Replace("763", ""));
		}

		public string foo763(string strparam)
		{
			return foo764(strparam.Replace("764", ""));
		}

		public string foo764(string strparam)
		{
			return foo765(strparam.Replace("765", ""));
		}

		public string foo765(string strparam)
		{
			return foo766(strparam.Replace("766", ""));
		}

		public string foo766(string strparam)
		{
			return foo767(strparam.Replace("767", ""));
		}

		public string foo767(string strparam)
		{
			return foo768(strparam.Replace("768", ""));
		}

		public string foo768(string strparam)
		{
			return foo769(strparam.Replace("769", ""));
		}

		public string foo769(string strparam)
		{
			return foo770(strparam.Replace("770", ""));
		}

		public string foo770(string strparam)
		{
			return foo771(strparam.Replace("771", ""));
		}

		public string foo771(string strparam)
		{
			return foo772(strparam.Replace("772", ""));
		}

		public string foo772(string strparam)
		{
			return foo773(strparam.Replace("773", ""));
		}

		public string foo773(string strparam)
		{
			return foo774(strparam.Replace("774", ""));
		}

		public string foo774(string strparam)
		{
			return foo775(strparam.Replace("775", ""));
		}

		public string foo775(string strparam)
		{
			return foo776(strparam.Replace("776", ""));
		}

		public string foo776(string strparam)
		{
			return foo777(strparam.Replace("777", ""));
		}

		public string foo777(string strparam)
		{
			return foo778(strparam.Replace("778", ""));
		}

		public string foo778(string strparam)
		{
			return foo779(strparam.Replace("779", ""));
		}

		public string foo779(string strparam)
		{
			return foo780(strparam.Replace("780", ""));
		}

		public string foo780(string strparam)
		{
			return foo781(strparam.Replace("781", ""));
		}

		public string foo781(string strparam)
		{
			return foo782(strparam.Replace("782", ""));
		}

		public string foo782(string strparam)
		{
			return foo783(strparam.Replace("783", ""));
		}

		public string foo783(string strparam)
		{
			return foo784(strparam.Replace("784", ""));
		}

		public string foo784(string strparam)
		{
			return foo785(strparam.Replace("785", ""));
		}

		public string foo785(string strparam)
		{
			return foo786(strparam.Replace("786", ""));
		}

		public string foo786(string strparam)
		{
			return foo787(strparam.Replace("787", ""));
		}

		public string foo787(string strparam)
		{
			return foo788(strparam.Replace("788", ""));
		}

		public string foo788(string strparam)
		{
			return foo789(strparam.Replace("789", ""));
		}

		public string foo789(string strparam)
		{
			return foo790(strparam.Replace("790", ""));
		}

		public string foo790(string strparam)
		{
			return foo791(strparam.Replace("791", ""));
		}

		public string foo791(string strparam)
		{
			return foo792(strparam.Replace("792", ""));
		}

		public string foo792(string strparam)
		{
			return foo793(strparam.Replace("793", ""));
		}

		public string foo793(string strparam)
		{
			return foo794(strparam.Replace("794", ""));
		}

		public string foo794(string strparam)
		{
			return foo795(strparam.Replace("795", ""));
		}

		public string foo795(string strparam)
		{
			return foo796(strparam.Replace("796", ""));
		}

		public string foo796(string strparam)
		{
			return foo797(strparam.Replace("797", ""));
		}

		public string foo797(string strparam)
		{
			return foo798(strparam.Replace("798", ""));
		}

		public string foo798(string strparam)
		{
			return foo799(strparam.Replace("799", ""));
		}

		public string foo799(string strparam)
		{
			return foo800(strparam.Replace("800", ""));
		}

		public string foo800(string strparam)
		{
			return foo801(strparam.Replace("801", ""));
		}

		public string foo801(string strparam)
		{
			return foo802(strparam.Replace("802", ""));
		}

		public string foo802(string strparam)
		{
			return foo803(strparam.Replace("803", ""));
		}

		public string foo803(string strparam)
		{
			return foo804(strparam.Replace("804", ""));
		}

		public string foo804(string strparam)
		{
			return foo805(strparam.Replace("805", ""));
		}

		public string foo805(string strparam)
		{
			return foo806(strparam.Replace("806", ""));
		}

		public string foo806(string strparam)
		{
			return foo807(strparam.Replace("807", ""));
		}

		public string foo807(string strparam)
		{
			return foo808(strparam.Replace("808", ""));
		}

		public string foo808(string strparam)
		{
			return foo809(strparam.Replace("809", ""));
		}

		public string foo809(string strparam)
		{
			return foo810(strparam.Replace("810", ""));
		}

		public string foo810(string strparam)
		{
			return foo811(strparam.Replace("811", ""));
		}

		public string foo811(string strparam)
		{
			return foo812(strparam.Replace("812", ""));
		}

		public string foo812(string strparam)
		{
			return foo813(strparam.Replace("813", ""));
		}

		public string foo813(string strparam)
		{
			return foo814(strparam.Replace("814", ""));
		}

		public string foo814(string strparam)
		{
			return foo815(strparam.Replace("815", ""));
		}

		public string foo815(string strparam)
		{
			return foo816(strparam.Replace("816", ""));
		}

		public string foo816(string strparam)
		{
			return foo817(strparam.Replace("817", ""));
		}

		public string foo817(string strparam)
		{
			return foo818(strparam.Replace("818", ""));
		}

		public string foo818(string strparam)
		{
			return foo819(strparam.Replace("819", ""));
		}

		public string foo819(string strparam)
		{
			return foo820(strparam.Replace("820", ""));
		}

		public string foo820(string strparam)
		{
			return foo821(strparam.Replace("821", ""));
		}

		public string foo821(string strparam)
		{
			return foo822(strparam.Replace("822", ""));
		}

		public string foo822(string strparam)
		{
			return foo823(strparam.Replace("823", ""));
		}

		public string foo823(string strparam)
		{
			return foo824(strparam.Replace("824", ""));
		}

		public string foo824(string strparam)
		{
			return foo825(strparam.Replace("825", ""));
		}

		public string foo825(string strparam)
		{
			return foo826(strparam.Replace("826", ""));
		}

		public string foo826(string strparam)
		{
			return foo827(strparam.Replace("827", ""));
		}

		public string foo827(string strparam)
		{
			return foo828(strparam.Replace("828", ""));
		}

		public string foo828(string strparam)
		{
			return foo829(strparam.Replace("829", ""));
		}

		public string foo829(string strparam)
		{
			return foo830(strparam.Replace("830", ""));
		}

		public string foo830(string strparam)
		{
			return foo831(strparam.Replace("831", ""));
		}

		public string foo831(string strparam)
		{
			return foo832(strparam.Replace("832", ""));
		}

		public string foo832(string strparam)
		{
			return foo833(strparam.Replace("833", ""));
		}

		public string foo833(string strparam)
		{
			return foo834(strparam.Replace("834", ""));
		}

		public string foo834(string strparam)
		{
			return foo835(strparam.Replace("835", ""));
		}

		public string foo835(string strparam)
		{
			return foo836(strparam.Replace("836", ""));
		}

		public string foo836(string strparam)
		{
			return foo837(strparam.Replace("837", ""));
		}

		public string foo837(string strparam)
		{
			return foo838(strparam.Replace("838", ""));
		}

		public string foo838(string strparam)
		{
			return foo839(strparam.Replace("839", ""));
		}

		public string foo839(string strparam)
		{
			return foo840(strparam.Replace("840", ""));
		}

		public string foo840(string strparam)
		{
			return foo841(strparam.Replace("841", ""));
		}

		public string foo841(string strparam)
		{
			return foo842(strparam.Replace("842", ""));
		}

		public string foo842(string strparam)
		{
			return foo843(strparam.Replace("843", ""));
		}

		public string foo843(string strparam)
		{
			return foo844(strparam.Replace("844", ""));
		}

		public string foo844(string strparam)
		{
			return foo845(strparam.Replace("845", ""));
		}

		public string foo845(string strparam)
		{
			return foo846(strparam.Replace("846", ""));
		}

		public string foo846(string strparam)
		{
			return foo847(strparam.Replace("847", ""));
		}

		public string foo847(string strparam)
		{
			return foo848(strparam.Replace("848", ""));
		}

		public string foo848(string strparam)
		{
			return foo849(strparam.Replace("849", ""));
		}

		public string foo849(string strparam)
		{
			return foo850(strparam.Replace("850", ""));
		}

		public string foo850(string strparam)
		{
			return foo851(strparam.Replace("851", ""));
		}

		public string foo851(string strparam)
		{
			return foo852(strparam.Replace("852", ""));
		}

		public string foo852(string strparam)
		{
			return foo853(strparam.Replace("853", ""));
		}

		public string foo853(string strparam)
		{
			return foo854(strparam.Replace("854", ""));
		}

		public string foo854(string strparam)
		{
			return foo855(strparam.Replace("855", ""));
		}

		public string foo855(string strparam)
		{
			return foo856(strparam.Replace("856", ""));
		}

		public string foo856(string strparam)
		{
			return foo857(strparam.Replace("857", ""));
		}

		public string foo857(string strparam)
		{
			return foo858(strparam.Replace("858", ""));
		}

		public string foo858(string strparam)
		{
			return foo859(strparam.Replace("859", ""));
		}

		public string foo859(string strparam)
		{
			return foo860(strparam.Replace("860", ""));
		}

		public string foo860(string strparam)
		{
			return foo861(strparam.Replace("861", ""));
		}

		public string foo861(string strparam)
		{
			return foo862(strparam.Replace("862", ""));
		}

		public string foo862(string strparam)
		{
			return foo863(strparam.Replace("863", ""));
		}

		public string foo863(string strparam)
		{
			return foo864(strparam.Replace("864", ""));
		}

		public string foo864(string strparam)
		{
			return foo865(strparam.Replace("865", ""));
		}

		public string foo865(string strparam)
		{
			return foo866(strparam.Replace("866", ""));
		}

		public string foo866(string strparam)
		{
			return foo867(strparam.Replace("867", ""));
		}

		public string foo867(string strparam)
		{
			return foo868(strparam.Replace("868", ""));
		}

		public string foo868(string strparam)
		{
			return foo869(strparam.Replace("869", ""));
		}

		public string foo869(string strparam)
		{
			return foo870(strparam.Replace("870", ""));
		}

		public string foo870(string strparam)
		{
			return foo871(strparam.Replace("871", ""));
		}

		public string foo871(string strparam)
		{
			return foo872(strparam.Replace("872", ""));
		}

		public string foo872(string strparam)
		{
			return foo873(strparam.Replace("873", ""));
		}

		public string foo873(string strparam)
		{
			return foo874(strparam.Replace("874", ""));
		}

		public string foo874(string strparam)
		{
			return foo875(strparam.Replace("875", ""));
		}

		public string foo875(string strparam)
		{
			return foo876(strparam.Replace("876", ""));
		}

		public string foo876(string strparam)
		{
			return foo877(strparam.Replace("877", ""));
		}

		public string foo877(string strparam)
		{
			return foo878(strparam.Replace("878", ""));
		}

		public string foo878(string strparam)
		{
			return foo879(strparam.Replace("879", ""));
		}

		public string foo879(string strparam)
		{
			return foo880(strparam.Replace("880", ""));
		}

		public string foo880(string strparam)
		{
			return foo881(strparam.Replace("881", ""));
		}

		public string foo881(string strparam)
		{
			return foo882(strparam.Replace("882", ""));
		}

		public string foo882(string strparam)
		{
			return foo883(strparam.Replace("883", ""));
		}

		public string foo883(string strparam)
		{
			return foo884(strparam.Replace("884", ""));
		}

		public string foo884(string strparam)
		{
			return foo885(strparam.Replace("885", ""));
		}

		public string foo885(string strparam)
		{
			return foo886(strparam.Replace("886", ""));
		}

		public string foo886(string strparam)
		{
			return foo887(strparam.Replace("887", ""));
		}

		public string foo887(string strparam)
		{
			return foo888(strparam.Replace("888", ""));
		}

		public string foo888(string strparam)
		{
			return foo889(strparam.Replace("889", ""));
		}

		public string foo889(string strparam)
		{
			return foo890(strparam.Replace("890", ""));
		}

		public string foo890(string strparam)
		{
			return foo891(strparam.Replace("891", ""));
		}

		public string foo891(string strparam)
		{
			return foo892(strparam.Replace("892", ""));
		}

		public string foo892(string strparam)
		{
			return foo893(strparam.Replace("893", ""));
		}

		public string foo893(string strparam)
		{
			return foo894(strparam.Replace("894", ""));
		}

		public string foo894(string strparam)
		{
			return foo895(strparam.Replace("895", ""));
		}

		public string foo895(string strparam)
		{
			return foo896(strparam.Replace("896", ""));
		}

		public string foo896(string strparam)
		{
			return foo897(strparam.Replace("897", ""));
		}

		public string foo897(string strparam)
		{
			return foo898(strparam.Replace("898", ""));
		}

		public string foo898(string strparam)
		{
			return foo899(strparam.Replace("899", ""));
		}

		public string foo899(string strparam)
		{
			return foo900(strparam.Replace("900", ""));
		}

		public string foo900(string strparam)
		{
			return foo901(strparam.Replace("901", ""));
		}

		public string foo901(string strparam)
		{
			return foo902(strparam.Replace("902", ""));
		}

		public string foo902(string strparam)
		{
			return foo903(strparam.Replace("903", ""));
		}

		public string foo903(string strparam)
		{
			return foo904(strparam.Replace("904", ""));
		}

		public string foo904(string strparam)
		{
			return foo905(strparam.Replace("905", ""));
		}

		public string foo905(string strparam)
		{
			return foo906(strparam.Replace("906", ""));
		}

		public string foo906(string strparam)
		{
			return foo907(strparam.Replace("907", ""));
		}

		public string foo907(string strparam)
		{
			return foo908(strparam.Replace("908", ""));
		}

		public string foo908(string strparam)
		{
			return foo909(strparam.Replace("909", ""));
		}

		public string foo909(string strparam)
		{
			return foo910(strparam.Replace("910", ""));
		}

		public string foo910(string strparam)
		{
			return foo911(strparam.Replace("911", ""));
		}

		public string foo911(string strparam)
		{
			return foo912(strparam.Replace("912", ""));
		}

		public string foo912(string strparam)
		{
			return foo913(strparam.Replace("913", ""));
		}

		public string foo913(string strparam)
		{
			return foo914(strparam.Replace("914", ""));
		}

		public string foo914(string strparam)
		{
			return foo915(strparam.Replace("915", ""));
		}

		public string foo915(string strparam)
		{
			return foo916(strparam.Replace("916", ""));
		}

		public string foo916(string strparam)
		{
			return foo917(strparam.Replace("917", ""));
		}

		public string foo917(string strparam)
		{
			return foo918(strparam.Replace("918", ""));
		}

		public string foo918(string strparam)
		{
			return foo919(strparam.Replace("919", ""));
		}

		public string foo919(string strparam)
		{
			return foo920(strparam.Replace("920", ""));
		}

		public string foo920(string strparam)
		{
			return foo921(strparam.Replace("921", ""));
		}

		public string foo921(string strparam)
		{
			return foo922(strparam.Replace("922", ""));
		}

		public string foo922(string strparam)
		{
			return foo923(strparam.Replace("923", ""));
		}

		public string foo923(string strparam)
		{
			return foo924(strparam.Replace("924", ""));
		}

		public string foo924(string strparam)
		{
			return foo925(strparam.Replace("925", ""));
		}

		public string foo925(string strparam)
		{
			return foo926(strparam.Replace("926", ""));
		}

		public string foo926(string strparam)
		{
			return foo927(strparam.Replace("927", ""));
		}

		public string foo927(string strparam)
		{
			return foo928(strparam.Replace("928", ""));
		}

		public string foo928(string strparam)
		{
			return foo929(strparam.Replace("929", ""));
		}

		public string foo929(string strparam)
		{
			return foo930(strparam.Replace("930", ""));
		}

		public string foo930(string strparam)
		{
			return foo931(strparam.Replace("931", ""));
		}

		public string foo931(string strparam)
		{
			return foo932(strparam.Replace("932", ""));
		}

		public string foo932(string strparam)
		{
			return foo933(strparam.Replace("933", ""));
		}

		public string foo933(string strparam)
		{
			return foo934(strparam.Replace("934", ""));
		}

		public string foo934(string strparam)
		{
			return foo935(strparam.Replace("935", ""));
		}

		public string foo935(string strparam)
		{
			return foo936(strparam.Replace("936", ""));
		}

		public string foo936(string strparam)
		{
			return foo937(strparam.Replace("937", ""));
		}

		public string foo937(string strparam)
		{
			return foo938(strparam.Replace("938", ""));
		}

		public string foo938(string strparam)
		{
			return foo939(strparam.Replace("939", ""));
		}

		public string foo939(string strparam)
		{
			return foo940(strparam.Replace("940", ""));
		}

		public string foo940(string strparam)
		{
			return foo941(strparam.Replace("941", ""));
		}

		public string foo941(string strparam)
		{
			return foo942(strparam.Replace("942", ""));
		}

		public string foo942(string strparam)
		{
			return foo943(strparam.Replace("943", ""));
		}

		public string foo943(string strparam)
		{
			return foo944(strparam.Replace("944", ""));
		}

		public string foo944(string strparam)
		{
			return foo945(strparam.Replace("945", ""));
		}

		public string foo945(string strparam)
		{
			return foo946(strparam.Replace("946", ""));
		}

		public string foo946(string strparam)
		{
			return foo947(strparam.Replace("947", ""));
		}

		public string foo947(string strparam)
		{
			return foo948(strparam.Replace("948", ""));
		}

		public string foo948(string strparam)
		{
			return foo949(strparam.Replace("949", ""));
		}

		public string foo949(string strparam)
		{
			return foo950(strparam.Replace("950", ""));
		}

		public string foo950(string strparam)
		{
			return foo951(strparam.Replace("951", ""));
		}

		public string foo951(string strparam)
		{
			return foo952(strparam.Replace("952", ""));
		}

		public string foo952(string strparam)
		{
			return foo953(strparam.Replace("953", ""));
		}

		public string foo953(string strparam)
		{
			return foo954(strparam.Replace("954", ""));
		}

		public string foo954(string strparam)
		{
			return foo955(strparam.Replace("955", ""));
		}

		public string foo955(string strparam)
		{
			return foo956(strparam.Replace("956", ""));
		}

		public string foo956(string strparam)
		{
			return foo957(strparam.Replace("957", ""));
		}

		public string foo957(string strparam)
		{
			return foo958(strparam.Replace("958", ""));
		}

		public string foo958(string strparam)
		{
			return foo959(strparam.Replace("959", ""));
		}

		public string foo959(string strparam)
		{
			return foo960(strparam.Replace("960", ""));
		}

		public string foo960(string strparam)
		{
			return foo961(strparam.Replace("961", ""));
		}

		public string foo961(string strparam)
		{
			return foo962(strparam.Replace("962", ""));
		}

		public string foo962(string strparam)
		{
			return foo963(strparam.Replace("963", ""));
		}

		public string foo963(string strparam)
		{
			return foo964(strparam.Replace("964", ""));
		}

		public string foo964(string strparam)
		{
			return foo965(strparam.Replace("965", ""));
		}

		public string foo965(string strparam)
		{
			return foo966(strparam.Replace("966", ""));
		}

		public string foo966(string strparam)
		{
			return foo967(strparam.Replace("967", ""));
		}

		public string foo967(string strparam)
		{
			return foo968(strparam.Replace("968", ""));
		}

		public string foo968(string strparam)
		{
			return foo969(strparam.Replace("969", ""));
		}

		public string foo969(string strparam)
		{
			return foo970(strparam.Replace("970", ""));
		}

		public string foo970(string strparam)
		{
			return foo971(strparam.Replace("971", ""));
		}

		public string foo971(string strparam)
		{
			return foo972(strparam.Replace("972", ""));
		}

		public string foo972(string strparam)
		{
			return foo973(strparam.Replace("973", ""));
		}

		public string foo973(string strparam)
		{
			return foo974(strparam.Replace("974", ""));
		}

		public string foo974(string strparam)
		{
			return foo975(strparam.Replace("975", ""));
		}

		public string foo975(string strparam)
		{
			return foo976(strparam.Replace("976", ""));
		}

		public string foo976(string strparam)
		{
			return foo977(strparam.Replace("977", ""));
		}

		public string foo977(string strparam)
		{
			return foo978(strparam.Replace("978", ""));
		}

		public string foo978(string strparam)
		{
			return foo979(strparam.Replace("979", ""));
		}

		public string foo979(string strparam)
		{
			return foo980(strparam.Replace("980", ""));
		}

		public string foo980(string strparam)
		{
			return foo981(strparam.Replace("981", ""));
		}

		public string foo981(string strparam)
		{
			return foo982(strparam.Replace("982", ""));
		}

		public string foo982(string strparam)
		{
			return foo983(strparam.Replace("983", ""));
		}

		public string foo983(string strparam)
		{
			return foo984(strparam.Replace("984", ""));
		}

		public string foo984(string strparam)
		{
			return foo985(strparam.Replace("985", ""));
		}

		public string foo985(string strparam)
		{
			return foo986(strparam.Replace("986", ""));
		}

		public string foo986(string strparam)
		{
			return foo987(strparam.Replace("987", ""));
		}

		public string foo987(string strparam)
		{
			return foo988(strparam.Replace("988", ""));
		}

		public string foo988(string strparam)
		{
			return foo989(strparam.Replace("989", ""));
		}

		public string foo989(string strparam)
		{
			return foo990(strparam.Replace("990", ""));
		}

		public string foo990(string strparam)
		{
			return foo991(strparam.Replace("991", ""));
		}

		public string foo991(string strparam)
		{
			return foo992(strparam.Replace("992", ""));
		}

		public string foo992(string strparam)
		{
			return foo993(strparam.Replace("993", ""));
		}

		public string foo993(string strparam)
		{
			return foo994(strparam.Replace("994", ""));
		}

		public string foo994(string strparam)
		{
			return foo995(strparam.Replace("995", ""));
		}

		public string foo995(string strparam)
		{
			return foo996(strparam.Replace("996", ""));
		}

		public string foo996(string strparam)
		{
			return foo997(strparam.Replace("997", ""));
		}

		public string foo997(string strparam)
		{
			return foo998(strparam.Replace("998", ""));
		}

		public string foo998(string strparam)
		{
			return foo999(strparam.Replace("999", ""));
		}

		public string foo999(string strparam)
		{
			return foo1000(strparam.Replace("1000", ""));
		}

		public string foo1000(string strparam)
		{
			return strparam;
		}

	}
}