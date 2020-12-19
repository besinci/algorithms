namespace ConsoleApp.FromTheBook
{
    /// <summary>
    /// Implements Arrays and Strings question from the book.
    /// </summary>
    public class ArrayAndStrings
    {
        // Implement an algorithm to determine if a string has all unique characters.
        // What if you cannot use additional data structures?
        public bool IsAllUnique(string sentence, int indexPoint = 0)
        {
            return false;
        }

        // Given two strings, write a method to decide if one is a permutation of the other.
        public bool IsPermutation(string str1, string str2)
        {
            return false;
        }

        // Write a method to replace all spaces in a string with '%20'.
        // You may assume that the string has sufficient space at the end of the string to hold
        // the addition characters, and that you are given the "true" lenght of the string. 
        // (Note: if implementing in Java, please use a character array so that you can perform
        //  this operation in place.)
        // EXAMPLE 
        //      Input:  "Mr John Smith      "
        //      Output: "Mr%Jonh%Smith"
        public string ReplaceAllSpaces(char[] arr)
        {
            return "";
        }

        // Implement a method to perform basic string compression using the counts 
        // of repeated characters. For example, the string aabcccccaaa would become a2b1c5a3.
        // if the "compressed" string would not become smaller than to original string,
        // your method should return the original string.
        public string CompressString(string sentence)
        {
            int countPoint = 1;
            string resultString = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                var selectedChar = sentence[i];

                int nextPoint = i + 1;

                if (nextPoint == sentence.Length || selectedChar != sentence[nextPoint])
                {
                    resultString += $"{selectedChar}{countPoint}";
                    countPoint = 1;
                }
                else
                {
                    countPoint++;
                }
            }

            if (resultString.Length >= sentence.Length)
            {
                return sentence;
            }
            else
            {
                return resultString;
            }
        }
        
        // Given an image represented by an NxN matrix, where each pixel in the image
        // is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this
        // in place?
        public int[,] RotateImage(int[,] arr)
        {
            return arr;
        }

        // Write an algorithm such that if an element in an MxN matrix is 0,
        // its entire row and column are set to 0.
        public bool IsColumnEndRowsAreZero(int[,] arr)
        {
            return false;
        }

        // Assume you have a method isSubstring which checks if one word is a
        // substring of another. Given two strings, s1 and s2, write code to chech 
        // if s2 is a rotation of s1 using only one call to isSubstring 
        // (eg. "waterbottle" is a rotation of "erbottlewat").
        
    }
}
