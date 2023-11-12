using Markdig;
using Markdig.Syntax;

namespace Markdown.ColorCode.Examples;

internal class MarkdownProcessor
{
    private readonly MarkdownPipeline basePipeline;
    private readonly MarkdownPipeline codeBlockPipeline;

    public MarkdownProcessor()
    {
        basePipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .Build();

        codeBlockPipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseColorCode(additionalLanguages: [new LanguagePlainText()], defaultLanguageId: LanguagePlainText.LangId)
            .Build();
    }

    public List<string> ProcessMd(string mdText)
    {
        MarkdownDocument fullMarkdownDoc = Markdig.Markdown.Parse(mdText, basePipeline);

        List<FencedCodeBlock> codeBlocks = fullMarkdownDoc.Descendants<FencedCodeBlock>().ToList();

        List<MarkdownDocument> documentSections = new List<MarkdownDocument>();

        foreach (FencedCodeBlock codeBlock in codeBlocks)
        {
            MarkdownDocument documentSection = new MarkdownDocument();

            int codeBlockIndex = fullMarkdownDoc.IndexOf(codeBlock);
            for (int i = 0; i < codeBlockIndex; i++)
            {
                Block block = fullMarkdownDoc[0];
                fullMarkdownDoc.Remove(block);
                documentSection.Add(block);
            }

            documentSections.Add(documentSection);

            fullMarkdownDoc.Remove(codeBlock);
            documentSections.Add([codeBlock]);
        }

        if (fullMarkdownDoc.Count > 0)
            documentSections.Add(fullMarkdownDoc);

        return documentSections.Select(md => md.ToHtml()).ToList();
    }
}
