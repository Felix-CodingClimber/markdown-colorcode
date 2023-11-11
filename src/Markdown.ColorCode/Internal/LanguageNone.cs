
namespace Markdown.ColorCode.Internal;

public class LanguageNone : ILanguage
{
    public string Id
    {
        get { return "None"; }
    }

    public string Name
    {
        get { return "None"; }
    }

    public string CssClassName
    {
        get { return null; }
    }

    public string FirstLinePattern
    {
        get
        {
            return null;
        }
    }

    public IList<LanguageRule> Rules
    {
        get
        {
            return [new LanguageRule(".*", new Dictionary<int, string>() { { 0, "all" } })];
        }
    }

    public bool HasAlias(string lang)
    {
        return false;
    }

    public override string ToString()
    {
        return Name;
    }
}
