using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace jessur_lab4._2
{
    class Validate
    {


        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }



        public static bool WithinRange(int min, int max, int entry)
        {

            bool result = true;
            if (entry < min || entry > max)
            {
                result = false;

            }
            return result;

        }

        public static bool WithinRangedouble(double min, double max, double entry)
        {

            bool result = true;
            if (entry < min || entry > max)
            {
                result = false;

            }
            return result;
        }

            public static bool ValidLength(int min, int max, string entry)
        {
            bool result = true;
            int EntryLen = entry.Length;
            if (EntryLen < min || EntryLen > max)
            {
                result = false;
            }
            return true;
        }


        //ZipValid
        public static bool IsValidZip(string ZipEntry)
        {
            return ValidLength(5, 5, ZipEntry);
        }

        public static bool IsValidLength(int min, int max, string entry)
        {

            bool result = true;
            int EntryLen = entry.Length;
            if (EntryLen < min || EntryLen > max)
            {
                result = false;
            }
            return true;
        }

        public static bool IsValidLengthdouble(double min, double max, string entry)
        {

            bool result = true;
            double EntryLen = entry.Length;
            if (EntryLen < min || EntryLen > max)
            {
                result = false;
            }
            return true;
        }


        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        const int charLimit = 30;


        public static bool IsValid(string input, int min , int max )
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var i = 0;
            if (Int32.TryParse(input, out i))
            {
                return IsInRange(i, min, max);
            }

            return IsInRange(input.Length, 0, charLimit);
        }




        public static bool IsValidphone(string input)
        {
            bool number = false;
            if (string.IsNullOrEmpty(input))
            {
                number = false;
            }
            else
                number = true;


           //int i = 0;
           // number = Int32.TryParse(input, out int  i);

            if (number == true ) {

                if (input.Length == 10)
                    number = true;
                else
                    number= false;
            }

            return number;


        }


       // int moneyAvg = Convert.ToInt32(value);

        public static bool IsInRange(int i, int min, int max)
        {
            return ((i >= min) && (i <= max));
        }



        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }

            return blnResult;
        }



        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }


    }
}

public static class StringExtensions
{


    public static bool ValidatePhoneNumber(this string PhoneN, bool IsRequired)
    {
        if (string.IsNullOrEmpty(PhoneN) & !IsRequired)
            return true;

        if (string.IsNullOrEmpty(PhoneN) & IsRequired)
            return false;

        var cleaned = PhoneN.RemoveNonNumeric();
        if (IsRequired)
        {
            if (cleaned.Length == 10)
                return true;
            else
                return false;
        }
        else
        {
            if (cleaned.Length == 0)
                return true;
            else if (cleaned.Length > 0 & cleaned.Length < 10)
                return false;
            else if (cleaned.Length == 10)
                return true;
            else
                return false; // should never get here
        }
    }


    public static string RemoveNonNumeric(this string phone)
    {
        return Regex.Replace(phone, @"[^0-9]+", "");
    }
}
