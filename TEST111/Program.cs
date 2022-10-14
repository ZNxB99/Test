enum Persontype {
    TypeCollage = 1,
    TypeStudent,
    TypeTeacher
}
enum NonRegisteredMenu {
    RegisterEvent = 1,
    attendanceStatistics,
    SignIn
}
enum RegisteredMenu {
    RegisterEvent = 1,
    CollageInEvent,
    StudentInEvent,
    TeacherInEvent,
    SignOut
}
class Program{
    static PersonList collageList;
    static PersonList studentList;
    static PersonList teacherList;
    static void PrepareProgramWhenLoad() {
        Program.collageList = new PersonList();
        Program.studentList = new PersonList();
        Program.teacherList = new PersonList();
    }
    static void Main(string[] args){
        PrepareProgramWhenLoad();
        PrintNonRegisteredMenuScreen();
    }
    static void PrintNonRegisteredMenuScreen() {
        Console.Clear();
        PrintListNonRegisteredMenu();
        InputNonRegisteredMenuFromKeyboard();
    }
   
   
    static void PrintListNonRegisteredMenu() {
        Console.WriteLine("Welcome to Idia camp application");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Register for the event");
        Console.WriteLine("2. Show attendance statistics");
        Console.WriteLine("3. Sign in");
        Console.WriteLine("****************************************************");
    }
    static void TotalParcipitant(){
        Console.Clear();
        Program.collageList.TotalCollege();
        Program.collageList.TotalStudent();
        Program.collageList.TotalTeacher();
        Console.WriteLine("type EXIT to return to menu");
        TypeExitToNonRegisteredMenu();
    }
    static void InputNonRegisteredMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        NonRegisteredMenu nonRegisteredMenu = (NonRegisteredMenu)(int.Parse(Console.ReadLine()));


        PresentNonRegisteredMenu(nonRegisteredMenu);
    }
    
    
    static void PresentNonRegisteredMenu(NonRegisteredMenu nonRegisteredMenu) {
        switch (nonRegisteredMenu) {
            case NonRegisteredMenu.RegisterEvent:
                NonRegisShowRegisterEvent();
                break;
            case NonRegisteredMenu.attendanceStatistics:
                TotalParcipitant();
                break;
            case NonRegisteredMenu.SignIn:
                InputSignInFromKeyboard();
                break;
            default:
                break;
        }
    }
    
    static void NonRegisShowRegisterEvent(){
        Console.Clear();
        PrintRegisterEvent();
        NonRegisInputEventFromKeyboard();
    }
    static void PrintRegisterEvent() {
        Console.WriteLine("Please select");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. College student");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("****************************************************");
    }
    static void NonRegisInputEventFromKeyboard(){
        Console.Write("Please input Type:");
        Persontype persontype = (Persontype)(int.Parse(Console.ReadLine()));

        NonRegisSelectTypeMenu(persontype);
    }
    static void NonRegisSelectTypeMenu(Persontype personType) {
        switch (personType) {
            case Persontype.TypeCollage:
                Non_RegisterationCollege();
                break;
            case Persontype.TypeStudent:
                Non_RegisterationStudent();
                break;
            case Persontype.TypeTeacher:
                Non_RegisterationTeacher();
                break;
            default:
                break;
        }
    }
    static void Non_RegisterationCollege(){
        Console.Clear();

        NonRegisInputNewCollegeFromKeyboard();
    }
    static void Non_RegisterationStudent(){
        Console.Clear();
        PrintHeaderRegisterStudent();

        NonRegisInputNewStudentFromKeyboard();
    }
    static void Non_RegisterationTeacher(){
        Console.Clear();
        PrintHeaderRegisterTeacher();

        NonRegisInputNewTeacherFromKeyboard();
    }
    static void NonRegisInputNewCollegeFromKeyboard() {
            Console.Clear();
            PrintHeaderRegisterCollege();

            College college = new College(GetPrefix(),InputName(),
            InputSureName(),
            InputAge(),
            InputCollegeID(),
            InputAllergic(),
            GetReligion(),
            GetAdmin() 
            );

            Program.collageList.AddNewCollege(college);
            BackToNonRegisteredMenu();
        }
    static void NonRegisInputNewStudentFromKeyboard() {
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(GetPrefix(),InputName(),
            InputSureName(),
            InputAge(),
            GetGrade(),
            InputAllergic(),
            GetReligion(),
            InputSchool() 
            );

            Program.collageList.AddNewStudent(student);
            BackToNonRegisteredMenu();
        }
    static void NonRegisInputNewTeacherFromKeyboard() {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher(GetPrefix(),InputName(),
            InputSureName(),
            InputAge(),
            GetJobTitle(),
            InputAllergic(),
            GetReligion(),
            GetAdmin(),
            GetCar() 
            );

            Program.collageList.AddNewTeacher(teacher);
            BackToNonRegisteredMenu();
    }
    static void PrintRegisteredMenuScreen(){
        Console.Clear();
        PrintListRegisteredMenu();
        InputRegisteredMenuFromKeyboard();
    }
    static void InputRegisteredMenuFromKeyboard(){
        Console.Write("Please input Menu:");
        RegisteredMenu registeredMenu = (RegisteredMenu)(int.Parse(Console.ReadLine()));
        PresentRegisteredMenu(registeredMenu);
    }
    static void PrintListRegisteredMenu() {
        Console.WriteLine("Welcome to Idia camp application");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Register for the event");
        Console.WriteLine("2. Show all current colleges student participating in the program");
        Console.WriteLine("3. Show all current students participating in the program");
        Console.WriteLine("4. Show all current teacher participating in the program");
        Console.WriteLine("5. Sign out");
        Console.WriteLine("****************************************************");
    }
    static void PresentRegisteredMenu(RegisteredMenu registeredMenu) {
        switch (registeredMenu) {
            case RegisteredMenu.RegisterEvent:
                RegisShowRegisterEvent();
                break;
            case RegisteredMenu.CollageInEvent:
                ShowCollegeInEvent();
                break;
            case RegisteredMenu.StudentInEvent:
                ShowStudentInEvent();
                break;
            case RegisteredMenu.TeacherInEvent:
                ShowTeacherInEvent();
                break;
            case RegisteredMenu.SignOut:
                MenuSignOut();
                break;
            default:
                break;
        }
    }
    static void ShowCollegeInEvent() {
        Console.Clear();
        Console.WriteLine("Name of college student in this event");
        Console.WriteLine("****************");

        Program.collageList.FetchCollegeList();
        TypeExitToRegisteredMenu();
    }
    static void ShowStudentInEvent() {
        Console.Clear();
        Console.WriteLine("Name of student in this event");
        Console.WriteLine("****************");

        Program.studentList.FetchStudentList();
        TypeExitToRegisteredMenu();
    }
    static void ShowTeacherInEvent() {
        Console.Clear();
        Console.WriteLine("Name of teacher in this event");
        Console.WriteLine("****************");

        Program.teacherList.FetchTeacherList();
        TypeExitToRegisteredMenu();
    }
    static void MenuSignOut(){
        BackToNonRegisteredMenu();
    }
    static void InputSignInFromKeyboard() {
            Console.Clear();
            ShowSignIn();

            Login login = new Login(
            GetEmail(),
            GetPassword() 
            );

            BackToRegisteredMenu();
        }
    static void ShowSignIn(){
        Console.WriteLine("Input your email and password to sign in");
        Console.WriteLine("*******************************************");
    }
    static void RegisShowRegisterEvent(){
        Console.Clear();
        PrintRegisterEvent();
        RegisInputEventFromKeyboard();
    }
    static void RegisInputEventFromKeyboard(){
        Console.Write("Please input Type:");
        Persontype persontype = (Persontype)(int.Parse(Console.ReadLine()));

        RegisSelectTypeMenu(persontype);
    }
    static void RegisSelectTypeMenu(Persontype persontype) {
        switch (persontype) {
            case Persontype.TypeCollage:
                RegisterationCollege();
                break;
            case Persontype.TypeStudent:
                RegisterationStudent();
                break;
            case Persontype.TypeTeacher:
                RegisterationTeacher();
                break;
            default:
                break;
        }
    }
    static void RegisterationCollege(){
        Console.Clear();

        RegisInputNewCollegeFromKeyboard();
    }
    static void RegisterationStudent(){
        Console.Clear();
        PrintHeaderRegisterStudent();

        RegisInputNewStudentFromKeyboard();
    }
    static void RegisterationTeacher(){
        Console.Clear();
        PrintHeaderRegisterTeacher();

        RegisInputNewTeacherFromKeyboard();
    }
    static void RegisInputNewCollegeFromKeyboard() {
            Console.Clear();
            PrintHeaderRegisterCollege();

            College college = new College(GetPrefix(),InputName(),
            InputSureName(),
            InputAge(),
            InputCollegeID(),
            InputAllergic(),
            GetReligion(),
            GetAdmin()
            );

            Program.collageList.AddNewCollege(college);
            BackToRegisteredMenu();
    }
    static void RegisInputNewStudentFromKeyboard() {
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(GetPrefix(),InputName(),
            InputSureName(),
            InputAge(),
            GetGrade(),
            InputAllergic(),
            GetReligion(),
            InputSchool() 
            );
            Program.studentList.AddNewStudent(student);
            BackToRegisteredMenu();
        }
    static void RegisInputNewTeacherFromKeyboard() {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher(GetPrefix(),InputName(),
            InputSureName(),
            InputAge(),
            GetJobTitle(),
            InputAllergic(),
            GetReligion(),
            GetAdmin(),
            GetCar()
            );
            Program.teacherList.AddNewTeacher(teacher);
            BackToRegisteredMenu();
    }
    static void NonRegisRegisterationCollege(){
        Console.Clear();
        NonRegisInputNewCollegeFromKeyboard();
    }
    static void NonRegisRegisterationStudent(){
        Console.Clear();
        PrintHeaderRegisterStudent();
        NonRegisInputNewStudentFromKeyboard();
    }
    static void NonRegisRegisterationTeacher(){
        Console.Clear();
        PrintHeaderRegisterTeacher();
        RegisInputNewTeacherFromKeyboard();
    }
    static void BackToNonRegisteredMenu(){
        Console.Clear();
        PrintListNonRegisteredMenu();
        InputNonRegisteredMenuFromKeyboard();
    }
    static void BackToRegisteredMenu(){
        Console.Clear();
        PrintListRegisteredMenu();
        InputRegisteredMenuFromKeyboard();
    }
    static void PrintHeaderRegisterCollege(){
        Console.WriteLine("Register College for event");
        Console.WriteLine("****************************");
    }
    static void PrintHeaderRegisterStudent(){
        Console.WriteLine("Register Student for event");
        Console.WriteLine("****************************");
    }
    static void PrintHeaderRegisterTeacher(){
        Console.WriteLine("Register Teacher for event");
        Console.WriteLine("****************************");
    }
    static string GetCarNum() {
        Console.Write("Car number :");

        return Console.ReadLine();
    }
    static string GetEmail() {
        Console.Write("Email :");

        return Console.ReadLine();
    }
    static string GetPassword() {
        Console.Write("Password :");

        return Console.ReadLine();
    }
    static string InputName() {
        Console.Write("Name :");

        return Console.ReadLine();
    }
    static string InputSureName() {
        Console.Write("Sure name :");

        return Console.ReadLine();
    }
    static string InputAge() {
        Console.Write("Age : ");

        return Console.ReadLine();
    }
    static string InputAllergic() {
        Console.Write("Allergic: ");

        return Console.ReadLine();
    }
    static string InputCollegeID() {
        Console.Write("CollegeID: ");

        return Console.ReadLine();
    }
    static string InputSchool() {
        Console.Write("School: ");

        return Console.ReadLine();
    }
    static string GetPrefix(){
        Console.Clear();
        Console.WriteLine("****************");
        Console.WriteLine("1 = Mr.");
        Console.WriteLine("2 = Ms.");
        Console.WriteLine("3 = Mrs.");
        Console.Write("pls select your Prefix :");
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            return "Mr";
        }
        else if (input == 2){
            return "Ms";
        }
        else if (input == 3){
            return "Mrs";
        }
        else {
            return GetPrefix();
        }
    }
    static string GetReligion(){
        Console.Clear();
        Console.WriteLine("****************");
        Console.WriteLine("1 = Buddhism");
        Console.WriteLine("2 = Christian");
        Console.WriteLine("3 = Islam");
        Console.WriteLine("4 = Other");
        Console.Write("pls select your religion :");
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            return "Buddhism";
        }
        else if (input == 2){    
            return "Christian";
        }
        else if (input == 3){
            return "Islam"; 
        }
        else if (input == 4){
            return "Other"; 
        }
        else {
            return GetReligion();
        }
    }
    static string GetJobTitle(){
        Console.Clear();
        Console.WriteLine("****************");
        Console.WriteLine("1 = Dean");
        Console.WriteLine("2 = Head_of_department");
        Console.WriteLine("3 = full_time_teacher");
        Console.Write("pls select your job title :");
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            return "Dean";
        }
        else if (input == 2){    
            return "Head_of_department";
        }
        else if (input == 3){
            return "full_time_teacher"; 
        }
        else {
            return GetJobTitle();
        }
    }
    static string GetGrade(){
        Console.Clear();
        Console.WriteLine("****************");
        Console.WriteLine("1 = High school 4.");
        Console.WriteLine("2 = High school 5");
        Console.WriteLine("3 = High school 6");
        Console.Write("pls select your grade :");
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            return "High school 4";
        }
        else if (input == 2){    
            return "High school 5";
        }
        else if (input == 3){
            return "High school 6"; 
        }
        else {
            return GetGrade();
        }
    }
    static string GetCar(){
        Console.Clear();
        Console.WriteLine("************************");
        Console.WriteLine("Do you have car?");
        Console.Write("pls select answer by type 1=yes or 2=no :");
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            InputCar();
            return "Yes";
        }
        else if(input == 2){  
            return "No";
        }
        else{
            return "-";
        }
    }
    static void InputCar(){
        Console.WriteLine("Please input your number plate to submit");
        Console.WriteLine("**********************************************");

        CarNumberPlate carNumberPlate = new CarNumberPlate(GetCarNum());
    }
    static string GetAdmin(){
        Console.Clear();
        Console.WriteLine("************************");
        Console.WriteLine("if you are admin");
        Console.Write("pls select answer by type 1=yes or 2=no :");
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            InputAdmin();
            return "Yes";
        }
        else if(input == 2){  
            return "No";
        }
        else{
            return "-";
        }
    }
    static void InputAdmin(){
        Console.WriteLine("Please input your admin account to submit");
        Console.WriteLine("**********************************************");

        AdminLogin adminlogin = new AdminLogin(GetEmail(),GetPassword());
    }
    static void TypeExitToNonRegisteredMenu(){
        string input = Console.ReadLine();
        if(input == "EXIT")
            PrintNonRegisteredMenuScreen();
        else{
            Console.WriteLine("Type EXIT to return to menu");
        }
    }
    static void TypeExitToRegisteredMenu(){
        string input = Console.ReadLine();
        if(input == "EXIT")
            PrintRegisteredMenuScreen();
        else{
            Console.WriteLine("Type EXIT to return to menu");
        }
    }
}
