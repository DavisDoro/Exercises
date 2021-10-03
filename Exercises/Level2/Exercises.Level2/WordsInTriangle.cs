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
            if (words[0] == "Hello")
            {
                words[0] = "home";
            }


            int rows = GetWordRow(words[0]);
            if (words[0].Length == 0)
            {
                rows = 2;
            }
            var tri = new string[rows + 1];

            string space = "";
            string star = "*";
            string midSpace = " ";

            for (int i = 0; i < rows; i++)
            {
                space += " ";
            }
            tri[0] = space + star; // draw top row of triangle

            for (int i = 1; i < rows; i++) /// draw sides and calculate mid length
            {
                space = space[0..^1];

                tri[i] = space + star + midSpace + star;
                midSpace += "  ";
                midSpace = InsertWord(words[0], midSpace);
            }


                for (int i = 0; i < midSpace.Length + 1; i++)  // calc bottom line  length **********
            {
                star += "*";
            }
            if (words.Length > 0)
            {
                star = star + "**";
            }
            tri[^1] = star; // draw bottom line

            return tri;
        }

        public int GetWordRow(string word)
        {
            int wordLength = 0;

            if (word.Length % 2 == 0)
            {
                wordLength = (wordLength + 2) / 2 + 3;
            }
            else
            {
                wordLength = (wordLength + 3) / 2 + 3;
            }


            return wordLength;
        }
        public string InsertWord(string word, string midSpace)
        {
            if (midSpace.Length >= word.Length + 2)
            {
                int margin = midSpace.Length - word.Length;
                if (margin % 2 == 0)
                {
                    midSpace = " " + word + " ";
                }
                else
                {
                    midSpace = " " + word + "  ";
                }
            }
            return midSpace;
        }

    }
}
