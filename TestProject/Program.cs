using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        public interface I
        {
            void Go();
        }
        public class A : I
        {
            public void Go()
            {
                Console.WriteLine("А.Go()");
            }
        }
        class B : A
        { }
        class C : B, I
        {
            public new void Go()
            {
                Console.WriteLine("C.Gо()");
            }
        }

        class Account<T>
        {
            public T Id { get; set; }
            public int Sum { get; set; }
        }

        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int> { Sum = 5000 };
            Account<string> account2 = new Account<string> { Sum = 4000 };
            account1.Id = 2;
            account2.Id = "4356";
            Console.WriteLine(account1.Id.GetType() + " " + account2.Id.GetType().ToString());

            B b1 = new B();
            C c1 = new C();
            B b2 = c1;
            b1.Go();
            c1.Go();
            b2.Go();
            ((I)b2).Go();

            String s1 = "abc";
            String s2 = "cbd";
            String s3 = "abc";
            s2 = s3;

            Console.Write(s1 == s3 + " ");
            Console.Write(" " + s1.Equals(s3) + " ");
            Console.Write(ReferenceEquals(s1, s3) + " ");
            Console.Write(ReferenceEquals(s2, s3));

            var str = "" + 5;
            Console.WriteLine(str);
            str = "".ToString() + "5";
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);

            // заменяем слово
            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            Console.WriteLine(sb);

            // получаем строку из объекта StringBuilder
            string s = sb.ToString();
            Console.WriteLine(s);

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Число: {0}, срока: {1}", 23, "hello");
            Console.WriteLine(builder.ToString());
        }
    }
}
