using System;

public class vsw
{
    static public void Main ()
    {

Kalkulator kal = new Kalkulator();
kal.judul("luas persegi panjang ");
Console.Write("masukkan p : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("masukkan l : ");
int l = Convert.ToInt16(Console.ReadLine());
Console.Write($"luas persegi panjang dengan p :{p} dan l :{l} adalah : ");
Console.WriteLine(kal.kali(p,l));
    }
interface IHitung{

        void judul(string j);

        int kali(int a, int b);

        int tambah(int a, int b);
    }

    class Kalkulator:IHitung
    {

        public void judul(string j){
            Console.WriteLine(j);
        }

        public int kali(int a, int b){
            return a * b;
        }

        public int tambah(int a, int b){
           return a + b; 
        }
    }
}
