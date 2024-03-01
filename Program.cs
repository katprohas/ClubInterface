using System;
namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }
    class Program
    {
        class Member : IClub
        {
            //from interface 
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            //3 additional fields/properties
            public double Dues { get; set; }
            public bool PoolAccess { get; set; }
            public string Pronouns { get; set; }
            
            //constructor
            public Member()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Dues = 0;
                PoolAccess = false;
                Pronouns = string.Empty;
            }
            //parameterized constructor
            public Member(int id, string firstName, string lastName, double dues, bool poolAccess, string pronouns)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Dues = dues;
                PoolAccess = poolAccess;                    
                Pronouns = pronouns;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }

            public string Display()
            {
                return "Member name: " + Fullname() + "\nMember Dues: $" + Dues + "\nHas Pool Access: " + PoolAccess + "\nPronouns: " + Pronouns;
            }
        } //end member class

        static void Main(string[] args)
        {
            Member member1 = new Member(42, "Douglas", "Adams", 50.50, true, "he/him/his");
            Console.WriteLine(member1.Display());
            Console.WriteLine();
            Member member2 = new Member(1010, "Ada", "Lovelace", 36, false, "she/her/hers");
            Console.WriteLine(member2.Display());
        }//end Main
    } //end program class
} //end namespace
