using System.Numerics;
using System.Text.RegularExpressions;
using System;
using Exercise01.Functions;

namespace Exercise01
{
    public static class ExtensionMethods
    {
        public static BigInteger Bignteger(this string str)
        {
            var res = str.Replace(",", "");
            if (string.IsNullOrEmpty(res))
            {
                res = "0";
            }
            return BigInteger.Parse(res);
        }
        public static string ProcessInterger(this string str)
        {
            string[] res = NumberToWords(Bignteger(str).ToString()).Split(' ');
            if (res.Any()) //prevent IndexOutOfRangeException for empty list
            {
                res = res.Take(res.Count() - 2).ToArray();
            }
            return string.Join(" ", res); 
        }
        public static string NumberToWords(string number)
        {
            string negative = string.Empty;
            string value = Convert.ToDouble(number).ToString();
            if (value.Contains('-'))
            {
                negative = "-";
                value = value[1..];
            }
            if (value == "0")
            {
                return "Zero";
            }
            string[] FinalResult = ConvertToWords(number).Split(" ");
            string result = Regex.Match(number, @"(.{3})\s*$").ToString();
            if (result[..1] == "0" && result[..1] == "0")
            {
                string lastItem = FinalResult[^4];
                if (lastItem == "Thousand")
                {
                    FinalResult[^4] = "And";
                }
                if (FinalResult.Length == 5)
                {
                    return string.Join(" ", FinalResult).Replace("And", "Thousand And");
                }
            }

            return negative + string.Join(" ", FinalResult);
        }
        private static string ConvertToWords(string Input)
        {
            string ReturnValue = string.Empty;
            string WholeNumber = Input;
            string AndString = string.Empty;
            string PointString = string.Empty;
            string EndString = string.Empty;
            try
            {
                int decimalPlace = Input.IndexOf(".");
                if (decimalPlace > 0)
                {
                    WholeNumber = Input[..decimalPlace];
                    string points = Input[(decimalPlace + 1)..];
                    if (Convert.ToInt32(points) > 0)
                    {
                        AndString = "and";
                        EndString = "cents " + EndString;
                        PointString = Decimals(points);
                    }
                }
                ReturnValue = string.Format("{0} {1}{2} {3}", NumToWordsFunction.WholeNumber(WholeNumber).Trim(), AndString, PointString, EndString);
            }
            catch { }
            return ReturnValue;
        }
        private static string Decimals(string numbertodecimal)
        {
            string returnvalue = string.Empty;
            for (int i = 0; i < numbertodecimal.Length; i++)
            {
                string digit = numbertodecimal[i].ToString();
                string One;
                if (digit.Equals("0"))
                {
                    One = "Zero";
                }
                else
                {
                    One = NumToWordsFunction.GetOnes(digit);
                }
                returnvalue += " " + One;
            }
            return returnvalue;
        }
    }
}