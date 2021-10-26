using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020002309_方泽楠_学生管理
{
    struct xs
    {
        public int xh;
        public String name;
    }

    public class sxb
    {
        private int maxSize;
        private int[] elem;
        private int len;

        public sxb(int[] elem)
        {
            this.elem = elem;
            this.maxSize = elem.Length;
            len = elem.Length;
        }

        public sxb() {

        }


        public sxb(int size)
        {
            this.maxSize = size;
            this.elem = new int[size];
            len = 1;
        }

    public override String ToString()
        {
            return "SequenceList{" +
                    "maxSize=" + maxSize +
                    ", elem=" + string.Join(",", elem) +
                    ", len=" + len +
                    '}';
        }

        internal string delIndex(string v1, string v2, MessageBoxButtons oKCancel)
        {
            throw new NotImplementedException();
        }

        /**
         * 常用操作：求线性表长度
         */
        public int getLen()
        {
            return len;
        }

        /**
         * 常用操作：清空线性表
         */
        public void empty()
        {
            this.len = 0;
            elem = null;
        }

        /**
         * 常用操作：判断线性表是否满了
         */
        public bool isFull()
        {
            return this.len == maxSize ? true : false;
        }

        /**
         * 常用操作：判断线性表是否为空
         */
        public bool isEmpty()
        {
            return this.len == 1 ? true : false;
        }

        /**
         * 常用操作：在顺序表第i个位置插入元素
         */
        public bool insert(int i, int a)
        {
            bool bo = false;
            bool b = i < 0 || i > len;
            if (!b)
            {
                bo = !bo;
                if (isFull())
                {
                    ++maxSize;
                }
                int[] newArray = new int[len + 1];
                for (int j = 1; j <= len; j++)
                {
                    if (j < i)
                    {
                        newArray[j] = elem[j];
                    }
                    else if (j == i)
                    {
                        newArray[j] = a;
                    }
                    else if (j > i)
                    {
                        newArray[j] = elem[j - 1];
                    }
                }
                elem = newArray;
                ++len;
            }
            return bo;
        }

        /**
         * 常用操作：删除指定位置（第i个）的元素
         */
        public bool delIndex(int i)
        {
            bool bo = false;
            bool b = i < 0 || i > len ;
            if (!b && !isEmpty())
            {
                bo = !bo;
                int[] newArray = new int[len - 1];
                for (int j = 1; j < len - 1; j++)
                {
                    if (j < i)
                    {
                        newArray[j] = elem[j];
                    }
                    else
                    {
                        newArray[j] = elem[j + 1];
                    }
                }
                elem = newArray;
                len--;
            }
            return bo;
        }

        /**
         * 删除线性表中所有值为e的元素
         */
        public void delE(int e)
        {
            for (int i = 0; i < len; i++)
            {
                if (e == elem[i])
                {
                    delIndex(i);
                }
            }
        }

        /**
         * 常用操作：得到第i个元素的值
         */
        public int findI(int i)
        {
            bool b = i < 0 || i > len - 1;
            if (b)
            {
                Console.WriteLine("索引错误");
            }
            return b ? -1 : elem[i];
        }

        /**
         * 常用操作：得到值为ktn的索引
         */
        public String findKtn(int i)
        {
            String s = "";
            for (int j = 0; j < elem.Length; j++)
            {
                if (i == elem[j])
                {
                    s += j + " ";
                }
            }
            return s;
        }

        /**
         * 常用操作：遍历线性表
         */
        public void print()
        {
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(this.elem[i]);
            }
        }

        /**
         * 将线性表b1连接到表后
         *
         * @return
         */
        public sxb connect(sxb b1)
        {
            int[] newArr = new int[elem.Length + b1.len - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < elem.Length)
                {
                    newArr[i] = elem[i];
                }
                else
                {
                    newArr[i] = b1.findI(i - elem.Length + 1);
                }
            }
            elem = newArr;
            maxSize += b1.maxSize;
            len += b1.len - 1;
            return this;
        }

        public sxb getOrder(sxb b1)
        {
            int k = this.len + b1.len - 1;
            sxb s3 = new sxb(k);
            int i = 1, j = 1;
            k = 1;
            while (i < len && j < b1.len)
            {
                if (elem[i] <= b1.findI(j))
                {
                    s3.insert(k++, elem[i]);
                    i++;
                }
                else
                {
                    s3.insert(k++, b1.findI(j));
                    j++;
                }
            }
            for (i = i; i < len; i++)
            {
                s3.insert(k++, elem[i]);
            }
            for (j = j; j < b1.len; j++)
            {
                s3.insert(k++, b1.findI(j));
            }
            return s3;
        }

        public void setElem(int[] elem)
        {
            this.elem = elem;
            len = elem.Length;
        }
    }
}


