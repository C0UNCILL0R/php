namespace totr
{
    internal class Program
    {
        class Konto
        {
            public string Numer { get; }
            public decimal Stan { get; set; }
            public Konto() { }
            public Konto(string numer, decimal stan)
            {
                Numer = numer;
                Stan = stan;
            }
            public override string ToString()
            {
                return Numer + " " + Stan;
            }
            public void Przelej(Konto k, decimal kwota)
            {
                Stan -= kwota;
                k.Stan += kwota;
            }
        }
        static void Main(string[] args)
        {
            Konto k1 = new Konto("2396239529587623874123", 2354.30m);
            Console.WriteLine("Konto 1 : " + k1.ToString());
            Konto k2 = new Konto("2389757897389605031356", 1238.30m);
            Console.WriteLine("Konto 2 : " + k2.ToString());
            k1.Stan = k1.Stan - 1000;
            k2.Stan = k2.Stan + 1000;
            Console.WriteLine("Konto 1 : " + k1.ToString());
            Console.WriteLine("Konto 2 : " + k2.ToString());
            k1.Przelej(k2, 300);
            Console.WriteLine("Konto 1 : " + k1.ToString());
            Console.WriteLine("Konto 2 : " + k2.ToString());
        }
    }
}
