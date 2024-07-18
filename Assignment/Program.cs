namespace Assignment
{
    #region Part 02 Q01 Methods

    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}");
        }
    }

    #endregion

    #region Part 02 Q02 Methods

    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "admin";
        private string storedPassword = "password";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            // For simplicity, assume the user "admin" has the "admin" role
            return username == storedUsername && role == "admin";
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q01 What is the primary purpose of an interface in C#?
            //- b) To define a blueprint for a class

            #endregion

            #region Q02 Which of the following is NOT a valid access modifier for interface members in C#?
            //-a) private
            //-b) protected


            #endregion

            #region Q03 Can an interface contain fields in C#?
            //- b) No

            #endregion

            #region Q04 In C#, can an interface inherit from another interface?
            //- b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q05 Which keyword is used to implement an interface in a class in C#?
            //- d) implements

            #endregion

            #region Q06 Can an interface contain static methods in C#?
            //- a) Yes (starting from C# 8.0, interfaces can contain static methods)

            #endregion

            #region Q07 In C#, can an interface have explicit access modifiers for its members?
            //- b) No, all members are implicitly public

            #endregion

            #region Q08 What is the purpose of an explicit interface implementation in C#?
            //- b) To provide a clear separation between interface and class members

            #endregion

            #region Q09 In C#, can an interface have a constructor?
            //- b) No, interfaces cannot have constructors

            #endregion

            #region Q10 How can a C# class implement multiple interfaces?
            //- c) By separating interface names with commas

            #endregion

            #endregion

            #region Part 02

            #region Q01 Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

            //ICircle circle = new Circle { Radius = 5 };
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q02 

            //IAuthenticationService authService = new BasicAuthenticationService();

            //bool isAuthenticated = authService.AuthenticateUser("admin", "password");
            //Console.WriteLine("Authentication success: " + isAuthenticated);

            //bool isAuthorized = authService.AuthorizeUser("admin", "admin");
            //Console.WriteLine("Authorization success: " + isAuthorized);

            #endregion

            #endregion
        }
    }
}
