using ReflectionSample.Models;
using System;

namespace ReflectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新增
            var post = SqlCommand.Insert<NBA>();
            Console.WriteLine(post);
            Console.WriteLine("---------------------------------------------------");

            // 查詢
            var get = SqlCommand.Select<NBA>();
            Console.WriteLine(get);
            Console.WriteLine("---------------------------------------------------");

            // 修改
            var put = SqlCommand.Update<NBA>(new { new NBA().PlayerName, new NBA().PlayerNumber });
            Console.WriteLine(put);
            Console.WriteLine("---------------------------------------------------");

            // 刪除
            var delete = SqlCommand.Delete<NBA>(new { new NBA().PlayerName });
            Console.WriteLine(delete);

            Console.ReadKey();
        }
    }
}
