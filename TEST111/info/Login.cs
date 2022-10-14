class Login{
    public string email;
    public string password;
    
    public Login(string email, string password){
        this.email = email;
        this.password = password;
    }
    public string GetEmail() {
        return this.email;
    }
    public string GetPassword() {
        return this.password;
    }
}
class AdminLogin{
    public string email;
    public string password;
    public AdminLogin(string email, string password){
        this.email = email;
        this.password = password;
    }
    public string GetEmail() {
        return this.email;
    }
    public string GetPassword() {
        return this.password;
    }
}
class CarNumberPlate{
    public string numberplate;
    public CarNumberPlate(string numberplate){
        this.numberplate = numberplate;
    }
    public string GetCarNumPlate(){
        return this.numberplate;
    }
}