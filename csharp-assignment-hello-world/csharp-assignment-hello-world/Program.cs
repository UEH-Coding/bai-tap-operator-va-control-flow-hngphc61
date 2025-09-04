using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("BAI TAP OPERATOR VA CONTROL FLOW");
            Console.WriteLine("PHAN 1: Operators (Slide 9)");
            Console.WriteLine("  1. Tinh phep toan (+, -, *, /, %, x) giua 2 so");
            Console.WriteLine("  2. Hien thi gia tri ham x = y^2 + 2y + 1 voi y tu -5 den 5");
            Console.WriteLine("  3. Tinh van toc km/h va miles/h tu khoang cach va thoi gian");
            Console.WriteLine("  4. Tinh dien tich & the tich hinh cau");
            Console.WriteLine("  5. Kiem tra ky tu la nguyen am, chu so hay ky hieu khac");

            Console.WriteLine("\nPHAN 2: Control Flow (Slide 21)");
            Console.WriteLine("  6. Kiem tra so chan/le");
            Console.WriteLine("  7. Tim so lon nhat trong 3 so");
            Console.WriteLine("  8. Xac dinh diem (x,y) nam o goc phan tu nao");

            Console.WriteLine("\nPHAN 3: Control Flow (Slide 22)");
            Console.WriteLine("  9. Kiem tra tam giac (Deu, Can, Thuong)");
            Console.WriteLine("  10. Doc 10 so va tinh tong, trung binh");
            Console.WriteLine("  11. Bang cuu chuong");
            Console.WriteLine("  12. In pattern tam giac so");
            Console.WriteLine("  13. In day so harmonic 1 + 1/2 + 1/3 + ... + 1/n");
            Console.WriteLine("  14. Tim so hoan hao trong khoang cho truoc");
            Console.WriteLine("  15. Kiem tra so nguyen to");

            Console.WriteLine("\n0. Thoat chuong trinh");
            Console.Write("\nNhap lua chon cua ban: ");
            int chon;
            if (!int.TryParse(Console.ReadLine(), out chon)) continue;
            if (chon == 0) break;

            Console.Clear();
            switch (chon)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 11: Bai11(); break;
                case 12: Bai12(); break;
                case 13: Bai13(); break;
                case 14: Bai14(); break;
                case 15: Bai15(); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }

            Console.WriteLine("\nNhan phim ENTER de quay ve MENU...");
            Console.ReadKey();
        }
    }

    // ===== PHAN 1: SLIDE 9 =====
    static void Bai1()
    {
        Console.Write("Nhap so thu nhat: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double kq = 0;
        switch (op)
        {
            case '+': kq = a + b; break;
            case '-': kq = a - b; break;
            case '*': kq = a * b; break;
            case '/': kq = b != 0 ? a / b : double.NaN; break;
            case '%': kq = a % b; break;
            default: Console.WriteLine("Phep toan khong hop le!"); return;
        }
        Console.WriteLine($"Ket qua: {a} {op} {b} = {kq}");
    }

    static void Bai2()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }

    static void Bai3()
    {
        Console.Write("Nhap khoang cach (km): ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Nhap gio: ");
        double h = double.Parse(Console.ReadLine());
        Console.Write("Nhap phut: ");
        double m = double.Parse(Console.ReadLine());
        Console.Write("Nhap giay: ");
        double s = double.Parse(Console.ReadLine());

        double time = h + m / 60 + s / 3600;
        double speedKm = d / time;
        double speedMiles = speedKm / 1.609;
        Console.WriteLine($"Toc do: {speedKm:F2} km/h ~ {speedMiles:F2} miles/h");
    }

    static void Bai4()
    {
        Console.Write("Nhap ban kinh r: ");
        double r = double.Parse(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Dien tich = {surface:F2}, The tich = {volume:F2}");
    }

    static void Bai5()
    {
        Console.Write("Nhap ky tu: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if ("aeiouAEIOU".Contains(c)) Console.WriteLine("Day la nguyen am");
        else if (char.IsDigit(c)) Console.WriteLine("Day la chu so");
        else if (char.IsLetter(c)) Console.WriteLine("Day la phu am");
        else Console.WriteLine("Day la ky hieu khac");
    }

    // ===== PHAN 2: SLIDE 21 =====
    static void Bai6()
    {
        Console.Write("Nhap so: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "So chan" : "So le");
    }

    static void Bai7()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        int c = int.Parse(Console.ReadLine());
        int max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"So lon nhat: {max}");
    }

    static void Bai8()
    {
        Console.Write("Nhap X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhap Y: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0) Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu 1");
        else if (x < 0 && y > 0) Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu 2");
        else if (x < 0 && y < 0) Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu 3");
        else if (x > 0 && y < 0) Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu 4");
        else if (x == 0 && y == 0) Console.WriteLine("Diem nam o goc toa do");
        else if (x == 0) Console.WriteLine("Diem nam tren truc Y");
        else Console.WriteLine("Diem nam tren truc X");
    }

    // ===== PHAN 3: SLIDE 22 =====
    static void Bai9()
    {
        Console.Write("Nhap canh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c) Console.WriteLine("Tam giac deu");
        else if (a == b || b == c || a == c) Console.WriteLine("Tam giac can");
        else Console.WriteLine("Tam giac thuong");
    }

    static void Bai10()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nhap so thu {i}: ");
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Tong = {sum}, Trung binh = {(double)sum / 10}");
    }

    static void Bai11()
    {
        Console.Write("Nhap so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }

    static void Bai12()
    {
        Console.Write("Nhap so dong: ");
        int n = int.Parse(Console.ReadLine());

        // Pattern 1
        Console.WriteLine("Pattern 1:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        // Pattern 2
        Console.WriteLine("Pattern 2:");
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }

    static void Bai13()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
            Console.Write(i == n ? $"1/{i}" : $"1/{i} + ");
        }
        Console.WriteLine($"\nTong = {sum:F4}");
    }

    static void Bai14()
    {
        Console.Write("Nhap gioi han tren: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Cac so hoan hao:");
        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i / 2; j++)
                if (i % j == 0) sum += j;
            if (sum == i) Console.WriteLine(i);
        }
    }

    static void Bai15()
    {
        Console.Write("Nhap so: ");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) { isPrime = false; break; }
        Console.WriteLine(isPrime ? "So nguyen to" : "Khong phai so nguyen to");
    }
}

