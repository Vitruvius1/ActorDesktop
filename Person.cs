using System;
using System.Windows.Forms;

namespace Actor
{
    public class Actorobj
    {
        public string actorId; //Create a field
        public string firstName;
        public string lastName;
        public string age;
        public string gender;
        public string yearPerformed;
        public string photo;
        public string moviePlayed;
        public string points;




        public class Example
        {
            public static void Main(string[] args)
            {
                string[] ActorData = { "" };

                static void MyMethod(string fName, string lName)
                {
                    fName = Console.ReadLine();
                    lName = Console.ReadLine();
                }

                static void generateID(string id)
                {
                    string id = " ";
                    Random rnd = new Random();

                    for (int j = 0; j <= 10; j++)
                    {
                        id += rnd;
                    }
                    {
                        return id;

                    }
                }

           


            

        }
    }
}


ActorID    // property
        {
            get { return actorID; }  //get method
            set { actorID = value; }  //set method
        }



    }

}
