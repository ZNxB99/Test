public abstract class Person{
    private string prefix;
    private string name;
    private string surename;
    private string age;
    private string allergic;
    private string religion;

    public Person(string prefix, string name, string surename,
    string age, string allergic, string religion){
        this.prefix = prefix;
        this.name = name;
        this.surename = surename;
        this.age = age;
        this.allergic = allergic;
    }
    public string GetPrefix() {
        return this.prefix;
    }
    public string GetName() {
        return this.name;
    }
    public string GetSurename() {
        return this.surename;
    }
    public string GetAge() {
        return this.age;
    }
    public string GetAllergic() {
        return this.allergic;
    }
}