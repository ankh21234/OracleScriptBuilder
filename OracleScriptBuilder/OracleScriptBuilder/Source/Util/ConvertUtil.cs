using System;

namespace OracleScriptBuilder.Source.Util
{
    internal static class ConvertUtil
    {
        public static string ToStr(this object obj)
        {
            string s = string.Format("{0}", obj);
            return s;
        }

        public static bool IsNullOrDbNull(this object obj)
        {
            return obj == null || obj == DBNull.Value;
        }

        public static DateTime ToDate(this object obj)
        {
            DateTime dt = ToDate(obj.ToStr());
            return dt;
        }

        public static DateTime ToDate(string str)
        {
            DateTime dt;
            DateTime.TryParse(str, out dt);
            return dt;
        }

        public static string DateToStr(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss FFF");
        }

        public static double ToDouble(this object obj)
        {
            return ToDouble(obj.ToStr());
        }

        public static decimal ToDecimal(this object obj)
        {
            return ToDecimal(obj.ToStr());
        }

        public static decimal ToDecimal(this string str)
        {
            decimal d;
            decimal.TryParse(str, out d);
            return d;
        }

        public static double ToDouble(this string str)
        {
            double d;
            double.TryParse(str, out d);
            return d;
        }

        public static float ToFloat(this object obj)
        {
            return ToFloat(obj.ToStr());
        }

        public static float ToFloat(this string str)
        {
            float f;
            float.TryParse(str, out f);
            return f;
        }

        public static int ToInt(this object obj)
        {
            return ToInt(obj.ToStr());
        }

        public static int ToInt(string str)
        {
            int i;
            int.TryParse(str, out i);
            return i;
        }

        public static long ToLong(this object obj)
        {
            return ToLong(obj.ToStr());
        }

        public static long ToLong(this string str)
        {
            long l;
            long.TryParse(str, out l);
            return l;
        }

        public static bool ToBool(this string str)
        {
            bool result = false;

            bool.TryParse(str, out result);

            return result;
        }

        public static bool ToBool(this object obj)
        {
            bool result = false;

            result = ToBool(obj.ToStr());

            return result;
        }
    }
}