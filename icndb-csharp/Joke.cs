using System.Runtime.Serialization;

namespace ChuckNorris
{
    [DataContract]
    public class Joke
    {
        [DataMember(Name="id")]
        public string Id { get; set; }

        [DataMember(Name="joke")]
        public string Text { get; set; }
    }
}
