using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// 固定时间格式转换成时间
        /// </summary>
        /// <param name="convertStr">需要转换的str</param>
        /// <param name="strFormat">str 的格式</param>
        /// <returns></returns>
        public static DateTime? ConvertToDateTime(string convertStr, string strFormat)
        {
            DateTime? dt = null;
            DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();
            dtFormat.ShortDatePattern = strFormat;
            try
            {
                dt = Convert.ToDateTime(convertStr, dtFormat);
                return dt;
            }
            catch (Exception)
            {
                //Log.WriteInfoLog(typeof(DateTimeHelper), "字符串转日期失败：" + e);
                return dt;
            }
        }

        public static DateTime? ConvertToDateTime(string converStr)
        {
            if (string.IsNullOrEmpty(converStr))
            {
                if (DateTime.TryParse(converStr, out DateTime date))
                    return date;
            }

            return null;
        }
        /// <summary>
        /// 时间戳转换成日期字符串 "yyyy/MM/dd"
        /// </summary>
        /// <param name="timeStamp">时间戳</param>
        /// <returns></returns>
        public static string TimestampConvertToDateStr(string timeStamp)
        {
            var dateTime = TimestampConvertToDateTime(timeStamp);

            return dateTime.HasValue ? dateTime.Value.ToString("yyyy/MM/dd") : "";
        }
        /// <summary>
        /// 时间戳转换成日期字符串 "yyyy年MM月dd日"
        /// </summary>
        /// <param name="timeStamp">时间戳</param>
        /// <returns></returns>
        public static string TimestampConvertToDateStrTwo(string timeStamp)
        {
            var dateTime = TimestampConvertToDateTime(timeStamp);

            return dateTime.HasValue ? dateTime.Value.ToString("yyyy年MM月dd日") : "";
        }
        /// <summary>
        /// 时间戳转换成时间格式
        /// </summary>
        /// <param name="timeStamp">需要转换的时间戳字符串</param>
        /// <returns>转换的时间戳</returns>
        public static DateTime? TimestampConvertToDateTime(string timeStamp)
        {
            if (string.IsNullOrEmpty(timeStamp))
                return null;
            DateTime result;
            if (DateTime.TryParse(timeStamp, out result))
                return result;
            try
            {
                DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                long lTime = long.Parse(timeStamp + "0000");
                TimeSpan toNow = new TimeSpan(lTime);
                return dtStart.Add(toNow);
            }
            catch (Exception)
            {
                //Log.WriteErrorLog(typeof(DateTimeHelper), "", e);
                return null;
            }

        }
        /// <summary>  
        /// DateTime时间格式转换为Unix时间戳格式  
        /// </summary>  
        /// <param name="time">时间</param>  
        public static string DateTimeConvertToTimestamp(System.DateTime? time)
        {
            string result = "";
            if (time.HasValue)
            {
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
                long t = (time.Value.Ticks - startTime.Ticks) / 10000;   //除10000调整为13位   
                result = t.ToString();
            }
            return result;
        }
        /// <summary>  
        /// DateTime时间格式转换为yyyy-MM-dd HH:mm:ss格式  
        /// </summary>  
        /// <param name="time">时间</param>  
        public static string DateTimeConvertToString(System.DateTime? time)
        {
            string result = "";
            if (time.HasValue)
            {
                DateTime startTime = (DateTime)time;
                result = startTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return result;
        }


        #region 农历
        private static ChineseLunisolarCalendar china = new ChineseLunisolarCalendar();
        private static Hashtable gHoliday = new Hashtable();
        private static Hashtable nHoliday = new Hashtable();
        private static string[] JQ = { "小寒", "大寒", "立春", "雨水", "惊蛰", "春分", "清明", "谷雨", "立夏", "小满", "芒种", "夏至", "小暑", "大暑", "立秋", "处暑", "白露", "秋分", "寒露", "霜降", "立冬", "小雪", "大雪", "冬至" };
        private static int[] JQData = { 0, 21208, 43467, 63836, 85337, 107014, 128867, 150921, 173149, 195551, 218072, 240693, 263343, 285989, 308563, 331033, 353350, 375494, 397447, 419210, 440795, 462224, 483532, 504758 };

        static DateTimeHelper()
        {
            //公历节日
            gHoliday.Add("0101", "元旦");
            gHoliday.Add("0214", "情人节");
            gHoliday.Add("0305", "雷锋日");
            gHoliday.Add("0308", "妇女节");
            gHoliday.Add("0312", "植树节");
            gHoliday.Add("0315", "消费者权益日");
            gHoliday.Add("0401", "愚人节");
            gHoliday.Add("0501", "劳动节");
            gHoliday.Add("0504", "青年节");
            gHoliday.Add("0601", "儿童节");
            gHoliday.Add("0701", "建党节");
            gHoliday.Add("0801", "建军节");
            gHoliday.Add("0910", "教师节");
            gHoliday.Add("1001", "国庆节");
            gHoliday.Add("1224", "平安夜");
            gHoliday.Add("1225", "圣诞节");

            //农历节日
            nHoliday.Add("0101", "春节");
            nHoliday.Add("0115", "元宵节");
            nHoliday.Add("0505", "端午节");
            nHoliday.Add("0815", "中秋节");
            nHoliday.Add("0909", "重阳节");
            nHoliday.Add("1208", "腊八节");
        }

        /// <summary>
        /// 获取农历
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetChinaDate(DateTime dt)
        {
            if (dt > china.MaxSupportedDateTime || dt < china.MinSupportedDateTime)
            {
                //日期范围：1901 年 2 月 19 日 - 2101 年 1 月 28 日
                throw new Exception(string.Format("日期超出范围！必须在{0}到{1}之间！", china.MinSupportedDateTime.ToString("yyyy-MM-dd"), china.MaxSupportedDateTime.ToString("yyyy-MM-dd")));
            }
            string str = string.Format("{0} {1}{2}", GetYear(dt), GetMonth(dt), GetDay(dt));
            string strJQ = GetSolarTerm(dt);
            if (strJQ != "")
            {
                str += " (" + strJQ + ")";
            }
            string strHoliday = GetHoliday(dt);
            if (strHoliday != "")
            {
                str += " " + strHoliday;
            }
            string strChinaHoliday = GetChinaHoliday(dt);
            if (strChinaHoliday != "")
            {
                str += " " + strChinaHoliday;
            }

            return str;
        }
        /// <summary>
        /// 获取农历简易版
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetChinaDateSimple(DateTime dt)
        {
            if (dt > china.MaxSupportedDateTime || dt < china.MinSupportedDateTime)
            {
                //日期范围：1901 年 2 月 19 日 - 2101 年 1 月 28 日
                throw new Exception(string.Format("日期超出范围！必须在{0}到{1}之间！", china.MinSupportedDateTime.ToString("yyyy-MM-dd"), china.MaxSupportedDateTime.ToString("yyyy-MM-dd")));
            }
            string str = string.Format("{0} {1}", GetMonth(dt), GetDay(dt));
            string strJQ = GetSolarTerm(dt);
            if (strJQ != "")
            {
                str += " (" + strJQ + ")";
            }
            string strHoliday = GetHoliday(dt);
            if (strHoliday != "")
            {
                str += " " + strHoliday;
            }
            string strChinaHoliday = GetChinaHoliday(dt);
            if (strChinaHoliday != "")
            {
                str += " " + strChinaHoliday;
            }

            return str;
        }
        /// <summary>
        /// 获取农历年份
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetYear(DateTime dt)
        {
            int yearIndex = china.GetSexagenaryYear(dt);
            string yearTG = " 甲乙丙丁戊己庚辛壬癸";
            string yearDZ = " 子丑寅卯辰巳午未申酉戌亥";
            string yearSX = " 鼠牛虎兔龙蛇马羊猴鸡狗猪";
            int year = china.GetYear(dt);
            int yTG = china.GetCelestialStem(yearIndex);
            int yDZ = china.GetTerrestrialBranch(yearIndex);

            string str = string.Format("[{1}]{2}{3}{0}", year, yearSX[yDZ], yearTG[yTG], yearDZ[yDZ]);
            return str;
        }

        /// <summary>
        /// 获取农历月份
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetMonth(DateTime dt)
        {
            int year = china.GetYear(dt);
            int iMonth = china.GetMonth(dt);
            int leapMonth = china.GetLeapMonth(year);
            bool isLeapMonth = iMonth == leapMonth;
            if (leapMonth != 0 && iMonth >= leapMonth)
            {
                iMonth--;
            }

            string szText = "正二三四五六七八九十";
            string strMonth = isLeapMonth ? "闰" : "";
            if (iMonth <= 10)
            {
                strMonth += szText.Substring(iMonth - 1, 1);
            }
            else if (iMonth == 11)
            {
                strMonth += "十一";
            }
            else
            {
                strMonth += "腊";
            }
            return strMonth + "月";
        }

        /// <summary>
        /// 获取农历日期
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetDay(DateTime dt)
        {
            int iDay = china.GetDayOfMonth(dt);
            string szText1 = "初十廿三";
            string szText2 = "一二三四五六七八九十";
            string strDay;
            if (iDay == 20)
            {
                strDay = "二十";
            }
            else if (iDay == 30)
            {
                strDay = "三十";
            }
            else
            {
                strDay = szText1.Substring((iDay - 1) / 10, 1);
                strDay = strDay + szText2.Substring((iDay - 1) % 10, 1);
            }
            return strDay;
        }

        /// <summary>
        /// 获取节气
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetSolarTerm(DateTime dt)
        {
            DateTime dtBase = new DateTime(1900, 1, 6, 2, 5, 0);
            DateTime dtNew;
            double num;
            int y;
            string strReturn = "";

            y = dt.Year;
            for (int i = 1; i <= 24; i++)
            {
                //num = 525948.76 * (y - 1900) + JQData[i - 1];
                num = 525944 * (y - 1900) + JQData[i - 1];//ccc修改
                dtNew = dtBase.AddMinutes(num);
                if (dtNew.DayOfYear == dt.DayOfYear)
                {
                    strReturn = JQ[i - 1];
                }
            }

            return strReturn;
        }

        /// <summary>
        /// 获取公历节日
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetHoliday(DateTime dt)
        {
            string strReturn = "";
            object g = gHoliday[dt.Month.ToString("00") + dt.Day.ToString("00")];
            if (g != null)
            {
                strReturn = g.ToString();
            }

            return strReturn;
        }

        /// <summary>
        /// 获取农历节日
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetChinaHoliday(DateTime dt)
        {
            string strReturn = "";
            int year = china.GetYear(dt);
            int iMonth = china.GetMonth(dt);
            int leapMonth = china.GetLeapMonth(year);
            int iDay = china.GetDayOfMonth(dt);
            if (china.GetDayOfYear(dt) == china.GetDaysInYear(year))
            {
                strReturn = "除夕";
            }
            else if (leapMonth != iMonth)
            {
                if (leapMonth != 0 && iMonth >= leapMonth)
                {
                    iMonth--;
                }
                object n = nHoliday[iMonth.ToString("00") + iDay.ToString("00")];
                if (n != null)
                {
                    if (strReturn == "")
                    {
                        strReturn = n.ToString();
                    }
                    else
                    {
                        strReturn += " " + n.ToString();
                    }
                }
            }

            return strReturn;
        }

        #endregion
    }
}
