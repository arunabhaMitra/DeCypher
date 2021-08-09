using System;
using System.Collections.Generic;
using System.Text;

namespace DecypherString
{
    class ManageDecyphering
    {
        public static string DecypherEncodedString(string keyWrd, string cypher)
        {
            string msg = "";
            string alphabets = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, char> keyCypherMap = new Dictionary<char, char>();
            for(int i = 0; i < alphabets.Length; i++)
                keyCypherMap.Add(cypher[i], alphabets[i]);
            
            foreach (char keyWordChar in keyWrd)
                msg += cypher.Contains(keyWordChar.ToString().ToLower()) ? 
                            (  Char.IsLower(keyWordChar) ? 
                                        keyCypherMap[keyWordChar] 
                                                : Char.ToUpper(keyCypherMap[Char.ToLower(keyWordChar)])
                            ) : (keyWordChar == '_' ? ' ' : keyWordChar);

            return msg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Decyphered ==>> " + DecypherEncodedString("Z:be_p,I", "bdachgfelkjiponmtsrqxwvuzy"));
        }
    }
}
