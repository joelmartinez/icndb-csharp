icndb-csharp
============

C# API Wrapper for the Internet Chuck Norris Database: http://www.icndb.com/api/

```csharp
var response = ChuckNorris.API.Random(exclude: new string[] {"explicit"});
var joke = response.Result;

Console.WriteLine(joke.Text);
```