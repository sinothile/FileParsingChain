using System;

namespace FileParsingChain
{
    public class CsvFile : IParser
    {
        private IParser _nextParser;
        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.Contains(".csv"))
            {
                Console.Write("File Parsed with Csv Parser");
            }
            else
            {
                _nextParser.Parse(fileName);
            }
        }
    }
}
