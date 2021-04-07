## Command Line

Run:

```
$ dotnet run --project Hello.csproj
```

Run unit tests:

```
$ dotnet test Test.csproj
```

Build and run:

```
$ dotnet build Hello.csproj
$ bin/Debug/net5.0/Hello
Hello World!
```

## Postscript

Useful links:

* [Code Whisperer blog](https://blog.thecodewhisperer.com/permalink/from-zero-to-nunit-with-visual-studio-code) on setting up VSCode for a Linux developer.
* Fixing ["more than one entry point issue"](https://andrewlock.net/fixing-the-error-program-has-more-than-one-entry-point-defined-for-console-apps-containing-xunit-tests/) when tests share a project with an app.
* Basic [getting started with XUnit](https://codemag.com/Article/2009101/Interactive-Unit-Testing-with-.NET-Core-and-VS-Code) blog. I didn't find the VSCode extension all that useful, and it didn't like the project layout.
* [XUnit and NUnit](https://helpercode.com/2016/05/31/the-real-difference-between-nunit-and-xunit/) comparison
* Microsoft [docs on testing](https://docs.microsoft.com/en-gb/dotnet/core/testing/unit-testing-with-dotnet-test).
* Useful Stackoverflow response here on [excluding tests from the app build](https://stackoverflow.com/questions/43173811/how-do-i-exclude-files-folders-from-a-net-core-standard-project).