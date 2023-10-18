[32mINFO    [0m [34mREADME-AI is now executing.[0m
[32mINFO    [0m [34mUser Repository: https://github.com/iyasinn/TradingEngine[0m
[32mINFO    [0m [34mOutput README File: readmeai.md[0m
[32mINFO    [0m [34mLLM Engine:  gpt-3.5-turbo[0m
[32mINFO    [0m [34mDirectory tree: 
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
[0m
[32mINFO    [0m [34mDependencies: ['', 'GraphicCS.AssemblyInfoInputs.cache', 'TradingEngineServer.Orderbook.deps.json', 'AbstractLogger.cs', 'InstrumentCS.csproj.FileListAbsolute.txt', '.NETCoreApp,Version=v6.0.AssemblyAttributes.cs', 'GraphicUI.csproj.BuildWithSkipAnalyzers', 'Console.cs', 'Limit.cs', 'RejectCS.csproj.nuget.dgspec.json', 'InstrumentCS.AssemblyInfo.cs', 'ConsoleUI.csproj.nuget.g.targets', 'GraphicCS.csproj.BuildWithSkipAnalyzers', 'IOrderEntryOrderbook.cs', 'Rejection.cs', 'props', 'OrdersCS.csproj.CoreCompileInputs.cache', 'OrderCore.cs', 'editorconfig', 'WinFormsApp1.designer.deps.json', 'WinFormsLibrary1.GeneratedMSBuildEditorConfig.editorconfig', 'InstrumentCS.AssemblyInfoInputs.cache', 'ConsoleUI.GlobalUsings.g.cs', 'TextLogger.cs', 'OrderbookCS.csproj', 'OrdersCS.csproj.nuget.g.props', 'NewOrderStatus.cs', 'cs', 'ConsoleUI.csproj', 'LoggingCS.csproj.CoreCompileInputs.cache', 'csproj', 'GraphicUI.csproj.nuget.g.targets', 'WinFormsLibrary1.csproj', 'WinFormsLibrary2.csproj.nuget.g.targets', 'OrderbookCS.csproj.nuget.g.targets', 'WinFormsApp1.AssemblyInfo.cs', 'LoggingCS.csproj.nuget.g.targets', 'LoggingCS.csproj.nuget.g.props', 'GraphicUI.runtimeconfig.json', 'WinFormsApp1.csproj.CoreCompileInputs.cache', 'ModifyOrderStatus.cs', 'OrdersCS.AssemblyInfo.cs', 'OrderbookCS.csproj.nuget.dgspec.json', 'targets', 'GraphicCS.GlobalUsings.g.cs', 'WinFormsApp1.csproj.BuildWithSkipAnalyzers', 'GraphicUI.genruntimeconfig.cache', 'WinFormsApp1.sln', 'InstrumentCS.csproj.BuildWithSkipAnalyzers', 'WinFormsApp1.GeneratedMSBuildEditorConfig.editorconfig', 'GraphicUI.AssemblyInfoInputs.cache', 'LimitComparer.cs', 'GraphicUI.csproj.FileListAbsolute.txt', 'sln', 'GraphicUI.designer.runtimeconfig.json', 'json', 'LoggingCS.AssemblyInfoInputs.cache', 'OrdersCS.AssemblyInfoInputs.cache', 'GraphicCS.csproj.nuget.g.props', 'ConsoleUI.GeneratedMSBuildEditorConfig.editorconfig', 'Side.cs', 'ILogger.cs', 'OrderbookCS.AssemblyInfoInputs.cache', 'ConsoleUI.AssemblyInfo.cs', 'NoMatchOrderbook.cs', 'RejectCS.GeneratedMSBuildEditorConfig.editorconfig', 'OrderbookCS.AssemblyInfo.cs', 'ConsoleUI.csproj.nuget.g.props', 'OrderStatusCreator.cs', 'OrderbookCS.csproj.nuget.g.props', 'OrderbookCS.csproj.BuildWithSkipAnalyzers', 'WinFormsLibrary2.AssemblyInfo.cs', 'WinFormsLibrary1.csproj.user', 'GraphicCS.designer.runtimeconfig.json', 'GraphicCS.csproj', 'Form1.cs', 'LoggingCS.GeneratedMSBuildEditorConfig.editorconfig', 'IReadOnlyOrderbook.cs', 'WinFormsApp1.csproj.user', 'GraphicCS.designer.deps.json', 'WinFormsLibrary2.csproj', 'OrderRecord.cs', 'WinFormsApp1.csproj.FileListAbsolute.txt', 'GraphicUI.csproj.nuget.g.props', 'LoggerType.cs', 'OrderbookCS.csproj.CopyComplete', 'text', 'InstrumentCS.csproj.nuget.dgspec.json', 'InstrumentCS.GeneratedMSBuildEditorConfig.editorconfig', 'WinFormsApp1.csproj.nuget.dgspec.json', 'resx', 'project.assets.json', 'WinFormsLibrary1.csproj.nuget.g.targets', 'WinFormsApp1.deps.json', 'WinFormsApp1.GlobalUsings.g.cs', 'WinFormsLibrary1.csproj.BuildWithSkipAnalyzers', 'CancelOrderStatus.cs', 'Security.cs', 'GraphicCS.csproj.nuget.dgspec.json', 'OrdersCS.GeneratedMSBuildEditorConfig.editorconfig', 'LoggingCS.csproj.nuget.dgspec.json', 'Form1.Designer.cs', 'lock', 'WinFormsLibrary2.GlobalUsings.g.cs', 'GraphicUI.AssemblyInfo.cs', 'WinFormsApp1.AssemblyInfoInputs.cache', 'OrdersCS.csproj.nuget.g.targets', 'csharp', 'WinFormsApp1.designer.runtimeconfig.json', 'GraphicCS.GeneratedMSBuildEditorConfig.editorconfig', 'IMatchingOrderbook.cs', 'GraphicUI.csproj.CoreCompileInputs.cache', 'read.lock', 'OrdersCS.csproj', 'WinFormsLibrary1.AssemblyInfo.cs', 'WinFormsLibrary1.GlobalUsings.g.cs', 'LoggerConfiguration.cs', 'WinFormsApp1.runtimeconfig.json', 'ITextLogger.cs', 'GraphicCS.csproj.CoreCompileInputs.cache', 'TradingEngineServer.Orders.deps.json', 'InstrumentCS.csproj.nuget.g.targets', 'txt', 'GraphicCS.genruntimeconfig.cache', 'OrderbookSpread.cs', 'GraphicUI.csproj', 'project.nuget.cache', 'GraphicCS.deps.json', 'LoggingCS.AssemblyInfo.cs', 'Order.cs', 'CancelOrder.cs', 'GraphicUI.designer.deps.json', 'TradingEngineServer.Logging.deps.json', 'WinFormsApp1.genruntimeconfig.cache', 'ModifyOrder.cs', 'WinFormsLibrary2.csproj.nuget.g.props', 'GraphicCS.csproj.nuget.g.targets', 'GraphicCS.csproj.FileListAbsolute.txt', 'IOrderCore.cs', 'settings.json', 'OrdersCS.csproj.nuget.dgspec.json', 'BuildWithSkipAnalyzers', 'OrdersCS.csproj.FileListAbsolute.txt', 'ConsoleUI.AssemblyInfoInputs.cache', 'Form1.resx', 'OrderbookCS.csproj.CoreCompileInputs.cache', 'WinFormsLibrary1.csproj.FileListAbsolute.txt', 'LogInformation.cs', 'WinFormsLibrary2.AssemblyInfoInputs.cache', 'GraphicUI.csproj.nuget.dgspec.json', 'WinFormsLibrary1.sln', 'GraphicUI.GlobalUsings.g.cs', 'TradingEngineServer.Instrument.deps.json', 'WinFormsLibrary1.csproj.nuget.dgspec.json', '.NETStandard,Version=v2.1.AssemblyAttributes.cs', 'Class1.cs', 'LoggingCS.csproj', 'WinFormsApp1.csproj', 'GraphicCS.runtimeconfig.json', 'RejectCS.csproj', 'GraphicUI.GeneratedMSBuildEditorConfig.editorconfig', 'MatchResult.cs', 'CopyComplete', 'WinFormsLibrary2.GeneratedMSBuildEditorConfig.editorconfig', 'IRetrievalOrderbook.cs', 'OrderBookEntry.cs', 'GraphicCS.csproj.user', 'InstrumentCS.csproj', 'WinFormsLibrary1.deps.json', 'GraphicCS.AssemblyInfo.cs', 'GraphicUI.deps.json', 'GraphicUI.csproj.user', 'cache', 'LoggingCS.csproj.BuildWithSkipAnalyzers', 'InstrumentCS.csproj.CoreCompileInputs.cache', 'Program.cs', 'RejectionReason.cs', 'LogLevel.cs', 'ConsoleUI.csproj.nuget.dgspec.json', 'Graphic.cs', 'OrderbookCS.GeneratedMSBuildEditorConfig.editorconfig', 'RejectCS.AssemblyInfo.cs', 'WinFormsLibrary1.AssemblyInfoInputs.cache', 'RejectCS.csproj.nuget.g.targets', 'OrderbookCS.csproj.FileListAbsolute.txt', 'RejectCS.csproj.nuget.g.props', 'WinFormsLibrary2.csproj.nuget.dgspec.json', 'WinFormsApp1.csproj.nuget.g.props', 'user', 'WinFormsLibrary1.csproj.CoreCompileInputs.cache', 'InstrumentCS.csproj.nuget.g.props', 'RejectCS.AssemblyInfoInputs.cache', 'LoggingCS.csproj.FileListAbsolute.txt', 'WinFormsApp1.csproj.nuget.g.targets', 'RejectCreator.cs', 'OrdersCS.csproj.BuildWithSkipAnalyzers', 'WinFormsLibrary1.csproj.nuget.g.props'][0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary2/obj/WinFormsLibrary2.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary2/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary2/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary2/obj/Debug/net6.0-windows/WinFormsLibrary2.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: LoggingCS/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: LoggingCS/obj/LoggingCS.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: LoggingCS/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: LoggingCS/obj/Debug/netstandard2.1/LoggingCS.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: LoggingCS/obj/Debug/netstandard2.1/LoggingCS.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: LoggingCS/bin/Debug/netstandard2.1/TradingEngineServer.Logging.deps.json[0m
[33mWARNING [0m [34mIgnoring file: ConsoleUI/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: ConsoleUI/obj/ConsoleUI.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: ConsoleUI/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: ConsoleUI/obj/Debug/net6.0/ConsoleUI.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary1/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary1/obj/WinFormsLibrary1.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary1/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary1/obj/Debug/net6.0-windows/WinFormsLibrary1.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsLibrary1/bin/Debug/net6.0-windows/WinFormsLibrary1.deps.json[0m
[33mWARNING [0m [34mIgnoring file: InstrumentCS/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: InstrumentCS/obj/InstrumentCS.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: InstrumentCS/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: InstrumentCS/obj/Debug/netstandard2.1/InstrumentCS.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: InstrumentCS/obj/Debug/netstandard2.1/InstrumentCS.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: InstrumentCS/bin/Debug/netstandard2.1/TradingEngineServer.Instrument.deps.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/GraphicUI.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/Debug/net6.0-windows/GraphicUI.designer.runtimeconfig.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/Debug/net6.0-windows/GraphicUI.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/Debug/net6.0-windows/GraphicUI.genruntimeconfig.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/Debug/net6.0-windows/GraphicUI.designer.deps.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/obj/Debug/net6.0-windows/GraphicUI.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/bin/Debug/net6.0-windows/GraphicUI.deps.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicUI/bin/Debug/net6.0-windows/GraphicUI.runtimeconfig.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/WinFormsApp1.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.genruntimeconfig.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.designer.runtimeconfig.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.designer.deps.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/obj/Debug/net6.0-windows/WinFormsApp1.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/bin/Debug/net6.0-windows/WinFormsApp1.deps.json[0m
[33mWARNING [0m [34mIgnoring file: WinFormsApp1/bin/Debug/net6.0-windows/WinFormsApp1.runtimeconfig.json[0m
[33mWARNING [0m [34mIgnoring file: AlgoTradingPlatform/.vscode/settings.json[0m
[33mWARNING [0m [34mIgnoring file: OrdersCS/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: OrdersCS/obj/OrdersCS.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: OrdersCS/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: OrdersCS/obj/Debug/netstandard2.1/OrdersCS.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: OrdersCS/obj/Debug/netstandard2.1/OrdersCS.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: OrdersCS/bin/Debug/netstandard2.1/TradingEngineServer.Orders.deps.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/GraphicCS.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/Debug/net6.0-windows/GraphicCS.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/Debug/net6.0-windows/GraphicCS.genruntimeconfig.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/Debug/net6.0-windows/GraphicCS.designer.runtimeconfig.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/Debug/net6.0-windows/GraphicCS.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/obj/Debug/net6.0-windows/GraphicCS.designer.deps.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/bin/Debug/net6.0-windows/GraphicCS.deps.json[0m
[33mWARNING [0m [34mIgnoring file: GraphicCS/bin/Debug/net6.0-windows/GraphicCS.runtimeconfig.json[0m
[33mWARNING [0m [34mIgnoring file: RejectCS/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: RejectCS/obj/RejectCS.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: RejectCS/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: RejectCS/obj/Debug/netstandard2.1/RejectCS.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: OrderbookCS/obj/project.nuget.cache[0m
[33mWARNING [0m [34mIgnoring file: OrderbookCS/obj/OrderbookCS.csproj.nuget.dgspec.json[0m
[33mWARNING [0m [34mIgnoring file: OrderbookCS/obj/project.assets.json[0m
[33mWARNING [0m [34mIgnoring file: OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.csproj.CoreCompileInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: OrderbookCS/obj/Debug/netstandard2.1/OrderbookCS.AssemblyInfoInputs.cache[0m
[33mWARNING [0m [34mIgnoring file: OrderbookCS/bin/Debug/netstandard2.1/TradingEngineServer.Orderbook.deps.json[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[32mINFO    [0m [34mCode summaries returned:
[(PosixPath('WinFormsLibrary2/Class1.cs'), 'HTTPStatus Exception: 401'), (PosixPath('WinFormsLibrary2/WinFormsLibrary2.csproj'), 'HTTPStatus Exception: 401'), (PosixPath('WinFormsLibrary2/obj/WinFormsLibrary2.csproj.nuget.g.props'), 'HTTPStatus Exception: 401'), (PosixPath('WinFormsLibrary2/obj/WinFormsLibrary2.csproj.nuget.g.targets'), 'HTTPStatus Exception: 401'), (PosixPath('WinFormsLibrary2/obj/Debug/net6.0-windows/WinFormsLibrary2.GlobalUsings.g.cs'), 'HTTPStatus Exception: 401')][0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[31mERROR   [0m [34mHTTPStatus Exception:
Client error '401 Unauthorized' for url 'https://api.openai.com/v1/chat/completions'
For more information check: https://httpstatuses.com/401[0m
[32mINFO    [0m [34mCSharp setup guide: ['dotnet build', 'dotnet run', 'dotnet test'][0m
[32mINFO    [0m [34mREADME file generated at: readmeai.md[0m
[32mINFO    [0m [34mREADME-AI execution complete.[0m
