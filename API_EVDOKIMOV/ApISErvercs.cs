using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.IO;

namespace API_EVDOKIMOV
{
    public class ApIServercs
    {

       

        public string Registr ( Model.RegistrRequest_ registr)
        {
            string url = @"http://lesha.h1n.ru/api/signup";
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);

                request.Method = "POST";

                string content = JsonSerializer.Serialize(registr);

                byte[] contentByte = Encoding.UTF8.GetBytes(content);


                request.ContentType = "application/json";

                request.ContentLength = contentByte.Length;

                using (Stream st = request.GetRequestStream())
                {
                    st.Write(contentByte, 0, contentByte.Length);
                }


                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                string responseContent = string.Empty;


                using (StreamReader st = new StreamReader(response.GetResponseStream()))
                {
                    responseContent = st.ReadToEnd();
                }
                return responseContent;
            }
            catch (WebException ex)
            {
                return "Eror "+ ex.Message;
            }
            catch
            {
                return "XZ";
            }

        }

        public string InApi(Model.InApiRequist registr)
        {
            string url = @"http://lesha.h1n.ru/api/login";
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);

                request.Method = "POST";

                string content = JsonSerializer.Serialize(registr );

                byte[] contentByte = Encoding.UTF8.GetBytes(content);

                request.ContentType = "application/json";

                request.ContentLength = contentByte.Length;

                using (Stream st = request.GetRequestStream())
                {
                    st.Write(contentByte, 0, contentByte.Length);
                }


                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                string responseContent = string.Empty;


                using (StreamReader st = new StreamReader(response.GetResponseStream()))
                {
                    responseContent = st.ReadToEnd();
                }
                return responseContent;
            }
            catch (WebException ex)
            {
                return "Eror " + ex.Message;
            }
            catch
            {
                return "XZ";
            }
        }
    }
}
