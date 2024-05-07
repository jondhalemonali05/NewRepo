using System.ComponentModel.DataAnnotations;

namespace tuesdaycrud.Models
{
    public class Student
    {
        [Key]
        public int roll_no { get; set; }
        public string stu_name { get; set; }
        public string stu_address { get; set; }
    }
}
