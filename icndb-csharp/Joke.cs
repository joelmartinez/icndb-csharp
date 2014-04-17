using System.Runtime.Serialization;

namespace ChuckNorris
{
    [DataContract]
    public class Joke
    {
        private string _text;
        
        [DataMember(Name="id")]
        public string Id { get; set; }

        [DataMember(Name="joke")]
        public string Text { 
            get 
            {
                return _text.Replace("quot;", "'");
            } 
            set
            {
                _text = value;
            }
        }
    }
}
