using Markdown.ColorCode.Examples;

MarkdownProcessor processor = new MarkdownProcessor();

string mdText =
"""
```cs
public static void HuhuFromCodeBlock()
{
    Console.WriteLine("Huhu");
}
```
""";

string htmlResult = processor.ProcessMd(mdText);

Console.ReadKey();
