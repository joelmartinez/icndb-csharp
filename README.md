icndb-csharp
============

C# API Wrapper for the Internet Chuck Norris Database: http://www.icndb.com/api/

There are currently 567 jokes in the database (as of 4/17/2014)

```csharp
var joke = (ChuckNorris.API.Random(exclude: new string[] {"explicit"})response).Result;

Console.WriteLine(joke.Text);
```
