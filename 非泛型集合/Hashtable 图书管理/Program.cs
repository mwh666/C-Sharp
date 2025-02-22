using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_图书管理
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book(1, "西游记");
            Book book2 = new Book(2, "水浒传");
            Book book3 = new Book(3, "水猴子");
            //添加图书
            BookService bookService = new BookService();
            bookService.AddBook(1, book1);
            bookService.AddBook(2, book2);
            bookService.AddBook(3, book3);
            //展示图书
            bookService.ShowBook();
            Console.WriteLine();
            //删除图书
            Console.WriteLine("删除序号为1的图书");
            bookService.DeltBook(1);
            bookService.ShowBook();
            Console.WriteLine();
            //修改图书名
            bookService.XiuBook(2, "红楼梦");

            bookService.ShowBook();
            Console.WriteLine();

        }
    }
}
