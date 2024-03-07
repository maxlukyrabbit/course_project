using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ChangeTrackNumber
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task<string> ChangeInTrackNumber(string idDeal, string inTrackNumber)
    {
        if (idDeal.Trim().Length != 5)
        {
            return "Некоректный номер сделки";
        }

        try
        {
            string url = "https://sputniksystems.bitrix24.ru/rest/879/hpyrfpxem514tmr4/crm.deal.update.json";
            string json = "{\"id\": " + idDeal + ", \"fields\": {\"UF_CRM_1693478562036\": \"" + inTrackNumber + "\"}}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return "Успех";
            }
        }
        catch (Exception)
        {
            return "Ошибка";
        }

        return string.Empty;
    }

    public static async Task<string> ChangeOutTrackNumber(string idDeal, string outTrackNumber)
    {
        if (idDeal.Trim().Length != 5)
        {
            return "Некоректный номер сделки";
        }

        try
        {
            string url = "https://sputniksystems.bitrix24.ru/rest/161/l93zfoeri1pzz656/crm.deal.update.json";
            string json = "{\"id\": " + idDeal + ", \"fields\": {\"UF_CRM_1693292930596\": \"" + outTrackNumber + "\"}}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return "Успех";
            }
        }
        catch (Exception)
        {
            return "Ошибка";
        }

        return string.Empty;
    }
}
