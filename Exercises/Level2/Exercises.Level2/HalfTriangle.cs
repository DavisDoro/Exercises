using System;

namespace Exercises.Level2
{
    public class HalfTriangle
    {
        /// <summary>
        /// The program:
        ///  You must create a half triangle. 
        ///  n is the number of lines a triangle will have.
        ///  Triangle body has to be made out of "*",
        ///  so result should for 3 be like:
        ///* 
        ///***
        ///*****
        /// 
        /// Example of 5:
        /// 
        ///*
        ///***
        ///*****
        ///*******
        ///*********
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] GetHalfTriangle(int n)
        {
            string[] tri = new string[n];
            string star = "*";

            tri[0] = star;
            for (int i = 1; i < n; i++)
            {
                star += "**";
                tri[i] = star;
            }
            return tri;

        }
    }
}
