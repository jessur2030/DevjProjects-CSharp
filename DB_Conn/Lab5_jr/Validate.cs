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


        public static bool IsValidEmail(string temp)
        {
            //assume true, but look for bad stuff to make it false
            bool blnResult = true;

            //Look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            //temp = scott@neit.ca
            // length = 13
            // position of last period = 10

            //Look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");

            //check for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2)    //if it is -1, not found and needs at least 2 chars in front
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }

            return blnResult;
        }



        public static bool invalidEntry(string temp)
        {
            bool result = false;

            string[] strInvalid = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strInvalid)
                if (temp.Contains(strBW))
                {
                    result = true;
                }

            return result;
        }
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }


        //****************************************************************************************************************

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

        /// <summary>
        /// //
        /// </summary>
        /// <param name="input"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
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


        //****************




        //Phone number 
        public static String BeautifyPhoneNumber(string numberToBeautify)
        {
            //The below gives us capture groups for each 
            //individual piece of the number.
            var regularExpression = new Regex(@"(\d{3})(\d{3})(\d{4})(x\d*)?");
            //This matches a number that's already been beautified, 
            //so we can guard against beautifying twice.
            var alreadyBeautifulExpression = new Regex(@"(\(\d{3}\)) (\d{3})-(\d{4}) ?(x\d*)?");
            var beautifulNumber = string.Empty;
            var separator = "-";
            var space = " ";
            //This prevents us from accidentally beautifying 
            //something more than once
            //You could also guard against this in your getter using a
            //IsBeautified extension, using the alreadyBeautifulExpression above
            if (alreadyBeautifulExpression.IsMatch(numberToBeautify))
            {
                return numberToBeautify;
            }

            //Trying to protect against invalid input... May be insufficient,
            //Or unnecessary
            if (string.IsNullOrEmpty(numberToBeautify)
                || regularExpression.Matches(numberToBeautify).Count <= 0)
            {
                return beautifulNumber;
            }

            GroupCollection groups = regularExpression.Matches(
                                                    numberToBeautify)[0].Groups;

            //More protection against invalid input
            if (groups.Count < 3)
            {
                return beautifulNumber;
            }

            //Given "7689131234",
            beautifulNumber += "(" + groups[1] + ")" + space; //gives us "(768) "
            beautifulNumber += groups[2] + separator; //gives us "(768) 913-"
            beautifulNumber += groups[3]; //gives us "(768) 913-1234"
                                          //If we have an extension, we add it.
            if (groups[4] != null)
            {
                beautifulNumber += space + groups[4];
            }

            return beautifulNumber;
        }


    }
}
