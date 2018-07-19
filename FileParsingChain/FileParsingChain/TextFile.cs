using System;

namespace FileParsingChain
{
    public class TextFile : IParser
    {
        private IParser _nextParser;
        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.Contains(".txt"))
            {
                Console.Write("File Parsed with Text Parser");
            }
            else
            {
                _nextParser.Parse(fileName);
            }
        }
    }
}