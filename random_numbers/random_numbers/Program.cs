using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Random_numbers
{
    public class Random_mine
    {

        private async Task<Numbers> ShowData(string url)
        {
            string json = await downloadData(url);
            Numbers numbers = JsonSerializer.Deserialize<Numbers>(json);
            Console.WriteLine(numbers.ToString());
            return numbers;
        }

        private async Task<string> downloadData(string url)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
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
            Random_mine random = new Random_mine();
            var context = new classBoss();
            Console.WriteLine("Nasza baza to: \n");
            context.numbers_table.Select(elem=>new { elem.number, elem.text }).ToList().ForEach(elem => Console.WriteLine(elem + ","));
            while (true)
            {
                
                Console.WriteLine("Menu:\n 1.Losowy rok\n 2.Wybrany rok\n 3.Losowa liczba\n 4.Wybrana liczba\n 5.Koniec programu\n");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Random rnd = new Random();
                        int rand_num = rnd.Next(-1000,2022);
                        if (context.numbers_table.Select(elem => elem).Where(elem => elem.number == Convert.ToInt32(rand_num)).Count() > 0)
                        {
                            Console.WriteLine("Pobieram z bazy!!!");
                            context.numbers_table.Select(elem => elem).Where(elem => elem.number == Convert.ToInt32(rand_num)).ToList().ForEach(elem => Console.WriteLine(elem));
                        }
                        else
                        {
                            Console.WriteLine("Korzystam z API!!!");
                            string call_tmp = "http://numbersapi.com/tmp_number/year?json";
                            string call = call_tmp.Replace("tmp_number", rand_num.ToString());
                            Numbers number = random.ShowData(call).Result;
                            context.numbers_table.Add(number);
                            context.SaveChanges();
                        }

                            //string call_tmp = "http://numbersapi.com/tmp_number?json";
                            //string call = call_tmp.Replace("tmp_number","random/year");
                            //Numbers number = random.ShowData(call).Result;
                            break;

                    case 2:
                        Console.WriteLine("O jakim roku chcesz poznac ciekawostke?");
                        string requested_number = Console.ReadLine();

                        if (context.numbers_table.Select(elem => elem).Where(elem => elem.number == Convert.ToInt32(requested_number)).Count() > 0)
                        {
                            Console.WriteLine("Pobieram z bazy!!!");
                            context.numbers_table.Select(elem => elem).Where(elem => elem.number == Convert.ToInt32(requested_number)).ToList().ForEach(elem => Console.WriteLine(elem));
                        }
                        else
                        {
                            Console.WriteLine("Korzystam z API!!!");
                            string call_tmp2 = "http://numbersapi.com/tmp_number/year?json";
                            string call2 = call_tmp2.Replace("tmp_number", requested_number);
                            Numbers number2 = random.ShowData(call2).Result;
                            //Numbers number_test = new Numbers() { text="a",number=2, found=true};
                            context.numbers_table.Add(number2);
                            context.SaveChanges();
                        }
                        break;

                    case 3:
                        string call_tmp3 = "http://numbersapi.com/tmp_number?json";
                        string call3 = call_tmp3.Replace("tmp_number", "random/trivia");
                        Numbers number3 = random.ShowData(call3).Result;
                        break;

                    case 4:
                        Console.WriteLine("O jakiej liczbie chcesz poznac ciekawostke?");
                        string requested_number2 = Console.ReadLine();

                        if (context.numbers_table.Select(elem => elem).Where(elem => elem.number == Convert.ToInt32(requested_number2)).Count() > 0)
                        {
                            Console.WriteLine("Pobieram z bazy!!!");
                            context.numbers_table.Select(elem => elem).Where(elem => elem.number == Convert.ToInt32(requested_number2)).ToList().ForEach(elem => Console.WriteLine(elem));
                        }
                        else
                        {
                            Console.WriteLine("Korzystam z API!!!");
                            string call_tmp4 = "http://numbersapi.com/tmp_number?json";
                            string call4 = call_tmp4.Replace("tmp_number", requested_number2);
                            Numbers number4 = random.ShowData(call4).Result;
                            context.numbers_table.Add(number4);
                            context.SaveChanges();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Koncze dzialanie programu");
                        return;
                    default:
                        Console.WriteLine("Zla wartosc!!!");
                        break;
                }
            }
        }

    }
}
