using System;
using System.Net.Http;

public static class DealManager
{
    public static string ChangeStage(string dealId, string stageId)
    {
        string result = "";

        if (dealId.Trim().Length != 5)
        {
            return "Некорректный номер сделки";
        }

        HttpClient client = new HttpClient();

        try
        {
            // URL и JSON-запрос
            string url = "https://sputniksystems.bitrix24.ru/rest/161/l93zfoeri1pzz656/crm.deal.update.json";
            string json = "{\"id\": " + dealId + ", \"fields\": {\"STAGE_ID\": \"" + stageId + "\"}}";

            // Создание запроса POST
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client.PostAsync(url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                // Преобразование ответа в строку
                string responseBody = response.Content.ReadAsStringAsync().Result;
                result = "Успех";
            }
        }
        catch (Exception e)
        {
            result = "Ошибка";
        }

        return result;
    }
}
