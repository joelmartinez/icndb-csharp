using System.Runtime.Serialization;

namespace ChuckNorris
{
    /// <summary>
    /// Sample:
    /// { "type": "success", "value": { "id": 268, "joke": "Time waits for no man. Unless that man is Chuck Norris." } }
    /// </summary>
    [DataContract]
    public class Result
    {
        [DataMember(Name="type")]
        public string Type { get; set; }

        [DataMember(Name = "value")]
        public Joke Value { get; set; }
    }

}
