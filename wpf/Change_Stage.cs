using course_project;
using System;
using System.Net.Http;
using System.Xml.XPath;

public static class DealManager
{
    private static string ChangeStage_universal(string dealId, string stageId, string stage)
    {
        string result = "";

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
                if(Window2.flag == false)
                {
                    logs_save.save(Window2.id_user, MainWindow.id_panel, stage, stageId, true, "");
                }
                


            }
            else
            {
                result = "Запрос отправлен, но сообщеня об успехе нет";
                if (Window2.flag == false)
                {
                    logs_save.save(Window2.id_user, MainWindow.id_panel, stage, stageId, false, result);
                }
                
            }
        }
        catch
        {
            result = "Ошибка запроса";
            if (Window2.flag == false)
            {
                logs_save.save(Window2.id_user, MainWindow.id_panel, stage, stageId, false, result);
            }
            
        }

        return result;
    }

    public static string сhangeStage_accepted_warehouse(string dealId)
    {
        string result = "";
        string stage = CheckStage.Check_Stage(dealId);
        if (stage.Length <= 30)
        {
            if (stage == "C25:NEW" || stage == "C25:PREPARATION" || stage == "C25:PREPAYMENT_INVOIC")
            {
                result = ChangeStage_universal(dealId, "C25:EXECUTING", stage);
            }
            else
            {
                result = $"Панель находится в неподходящей стадии:{stage}";
                if (Window2.flag == false)
                {
                    logs_save.save(Window2.id_user, MainWindow.id_panel, stage, "C25:EXECUTING", false, "Панель находится в неподходящей стадии");
                }
                
            }
        }
        else
        {
            result = stage;
        }
        return result;
    }

    public static string сhangeStage_fix(string dealId)
    {
        string result = "";
        string stage = CheckStage.Check_Stage(dealId);
        if (stage.Length <= 30)
        {
            if (stage == "C25:1" || stage == "C25:2" || stage == "C25:PREPAYMENT_INVOIC" || stage == "C25:7" || stage == "C25:UC_DMZGI5" || stage == "C25:EXECUTING")
            {
                result = ChangeStage_universal(dealId, "C25:2", stage);
            }
            else
            {
                result = $"Панель находится в неподходящей стадии:{stage}";
                if (Window2.flag == false)
                {
                    logs_save.save(Window2.id_user, MainWindow.id_panel, stage, "C25:2", false, "Панель находится в неподходящей стадии");
                }
                
            }
        }
        else
        {
            result = stage;
        }
        return result;
    }

    public static string сhangeStage_ready_ship(string dealId)
    {
        string result = "";
        string stage = CheckStage.Check_Stage(dealId);
        if (stage.Length <= 30)
        {
            if (stage != "C25:LOSE" && stage != "C25:APOLOGY" && stage != "C25:WON")
            {
                result = ChangeStage_universal(dealId, "C25:7", stage);
            }
            else
            {
                result = $"Панель находится в неподходящей стадии:{stage}";
                if (Window2.flag == false)
                {
                    logs_save.save(Window2.id_user, MainWindow.id_panel, stage, "C25:7", false, "Панель находится в неподходящей стадии");
                }
                
            }
        }
        else
        {
            result = stage;
        }
        return result;
    }

    public static string сhangeStage_test(string dealId)
    {
        string result = "";
        string stage = CheckStage.Check_Stage(dealId);
        if (stage.Length <= 30)
        {
            result = ChangeStage_universal(dealId, "C25:FINAL_INVOICE", stage);
        }
        else
        {
            result = $"Панель находится в неподходящей стадии:{stage}";
            if (Window2.flag == false)
            {
                logs_save.save(Window2.id_user, MainWindow.id_panel, stage, "C25:FINAL_INVOICE", false, "Панель находится в неподходящей стадии");
            }
            
        }
        return result;
    }








}
