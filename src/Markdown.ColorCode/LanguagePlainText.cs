
using ColorCode.Common;

namespace Markdown.ColorCode;

public class LanguagePlainText : ILanguage
{
    public const string LangId = "text";

    public string Id => LangId;

    public string Name => Id;

    public string CssClassName => null!;

    public string FirstLinePattern => null!;

    public IList<LanguageRule> Rules => [new LanguageRule("^$", new Dictionary<int, string>() { { 0, ScopeName.PlainText } })];

    public bool HasAlias(string lang) => true;

    public override string ToString() => Id;
}
