using System;

namespace Exercises.Level2
{
    public class Triforce
    {
        /// <summary>
        /// !!! COMPLETE TRIANGLE BEFORE ATTEMPTING THIS !!!
        /// 
        /// 
        /// The program:
        ///  You must create a program that echoes a Triforce of a given size N.       
        /// - A triforce is made of 3 identical triangles
        /// - A triangle of size N should be made of N lines
        /// - A triangle's line starts from 1 star, and earns 2 stars each line
        /// 
        /// For example, a Triforce of size 3 will look like:
        ///        
        ///     *
        ///    ***
        ///   *****
        ///  *     *
        /// ***   ***
        ///***** *****
        ///
        /// Another example, a Triforce of size 5 will look like:
        ///
        ///         *
        ///        ***
        ///       *****
        ///      *******
        ///     *********
        ///    *         *
        ///   ***       ***
        ///  *****     *****
        /// *******   *******
        ///********* *********
        ///
        ///     *
        ///    ***
        ///   *****
        ///  *     *
        /// ***   ***
        ///***** *****
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>


        public string[] GetTriforce(int n)
        {
            var tri = new string[n * 2];

            string spaceSide = " ";
            string spaceMid = " ";
            string star = "*";

            for (int i = 0; i < n - 1; i++) // prepare bottom triangle middle spacing
            {
                spaceMid += "  ";
            }
            for (int i = 1; i < n * 2 - 1; i++)  // prepare side left side spacing
            {
                spaceSide += " ";
            }
            for (int i = 0; i < n; i++)  // assign top triangle array elements
            {
                tri[i] = spaceSide + star;
                star += "**";
                spaceSide = spaceSide[0..^1];
            }
            star = "*";   // reset star count for bottom triangles

            for (int i = n; i < n * 2; i++)  // assign bottom triangles array elements
            {
                tri[i] = spaceSide + star + spaceMid + star;
                star += "**";
                if (spaceSide.Length > 0)  // shortening left side space
                {
                    spaceSide = spaceSide[0..^1];
                }
                if (spaceMid.Length > 2)  // shortening mid space
                {
                    spaceMid = spaceMid[0..^2];
                }
            }
            return tri;
        }
    }
}
