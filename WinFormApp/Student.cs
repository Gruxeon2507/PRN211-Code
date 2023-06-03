namespace WinFormApp
{
    public class Student
    {
        public string Code { get; set; }

        public string Name { get; set; }
        public int  Mark { get; set; }

        public string Subject { get; set; }
        public Student()
        {
            
        }

        public Student(string code, string name, int mark,string subject)
        {
            Code = code;
            Name = name;
            Mark = mark;
            Subject = subject;
        }

        public override string ToString()
        {
            return Code + "\t" + Name + "\t" + Subject + "\t" + Mark;
        }
    }
}