using System;

namespace Exercises.Level2
{
    public class WordsInTriangle
    {
        /// <summary>
        /// Given array of words draw them inside a smallest possible triangle, compleeting rules. 
        /// !. Every word has to be drawn in a new line.
        /// 2. No word can touch wall of the triangle, meaning there has to a " " between a wall and word.
        /// 
        /// 
        /// 
        /// a beautiful home:
        /// 
        ///         *
        ///        * *
        ///       *   *
        ///      *     *
        ///     *       *
        ///    * a       *
        ///   * beautiful *
        ///  * home        *
        /// *****************
        /// 
        /// For example word Home:
        /// 
        ///      *
        ///     * *
        ///    *   *
        ///   *     *
        ///  * home  *
        /// ***********
        /// </summary>
        /// <param name="words">Words to put in triangle</param>
        /// <returns></returns>
        public string[] GetWordInTriangle(string[] words)
        {
            string word = "Wolf";
            int leng = 4;
            var tri = new string[leng + 1];
            string space = "";
            string star = "*";

            for (int i = 0; i < leng; i++)
            {
                space += " ";
            }





            return tri;
            
        }

        public int ThisWordRow(string words)
        {
            // vards :atstarpes :  par nepara : - 3 rindas : dalit ar vietam rindaa  :   varda limenis piramiidaa (no augshas)
            // (10 +      2        + 1 -          3)               / 2           3+  rezultats

            int wordL = words.Length + 2;
            if (wordL % 2 != 0)
            {
                wordL += 1;
            }
            wordL = (wordL - 3) / 2;
            wordL += 3;

            return wordL;
        }
    }
}
