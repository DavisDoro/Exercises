using System;

namespace Exercises.Level2
{
    public class Triangle
    {
        /// <summary>
        /// Note: compleete half trangle first
        /// 
        /// The program:
        ///  You must create a triangle. 
        ///  n is the number of lines a triangle will have.
        ///  Triangle body has to be made out of "*",
        ///  so result should for 3 be like:
        ///  * 
        /// ***
        ///*****
        /// 
        /// Example of 5:
        /// 
        ///    *
        ///   ***
        ///  *****
        /// *******
        ///*********
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] GetTRiangle(int n)
        {
            string[] tri = new string[n];
            string space = "";
            string stars = "*";

            for (int i = 0; i < n-1; i++)
            {
                space += " ";
            }
            tri[0] = space + stars;

            for (int i = 1; i < n; i++)
            {
                space = space[0..^1];
                stars = stars + "**";
                tri[i] = space + stars;
            }
            return tri;
        }
    }
}
