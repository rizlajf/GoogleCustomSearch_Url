using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GoogleSearchWeb
{
    [DataContract]
    internal class GoogleAPISearchResults
    {
        [DataMember(Name = "items")]
        internal ResponseData[] responseData
        {
            get;
            set;
        }
    }
}