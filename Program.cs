using System;           

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020002309_方泽楠_学生管理
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("1.建立的线性表s1:   10,13,15,18,21");
            sxb s1 = new sxb(1);
            s1.insert(1, 10);
            s1.insert(2, 13);
            s1.insert(3, 15);
            s1.insert(4, 18);
            s1.insert(5, 21);
            Console.WriteLine(s1);
            Console.WriteLine("2.在线性表s1的第3个位置插入100");
            s1.insert(3, 100);
            Console.WriteLine(s1);
            Console.WriteLine("3.删除线性表s1的第2个的元素");
            s1.delIndex(2);
            Console.WriteLine(s1);
            Console.WriteLine("4.查找值为18的元素");
            Console.WriteLine(s1.findKtn(18));
            Console.WriteLine("5.建立的线性表s2:  11,13,14,17,20,23,30");
            sxb s2 = new sxb(new int[] { 0, 11, 13, 14, 17, 20, 23, 30 });
            Console.WriteLine(s2);
            Console.WriteLine("6.将线性表s2连接到s1后面");
            s1.connect(s2);
            Console.WriteLine(s1);
            Console.WriteLine("7.将线性表s1中所有值为13的元素删除");
            s1.delE(13);
            Console.WriteLine(s1);
            Console.WriteLine("8.建立的线性表s1:   10,13,15,18,25");
            s1 = new sxb(new int[] { 0, 10, 13, 15, 18, 25 });
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("9.将有序线性表s1,s2合并到s3,s3仍有序");
            sxb s3 = s1.getOrder(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s1);
            s1.delIndex(2);
            s1.delIndex(2);
            s1.delIndex(2);
            s1.insert(2,1);
            s1.insert(2,1);
            s1.insert(2,1);
            s1.insert(2,1);
            Console.WriteLine(s1);
            
        }
    }
}