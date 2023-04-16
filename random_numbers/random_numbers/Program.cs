using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;

namespace Random_numbers
{
    public class Random
    {

        private async void ShowData(string requested_number)
        {
            string json = await downloadData(requested_number);
            Numbers numbers = JsonSerializer.Deserialize<Numbers>(json);
            Console.WriteLine(numbers.ToString());
        }

        private async Task<string> downloadData(string requested_number)
        {
            HttpClient client = new HttpClient();
            string call_tmp = "http://numbersapi.com/tmp_number?json";
            string call = call_tmp.Replace("tmp_number", requested_number);
            string json = await client.GetStringAsync(call);
            return json;
        }


        //http://numbersapi.com/random/year?json   //randomowy rok
        //http://numbersapi.com/1917/year?json     //dany rok
        //http://numbersapi.com/random/trivia?json //randomowa liczba
        //http://numbersapi.com/tmp_number?json    //dana liczba
        //http://numbersapi.com/random/date?json   //randomowa data
        //http://numbersapi.com/4/2/date?json      //2 kwietnia
        //http://numbersapi.com/random/math?json   //randomowa mat ciekawostka
        //http://numbersapi.com/12/math?json       //matematyczna ciekawostka


        static void Main(string[] args)
        {
            Random random = new Random();
            random.ShowData("4");

            var context = new classBoss();
            Numbers number_test = new Numbers() { text="a",number=2};
            context.numbers_table.Add(number_test);
        
            context.SaveChanges();
            while (true)
            {
             Console.WriteLine("O jakiej liczbie chcesz poznac ciekawostke?");
             string requested_number = Console.ReadLine();
             random.ShowData(requested_number);
             Thread.Sleep(1000);

             Console.WriteLine("Chcesz zakonczyc dzialanie programu? (T/N)");
             string x = Console.ReadLine();
             Console.WriteLine("\n");
             if (x == "T" || x=="t")
                break;
             }
            

          //  Console.ReadLine();
        }
    }
}