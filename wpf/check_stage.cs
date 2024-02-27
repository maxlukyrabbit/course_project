using System.Net;
using Newtonsoft.Json.Linq;
using System.Text;
using System.IO;
using System;

public class CheckStage
{
    public static string Check_Stage(string id_deal)
    {
        string status = "";
        try
        {
            // URL for getting JSON
            string urlString = "https://sputniksystems.bitrix24.ru/rest/161/l93zfoeri1pzz656/crm.deal.get.json?id=" + id_deal;

            // Create a HttpWebRequest object
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlString);
            request.Method = "GET";

            // Get the response from the server
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Read data from the input stream
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    string inputLine;
                    StringBuilder jsonResponse = new StringBuilder();

                    while ((inputLine = reader.ReadLine()) != null)
                    {
                        jsonResponse.Append(inputLine);
                    }
                    reader.Close();

                    // Processing the received JSON
                    JObject jsonObject = JObject.Parse(jsonResponse.ToString());
                    JObject dealsArray = (JObject)jsonObject["result"];
                    status = (string)dealsArray["STAGE_ID"];
                }
            }
            else
            {
                status = "Error executing request. Response code: " + response.StatusCode;
            }

            response.Close();
        }
        catch (Exception e)
        {
            status = "Error executing: " + e.Message;
        }
        return status;
    }
}