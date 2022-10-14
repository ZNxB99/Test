using System.Collections.Generic;
using System;
class Personlist {
    private List<Collage> collageList;
    private List<Teacher> teacherList;
    private List<Student> studentList;

    public Personlist() {
        this.collageList = new List<Collage>();
        this.teacherList = new List<Teacher>();
        this.studentList = new List<Student>();
    }
    public void AddNewCollege(Collage collage) {
        this.collageList.Add(collage);
    }
    public void AddNewTeacher(Teacher teacher) {
        this.teacherList.Add(teacher);
    }
    public void AddNewStudent(Student student) {
        this.studentList.Add(student);
    }
    public void TotalCollege(){
        int countCollage = collageList.Count;
        Console.WriteLine("Total participant: {0}",countCollage);
    }
    public void TotalTeacher(){
        int countTeacher = teacherList.Count;
        Console.WriteLine("Total college Teacher: {0}",countTeacher);
    }
    public void TotalStudent(){
        int countstudent = studentList.Count;
        Console.WriteLine("Total college Teacher: {0}",countstudent);
    }
    public void FetchCollegeList() {
        Console.WriteLine("List College");
        Console.WriteLine("************");
        foreach(College personal in this.collageList) {
            Console.WriteLine("Name {0} {1} {2} ", personal.GetPrefix(),personal.Getname(),personal.GetSurename());
        }
        Console.WriteLine("Type EXIT to return to menu");
    }
    public void FetchStudentList() {
        Console.WriteLine("List Student");
        Console.WriteLine("************");
        foreach(Student personal in this.studentList) {
            Console.WriteLine("Name {0} {1} {2} ", personal.GetPrefix(),personal.GetName(),personal.GetSurename());
        }
        Console.WriteLine("Type EXIT to return to menu");
    }
    public void FetchTeacherList() {
        Console.WriteLine("List Teacher");
        Console.WriteLine("************");
        foreach(Teacher personal in this.teacherList) {
            Console.WriteLine("Name {0} {1} {2} ", personal.GetPrefix(),personal.GetName(),personal.GetSurename());
        }
        Console.WriteLine("Type EXIT to return to menu");
    }
}