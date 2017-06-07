using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module11CollectionGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> list = new List<Person>();
            //list.Add(new Person() {Id=1, Navn="Peter"  });
            //list.Add(new Person() { Id = 2, Navn = "June" });
            //list.Add(new Person() { Id = 3, Navn = "Niels" });

            //Dictionary<int, Person> lis2 = new Dictionary<int, Person>();

            //lis2.Add(0, new Person() {Id=2, Navn="Gry" });
            //lis2.Add(1, new Person() { Id = 3, Navn = "Elin" });
            //lis2.Add(2, new Person() { Id = 4, Navn = "Stine" });

            //foreach (Person item in list)
            //{
            //    Console.WriteLine(item.Navn);
            //}

            //var p = lis2[2];

            //Console.WriteLine(p.Navn);

            //Bunke b = new Bunke();
            //b.TilFøjKort(new Kort() { Kulør="Spar", Værdi=2});
            //b.TilFøjKort(new Kort() { Kulør = "Hjerter", Værdi = 4 });
            //b.TilFøjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            //b.Vis();

            //var k = b.FjernKort();
            //Console.WriteLine();
            //Console.WriteLine(k);
            //Console.WriteLine();
            //b.Vis();

            string ip = GetAppString("ip", "127.0.0.1");
            int maxRecords= GetAppSettingGeneric("maxrecords", 100)



        }

        static string GetAppString(string key, string defaultValue)
        {
            string v = System.Configuration.ConfigurationSettings.AppSettings[key];
            if (v == null)
                return defaultValue;
            return v;
        }

        static T GetAppSettingGeneric<T>(string key, T defaultValue)
        {
            var v = System.Configuration.ConfigurationSettings.AppSettings[key];
            if (v == null) 
            return defaultValue;

            return (T)Convert.ChangeType(v,typeof(T));
            
            
        }
    }
}
