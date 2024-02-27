using System;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

public class SearchDeal
{
    public static string SearchDealMethod(string idPanel)
    {
        string idDeal = "";

        try
        {
            // URL for getting JSON
            string urlString = "https://sputniksystems.bitrix24.ru/rest/161/l93zfoeri1pzz656/crm.deal.list.json?FILTER[UF_CRM_1629819273209]=" + idPanel.Trim();

            // Creating URL object
            Uri url = new Uri(urlString);

            // Creating HttpWebRequest object
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            // Getting response from server
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Reading data from input stream
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseContent = reader.ReadToEnd();

                // Processing received JSON
                JObject jsonObject = JObject.Parse(responseContent);
                JArray dealsArray = (JArray)jsonObject["result"];
                JObject lastDeal = (JObject)dealsArray[dealsArray.Count - 1];
                idDeal = lastDeal["ID"].ToString();
            }
            else
            {
                idDeal = "Error executing request. Response code: " + response.StatusCode;
            }
        }
        catch
        {
            idDeal = "Error executing";
        }
        return idDeal;
    }
}
