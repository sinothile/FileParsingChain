namespace FileParsingChain
{
    public interface IParser
    {
        void SetSuccessor(IParser nextParser);
        void Parse(string fileName);
    }
}
