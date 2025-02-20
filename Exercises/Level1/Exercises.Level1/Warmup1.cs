﻿using System;

namespace Exercises.Level1
{
    /// <summary>
    /// Simple warmup problems to get started.
    /// </summary>
    public class Warmup1
    {
        /// <summary>
        /// The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation. 
        /// We sleep in if it is not a weekday or we're on vacation. 
        /// Return true if we sleep in.
        ///
        /// sleepIn(false, false) → true
        /// sleepIn(true, false) → false
        /// sleepIn(false, true) → true
        /// </summary>
        public bool SleepIn(bool weekday, bool vacation)
        {
            if ( vacation == true || weekday == false)
                {
                    return true;
                }
            else
                {
                    return false;
                }
            //upload test
        }

        /// <summary>
        /// 
        /// We have two monkeys, a and b, and the parameters aSmile and bSmile indicate if each is smiling.
        /// We are in trouble if they are both smiling or if neither of them is smiling.
        /// Return true if we are in trouble.
        /// 
        /// monkeyTrouble(true, true) → true
        /// monkeyTrouble(false, false) → true
        /// monkeyTrouble(true, false) → false
        /// </summary>
        public bool MonkeyTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile == true && bSmile == true)
            {
                return true;
            }
            else if (aSmile == false && bSmile == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 
        /// Given two int values, return their sum. Unless the two values are the same, then return double their sum.
        /// 
        /// sumDouble(1, 2) → 3
        /// sumDouble(3, 2) → 5
        /// sumDouble(2, 2) → 8
        /// </summary>
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (a+b)*2;
            }
            else
            {
                return a+b;
            }
        }

        /// <summary>
        /// 
        /// Given an int n, return the absolute difference between n and 21, except return double the absolute difference if n is over 21.
        /// 
        /// diff21(19) → 2
        /// diff21(10) → 11
        /// diff21(21) → 0
        /// </summary>
        public int Diff21(int n)
        {
            if (n < 21)
            {
                return 21 - n;
            }
            else
            {
                int diff =  (21 - n)*2;
                return Math.Abs(diff);
            }
        }

        /// <summary>
        /// We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23. We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if we are in trouble.
        /// 
        /// parrotTrouble(true, 6) → true
        /// parrotTrouble(true, 7) → false
        /// parrotTrouble(false, 6) → false
        /// </summary>
        public bool ParrotTrouble(bool talking, int hour)
        {
            if (talking == true && (hour < 7 || hour > 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Given 2 ints, a and b, return true if one if them is 10 or if their sum is 10.
        /// 
        /// makes10(9, 10) → true
        /// makes10(9, 9) → false
        /// makes10(1, 9) → true
        /// </summary>
        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10 || a + b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given an int n, return true if it is within 10 of 100 or 200. Note: Math.abs(num) computes the absolute value of a number.
        /// 
        /// nearHundred(93) → true
        /// nearHundred(90) → true
        /// nearHundred(89) → false
        /// </summary>
        public bool NearHundred(int n)
        {
            
            if (Math.Abs(100-n) < 11)
            {
                return true;
            }
            else if (Math.Abs(200-n) < 11)
            {
                return true;
            }
            else
            {
                return false;
            }
             

        }

        /// <summary>
        /// Given 2 int values, return true if one is negative and one is positive. 
        /// Except if the parameter "negative" is true, then return true only if both are negative.
        /// 
        /// posNeg(1, -1, false) → true
        /// posNeg(-1, 1, false) → true
        /// posNeg(-4, -5, true) → true
        /// </summary>
        public bool PosNeg(int a, int b, bool negative)
        {
            if ((a == 0 || b == 0) || (a == 0 && b == 0 && negative == true))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Given a string, return a new string where "not " has been added to the front. 
        /// However, if the string already begins with "not", return the string unchanged. Note: use .equals() to compare 2 strings.
        /// 
        /// notString("candy") → "not candy"
        /// notString("x") → "not x"
        /// notString("not bad") → "not bad"
        /// </summary>
        public string NotString(string str)
        {
            if (str.Substring(0, 4) == "not ")
            {
                return str;
            }
            else
            {
                str = "not " + str;
                return str;
            }
        }

        /// <summary>
        /// Given a non-empty string and an int n, return a new string where the char at index n has been removed. 
        /// The value of n will be a valid index of a char in the original string (i.e. n will be in the range 0..str.length()-1 inclusive).
        /// 
        /// missingChar("kitten", 1) → "ktten"
        /// missingChar("kitten", 0) → "itten"
        /// missingChar("kitten", 4) → "kittn"
        /// </summary>
        public string MissingChar(string str, int n)
        {
            str = str.Remove(n, 1);
            return str;
        }

        /// <summary>
        /// Given a string, return a new string where the first and last chars have been exchanged.
        /// 
        /// frontBack("code") → "eodc"
        /// frontBack("a") → "a"
        /// frontBack("ab") → "ba"
        /// </summary>
        public string FrontBack(string str)
        {
            // get string length
            int charCount = str.Length;
            // get first and last char from string
            char firstChar = str[0];
            char lastChar = str[charCount - 1];
            //remove first and last from original string
            str = str.Remove(0, 1);
            str = str.Remove(charCount -2, 1);
            //swap
            string newString = lastChar.ToString() + str + firstChar.ToString();

            return newString;
        }

        /// <summary>
        /// Given a string, we'll say that the front is the first 3 chars of the string. 
        /// If the string length is less than 3, the front is whatever is there. Return a new string which is 3 copies of the front.
        /// 
        /// front3("Java") → "JavJavJav"
        /// front3("Chocolate") → "ChoChoCho"
        /// front3("abc") → "abcabcabc"
        /// </summary>
        public string Front3(string str)
        {
            int strLength = str.Length;
            // if 2 char string
            if (strLength <= 3)
            {
                return str + str + str;
            }
            // if 3+ char string
            else
            {
                str = str.Remove(3);
                return str + str + str;
            }
        }

        /// <summary>
        /// Given a string, take the last char and return a new string with the last char added at the front and back, so "cat" yields "tcatt". The original string will be length 1 or more.
        /// 
        /// backAround("cat") → "tcatt"
        /// backAround("Hello") → "oHelloo"
        /// backAround("a") → "aaa"
        /// </summary>
        public string BackAround(string str)
        {
            // get string length
            int charCount = str.Length;
            // get last char from string
            char lastChar = str[charCount - 1];

            //swap
            string newString = lastChar.ToString() + str + lastChar.ToString();

            return newString;
        }

        /// <summary>
        /// Return true if the given non-negative number is a multiple of 3 or a multiple of 5. 
        /// Use the % "mod" operator -- see http://codingbat.com/doc/practice/mod-introduction.html (Introduction to Mod)
        /// 
        /// or35(3) → true
        /// or35(10) → true
        /// or35(8) → false
        /// </summary>
        public bool Or35(int n)
        {
            if ((n % 5 == 0) || (n % 3 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given a string, take the first 2 chars and return the string with the 2 chars added at both the front and back, so "kitten" yields "kikittenki". 
        /// If the string length is less than 2, use whatever chars are there.
        /// 
        /// front22("kitten") → "kikittenki"
        /// front22("Ha") → "HaHaHa"
        /// front22("abc") → "ababcab"
        /// </summary>
        public string Front22(string str)
        {
            string beginning = str.Remove(2);

            return beginning + str + beginning;
        }

        /// <summary>
        /// Given a string, return true if the string starts with "hi" and false otherwise.
        /// 
        /// startHi("hi there") → true
        /// startHi("hi") → true
        /// startHi("hello hi") → false
        /// </summary>
        public bool StartHi(string str)
        {
            if (str.Remove(2) == "hi")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given two temperatures, return true if one is less than 0 and the other is greater than 100.
        /// 
        /// icyHot(120, -1) → true
        /// icyHot(-1, 120) → true
        /// icyHot(2, 120) → false
        /// </summary>
        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100)
            {
                return true;
            }
            else if (temp1 > 100 && temp2 < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given 2 int values, return true if either of them is in the range 10..20 inclusive.
        /// 
        /// in1020(12, 99) → true
        /// in1020(21, 12) → true
        /// in1020(8, 99) → false
        /// </summary>
        public bool In1020(int a, int b)
        {
            if (a >= 10 && a <= 20)
            {
                return true;
            }
            else if (b >= 10 && b <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
        /// Given 3 int values, return true if 1 or more of them are teen.
        /// 
        /// hasTeen(13, 20, 10) → true
        /// hasTeen(20, 19, 10) → true
        /// hasTeen(20, 10, 13) → true
        /// </summary>
        public bool HasTeen(int a, int b, int c)
        {
            if (a >= 13 && a <= 19)
            {
                return true;
            }
            if (b >= 13 && b <= 19)
            {
                return true;
            }
            if (c >= 13 && c <= 19)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 2 int values, return true if one or the other is teen, but not both.
        /// 
        /// loneTeen(13, 99) → true
        /// loneTeen(21, 19) → true
        /// loneTeen(13, 13) → false
        /// </summary>
        public bool LoneTeen(int a, int b)
        {
            if ((a >= 13 && a <= 19) && (b < 13 || b > 19))
            {
                return true;
            }
            else if ((b >= 13 && b <= 19) && (a < 13 || a > 19))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given a string, if the string "del" appears starting at index 1, return a string where that "del" has been deleted. Otherwise, return the string unchanged.
        /// 
        /// delDel("adelbc") → "abc"
        /// delDel("adelHello") → "aHello"
        /// delDel("adedbc") → "adedbc"
        /// </summary>
        public string DelDel(string str)
        {
            //remove beginning and end of the string
            string isDel = str.Remove(0, 1);
            isDel = str.Remove(4);

            //compare new string to "del"
            if (isDel == "del")
            {
                //remove "del" from string
                return "";
            }
            return "";
        }

        /// <summary>
        /// Return true if the given string begins with "mix", except the 'm' can be anything, so "pix", "9ix" .. all count.
        /// 
        /// mixStart("mix snacks") → true
        /// mixStart("pix snacks") → true
        /// mixStart("piz snacks") → false
        /// </summary>
        public bool MixStart(string str)
        {
            string checkString = str.Remove(0, 1);
            checkString = checkString.Remove(2);
            if (checkString == "ix")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Given a string, return a string made of the first 2 chars (if present), however include first char only if it is 'o' and include the second only if it is 'z', so "ozymandias" yields "oz".
        /// 
        /// startOz("ozymandias") → "oz"
        /// startOz("bzoo") → "z"
        /// startOz("oxx") → "o"
        /// </summary>
        public string StartOz(string str)
        {
            str = str.Remove(2);
            char firstLetter = str[0];
            char secondLetter = str[1];
            string firstString = firstLetter.ToString();
            string secondString = secondLetter.ToString();
            if (firstString == "o" && secondString == "z")
            {
                return "oz";
            }
            else if (firstString == "o")
            {
                return "o";
            }
            else if (secondString == "z")
            {
                return "z";
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Given three int values, a b c, return the largest.
        /// 
        /// intMax(1, 2, 3) → 3
        /// intMax(1, 3, 2) → 3
        /// intMax(3, 2, 1) → 3
        /// </summary>
        public int IntMax(int a, int b, int c)
        {
            int maxValue = Math.Max(a, Math.Max(b, c));
            return maxValue;
        }

        /// <summary>
        /// Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie. 
        /// Note that Math.abs(n) returns the absolute value of a number.
        ///
        /// close10(8, 13) → 8
        /// close10(13, 8) → 8
        /// close10(13, 7) → 0
        /// </summary>
        public int Close10(int a, int b)
        {
            int aHowClose = Math.Abs(a - 10);
            int bHowClose = Math.Abs(b - 10);

            if (aHowClose < bHowClose)
            {
                return a;
            }
            else if (aHowClose == bHowClose)
            {
                return 0;
            }
            else
            {
                return b;
            }
        }

        /// <summary>
        /// Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both in the range 40..50 inclusive.
        /// 
        /// in3050(30, 31) → true
        /// in3050(30, 41) → false
        /// in3050(40, 50) → true
        /// </summary>
        public bool In3050(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, or return 0 if neither is in that range.
        /// 
        /// max1020(11, 19) → 19
        /// max1020(19, 11) → 19
        /// max1020(11, 9) → 11
        /// </summary>
        public int Max1020(int a, int b)
        {
            if ((a >= 10 && a <=20)&&(b >= 10 && b <=20))
             {
                return Math.Max(a, b);
            }
            else if ((a >= 10 && a <=20))
                {
                return a;
            }
            else if ((b >= 10 && b <=20))
                {
                return b;
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// Return true if the given string contains between 1 and 3 'e' chars.
        /// 
        /// stringE("Hello") → true
        /// stringE("Heelle") → true
        /// stringE("Heelele") → false
        /// </summary>
        public bool StringE(string str)
        {
            int count = 0;
            foreach(char ch in str)
            {
                if(ch.Equals('e'))
                {
                    count ++;
                }
            }
            if (count > 0 && count <=3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Given two non-negative int values, return true if they have the same last digit, such as with 27 and 57. Note that the % "mod" operator computes remainders, so 17 % 10 is 7.
        /// 
        /// lastDigit(7, 17) → true
        /// lastDigit(6, 17) → false
        /// lastDigit(3, 113) → true
        /// </summary>
        public bool LastDigit(int a, int b)
        {
            if (a % 10 == b % 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Given a string, return a new string where the last 3 chars are now in upper case. 
        /// If the string has less than 3 chars, uppercase whatever is there. Note that str.toUpperCase() returns the uppercase version of a string.
        /// 
        /// endUp("Hello") → "HeLLO"
        /// endUp("hi there") → "hi thERE"
        /// endUp("hi") → "HI"
        /// </summary>
        public string EndUp(string str)
        {
            int strLength = str.Length;
            //cut string into two parts
            string startOfStr = str.Remove(strLength-3);
            string endOfStr = str.Remove(0, strLength-3);

            

            if (strLength <= 3)
            {
                return str.ToUpper();
            }
            else
            {
                return startOfStr + endOfStr.ToUpper();
            }

        }

        /// <summary>
        /// Given a non-empty string and an int N, return the string made starting with char 0, and then every Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more.
        ///
        /// everyNth("Miracle", 2) → "Mrce"
        /// everyNth("abcdefg", 2) → "aceg"
        /// everyNth("abcdefg", 3) → "adg"
        /// </summary>
        public string EveryNth(string str, int n)
        {
            string newString = "";
            int plusInt = n;
            int i = 0;
            while (str.Length > n)
            {

                newString = newString + str[i];
                n = n + plusInt;
                i = i + plusInt;
            }
            return newString;
        }
    }
}