using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cal_Pomona_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
          CalPomonaEntities db = new CalPomonaEntities();


            
            for(; ;)
            {
                try
                {
                    Console.WriteLine("please Swap a magnetic card to login to office");
                    string id = Console.ReadLine();
                    string[] i = id.Split('=', '?');

                    var name = "";
                    string office = "";
                    
                    db.Database.ExecuteSqlCommand("UPDATE Professor SET Avalability = 'yes' WHERE Professor_Id = " + i[1] + ";");
                    int n = int.Parse(i[1]);
                    var l = db.Professors.Where(x=>x.Professor_Id==n).ToList();
                    foreach(var prof in l)
                    {
                       
                        name = prof.Name;
                        office = prof.Room;
                    }
                   
                    Console.WriteLine("Welcome professor : " + name + " office number : " +office);
                    Console.WriteLine("Please Swape a magnetic card to logout of office");
                    id = Console.ReadLine();
                    string[] o = id.Split('=', '?');
                    db.Database.ExecuteSqlCommand("UPDATE Professor SET Avalability = 'no' WHERE Professor_Id = " + o[1] + ";");
                    Console.WriteLine("you have louged out successfully");
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message + "Error happened");
                }

            }
         
        }
    }
}
