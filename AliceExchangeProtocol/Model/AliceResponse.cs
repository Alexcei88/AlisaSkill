using System;
using System.Collections.Generic;
using System.Text;

namespace AlisaExchangeProtocol.Model
{
    public class ButtonModel
    {
        public string title { get; set; }
        public object payload { get; set; }
        public string url { get; set; }
        public bool hide { get; set; }
    }
  
    public class Session
    {
        public string session_id { get; set; }
        public int message_id { get; set; }
        public string user_id { get; set; }
    }

    public class ResponseModel
    {
        public string text { get; set; }
        public string tts { get; set; }
        public List<ButtonModel> buttons { get; set; }
        public bool end_session { get; set; }
    }

    public class AliceResponse
    {
        public ResponseModel response { get; set; }
        public Session session { get; set; }
        public string version { get; set; } = "1.0";
    }
}
