using System.Collections;

namespace TestParserAndOther
{
    public interface IParser
    {
        ArrayList ParserArrayByAttributes(string requestName, string attribut);
        ArrayList ParserArrayByTag(string requestName, string tag);
        string ParserString(string requestName);
        string ParserStringByAttributes(string requestName, string attribut);
        string ParserText(string requestName, string tag);
    }
}