# Markdown.ColorCode

[![Build][github-checks-shield]][github-checks-url]
[![Coverage][coverage-shield]][coverage-url]

[![Version][nuget-version-shield]][nuget-url]
[![Downloads][nuget-downloads-shield]][nuget-url]

[![Contributor Covenant][contributor-covenant-shield]][contributor-covenant-url]
[![Contributors][contributors-shield]][contributors-url]
[![Commits][last-commit-shield]][last-commit-url]

[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

[![LinkedIn][linkedin-shield]][linkedin-url]

## About The Project

An extension for [Markdig](https://github.com/xoofx/markdig) that adds syntax highlighting to code through the power of [ColorCode](https://github.com/CommunityToolkit/ColorCode-Universal).

## Demonstration

### Before

```text
using Foo.Bar.Baz;

namespace Foo.Api;

public interface FooService {
    /// <summary>
    ///     Gets a new Foo!
    /// </summary>
    /// <returns>A new Foo</returns>
    public void GetFoo() {
        return new Foo();
    }
}
```

### After

```csharp
using Foo.Bar.Baz;

namespace Foo.Api;

public interface FooService {
    /// <summary>
    ///     Gets a new Foo!
    /// </summary>
    /// <returns>A new Foo</returns>
    public void GetFoo() {
        return new Foo();
    }
}
```

## Installation

### Package Manager

```text
Install-Package Markdown.ColorCode -Version 1.0.0
```

### .NET CLI

```text
dotnet add package Markdown.ColorCode --version 1.0.0
```

## Usage

To use this extension with [Markdig](https://github.com/xoofx/markdig), simply install the `Markdown.ColorCode` package use the ColorCode extension:

```cs
var pipeline = new MarkdownPipelineBuilder()
    .UseAdvancedExtensions()
    .UseColorCode()
    .Build();

var colorizedHtml = Markdig.Markdown.ToHtml(someMarkdown, pipeline);
```

## Roadmap

See the [open issues](https://github.com/wbaldoumas/markdown-colorcode/issues) for a list of proposed features (and known issues).

## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**. For detailed contributing guidelines, please see [CONTRIBUTING.md](CONTRIBUTING.md).

## License

Distributed under the `MIT License` License. See `LICENSE` for more information.

## Contact

[@wbaldoumas](https://github.com/wbaldoumas)

Project Link: [https://github.com/wbaldoumas/markdown-colorcode](https://github.com/wbaldoumas/markdown-colorcode)

## Acknowledgements

This `README` was adapted from
[https://github.com/othneildrew/Best-README-Template](https://github.com/othneildrew/Best-README-Template).

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/wbaldoumas/markdown-colorcode.svg?style=for-the-badge
[contributors-url]: https://github.com/wbaldoumas/markdown-colorcode/graphs/contributors
[contributor-covenant-shield]: https://img.shields.io/badge/Contributor%20Covenant-2.1-4baaaa.svg?style=for-the-badge
[contributor-covenant-url]: https://github.com/wbaldoumas/markdown-colorcode/blob/main/CODE_OF_CONDUCT.md
[forks-shield]: https://img.shields.io/github/forks/wbaldoumas/markdown-colorcode.svg?style=for-the-badge
[forks-url]: https://github.com/wbaldoumas/markdown-colorcode/network/members
[stars-shield]: https://img.shields.io/github/stars/wbaldoumas/markdown-colorcode.svg?style=for-the-badge
[stars-url]: https://github.com/wbaldoumas/markdown-colorcode/stargazers
[issues-shield]: https://img.shields.io/github/issues/wbaldoumas/markdown-colorcode.svg?style=for-the-badge
[issues-url]: https://github.com/wbaldoumas/markdown-colorcode/issues
[license-shield]: https://img.shields.io/github/license/wbaldoumas/markdown-colorcode.svg?style=for-the-badge
[license-url]: https://github.com/wbaldoumas/markdown-colorcode/blob/main/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/williambaldoumas
[github-checks-shield]: https://img.shields.io/github/checks-status/wbaldoumas/markdown-colorcode/main?style=for-the-badge
[github-checks-url]: https://github.com/wbaldoumas/markdown-colorcode/actions
[coverage-shield]: https://img.shields.io/codecov/c/github/wbaldoumas/markdown-colorcode?style=for-the-badge
[coverage-url]: https://app.codecov.io/gh/wbaldoumas/markdown-colorcode/branch/main
[nuget-version-shield]: https://img.shields.io/nuget/v/markdown.colorcode?style=for-the-badge
[nuget-downloads-shield]: https://img.shields.io/nuget/dt/markdown.colorcode?style=for-the-badge
[nuget-url]: https://www.nuget.org/packages/markdown.colorcode/
[last-commit-shield]: https://img.shields.io/github/last-commit/wbaldoumas/markdown-colorcode?style=for-the-badge
[last-commit-url]: https://github.com/wbaldoumas/markdown-colorcode/commits/main
