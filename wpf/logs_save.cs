using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project
{
    internal class logs_save
    {
        course_projectEntities1 db = new course_projectEntities1();
        public logs_save(int user_id, string first_stage, string final_stage, DateTime date, bool result) 
        {
            logs logs = new logs();
            logs.user_id = user_id;
            //logs.initial_stage = ;
            logs.user_id = user_id;
            logs.user_id = user_id;
            logs.user_id = user_id;

        }

    }
}
