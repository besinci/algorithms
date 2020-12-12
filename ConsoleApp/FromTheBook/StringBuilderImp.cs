namespace ConsoleApp.FromTheBook
{
    /// <summary>
    /// Exercise: Implementing your own version of StringBuffer class.
    /// This was a suggestion from the book: Cracking The Coding Interview.
    /// This implementation is much simpler then .Net 
    /// For more details you should check: https://docs.microsoft.com/tr-tr/dotnet/api/system.text.stringbuilder?view=net-5.0
    /// </summary>
    public class StringBuilderImp
    {
        private static int _sizeOfArray = 1000;

        private char[] _stringCharacters = new char[_sizeOfArray];
        private int _arrayLength = 0;

        public StringBuilderImp Append(char c)
        {
            CheckArraySize();

            _stringCharacters[_arrayLength] = c;
            _arrayLength++;

            return this;
        }

        public StringBuilderImp Append(string s)
        {
            CheckArraySize();

            for (int i = 0; i < s.Length; i++)
            {
                _stringCharacters[_arrayLength] = s[i];
                _arrayLength++;
            }

            return this;
        }

        public override string ToString()
        {
            return new string(_stringCharacters, 0, _arrayLength);
        }

        private void CheckArraySize()
        {
            if (_arrayLength == _stringCharacters.Length)
            {
                char[] chars = new char[_arrayLength * 2];
                _stringCharacters.CopyTo(chars, 0);
                _stringCharacters = chars;
            }
        }
    }
}
