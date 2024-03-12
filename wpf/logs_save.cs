using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project
{
    public class logs_save
    {
        course_projectEntities2 db = new course_projectEntities2();

        public static void save(int user_id, string id_panel, string first_stage, string final_stage, bool result)
        {
            logs logs = new logs();
            logs.user_id = user_id;
            logs.id_panel = id_panel;
            logs.result = result;
            logs.date = DateTime.Now;

            var start_stage = db.stage_deal.FirstOrDefault(x => x.name_stage == first_stage);
            if (start_stage != null)
            {
                logs.initial_stage = start_stage.id_deal;
            }

            var end_stage = db.stage_deal.FirstOrDefault(x => x.name_stage == final_stage);
            if (end_stage != null)
            {
                logs.final_stage = end_stage.id_deal;
            }
        }


    }
}
