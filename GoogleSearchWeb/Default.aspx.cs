using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace GoogleSearchWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchKeyword = searchtextBox.Text;
            System.Net.HttpWebRequest hwb;

            //String url = "https://www.googleapis.com/customsearch/v1?key=AIzaSyDT86CgITC6vibZq5psOGGICqYZc2jTTw0&cx=001247559984859716110:eplzkkr913k&&q=apple";
            String url = "https://www.googleapis.com/customsearch/v1?key=AIzaSyAt8AkrmkiLVghrcKA3lFh37R79rSG0NsE&cx=003470263288780838160:ty47piyybua&q=apple";
            hwb = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);

            HttpWebResponse resp = (HttpWebResponse)hwb.GetResponse();

            //StreamReader streamReader = new StreamReader(resp.GetResponseStream());
            //String responseData = streamReader.ReadToEnd();
            //GoogleAPISearchResults outObject = JsonConvert.DeserializeObject<GoogleAPISearchResults>(responseData);

            using (resp)
            {
                if (resp.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    resp.StatusCode,
                    resp.StatusDescription));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(GoogleAPISearchResults));
                object objResponse = jsonSerializer.ReadObject(resp.GetResponseStream());
                GoogleAPISearchResults jsonResponse = objResponse as GoogleAPISearchResults;
            }

        }
    }
}