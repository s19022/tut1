using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task_1
{
    public class Program
    {
        public async static Task Main(string[] args)
        {

            var httpClient = new HttpClient();
            var url = "https://www.pja.edu.pl";



            var response = await httpClient.GetAsync(url);

            var content = response.Content;

        

            var regex = new Regex("[*]");



            var matches = regex.Matches(content.ToString());

            Console.WriteLine(matches.);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            } 
           
        }
    }
}
