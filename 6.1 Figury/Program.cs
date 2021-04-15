using System;
using System.Collections.Generic;

namespace _6._1_Figury
{
    class Punkt
    {
        private int x;
        private int y;
        public Punkt() { }
        public Punkt(int pierwszy, int drugi) { x = pierwszy; y = drugi; }

        public Punkt(Punkt p) { x = p.x; y = p.y; }
        public void przesun(int dx, int dy)
        {
            x = x + dx;
            y = y + dy;
        }
        public string toString() { return "(" + x + "," + y + ")"; }
        // public int getX() { return this.x; }
        // public int getY() { return this.y; }

    }
    class Linia
    {
        private Punkt pierwszy = new Punkt();
        private Punkt drugi = new Punkt();
        public Linia() { }
        public Linia(Punkt p1, Punkt p2) { pierwszy = new Punkt(p1); drugi = new Punkt(p2); }
        public Linia(Linia l) { pierwszy = new Punkt(l.pierwszy); drugi = new Punkt(l.drugi); }
        // pierwszy = l.pierwszy; drugi = l.drugi; }
        public void przesun(int dx, int dy)
        {
            pierwszy.przesun(dx, dy);
            drugi.przesun(dx, dy);
        }
        public string toString() { return pierwszy.toString() + "->" + drugi.toString(); }
        //return "(" + pierwszy.getX() + "," + pierwszy.getY() + ")->" +
        //"(" + drugi.getX() + "," + drugi.getY() + ")"; }
        //"(" + pierwszy.x + "," + pierwszy.y + ")->(" + drugi.x + "," + drugi.y + ")"; }

    }
    class Trojkat
    {
        private Linia pierwsza = new Linia();
        private Linia druga = new Linia();
        private Linia trzecia = new Linia();
        public Trojkat() { }
        public Trojkat(Linia l1, Linia l2, Linia l3)
        {
            pierwsza = new Linia(l1);
            druga = new Linia(l2);
            trzecia = new Linia(l3);
        }

        public Trojkat(Trojkat t) { pierwsza = t.pierwsza; druga = t.druga; trzecia = t.trzecia; }

        public void przesun(int dx, int dy)
        {
            pierwsza.przesun(dx, dy);
            druga.przesun(dx, dy);
            trzecia.przesun(dx, dy);
        }
        public string toString() { return pierwsza.toString() + "  " + druga.toString() + "  " + trzecia.toString(); }
    }
    class Czworokat
    {
        private Linia pierwsza = new Linia();
        private Linia druga = new Linia();
        private Linia trzecia = new Linia();
        private Linia czwarta = new Linia();

        public Czworokat() { }

        public Czworokat(Czworokat cz) { pierwsza = cz.pierwsza; druga = cz.druga; trzecia = cz.trzecia; czwarta = cz.czwarta; }
        public Czworokat(Linia l1, Linia l2, Linia l3, Linia l4)
        {
            pierwsza = new Linia(l1);
            druga = new Linia(l2);
            trzecia = new Linia(l3);
            czwarta = new Linia(l3);
        }

        public void przesun(int dx, int dy)
        {
            pierwsza.przesun(dx, dy);
            druga.przesun(dx, dy);
            trzecia.przesun(dx, dy);
            czwarta.przesun(dx, dy);
        }
        public string toString() { return pierwsza.toString() + "  " + druga.toString() + "  " + trzecia.toString() + "  " + czwarta.toString(); }
    }
    class Obraz
    {

        List<Trojkat> trojkaty = new List<Trojkat>();
        List<Czworokat> czworokaty = new List<Czworokat>();

        public void dodajTrojkat(Trojkat t)
        {
            trojkaty.Add(t);
        }
        public void dodajCzworokat( Czworokat cz)
        {
            czworokaty.Add(cz);
        }
        public void przesunTrojkat(int dx, int dy, int index)
        {
            trojkaty[index].przesun(dx, dy);


        }
        public void przesunCzworokat(int dx, int dy, int index)
        {
            czworokaty[index].przesun(dx, dy);
        }
        public string toString(Trojkat t)
        {
            return t.toString();
        }
        public string toString(Czworokat cz)
        {
            return cz.toString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(0, 0), p2 = new Punkt(1, 1), p3 = new Punkt(2, 2);
            Linia l1 = new Linia(p1, p2), l2 = new Linia(p1, p2), l3 = new Linia(p1, p3), l4 = new Linia(p2, p3);
            l1.przesun(5, 5);
            l2.przesun(1, 1);
            Console.WriteLine(l1.toString());
            Trojkat t1 = new Trojkat(l1, l2, l3);
            t1.przesun(10, 10);

            Czworokat cz1 = new Czworokat(l1, l2, l3, l4);
            cz1.przesun(20, 21);

            Obraz obraz = new Obraz();
            obraz.dodajCzworokat(cz1);

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(t1);
            Console.WriteLine(cz1);

            Console.WriteLine(l1.toString());
            Console.WriteLine(l2.toString());
            Console.WriteLine(t1.toString());
            Console.WriteLine(cz1.toString());

        }
    }
}
