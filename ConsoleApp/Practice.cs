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

        
    }
}
