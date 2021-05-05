In this project you can find examples of how to use [Punch UI](https://github.com/mtutynina/punch-ui) components library.
In `PunchUIExamples/Pages` directory you will find examples how to use componens inside Razor pages.
In  `PunchUIExamples/app` directory you will find examples of how to use components inside KnockoutJs SPA application.
___

## Getting Started
Make sure that you have VS 2019 at least 16.6,
or alternatively [.NET SDK](https://dotnet.microsoft.com/download/dotnet-core)
You can check by running  
```
dotnet --info
```
Also make sure that you have NodeJS installed (at least 10.x version) and available from command line.

	node -v

### Running website from VS

1. Follow insructions from section [Building website from command line](#building-website-from-command-line)
2. Open VS
3. Make `PunchUIExamples` startup project
4. Hit Run.

### Building website from command line
1. `cd PunchUIExamples/PunchUIExamples`
2. Install npm dependencies `npm install`
3. Prepare app vendor file `npm run webpack-vendor`
4. Build app `npm run build`
