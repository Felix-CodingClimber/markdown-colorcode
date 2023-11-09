using Markdig;
using Markdig.Renderers.Html;
using Markdig.Syntax;

namespace Markdown.ColorCode.Examples;

internal class MarkdownProcessor
{
    private readonly Markdig.MarkdownPipeline pipeline;

    public MarkdownProcessor()
    {

        pipeline = new MarkdownPipelineBuilder()
            .UseColorCode()
            .Build();
    }

    public string ProcessMd(string mdText)
    {
        var html = Markdig.Markdown.ToHtml(mdText, pipeline);

        return html;
    }
}
