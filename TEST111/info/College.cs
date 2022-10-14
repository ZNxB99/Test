public class Collage: Person{
    private string collegeID;
    private string admin;

    public Collage (string prefix, string name, string surename,
    string age, string collegeID, string allergic, string religion, string admin)
   
    : base (prefix, name, surename, age, allergic, religion){

        this.collegeID = collegeID;
        this.admin = admin;
    }
}