using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public abstract class FiguraGeometryczna{
        public abstract int ObliczPole();

        public FiguraGeometryczna() {
        
        }
    }

    public abstract class FiguraPlaska : FiguraGeometryczna {
        public abstract int ObliczObwod();

        public override string ToString() {
            return "Obliczanie parametrów figury płaskiej. ";
        }

        public FiguraPlaska() {
        
        }
    }

    public abstract class FiguraPrzestrzenna : FiguraGeometryczna {
        public abstract int ObliczObjetosc();

        public override string ToString()
        {
            return "Obliczanie parametrów figury przestrzennej. ";
        }
    }

    public class Kwadrat : FiguraPlaska {
        private int bokA { get; set; }

        public int BokA
        {
            get => bokA;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokA = value;
            }
        }

        public Kwadrat(int bokA) {
            bokA = BokA;
        }

        public Kwadrat() {}

        public override int ObliczObwod()
        {
            return 4 * bokA;
        }

        public override int ObliczPole()
        {
            return bokA * bokA;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Kwadrat"+"\n"+
                "Bok A=" + bokA + "\n" +
                "Pole=" + ObliczPole() + "\n" +
                "Obwod=" + ObliczObwod() + "\n\n";
        }
    }

    public class Prostokat : FiguraPlaska
    {
        private int bokA;
        private int bokB;

        public Prostokat(int bokA, int bokB)
        {
            bokA = BokA;
            bokB = BokB;
        }

        public int BokA
        {
            get => bokA;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokA = value;
            }
        }
        public int BokB
        {
            get => bokB;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokB = value;
            }
        }

        public override int ObliczObwod()
        {
            return 2 * bokA + 2 * bokB;
        }

        public override int ObliczPole()
        {
            return bokA * bokB;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Prostokąt" + "\n" +
                "Bok A=" + BokA + "\n" +
                "Bok B=" + BokB + "\n" +
                "Pole=" + ObliczPole() + "\n" +
                "Obwod=" + ObliczObwod() + "\n\n";
        }
    }

    public class Trojkat : FiguraPlaska
    {
        private int bokA;
        private int h;

        public int BokA {
            get => bokA;
            set {
                if(value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokA = value;
            }
        }

        public int H {
            get=> h;
            set {
                if(value<0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                h = value;
            }
        }
        public Trojkat() { }
        public Trojkat(int bokA, int h) {
            bokA = BokA;
            h = H;
        }

        public override int ObliczObwod()
        {
            return 3 * BokA;
        }

        public override int ObliczPole()
        {
            return 1 / 2 * BokA * H;
        }

        public override string ToString()
        {
            return base.ToString()+"\n"+
                "Trójkąt" + "\n" +
                "Bok A=" + BokA + "\n"+
                "Pole="+ObliczPole()+"\n"+
                "Objętość=" + ObliczObwod()+"\n\n";
        }
    }
    public class Trapez : FiguraPlaska
    {
        private int a;
        private int b;
        private int ramiona;
        private int h;

        public int A {
            get => a;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                a = value;
            }
        }

        public int B {
            get => b;
            set {
                if(value<0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                b = value;
            }
        }

        public int Ramiona {
            get => ramiona;
            set {
                if(value<0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                ramiona = value;
            }
        }

        public int H {
            get => h;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                h = value;
            }
        }

        public override int ObliczPole()
        {
            return ((a + b) * h) / 2;
        }

        public override int ObliczObwod()
        {
            return a + b + ramiona;
        }

        public override string ToString()
        {
            return base.ToString()+
                "Trazpez" + "\n" +
                "Bok A: " +a+"\n"+
                "Bok B: "+b+"\n"+
                "Ramiona: "+ramiona+"\n"+
                "Wysokość: "+h+"\n"+
                "Obwód= "+ObliczObwod()+"\n"+
                "Pole="+ObliczPole()+"\n\n";
        }
    }
    public class Rownoleglobok : FiguraPlaska
    {
        private int a;
        private int b;
        private int h;

        public int A {
            get => a;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                a = value;
            }
        }

        public int B {
            get => b;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                b = value;
            }
        }

        public int H {
            get => H;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                h = value;
            }
        }

        public override int ObliczObwod()
        {
            return 2 * a + 2 * b;
        }

        public override int ObliczPole()
        {
            return a * h;
        }

        public override string ToString()
        {
            return base.ToString()+
                "Równoległobok" + "\n" +
                "Bok a: " +a+"\n"+
                "Bok b: "+b+"\n"+
                "Wysokość: "+h+"\n"+
                "Pole: "+ObliczPole()+"\n"+
                "Obwód: "+ObliczObwod()+"\n\n";
        }
    }
    public class Romb : FiguraPlaska
    {
        private int a;
        private int b;
        private int h;

        public int A {
            get => a;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                a = value;
            }
        }

        public int B {
            get => b;
            set {
                if(value<b)
                    throw new ArgumentOutOfRangeException(nameof(value));
                b = value;
            }
        }

        public int H {
            get => h;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                h = value;
            }
        }

        public override int ObliczObwod()
        {
            return 2*a + 2*b;
        }

        public override int ObliczPole()
        {
            return a * h;
        }

        public override string ToString()
        {
            return base.ToString()+
                "Romb" + "\n" +
                "Bok a" +a+"\n"+
                "Bok b"+b+"\n"+
                "Wysokość"+h+"\n"+
                "Pole: "+ObliczPole()+"\n"
                +"Obwód: "+ObliczObwod()+"\n\n";
        }
    }

    public class Kolo : FiguraPlaska
    {
        private int r;

        public int R {
            get => r;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                r = value;
            }
        }

        public override int ObliczObwod()
        {
            return (int)(2 *Math.PI*r);
        }

        public override int ObliczPole()
        {
            return (int)(Math.PI*Math.Pow(r,2));
        }

        public override string ToString()
        {
            return base.ToString()+
                "Koło" + "\n" +
                "Promień" +r+"\n"+
                "Pole: "+ObliczPole()+"\n"
                +"Obwód: "+ObliczObwod()+"\n\n";
        }
    }

    public class Szescian : FiguraPrzestrzenna
    {
        private int bokA;

        public int BokA
        {
            get => bokA;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokA = value;
            }
        }

        public override int ObliczObjetosc()
        {
            return bokA * bokA * bokA;
        }

        public override int ObliczPole()
        {
            return 6 * bokA * bokA;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Sześcian" + "\n" +
                "Bok A=" + BokA + "\n" +
                "Pole=" + ObliczPole() + "\n" +
                "Objętość=" + ObliczObjetosc() + "\n\n";
        }

        public Szescian() { }
        public Szescian(int bokA) {
            bokA = BokA;
        }
    }

    public class Prostopadloscian : FiguraPrzestrzenna {
        private int bokA;
        private int bokB;
        private int wysokosc;

        public int BokA
        {
            get => bokA;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokA = value;
            }
        }
        public int BokB
        {
            get => bokB;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                bokB = value;
            }
        }

        public int Wysokosc
        {
            get => wysokosc;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                wysokosc = value;
            }
        }

        public override int ObliczObjetosc()
        {
            return BokA * BokB * Wysokosc;
        }

        public override int ObliczPole()
        {
            return BokA * BokB * 2 + BokA * Wysokosc * 2 + BokB * Wysokosc * 2;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Prostopadłościan" + "\n" +
                "Bok A=" + BokA + "\n" +
                "Bok B=" + BokB + "\n" +
                "Bok Wysokość=" + Wysokosc + "\n" +
                "Pole=" + ObliczPole() + "\n" +
                "Objętość=" + ObliczObjetosc() + "\n\n";
        }

        public Prostopadloscian() {
            
        }

        public Prostopadloscian(int a, int b, int c) {
            bokA = BokA;
            bokB = BokB;
            wysokosc = Wysokosc;
        }
    }

    public class Kula : FiguraPrzestrzenna {
        private int r;

        public int R {
            get => r;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                r = value;
            }
        }

        public override int ObliczPole()
        {
            return (int)(4 * Math.PI*r);
        }

        public override int ObliczObjetosc()
        {
            return (int)(4 /3* Math.PI*Math.Pow(r,3));
        }

        public override string ToString()
        {
            return base.ToString()+
                "Kula" + "\n" +
                "Promień" +r+"\n"+
                "Pole: "+ObliczPole()+"\n"+
                "Obwód: "+ObliczObjetosc()+"\n\n";
        }
    }

    public class Walec : FiguraPrzestrzenna
    {
        private int r;
        private int h;

        public int R {
            get => r;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                r = value;
            }
        }

        public int H {
            get => h;
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                h = value;
            }
        }

        public override int ObliczObjetosc()
        {
            return (int)(Math.PI*Math.Pow(r,2)*h);
        }

        public override int ObliczPole()
        {
            return (int)(2 * Math.PI * Math.Pow(r, 2) + 2 * Math.PI * r * h);
        }

        public override string ToString()
        {
            return base.ToString()+
                "Walec" + "\n" +
                "Promień" +r+"\n"+
                "Wysokość"+h+"\n"+
                "Pole: "+ObliczPole()+"\n"+
                "Objętość"+ObliczObjetosc()+"\n\n";
        }
    }

    public class Stozek : FiguraPrzestrzenna {
        private int r;
        private int h;
        private int l;

        public int R {
            get => r;
            private set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                r = (int)value;
            }
        }

        public int H {
            get => h;
            private set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                h = (int)value;
            }
        }

        public int L {
            get => l;
            private set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                l = (int)value;
            }
        }

        public override int ObliczObjetosc()
        {
            return (int)(1 /3*Math.PI*Math.Pow(r, 2)*h);
        }

        public override int ObliczPole()
        {
            return (int)(Math.PI * Math.Pow(r,2)* Math.PI * r * l);
        }

        public override string ToString()
        {
            return base.ToString()+
                "Stożek" + "\n" +
                "Promień: " +r+"\n"+
                "Długość boku: "+l+"\n"+
                "Wysokość: "+h+"\n"+
                "Pole: "+ObliczPole()+"\n"+
                "Objętość: "+ObliczObjetosc()+"\n";
        }
    }
}
