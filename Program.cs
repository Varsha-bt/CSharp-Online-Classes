using System;

namespace ApartmentDemo
{
    public class Apartment
    {
        public string apartmentNo;
        public string buildingNo;
        public string Floor; 
        private string ownerName="xyz";


        public void displayInfo()
        {
            Console.WriteLine("Enter  the Apartment No");
            apartmentNo = Console.ReadLine();
            Console.WriteLine("Enter  the Building No");
            buildingNo = Console.ReadLine();
            Console.WriteLine("Enter  the Floor No");
            Floor = Console.ReadLine();
            //Console.WriteLine("Enter  the ownerName");
            //ownerName = Console.ReadLine();


        }

        //public string OwnerName
        //{
        //    get
        //    {
        //        return ownerName;
        //    }
        //    set
        //    {
        //        ownerName = value;
        //    }

        //}
        public void getDetails()
        {

            Console.WriteLine("Apartment No is : " + apartmentNo);
            Console.WriteLine("Building No is :" + buildingNo);
            Console.WriteLine("Floor No is :" + Floor);
            Console.WriteLine("Owner Name is :" + ownerName);



        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Apartment apartment1 = new Apartment();
           
            Apartment apartment2 = new Apartment();

            Apartment apartment3 = new Apartment();

            Apartment[] vilas = new Apartment[3];
            vilas[0] = apartment1;
            vilas[1] = apartment2;
            vilas[2] = apartment3;

            Console.WriteLine("Enter your deatis here :");
            for (int i = 0; i < vilas.Length; i++)
            {
                
                vilas[i].displayInfo();
                //vilas[i].getDetails();
            }

            Console.WriteLine("your deatis here :");

            for (int i = 0; i < vilas.Length; i++)
            {
                vilas[i].getDetails();
            }

        }
    }

}