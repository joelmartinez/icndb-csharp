icndb-csharp
============

C# API Wrapper for the Internet Chuck Norris Database: http://www.icndb.com/api/

```csharp
var joke = (ChuckNorris.API.Random(exclude: new string[] {"explicit"})response).Result;

Console.WriteLine(joke.Text);
```
