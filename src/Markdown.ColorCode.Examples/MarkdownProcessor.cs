using Markdig;

namespace Markdown.ColorCode.Examples;

internal class MarkdownProcessor
{
    private readonly Markdig.MarkdownPipeline pipeline;

    public MarkdownProcessor()
    {

        pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseColorCode(additionalLanguages: [new LanguagePlainText()], defaultLanguageId: LanguagePlainText.LangId)
            .Build();
    }

    public string ProcessMd(string mdText)
    {
        var html = Markdig.Markdown.ToHtml(mdText, pipeline);

        return html;
    }
}
