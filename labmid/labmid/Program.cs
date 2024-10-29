using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labmid
{

    public class StudentClub
    {
        private double budget;
        public ClubRole clubRole;
        public Society society;
        public StudentClub( double b)
        {
          
            budget = b;
        }


        //Functions
        public static void fundSociety()
        {

        }

        public static void dispenseFund()
        {

        }

        public static void RegisterSociety()
        {

        }

        public static void DispalySocieties()
        {

        }




    }

    public class ClubRole
    {
        private string name;
        private string role;
        private string contactInfo;
        private string viceprinciple;

        public ClubRole(string name, string role, string contactInfo)
        {
            this.name = name;
            this.role = role;
            this.contactInfo = contactInfo;
        }



        public override string ToString()
        {
            return $"Name:{name} , Role:{role} ,Contact:{contactInfo}";
        }

    }





    public class Society
    {
        private string Name;
        private  string conactInfo;

        public Society(string name, string cont)
        {
            this.Name = name;
            this.conactInfo = cont;
        }

        public static void addActivity()
        {

        }

        public static void ListEvent()
        {

        }

    }

    public class FundedSociety : Society
    {
        private double fundingamount;
        
        public FundedSociety( double f,string n, string c):base(n,c)
        {
            
            this.fundingamount = f;
        }

      

    }


    public class NonFundedSociety :Society
    {
      public  NonFundedSociety(string n, string c):base(n,c)
        {

        }
    }



    internal class Program
    {

        public List<Society> society = new List<Society>();
        public List<StudentClub> stClub = new List<StudentClub>();
        public List<FundedSociety> FS = new List<FundedSociety>();


        static void Main(string[] args)
        {

            Console.WriteLine("Student Club Management System");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1.Register a New Society");
            Console.WriteLine("2.Allocate Funding to Societies");
            Console.WriteLine("3.Register an Event for a Society");
            Console.WriteLine("4.Displaly Society funding Information");
            Console.WriteLine("5.Display Events for society");
            Console.WriteLine("6.Exit");

            Console.WriteLine("Enter your choice (1-6):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    registerSociety();
                    break;
                case 2:
                    alocateFunding();
                    break;
                case 3:
                    registerEvent();
                    break;
                case 4:
                    DisplayFunding();
                    break;
                case 5:
                    DisplayEvent();
                    break;
                case 6:
                    return;
                  

               /* default:
                    Console.WriteLine("Invalid choice.Please enter correct input!");*/



            }







        }


        private static void registerSociety()
        {
            Console.WriteLine("Enter a society name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a society Contact:");
            string contact = Console.ReadLine();
          /*  society.Add(new Society(name, contact));*/
            Console.WriteLine("Society register Successfully.");
        }

        public static void alocateFunding()
        {
            Console.WriteLine("Allocate a society for funding:");
            string name = Console.ReadLine();
            Console.WriteLine("Allocate amount to society:");
            int amount = Convert.ToInt32(Console.ReadLine());
            /* stClub.Add(new StudentClub(name, amount));*/
            Console.WriteLine("Allocate fund Successfully.");
        }

        public static void registerEvent()

        {

        }


        public static void DisplayEvent()
        {

        }


        /* public static int DisplayFunding(int value)
         {
 */
        public static void DisplayFunding()
        {


            /*    foreach (var fund in args.Length)
                {
                    Console.WriteLine(fund);
                }
            }*/



        }
    }
}
