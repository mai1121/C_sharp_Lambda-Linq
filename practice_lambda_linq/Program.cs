using System;
using System.Collections.Generic;

namespace practice_lambda_linq
{
    class Menu
    {
        static void Main(string[] args)
        {
            var m = new Menu();
            var data = new[]{"おにぎり","ラーメン","オムライス" };
            //data配列と、メソッドを渡している
            m.LunchMenu(data, (string d) => $"{d}を食べました");

            var list = new List<int> {100,200,300,400 };
            list.ForEach(v => Console.WriteLine($"{v*3}円です"));
            var result1 = list.ConvertAll(v => $"{2000-v}円のお釣りです");
            foreach(var r in result1)
            {
                Console.WriteLine(r);
            }
            var result2 = list.FindAll(v => v > 200);
            foreach(var r in result2)
            {
                Console.WriteLine($"再検査対象は{r}kgのかたです");
            }
            Console.WriteLine(list.FindIndex(v => v > 200));

            var sweets_list = new List<string> { "チョコケーキ","プリン","チョコアイス","バニラアイス"};
            var result3 = sweets_list.FindAll(v => v.Contains("チョコ"));
            foreach (var r in result3)
            {
                Console.WriteLine($"おやつは{r}");
            }
            Console.WriteLine(sweets_list.Exists(v=>v.Length<10));
        }
        //outputはstring型の引数を受け入れて、string型の値を返すメソッド
        public void LunchMenu(string[] data, Func<string,string>output)
        {
            //data配列の中身をoutputメソッドに渡すのを繰り返し
            foreach (var i in data)
            {
                Console.WriteLine(output(i));
            }
        }
    }
}
