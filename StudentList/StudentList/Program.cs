using System;
namespace StudentList
{
    class Poulami
    {
        static void Main(string[] args)
        {
            var Student = new List<StdList>()
            {
                new StdList(){ Std_id=1,Std_Fname="Poulami",Std_lname="Dhar",Roll_no=10},
                new StdList(){ Std_id=2,Std_Fname="Tania",Std_lname="ghosh",Roll_no=11},
                new StdList(){ Std_id=3,Std_Fname="suvo",Std_lname="dey",Roll_no=12},
                new StdList(){ Std_id=4,Std_Fname="nishan",Std_lname="Mal",Roll_no=13},

            };
            var Rollno = from bno in Student
                         where bno.Std_Fname == "Poulami"
                         select bno;
            foreach (var item in Rollno)
                Console.WriteLine(item.Std_Fname);


        }
    }
    public class StdList
    {
        public int Std_id { get; set; }
        public string Std_Fname { get; set; }
        public string Std_lname { get; set; }
        public int Roll_no { get; set; }
    }

}