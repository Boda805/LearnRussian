namespace LearnRussian;

using Markdig;

public class MarkdownService
{
    public string ConvertToHtml(string markdown)
    {
        // Configure the pipeline as needed, for example, to support advanced extensions
        var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
        
        return Markdown.ToHtml(markdown, pipeline);
    }
}