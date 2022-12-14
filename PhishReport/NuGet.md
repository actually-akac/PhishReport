# Phish.Report 🎣

![](https://raw.githubusercontent.com/actually-akac/PhishReport/master/PhishReport/icon.png)

### An async C# library for interacting with the Phish.Report, Indicator of Kit and detection beta APIs.

> **Warning**

> The Phish.Report API is still under development, so in the event that you start experiencing unexpected errors, first check if there's an update available or raise an issue in this repository.

## Usage
Provides an easy interface for interacting with the Phish.Report APIs.

You can create and track phishing takedowns and work with the [Indicator of Kit (IOK)](https://phish.report/IOK) platform.

API keys are required to use the API. Create one at: https://phish.report/user

To get started, add the library into your solution with either the `NuGet Package Manager` or the `dotnet` CLI.
```rust
dotnet add package PhishReport
```

For the primary classes to become available, import the used namespace.
```csharp
using PhishReport;
```

Need more examples? Under the `Example` directory you can find a working demo project that implements this library.

## Features
- Built for **.NET 6** and **.NET 7**
- Fully **async**
- Coverage of the current **beta API**
- Extensive **XML documentation**
- **No external dependencies** (uses integrated HTTP and JSON)
- Create phishing takedowns, fetch existing cases or process **Indicator of Kit** matches.
- **Custom exceptions** (`PhishReportException`) for advanced catching
- Automatic request retries

## Code Samples

### Initializing a new API client
```csharp
PhishReportClient phish = new("API KEY");
```

### Creating a new phishing takedown
```csharp
PhishingTakedown takedown1 = await phish.CreateTakedown("https://alpsautorepairv.ml/?gclid=EAIaIQobChMIsfmc__Ds-wIVSOHICh3oGwtsEAAYASAAEgIxmPD_BwE");
```

### Retrieving an existing phishing takedown by its ID
```csharp
PhishingTakedown takedown2 = await phish.GetTakedown("case_4ExZCRk3PAh");
```

### Retrieving the latest [Indicator of Kit](https://phish.report/IOK/) matches
```csharp
IokMatch[] matches = await phish.GetIokMatches();
```

### Processing [Indicator of Kit](https://phish.report/IOK/) matches in real time
```csharp
phish.IokMatched += (sender, match) =>
{
	Console.WriteLine($"{match.IndicatorId} match on {match.Url}, source: https://urlscan.io/result/{match.UrlscanUUID}/");
};
```

## Available Methods
- Task\<PhishingTakedown> **CreateTakedown**(string url)
- Task\<PhishingTakedown> **GetTakedown**(string id)
- Task\<IokMatch[]> **GetIokMatches**(int page = 1)
- Task\<string[]> **GetIokMatches**(string uuid)

## Available Events
- EventHandler\<IokMatch> IokMatched

## Resources
- Website: https://phish.report
- Indicator of Kit: https://phish.report/IOK/, https://github.com/phish-report/IOK