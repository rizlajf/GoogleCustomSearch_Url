using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GoogleSearchWeb
{
    [DataContract]
    public class ResponseData
    {
        [DataMember(Name = "link")]
        public string link
        {
            get;
            set;
        }

        [DataMember(Name = "displayLink")]
        public string displayLink
        {
            get;
            set;
        }
        [DataMember(Name = "snippet")]
        public string snippet
        {
            get;
            set;
        }
        [DataMember(Name = "htmlSnippet")]
        public string htmlSnippet
        {
            get;
            set;
        }
        [DataMember(Name = "formattedUrl")]
        public string formattedUrl
        {
            get;
            set;
        }
    }
}