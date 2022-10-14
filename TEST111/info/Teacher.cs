public class Teacher: Person{
    private string jobtitle;
    private string admin;
    private string carnum;
   
    public Teacher(string prefix, string name, string surename,
    string age, string jobtitle, string allergic, string religion, string admin, string carnum)
    : base (prefix, name, surename, age, allergic, religion){
        
        this.jobtitle = jobtitle;
        this.admin = admin;
        this.carnum = carnum;
    }
}