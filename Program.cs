// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

var student = new Student(3.00m,"awdhah","Cpeg");
student.PrintInfo();

public class Student
{
    public string Name { get; private set; }
    public decimal Gpa { get; private set; }
    public string Major { get; private set; }


    public Student (decimal gpa, string name,string major)
    

    {
        Major = major;
        Name = name;
        Gpa = gpa;

        
    }
    public void PrintInfo()
    {

        Console.WriteLine(" Name: " + Name +
              "\n Major: " + Major +
              "\n Gpa: " + Gpa);
    }

}
    
   
public class GraduatedStudent : Student
{
    public GraduatedStudent(decimal gpa, string name, string major) : base(gpa, name, major)
    {
    }

    public string ProjectIdea { get; private set; }
    


} 





