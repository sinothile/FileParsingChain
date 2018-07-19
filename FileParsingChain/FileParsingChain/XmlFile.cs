using System;

namespace FileParsingChain
{
    public class XmlFile : IParser
    {
        private IParser _nextParser;
        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.Contains(".xml"))
            {
                Console.Write("File Parsed with XML Parser");
            }
            else
            {
                Console.Write("Only provides xml,txt,csv and json files");
            }
        }
    }
}
