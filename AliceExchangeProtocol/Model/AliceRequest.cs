using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AlisaExchangeProtocol.Model
{
    //public class Screen
    //{
    //}

    //public class Interfaces
    //{
    //    public Screen screen { get; set; }
    //}

    public class MetaModel
    {
        public string locale { get; set; }
        public string timezone { get; set; }
        public string client_id { get; set; }
        //public Interfaces interfaces { get; set; }
    }

    public class MarkupModel
    {
        public bool dangerous_context { get; set; }
    }

    public class Tokens
    {
        public int start { get; set; }
        public int end { get; set; }
    }

    /// <summary>
    /// Тип именованной сущности
    /// </summary>
    public enum NamedEntitiesTypes
    {
        /// <summary>
        /// YANDEX.DATETIME — дата и время, абсолютные или относительные.
        /// </summary>
        [Description("YANDEX.DATETIME")]
        DATETIME = 0,

        /// <summary>
        /// YANDEX.FIO — фамилия, имя и отчество.
        /// </summary>
        [Description("YANDEX.FIO")]
        FIO,

        /// <summary>
        /// YANDEX.GEO — местоположение (адрес или аэропорт).
        /// </summary>
        [Description("YANDEX.GEO")]
        GEO,

        /// <summary>
        /// YANDEX.NUMBER — число, целое или с плавающей точкой.
        /// </summary>
        [Description("YANDEX.NUMBER")]
        NUMBER
    }


    public class Entity
    {
        public Tokens tokens { get; set; }
        public string type { get; set; }
        public object value { get; set; }
    }

    public class Nlu
    {
        public List<string> tokens { get; set; }
        public List<Entity> entities { get; set; }
    }
   
    public class RequestSession
    {
        public bool @new { get; set; }
        public int message_id { get; set; }
        public string session_id { get; set; }
        public string skill_id { get; set; }
        public string user_id { get; set; }
    }

    public class AliceRequest
    {
        //public Meta meta { get; set; }
        public string command { get; set; }
        public string original_utterance { get; set; }
        public string type { get; set; }
        public MarkupModel markup { get; set; }
        public object payload { get; set; }
        public Nlu nlu { get; set; }

        public RequestSession session { get; set; }
        public string version { get; set; } = "1.0";
    }
}
