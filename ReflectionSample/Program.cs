using ReflectionSample.Models;
using System;

namespace ReflectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var param = new NBA();

            Console.WriteLine("新增");
            var post = SqlCommand.Insert<NBA>();
            Console.WriteLine(post);


            Console.WriteLine("查詢");
            var get = SqlCommand.Select<NBA>(
                new { param.LeagueTeam});
            Console.WriteLine(get);

            Console.WriteLine("修改");
            var put = SqlCommand.Update<NBA>(
                new { param.PlayerName, param.PlayerNumber });
            Console.WriteLine(put);


            Console.WriteLine("刪除");
            var delete = SqlCommand.Delete<NBA>(
                new { param.PlayerName });
            Console.WriteLine(delete);


            Console.ReadKey();
        }
    }
}
