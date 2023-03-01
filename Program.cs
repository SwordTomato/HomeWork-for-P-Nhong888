class Program {

    static void Main(string[] args) {
        Console.Write("หน่วยงานของคุณ : ");
         string x = (Console.ReadLine());

    if (x == "CIA") {
        Console.Write("รหัสผ่าน6หลัก : ");
        int y = int.Parse(Console.ReadLine());

        int y1 = (y / 1000) % 10 ;
        int y2 = (y / 10) % 10 ;
        int y3 = y % 10 ;

        if (y3 % 3 == 0) {
            if (y2 != 1 && y2 != 3 && y2 != 5) {
                if (y1 > 6 && y1 != 8 ) {
                    Console.WriteLine("true");
                } else {
                    Console.WriteLine("false");}
            } else {
                Console.WriteLine("false");
            }
        } else {
            Console.WriteLine("false");
        }
    } else if (x == "FBI") {
       Console.Write("รหัสผ่าน6หลัก : ");
        int y = int.Parse(Console.ReadLine());

        int z1 = y / 100000;
        int z2 = (y / 10000) % 10 ;
        int z3 = (y / 100) % 10 ;

        if (z1 >= 4 && z1 <= 7) {
            if (z3 % 2 == 0 && z3 != 6) {
                if (z2 % 2 == 1) {
                    Console.WriteLine("true");
                } else {
                    Console.WriteLine("false");}
            } else {
                Console.WriteLine("false");
            }
        } else {
            Console.WriteLine("false");
        }
    } else if (x == "NSA") {
        Console.Write("รหัสผ่าน6หลัก : ");
        int y = int.Parse(Console.ReadLine());

        int a1 = y / 100000;
        int a2 = (y / 100) % 10 ;
        int a3 = y % 10 ;
        int a4 = (y / 1000) % 10 ;
        int a5 = (y / 10) % 10 ;
        int a6 = (y / 10000) % 10 ;

        if (30 % a3 == 0) {
            if (a2 % 3 == 0 && a2 % 2 != 0) {
                if (a1 == 7 || a2 == 7 || a3 == 7 || a4 == 7 || a5 == 7 || a6 == 7) {
                    Console.WriteLine("true");
                } else {
                    Console.WriteLine("false");}
            } else {
                Console.WriteLine("false");
            }
        } else {
            Console.WriteLine("false");
        }
    } else {
        Console.WriteLine("false");
    }
}
}