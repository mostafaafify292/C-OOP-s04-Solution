using C__OOP_s04.BuildInInterface;
using C__OOP_s04.Car_Airplane;
using C__OOP_s04.InterFace;
using C__OOP_s04.ISeries;
using C__OOP_s04.Part3_Q1_Q2_Q3;
using C__OOP_s04.Q3;
using System.Text;

namespace C__OOP_s04
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(Iseries Series)
        {
                if (Series is not  null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Series.GetNext();
                    Console.Write($"{Series.Current} \t");
                    
                }
                Series.ReSet();     

            }

        }

        static void Main(string[] args)
        {


            #region interface
            //ClassMyType Mytype1 = new ClassMyType();
            //Mytype1.Id = 5;
            //Mytype1.Myfun(10); 
            #endregion
            #region interface EX1


            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            //Console.WriteLine("\n***********************************");
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            #endregion
            #region EX2 [implicitly , explicitly]

            // Car car = new Car();
            // car.Backward();

            //Airplane airplane = new Airplane();
            //IMoveable moveable = new Airplane();
            //IFlyable flyable = new Airplane();

            //moveable.Backward();
            //flyable.Backward();

            #endregion
            #region Shalow Copy And Deep Copy
            #region Array Of Value Type
            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = new int[3];

            //Console.WriteLine($"Hash Of arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Of arr02 = {arr02.GetHashCode()}");
            #region Shallow Copy [stack]
            //arr01 = arr02;
            //Console.WriteLine();
            //Console.WriteLine($"Hash Of arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Of arr02 = {arr02.GetHashCode()}");
            //arr01[0] = 1;
            //Console.WriteLine(arr01[0]);
            //Console.WriteLine(arr02[0]); 
            #endregion
            #region Deep Copy [heap]

            //arr02 = (int[])arr01.Clone();
            //Console.WriteLine($"Hash Of arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Of arr02 = {arr02.GetHashCode()}");
            //Console.WriteLine(arr01[0]);
            //Console.WriteLine(arr02[0]);
            //arr01[0] = 5;
            //Console.WriteLine(arr01[0]);
            //Console.WriteLine(arr02[0]);
            #endregion

            #endregion
            #region Array Of Ref Type

            #region Array Of String[immutable]

            //string[] Names01 = { "omar" };
            //string[] Names02 = new string[1];

            #region Shallow Copy
            //Console.WriteLine($"Hash Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"Hash Of Names02 = {Names02.GetHashCode()}");
            ////Names02 = Names01; //Shallow Copy
            ////Console.WriteLine($"Hash Of Names01 = {Names01.GetHashCode()}");
            ////Console.WriteLine($"Hash Of Names02 = {Names02.GetHashCode()}");
            ////Console.WriteLine(Names01[0]);
            ////Console.WriteLine(Names02[0]); 
            #endregion
            #region Deep Copy
            //Names02 = (string[]) Names01.Clone();
            //Console.WriteLine($"Hash Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"Hash Of Names02 = {Names02.GetHashCode()}");
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);
            //Names01[0] = "maha";
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);


            #endregion

            #endregion



            #endregion
            #region Array Of StringBuilder [mutable]


            #region Shallow Copy

            ////StringBuilder[] Names01 = new StringBuilder[1];
            ////Names01[0] = new StringBuilder("Omar");

            ////StringBuilder[] Names02 = new StringBuilder[1];
            ////Console.WriteLine($"Hash Of Names01 = {Names01.GetHashCode()}");
            ////Console.WriteLine($"Hash Of Names02 = {Names02.GetHashCode()}");
            ////Names02 = Names01;
            ////Console.WriteLine($"Hash Of Names01 = {Names01.GetHashCode()}");
            ////Console.WriteLine($"Hash Of Names02 = {Names02.GetHashCode()}");
            ////Names01[0].Append("amr");
            ////Console.WriteLine(Names01[0]);
            ////Console.WriteLine(Names02[0]); 
            #endregion
            #region Deep Copy 
            //Names02 = (StringBuilder[])Names01.Clone();
            //Console.WriteLine($"Hash Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"Hash Of Names02 = {Names02.GetHashCode()}");
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);
            //Names01[0].Append("mohamed");
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            #endregion





            #endregion


            #endregion
            #region BuildIn ICloneable [Deep Copy]

            //Employee employee01 = new Employee() {Id = 10 , Name = "mostafa" , Salary =3000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "afify", Salary = 4000 };
            //employee02 = (Employee) employee01.Clone();
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);
            //employee01.Id = 300;
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);

            #endregion
            #region Part02 MCQ
            //Question1  :    a) To provide a way to implement multiple inheritance
            //Question2  :    a) private
            //Question3  :    c) Only if they are static
            //Question4  :    b) Yes, interfaces can inherit from multiple interfaces
            //Question5  :    d) implements
            //Question6  :    a) Yes
            //Question7  :    b) No, all members are implicitly public
            //Question8  :    b) To provide a clear separation between interface and class members
            //Question9  :    b) No, interfaces cannot have constructors
            //Question10 :    c) By separating interface names with commas
            #endregion
            #region Part03 Q1

            //ICircle circle1;
            //circle1 = new CircleClass();
            //circle1.DisplayShapeInfo();
            //IRectangle rectangle1;
            //rectangle1 = new RectanangleClass();
            //rectangle1.Width = 15;
            //rectangle1.Length = 2;
            //rectangle1.DisplayShapeInfo();

            #endregion
            #region Part3 Q2

            ////////////////////////////////////////////////////
            //Q2
            //IAuthenticationService AuthService;
            //AuthService = new BasicAuthenticationService();

            //AuthService.AuthenticateUser("mostafa", "password");
            //AuthService.AuthenticateUser("Admin", "password");

            //AuthService.AuthorizeUser("mostafa", "User");
            //AuthService.AuthorizeUser("Admin", "Admin");
            #endregion
            #region Part3 Q3

            //Q3

            //INotificationService notification = new EmailNotificationService();
            //notification.SendNotification("mostafa", "hello mostafa");
            #endregion











        }
    }
}