using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Practice
    {
        /// <summary>
        /// Kelimeyi tersten yazma problemi
        /// Zorluk: Basit
        /// Elinizde ne kadar uzun olduğunu bilmediğiniz bir kelime var.Sizden bu kelimeyi tersten yazacak bir algoritma geliştirmeniz isteniyor.
        /// Ancak bunu yaparken aşağıdaki yöntemleri kullanmanız yasak:
        /// Array.sort
        /// Hazır bir reverse fonksiyonu 
        /// LINQ
        /// For, foreach, do, while gibi döngü kelimeleri
        /// </summary>
        /// <param name="word">Muvaffakiyetsizleştiricileştiriveremeyebileceklerimizdenmişsinizcesine</param>
        /// <returns>eniseczinisşimnedzimirelkecelibeyemereviritşeliciritşelzisteyikaffavuM</returns>
        private static char[] reversedWord = new char[1];
        public static char[] ReverseWord(string word, int startPoint = 1)
        {
            var wordLength = word.Length;

            if (wordLength > reversedWord.Length)
            {
                reversedWord = new char[wordLength];
            }

            reversedWord[startPoint - 1] = word[wordLength - startPoint];

            startPoint++;

            if (startPoint <= wordLength)
            {
                ReverseWord(word, startPoint);
            }

            return reversedWord;
        }

        /// <summary>
        /// Bir cümle içerisinde tekrar eden harfleri bulmaca
        /// Zorluk: Basit
        /// Elinizde uzunluğunu bilmediğiniz bir cümle olsun. 
        /// Bu cümlenin içerisinde kendisini tekrar eden harfleri sayan ve bunu ekrana yazan programı yazın.
        /// Ek Soru. Algoritmanız Big O notasyonundaki değeri nedir? Daha az karmaşık yapılabilir mi?
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static Hashtable CountRepetitiveCharacters(string sentence)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Hashtable result = new Hashtable();
            
            for (int i = 0; i < alphabet.Length; i++)
            {
                var character = alphabet[i];
                if (sentence.Contains(character))
                {
                    result.Add(character, sentence.Where(x => x == character).Count());
                }
            }

            return result;
        }
    }
}
