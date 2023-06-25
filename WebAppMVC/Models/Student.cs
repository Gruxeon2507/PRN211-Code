using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Student
    {
        [Required(AllowEmptyStrings = false,ErrorMessage = "String is not empty")]
        public string Code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "String is not empty")]
        public string Name { get; set; }
        [Range(18,30)]
        public int Age { get; set; }

        public Student()
        {
            
        }

        public Student(string code, string name, int age)
        {
            Code = code;
            Name = name;
            Age = age;
        }
    }
}
