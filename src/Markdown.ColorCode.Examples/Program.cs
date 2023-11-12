using Markdown.ColorCode.Examples;

MarkdownProcessor processor = new MarkdownProcessor();

string mdText =
"""
# Basic Syntax

### Heading

# H1
## H2
### H3
#### H4
##### H5
###### H6

### Paragraph

This is the first paragraph.

This is the next paragraph separated by an empty line.

This is paragraph is very long so it will be wrapped on most screens to show the line height within a single paragraph. Hopefully this part here is on the next line with less space than between the two paragraphs above.

### Bold

**bold text**

### Italic

*italicized text*

### Blockquote

> blockquote


> ## Blockquote with header and list
> 
> 1. This is the first list item.
> 2. This is the second list item.

### Ordered List

1. First item
2. Second item
3. Third item

### Unordered List

- First item
- Second item
- Third item
  - First subitem
  - Second subitem

### Code

`if(test == true) return;`

##### Code in text

This is a paragraph containing a `if(test == true) return;` code block.

### Horizontal Rule

---

### Link

[Markdown Guide](https://www.markdownguide.org)

### Image

![alt text](https://www.markdownguide.org/assets/images/tux.png)

---
---
---

# Extended Syntax

These elements extend the basic syntax by adding additional features.
Not all Markdown applications support these elements.

### Tables

##### Simple table

| Syntax | Description |
| ----------- | ----------- |
| Header | Title |
| Paragraph | Text |

##### Table with alignment

| Default Header | Header Left Align | Header Right Align | Header Center Align |
| -------------- | :--------- | ----------: | :----------: |
| Row 1 Column 1 | Row 1 Column 2 | Row 1 Column 3 |Row 1 Column 4 |
| Row 2 Column 1 | Row 2 Column 2 | Row 2 Column 3 |Row 2 Column 4 |
| Row 3 Column 1 | Row 3 Column 2 | Row 3 Column 3 |Row 3 Column 4 |

### Fenced Code Blocks

##### Fenced code block without language

```
{
  "firstName": "John",
  "lastName": "Smith",
  "age": 25
}
```

##### Fenced code block with language (syntax highlighting)

```json
{
  "firstName": "John",
  "lastName": "Smith",
  "age": 25
}
```

### Footnote

Here's a sentence with a footnote. [^1]

[^1]: This is the footnote.

### Heading ID

### My Great Heading {#custom-id}

### Strikethrough

~~The world is flat.~~

### Task List

- [x] Write the press release
- [ ] Update the website
- [ ] Contact the media

### Emoji

That is so funny! :joy:

(See also [Copying and Pasting Emoji](https://www.markdownguide.org/extended-syntax/#copying-and-pasting-emoji))

### Highlight

I need to highlight these ==very important words==.

### Subscript

H~2~O

### Superscript

X^2^
""";

List<string> htmlResult = processor.ProcessMd(mdText);

Console.ReadKey();
