﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project
{
    public class logs_save
    { 
        public static void save(int user_id, string id_panel, string first_stage, string final_stage, bool result)
        {
            course_projectEntities3 db = new course_projectEntities3();

            logs logs = new logs();
            logs.user_id = user_id;
            logs.id_panel = id_panel;
            logs.result = result;
            logs.initial_stage = first_stage;
            logs.final_stage = final_stage;
            logs.date = DateTime.Now;


            db.logs.Add(logs);
            db.SaveChanges();
        }
    }
}
