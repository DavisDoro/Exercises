using System;

namespace Exercises.Level2
{
    public class WordsInBox
    {
        /// <summary>
        /// Draw a box made out of stars (*) and put the word inide of them.
        /// So that a word Home makes:
        /// 
        /// ********
        /// * Home *
        /// ********
        /// 
        /// If you need more examples go to the tests project.
        /// </summary>
        /// <param name="word">Word to put in a box</param>
        /// <returns></returns>
        public string[] GetBox(string word)
        {
            var box = new string[3];
            int stars = word.Length + 4;
            string starLiner = "";

            for (int i = 0; i < stars; i++)
            {
                starLiner += "*";
            }
            box[0] = starLiner;
            box[1] = "* " + word + " *";
            box[2] = starLiner;

            return box;
        }
    }
}
