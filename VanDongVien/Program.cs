using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanDongVien
{
    class Info
    {
        struct VDV
        {
            public string name;
            public int age;
            public double height;
            public char bangDau;
        }
        static void SignInfo(out VDV x)
        {
            Console.Write("Nhap ten: ");
            x.name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            x.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            x.height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap bang dau: ");
            x.bangDau = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
        }
        static void Show(VDV[] x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ten: " + x[i].name);
                Console.WriteLine("Tuoi: " + x[i].age);
                Console.WriteLine("Chieu cao: " + x[i].height);
                Console.WriteLine("Bang dau: " + x[i].bangDau);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int n;
            Console.Write("Nhap so luong VDV: ");
            n =Convert.ToInt32(Console.ReadLine());
            VDV[]x = new VDV[n];

            for (int i = 0; i < n; i++)
            {
                SignInfo(out x[i]);
            }
            Show(x, n);


            Console.ReadKey();
        }
    }
    
}
