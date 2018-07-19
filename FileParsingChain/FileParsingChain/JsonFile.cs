using System;

namespace FileParsingChain
{
    public class JsonFile : IParser
    {
        private IParser _nextParser;
        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.Contains(".json"))
            {
                Console.Write("File Parsed with Json Parser");
            }
            else
            {
                _nextParser.Parse(fileName);
            }
        }
    }
}
