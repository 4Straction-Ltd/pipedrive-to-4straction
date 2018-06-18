using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PipedriveClassLibrary.util
{
    public class HTTPRequest
    {
        private String m_authUserName;
        private String m_authPassword;

        public HTTPRequest()
        {

        }

        public HTTPRequest(String userName, String password)
        {
            m_authUserName = userName;
            m_authPassword = password;
        }

        public String DoPostRequest(String address, String postData, String cookieName, String cookieValue)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(address);
            request.Method = "POST";
            request.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.4 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.4";
            String responseFromServer = "";

            if (!String.IsNullOrEmpty(m_authUserName))
            {
                request.Credentials = new NetworkCredential(m_authUserName, m_authPassword);
            }

            if (!String.IsNullOrEmpty(cookieName))
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(new Cookie(cookieName, cookieValue, "", "helmi.crmservice.fi"));
            }

            request.ContentType = "application/x-www-form-urlencoded";

            try
            {
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(postData);
                request.ContentLength = bytes.Length;
                System.IO.Stream os = request.GetRequestStream();
                os.Write(bytes, 0, bytes.Length); //Push it out there
                os.Close();

                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (WebException web)
            {
                WebResponse response = web.Response;
                HttpWebResponse httpResponse = (HttpWebResponse)response;

                using (Stream data = response.GetResponseStream())
                using (var reader2 = new StreamReader(data))
                {
                    string text = reader2.ReadToEnd();
                    throw new ApplicationException("Could not process data: " + httpResponse.StatusCode + ": " + text);
                }
            }

            return responseFromServer;
        }

        public String DoGetRequest(String address)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(address);
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.4 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.4";
            String responseFromServer = "";

            if (!String.IsNullOrEmpty(m_authUserName)) {
                request.Credentials = new NetworkCredential(m_authUserName, m_authPassword);
            }

            request.ContentType = "application/json";

            try
            {
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (WebException web)
            {
                WebResponse response = web.Response;
                HttpWebResponse httpResponse = (HttpWebResponse)response;

                using (Stream data = response.GetResponseStream())
                using (var reader2 = new StreamReader(data))
                {
                    string text = reader2.ReadToEnd();
                    throw new ApplicationException("Could not process data: " + httpResponse.StatusCode + ": " + text);
                }
            }

            return responseFromServer;
        }

        public static bool IsValidUri(string text)
        {
            // The Uri.IsWellFormedUriString does not handle uris without dots
            if (!text.Contains("."))
            {
                return false;
            }

            // The Uri.IsWellFormedUriString does not handle uris without protocol
            string uri = text.StartsWith("http") ? text : $@"http://{text}";
            
            // Remove query sting. The Uri.IsWellFormedUriString does not handle [] in query strings.
            // If uri contains [], the method returns that uri is invalid
            string uriWithoutQueryString = uri.IndexOf("?") > 0 ? uri.Substring(0, uri.IndexOf("?")) : uri;
            return Uri.IsWellFormedUriString(uriWithoutQueryString, UriKind.Absolute);
        }
    }
}
