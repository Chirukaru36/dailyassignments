using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject2
{
    public class Teacher
    {
        public int teacherId { get; set; }

        public string teacherName { get; set; }

        public string ClassSection { get; set; }

        public override string ToString()
        {
            return $"TreacherId:{teacherId},TeacherName:{teacherName},Class and Section:{ClassSection}";
        }
    
    }
}
