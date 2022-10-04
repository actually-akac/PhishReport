﻿# Phish.Report 🎣

<div align="center">
  <img width="256" height="256" src="https://raw.githubusercontent.com/actually-akac/PhishReport/master/PhishReport/icon.png">
</div>

<div align="center">
  An async C# library for interacting with the Phish.Report, Indicator of Kit and detection beta APIs.
</div>

<br>

> **Warning**<br>
> The Phish.Report API is still under development, so in the event that you start experiencing an unexpected errors, first check if there's an update available or raise an issue in this repository.

## Usage
Available on NuGet as `PhishReport`, methods can be found under the class `PhishReportClient`.<br/>
You can create your API key here: https://phish.report/user

https://www.nuget.org/packages/PhishReport

## Features
- Made with **.NET 6**
- Fully **async**
- Full coverage of the current **beta API**
- Deep **documentation**
- **No external dependencies** (uses integrated HTTP and JSON)
- Create phishing takedowns, fetch existing cases or process **Indicator of Kit** matches.
- **Custom exceptions** (`PhishReportException`) for advanced catching
- Automatic request retries
- Example project to demonstrate all capabilities of the library

## Example
Under the `Example` directory you can find a working demo project that implements this library.

## Code Samples

### Initializing a new API client
```csharp
PhishReportClient phish = new("API KEY");
```

### Creating a new phishing takedown
```csharp
PhishingTakedown takedown1 = await phish.CreateTakedown("https://seowqpeoqwakfd425.ml/dssdfds-fsdfsdf0s-df0ds0f0dsdfsdd0f0s-df0dfgdd8658/");
```

### Retrieving an existing phishing takedown by its ID
```csharp
PhishingTakedown takedown2 = await phish.GetTakedown("case_4tmKtcajnzj");
```

### Retrieving the latest [Indicator of Kit](https://phish.report/IOK/) matches
```csharp
IoKMatch[] matches = await phish.GetMatches();
```

## Available Methods
- Task\<PhishingTakedown> **CreateTakedown**(string url)
- Task\<PhishingTakedown> **GetTakedown**(string id)
- Task\<IoKMatch[]> **GetMatches**(int page = 0)

## Resources
Website: https://phish.report<br/>
Indicator of Kit: https://phish.report/IOK/, https://github.com/phish-report/IOK