using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{

    //object[] tablica = new object[9];
    //var kolo = new Kolo();

    //int i = 0;
    //var enumerator = tab;
    //while(tab[i]<10){
    //    tab.ToString();
    //    int i++;

    //List<FiguraGeometryczna> lista = new List<FiguraGeometryczna>();

    public class Program1 {
        static void main(String[] args) {
            List<FiguraGeometryczna> lista = new List<FiguraGeometryczna>();

            lista.Add(new Kwadrat(4));

            foreach (var list in lista) {
                Console.WriteLine(list.ToString());
            }
        }
        
    }
    
}
