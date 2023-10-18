<div align="center">
<h1 align="center">
<img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" width="100" />
<br>TRADINGENGINE</h1>
<h3>◦ HTTPStatus Exception: 401</h3>
<h3>◦ Developed with the software and tools below.</h3>

<p align="center">
<img src="https://img.shields.io/badge/EditorConfig-FEFEFE.svg?style&logo=EditorConfig&logoColor=black" alt="EditorConfig" />
<img src="https://img.shields.io/badge/JSON-000000.svg?style&logo=JSON&logoColor=white" alt="JSON" />
</p>
<img src="https://img.shields.io/github/license/iyasinn/TradingEngine?style&color=5D6D7E" alt="GitHub license" />
<img src="https://img.shields.io/github/last-commit/iyasinn/TradingEngine?style&color=5D6D7E" alt="git-last-commit" />
<img src="https://img.shields.io/github/commit-activity/m/iyasinn/TradingEngine?style&color=5D6D7E" alt="GitHub commit activity" />
<img src="https://img.shields.io/github/languages/top/iyasinn/TradingEngine?style&color=5D6D7E" alt="GitHub top language" />
</div>

---

## 📖 Table of Contents
- [📖 Table of Contents](#-table-of-contents)
- [📍 Overview](#-overview)
- [📦 Features](#-features)
- [📂 Repository Structure](#-repository-structure)
- [⚙️ Modules](#modules)
- [🚀 Getting Started](#-getting-started)
    - [🔧 Installation](#-installation)
    - [🤖 Running TradingEngine](#-running-TradingEngine)
    - [🧪 Tests](#-tests)
- [🛣 Roadmap](#-roadmap)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [👏 Acknowledgments](#-acknowledgments)

---


## 📍 Overview

TradingEngine server that can take orders and match them 
---

## 📦 Features

Server with multiple orderbooks
FIFO matching algorithm
Logerbook
Templated code to use different loggers, matching algorithms, and orderbook implementations

---


## 📂 Repository Structure

```sh
└── TradingEngine/
    ├── AlgoTradingPlatform/
    │   └── .vscode/
    ├── ConsoleUI/
    │   ├── Console.cs
    │   ├── ConsoleUI.csproj
    │   └── obj/
    ├── GraphicCS/
    │   ├── Form1.Designer.cs
    │   ├── Form1.cs
    │   ├── Form1.resx
    │   ├── Graphic.cs
    │   ├── GraphicCS.csproj
    │   ├── GraphicCS.csproj.user
    │   ├── bin/
    │   └── obj/
    ├── GraphicUI/
    │   ├── Form1.Designer.cs
    │   ├── Form1.cs
    │   ├── Form1.resx
    │   ├── GraphicUI.csproj
    │   ├── GraphicUI.csproj.user
    │   ├── Program.cs
    │   ├── bin/
    │   └── obj/
    ├── InstrumentCS/
    │   ├── InstrumentCS.csproj
    │   ├── Security.cs
    │   ├── bin/
    │   └── obj/
    ├── LoggingCS/
    │   ├── AbstractLogger.cs
    │   ├── ILogger.cs
    │   ├── ITextLogger.cs
    │   ├── LogInformation.cs
    │   ├── LogLevel.cs
    │   ├── LoggerType.cs
    │   ├── LoggingCS.csproj
    │   ├── LoggingConfiguration/
    │   ├── TextLogger.cs
    │   ├── bin/
    │   └── obj/
    ├── OrderbookCS/
    │   ├── IMatchingOrderbook.cs
    │   ├── IOrderEntryOrderbook.cs
    │   ├── IReadOnlyOrderbook.cs
    │   ├── IRetrievalOrderbook.cs
    │   ├── MatchResult.cs
    │   ├── NoMatchOrderbook.cs
    │   ├── OrderbookCS.csproj
    │   ├── OrderbookSpread.cs
    │   ├── bin/
    │   └── obj/
    ├── OrdersCS/
    │   ├── CancelOrder.cs
    │   ├── CancelOrderStatus.cs
    │   ├── IOrderCore.cs
    │   ├── Limit.cs
    │   ├── LimitComparer.cs
    │   ├── ModifyOrder.cs
    │   ├── ModifyOrderStatus.cs
    │   ├── NewOrderStatus.cs
    │   ├── Order.cs
    │   ├── OrderBookEntry.cs
    │   ├── OrderCore.cs
    │   ├── OrderRecord.cs
    │   ├── OrderStatusCreator.cs
    │   ├── OrdersCS.csproj
    │   ├── RejectCreator.cs
    │   ├── Rejection.cs
    │   ├── RejectionReason.cs
    │   ├── Side.cs
    │   ├── bin/
    │   └── obj/
    ├── RejectCS/
    │   ├── Class1.cs
    │   ├── RejectCS.csproj
    │   └── obj/
    ├── TradingEngineServer/
    ├── WinFormsApp1/
    │   ├── .vs/
    │   ├── Form1.Designer.cs
    │   ├── Form1.cs
    │   ├── Form1.resx
    │   ├── Program.cs
    │   ├── WinFormsApp1.csproj
    │   ├── WinFormsApp1.csproj.user
    │   ├── WinFormsApp1.sln
    │   ├── bin/
    │   └── obj/
    ├── WinFormsLibrary1/
    │   ├── .vs/
    │   ├── Class1.cs
    │   ├── WinFormsLibrary1.csproj
    │   ├── WinFormsLibrary1.csproj.user
    │   ├── WinFormsLibrary1.sln
    │   ├── bin/
    │   └── obj/
    └── WinFormsLibrary2/
        ├── Class1.cs
        ├── WinFormsLibrary2.csproj
        └── obj/
```


---

## ⚙️ Modules

<details closed><summary>Winformslibrary2</summary>

| File                                                                                                                   | Summary                   |
| ---                                                                                                                    | ---                       |
| [Class1.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/Class1.cs)                             | HTTPStatus Exception: 401 |
| [WinFormsLibrary2.csproj](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/WinFormsLibrary2.csproj) | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Obj</summary>

| File                                                                                                                                                       | Summary                   |
| ---                                                                                                                                                        | ---                       |
| [WinFormsLibrary2.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/obj/WinFormsLibrary2.csproj.nuget.g.props)     | HTTPStatus Exception: 401 |
| [WinFormsLibrary2.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/obj/WinFormsLibrary2.csproj.nuget.g.targets) | HTTPStatus Exception: 401 |
| [LoggingCS.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/LoggingCS.csproj.nuget.g.targets)                      | HTTPStatus Exception: 401 |
| [LoggingCS.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/LoggingCS.csproj.nuget.g.props)                          | HTTPStatus Exception: 401 |
| [ConsoleUI.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/obj/ConsoleUI.csproj.nuget.g.targets)                      | HTTPStatus Exception: 401 |
| [ConsoleUI.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/obj/ConsoleUI.csproj.nuget.g.props)                          | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/WinFormsLibrary1.csproj.nuget.g.props)     | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/WinFormsLibrary1.csproj.nuget.g.targets) | HTTPStatus Exception: 401 |
| [InstrumentCS.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/InstrumentCS.csproj.nuget.g.targets)             | HTTPStatus Exception: 401 |
| [InstrumentCS.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/InstrumentCS.csproj.nuget.g.props)                 | HTTPStatus Exception: 401 |
| [GraphicUI.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/GraphicUI.csproj.nuget.g.targets)                      | HTTPStatus Exception: 401 |
| [GraphicUI.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/GraphicUI.csproj.nuget.g.props)                          | HTTPStatus Exception: 401 |
| [WinFormsApp1.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/WinFormsApp1.csproj.nuget.g.targets)             | HTTPStatus Exception: 401 |
| [WinFormsApp1.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/WinFormsApp1.csproj.nuget.g.props)                 | HTTPStatus Exception: 401 |
| [OrdersCS.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/OrdersCS.csproj.nuget.g.targets)                         | HTTPStatus Exception: 401 |
| [OrdersCS.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/OrdersCS.csproj.nuget.g.props)                             | HTTPStatus Exception: 401 |
| [GraphicCS.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/GraphicCS.csproj.nuget.g.props)                          | HTTPStatus Exception: 401 |
| [GraphicCS.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/GraphicCS.csproj.nuget.g.targets)                      | HTTPStatus Exception: 401 |
| [RejectCS.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/obj/RejectCS.csproj.nuget.g.targets)                         | HTTPStatus Exception: 401 |
| [RejectCS.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/obj/RejectCS.csproj.nuget.g.props)                             | HTTPStatus Exception: 401 |
| [OrderbookCS.csproj.nuget.g.props](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/OrderbookCS.csproj.nuget.g.props)                    | HTTPStatus Exception: 401 |
| [OrderbookCS.csproj.nuget.g.targets](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/OrderbookCS.csproj.nuget.g.targets)                | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Net6.0-windows</summary>

| File                                                                                                                                                                                                                  | Summary                   |
| ---                                                                                                                                                                                                                   | ---                       |
| [WinFormsLibrary2.GlobalUsings.g.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/obj/Debug/net6.0-windows/WinFormsLibrary2.GlobalUsings.g.cs)                                                 | HTTPStatus Exception: 401 |
| [.NETCoreApp,Version=v6.0.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/obj/Debug/net6.0-windows/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs)                         | HTTPStatus Exception: 401 |
| [WinFormsLibrary2.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/obj/Debug/net6.0-windows/WinFormsLibrary2.AssemblyInfo.cs)                                                     | HTTPStatus Exception: 401 |
| [WinFormsLibrary2.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary2/obj/Debug/net6.0-windows/WinFormsLibrary2.GeneratedMSBuildEditorConfig.editorconfig) | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.GeneratedMSBuildEditorConfig.editorconfig) | HTTPStatus Exception: 401 |
| [.NETCoreApp,Version=v6.0.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/Debug/net6.0-windows/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs)                         | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.AssemblyInfo.cs)                                                     | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.csproj.BuildWithSkipAnalyzers)                         | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.GlobalUsings.g.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.GlobalUsings.g.cs)                                                 | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.csproj.FileListAbsolute.txt)                             | HTTPStatus Exception: 401 |
| [GraphicUI.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/Debug/net6.0-windows/GraphicUI.csproj.BuildWithSkipAnalyzers)                                              | HTTPStatus Exception: 401 |
| [GraphicUI.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/Debug/net6.0-windows/GraphicUI.AssemblyInfo.cs)                                                                          | HTTPStatus Exception: 401 |
| [.NETCoreApp,Version=v6.0.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/Debug/net6.0-windows/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs)                                | HTTPStatus Exception: 401 |
| [GraphicUI.GlobalUsings.g.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/Debug/net6.0-windows/GraphicUI.GlobalUsings.g.cs)                                                                      | HTTPStatus Exception: 401 |
| [GraphicUI.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/Debug/net6.0-windows/GraphicUI.csproj.FileListAbsolute.txt)                                                  | HTTPStatus Exception: 401 |
| [GraphicUI.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/obj/Debug/net6.0-windows/GraphicUI.GeneratedMSBuildEditorConfig.editorconfig)                      | HTTPStatus Exception: 401 |
| [WinFormsApp1.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.csproj.FileListAbsolute.txt)                                         | HTTPStatus Exception: 401 |
| [.NETCoreApp,Version=v6.0.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/Debug/net6.0-windows/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs)                             | HTTPStatus Exception: 401 |
| [WinFormsApp1.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.GeneratedMSBuildEditorConfig.editorconfig)             | HTTPStatus Exception: 401 |
| [WinFormsApp1.GlobalUsings.g.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.GlobalUsings.g.cs)                                                             | HTTPStatus Exception: 401 |
| [WinFormsApp1.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.AssemblyInfo.cs)                                                                 | HTTPStatus Exception: 401 |
| [WinFormsApp1.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.csproj.BuildWithSkipAnalyzers)                                     | HTTPStatus Exception: 401 |
| [GraphicCS.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/Debug/net6.0-windows/GraphicCS.csproj.FileListAbsolute.txt)                                                  | HTTPStatus Exception: 401 |
| [GraphicCS.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/Debug/net6.0-windows/GraphicCS.AssemblyInfo.cs)                                                                          | HTTPStatus Exception: 401 |
| [.NETCoreApp,Version=v6.0.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/Debug/net6.0-windows/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs)                                | HTTPStatus Exception: 401 |
| [GraphicCS.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/Debug/net6.0-windows/GraphicCS.GeneratedMSBuildEditorConfig.editorconfig)                      | HTTPStatus Exception: 401 |
| [GraphicCS.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/Debug/net6.0-windows/GraphicCS.csproj.BuildWithSkipAnalyzers)                                              | HTTPStatus Exception: 401 |
| [GraphicCS.GlobalUsings.g.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/obj/Debug/net6.0-windows/GraphicCS.GlobalUsings.g.cs)                                                                      | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Loggingcs</summary>

| File                                                                                                | Summary                   |
| ---                                                                                                 | ---                       |
| [TextLogger.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/TextLogger.cs)         | HTTPStatus Exception: 401 |
| [ITextLogger.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/ITextLogger.cs)       | HTTPStatus Exception: 401 |
| [AbstractLogger.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/AbstractLogger.cs) | HTTPStatus Exception: 401 |
| [LogInformation.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/LogInformation.cs) | HTTPStatus Exception: 401 |
| [LoggingCS.csproj](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/LoggingCS.csproj)   | HTTPStatus Exception: 401 |
| [LoggerType.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/LoggerType.cs)         | HTTPStatus Exception: 401 |
| [LogLevel.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/LogLevel.cs)             | HTTPStatus Exception: 401 |
| [ILogger.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/ILogger.cs)               | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Netstandard2.1</summary>

| File                                                                                                                                                                                                      | Summary                   |
| ---                                                                                                                                                                                                       | ---                       |
| [LoggingCS.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/Debug/netstandard2.1/LoggingCS.csproj.BuildWithSkipAnalyzers)                                  | HTTPStatus Exception: 401 |
| [.NETStandard,Version=v2.1.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/Debug/netstandard2.1/.NETStandard,Version=v2.1.AssemblyAttributes.cs)                  | HTTPStatus Exception: 401 |
| [LoggingCS.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/Debug/netstandard2.1/LoggingCS.AssemblyInfo.cs)                                                              | HTTPStatus Exception: 401 |
| [LoggingCS.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/Debug/netstandard2.1/LoggingCS.GeneratedMSBuildEditorConfig.editorconfig)          | HTTPStatus Exception: 401 |
| [LoggingCS.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/obj/Debug/netstandard2.1/LoggingCS.csproj.FileListAbsolute.txt)                                      | HTTPStatus Exception: 401 |
| [InstrumentCS.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/Debug/netstandard2.1/InstrumentCS.csproj.BuildWithSkipAnalyzers)                         | HTTPStatus Exception: 401 |
| [.NETStandard,Version=v2.1.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/Debug/netstandard2.1/.NETStandard,Version=v2.1.AssemblyAttributes.cs)               | HTTPStatus Exception: 401 |
| [InstrumentCS.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/Debug/netstandard2.1/InstrumentCS.AssemblyInfo.cs)                                                     | HTTPStatus Exception: 401 |
| [InstrumentCS.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/Debug/netstandard2.1/InstrumentCS.csproj.FileListAbsolute.txt)                             | HTTPStatus Exception: 401 |
| [InstrumentCS.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/obj/Debug/netstandard2.1/InstrumentCS.GeneratedMSBuildEditorConfig.editorconfig) | HTTPStatus Exception: 401 |
| [.NETStandard,Version=v2.1.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/Debug/netstandard2.1/.NETStandard,Version=v2.1.AssemblyAttributes.cs)                   | HTTPStatus Exception: 401 |
| [OrdersCS.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/Debug/netstandard2.1/OrdersCS.csproj.BuildWithSkipAnalyzers)                                     | HTTPStatus Exception: 401 |
| [OrdersCS.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/Debug/netstandard2.1/OrdersCS.GeneratedMSBuildEditorConfig.editorconfig)             | HTTPStatus Exception: 401 |
| [OrdersCS.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/Debug/netstandard2.1/OrdersCS.csproj.FileListAbsolute.txt)                                         | HTTPStatus Exception: 401 |
| [OrdersCS.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/obj/Debug/netstandard2.1/OrdersCS.AssemblyInfo.cs)                                                                 | HTTPStatus Exception: 401 |
| [RejectCS.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/obj/Debug/netstandard2.1/RejectCS.AssemblyInfo.cs)                                                                 | HTTPStatus Exception: 401 |
| [.NETStandard,Version=v2.1.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/obj/Debug/netstandard2.1/.NETStandard,Version=v2.1.AssemblyAttributes.cs)                   | HTTPStatus Exception: 401 |
| [RejectCS.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/obj/Debug/netstandard2.1/RejectCS.GeneratedMSBuildEditorConfig.editorconfig)             | HTTPStatus Exception: 401 |
| [OrderbookCS.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.AssemblyInfo.cs)                                                        | HTTPStatus Exception: 401 |
| [.NETStandard,Version=v2.1.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/Debug/netstandard2.1/.NETStandard,Version=v2.1.AssemblyAttributes.cs)                | HTTPStatus Exception: 401 |
| [OrderbookCS.csproj.CopyComplete](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.csproj.CopyComplete)                                                | HTTPStatus Exception: 401 |
| [OrderbookCS.csproj.BuildWithSkipAnalyzers](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.csproj.BuildWithSkipAnalyzers)                            | HTTPStatus Exception: 401 |
| [OrderbookCS.csproj.FileListAbsolute.txt](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.csproj.FileListAbsolute.txt)                                | HTTPStatus Exception: 401 |
| [OrderbookCS.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.GeneratedMSBuildEditorConfig.editorconfig)    | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Loggingconfiguration</summary>

| File                                                                                                                               | Summary                   |
| ---                                                                                                                                | ---                       |
| [LoggerConfiguration.cs](https://github.com/iyasinn/TradingEngine/blob/main/LoggingCS/LoggingConfiguration/LoggerConfiguration.cs) | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Consoleui</summary>

| File                                                                                              | Summary                   |
| ---                                                                                               | ---                       |
| [ConsoleUI.csproj](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/ConsoleUI.csproj) | HTTPStatus Exception: 401 |
| [Console.cs](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/Console.cs)             | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Net6.0</summary>

| File                                                                                                                                                                                     | Summary                   |
| ---                                                                                                                                                                                      | ---                       |
| [.NETCoreApp,Version=v6.0.AssemblyAttributes.cs](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/obj/Debug/net6.0/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs)           | HTTPStatus Exception: 401 |
| [ConsoleUI.GeneratedMSBuildEditorConfig.editorconfig](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/obj/Debug/net6.0/ConsoleUI.GeneratedMSBuildEditorConfig.editorconfig) | HTTPStatus Exception: 401 |
| [ConsoleUI.AssemblyInfo.cs](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/obj/Debug/net6.0/ConsoleUI.AssemblyInfo.cs)                                                     | HTTPStatus Exception: 401 |
| [ConsoleUI.GlobalUsings.g.cs](https://github.com/iyasinn/TradingEngine/blob/main/ConsoleUI/obj/Debug/net6.0/ConsoleUI.GlobalUsings.g.cs)                                                 | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Winformslibrary1</summary>

| File                                                                                                                             | Summary                   |
| ---                                                                                                                              | ---                       |
| [Class1.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/Class1.cs)                                       | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.csproj.user](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/WinFormsLibrary1.csproj.user) | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.csproj](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/WinFormsLibrary1.csproj)           | HTTPStatus Exception: 401 |
| [WinFormsLibrary1.sln](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/WinFormsLibrary1.sln)                 | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Filecontentindex</summary>

| File                                                                                                                             | Summary                   |
| ---                                                                                                                              | ---                       |
| [read.lock](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsLibrary1/.vs/WinFormsLibrary1/FileContentIndex/read.lock) | HTTPStatus Exception: 401 |
| [read.lock](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/.vs/WinFormsApp1/FileContentIndex/read.lock)         | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Instrumentcs</summary>

| File                                                                                                       | Summary                   |
| ---                                                                                                        | ---                       |
| [InstrumentCS.csproj](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/InstrumentCS.csproj) | HTTPStatus Exception: 401 |
| [Security.cs](https://github.com/iyasinn/TradingEngine/blob/main/InstrumentCS/Security.cs)                 | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Graphicui</summary>

| File                                                                                                        | Summary                   |
| ---                                                                                                         | ---                       |
| [GraphicUI.csproj](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/GraphicUI.csproj)           | HTTPStatus Exception: 401 |
| [Form1.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/Form1.cs)                           | HTTPStatus Exception: 401 |
| [GraphicUI.csproj.user](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/GraphicUI.csproj.user) | HTTPStatus Exception: 401 |
| [Program.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/Program.cs)                       | HTTPStatus Exception: 401 |
| [Form1.Designer.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/Form1.Designer.cs)         | HTTPStatus Exception: 401 |
| [Form1.resx](https://github.com/iyasinn/TradingEngine/blob/main/GraphicUI/Form1.resx)                       | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Winformsapp1</summary>

| File                                                                                                                 | Summary                   |
| ---                                                                                                                  | ---                       |
| [WinFormsApp1.csproj.user](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/WinFormsApp1.csproj.user) | HTTPStatus Exception: 401 |
| [Form1.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/Form1.cs)                                 | HTTPStatus Exception: 401 |
| [Program.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/Program.cs)                             | HTTPStatus Exception: 401 |
| [WinFormsApp1.csproj](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/WinFormsApp1.csproj)           | HTTPStatus Exception: 401 |
| [Form1.Designer.cs](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/Form1.Designer.cs)               | HTTPStatus Exception: 401 |
| [Form1.resx](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/Form1.resx)                             | HTTPStatus Exception: 401 |
| [WinFormsApp1.sln](https://github.com/iyasinn/TradingEngine/blob/main/WinFormsApp1/WinFormsApp1.sln)                 | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Orderscs</summary>

| File                                                                                                       | Summary                   |
| ---                                                                                                        | ---                       |
| [CancelOrderStatus.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/CancelOrderStatus.cs)   | HTTPStatus Exception: 401 |
| [OrderBookEntry.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/OrderBookEntry.cs)         | HTTPStatus Exception: 401 |
| [Order.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/Order.cs)                           | HTTPStatus Exception: 401 |
| [LimitComparer.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/LimitComparer.cs)           | HTTPStatus Exception: 401 |
| [RejectionReason.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/RejectionReason.cs)       | HTTPStatus Exception: 401 |
| [Rejection.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/Rejection.cs)                   | HTTPStatus Exception: 401 |
| [IOrderCore.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/IOrderCore.cs)                 | HTTPStatus Exception: 401 |
| [ModifyOrder.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/ModifyOrder.cs)               | HTTPStatus Exception: 401 |
| [CancelOrder.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/CancelOrder.cs)               | HTTPStatus Exception: 401 |
| [ModifyOrderStatus.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/ModifyOrderStatus.cs)   | HTTPStatus Exception: 401 |
| [RejectCreator.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/RejectCreator.cs)           | HTTPStatus Exception: 401 |
| [Limit.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/Limit.cs)                           | HTTPStatus Exception: 401 |
| [OrderRecord.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/OrderRecord.cs)               | HTTPStatus Exception: 401 |
| [OrderStatusCreator.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/OrderStatusCreator.cs) | HTTPStatus Exception: 401 |
| [OrdersCS.csproj](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/OrdersCS.csproj)             | HTTPStatus Exception: 401 |
| [NewOrderStatus.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/NewOrderStatus.cs)         | HTTPStatus Exception: 401 |
| [Side.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/Side.cs)                             | HTTPStatus Exception: 401 |
| [OrderCore.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrdersCS/OrderCore.cs)                   | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Graphiccs</summary>

| File                                                                                                        | Summary                   |
| ---                                                                                                         | ---                       |
| [Graphic.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/Graphic.cs)                       | HTTPStatus Exception: 401 |
| [Form1.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/Form1.cs)                           | HTTPStatus Exception: 401 |
| [GraphicCS.csproj](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/GraphicCS.csproj)           | HTTPStatus Exception: 401 |
| [GraphicCS.csproj.user](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/GraphicCS.csproj.user) | HTTPStatus Exception: 401 |
| [Form1.Designer.cs](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/Form1.Designer.cs)         | HTTPStatus Exception: 401 |
| [Form1.resx](https://github.com/iyasinn/TradingEngine/blob/main/GraphicCS/Form1.resx)                       | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Rejectcs</summary>

| File                                                                                           | Summary                   |
| ---                                                                                            | ---                       |
| [Class1.cs](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/Class1.cs)             | HTTPStatus Exception: 401 |
| [RejectCS.csproj](https://github.com/iyasinn/TradingEngine/blob/main/RejectCS/RejectCS.csproj) | HTTPStatus Exception: 401 |

</details>

<details closed><summary>Orderbookcs</summary>

| File                                                                                                              | Summary                   |
| ---                                                                                                               | ---                       |
| [NoMatchOrderbook.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/NoMatchOrderbook.cs)         | HTTPStatus Exception: 401 |
| [IReadOnlyOrderbook.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/IReadOnlyOrderbook.cs)     | HTTPStatus Exception: 401 |
| [MatchResult.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/MatchResult.cs)                   | HTTPStatus Exception: 401 |
| [OrderbookCS.csproj](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/OrderbookCS.csproj)           | HTTPStatus Exception: 401 |
| [IMatchingOrderbook.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/IMatchingOrderbook.cs)     | HTTPStatus Exception: 401 |
| [IRetrievalOrderbook.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/IRetrievalOrderbook.cs)   | HTTPStatus Exception: 401 |
| [OrderbookSpread.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/OrderbookSpread.cs)           | HTTPStatus Exception: 401 |
| [IOrderEntryOrderbook.cs](https://github.com/iyasinn/TradingEngine/blob/main/OrderbookCS/IOrderEntryOrderbook.cs) | HTTPStatus Exception: 401 |

</details>

---

## 🚀 Getting Started

***Dependencies***

Please ensure you have the following dependencies installed on your system:

`- ℹ️ Dependency 1`

`- ℹ️ Dependency 2`

`- ℹ️ ...`

### 🔧 Installation

1. Clone the TradingEngine repository:
```sh
git clone https://github.com/iyasinn/TradingEngine
```

2. Change to the project directory:
```sh
cd TradingEngine
```

3. Install the dependencies:
```sh
dotnet build
```

### 🤖 Running TradingEngine

```sh
dotnet run
```

### 🧪 Tests
```sh
dotnet test
```

---


## 🛣 Roadmap

> - [X] `ℹ️  Task 1: Implement X`
> - [ ] `ℹ️  Task 2: Implement Y`
> - [ ] `ℹ️ ...`


---

## 🤝 Contributing

Contributions are always welcome! Please follow these steps:
1. Fork the project repository. This creates a copy of the project on your account that you can modify without affecting the original project.
2. Clone the forked repository to your local machine using a Git client like Git or GitHub Desktop.
3. Create a new branch with a descriptive name (e.g., `new-feature-branch` or `bugfix-issue-123`).
```sh
git checkout -b new-feature-branch
```
4. Make changes to the project's codebase.
5. Commit your changes to your local branch with a clear commit message that explains the changes you've made.
```sh
git commit -m 'Implemented new feature.'
```
6. Push your changes to your forked repository on GitHub using the following command
```sh
git push origin new-feature-branch
```
7. Create a new pull request to the original project repository. In the pull request, describe the changes you've made and why they're necessary.
The project maintainers will review your changes and provide feedback or merge them into the main branch.

---

## 📄 License

This project is licensed under the `ℹ️  LICENSE-TYPE` License. See the [LICENSE-Type](LICENSE) file for additional info.

---

## 👏 Acknowledgments

`- ℹ️ List any resources, contributors, inspiration, etc.`

[↑ Return](#Top)

---
