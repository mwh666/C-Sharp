using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_图书管理
{
    internal class BookService
    {

        //定义book为键值对集合
        Hashtable books = new Hashtable();
        //添加图书
        public void AddBook(int Id,Book book)
        {
      
            books.Add(Id,book);
        }
        //展示图书
        public void ShowBook()
        {
            foreach (Book book in books.Values)
            {
                Console.WriteLine($"{book.Id}\t{book.Name}");
            }
            
        }
        //删除图书
        public void DeltBook(int keys)
        {
            books.Remove(keys);
        }

        //修改图书名
        public void XiuBook(int keys,string name)
        {
            //值是Book类型
            Book x=(Book)books[keys];
            x.Name = name;
        }

    }
}
