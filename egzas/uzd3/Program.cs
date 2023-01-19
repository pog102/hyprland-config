using System.IO;
using System.Text;
namespace egazas
{
    class Program
    {
	static void Main(string[] args)
	{
	    fr.WriteLine();
	    int savaite, diena;
	    Asmuo a;
	    DienaMaxIslaidos(seimosIslaidos, out savaite, out diena);
	    fr.Write("Daugiausia išleista {0} sav. {1} dieną.", savaite, diena);
	    a = seimosIslaidos.ImtiReiksme(savaite - 1, diena - 1);
	    fr.WriteLine(" Pinigus išleido {0}: {1,5:c2}.", a.ImtiVarda(),
		    a.ImtiPinigus());
	}

	static void IslaidosSavaitemis(Matrica A, double [] Islaidos)
	{
	    for (int i = 0; i < A.n; i++)
	    {
		double suma = 0;
		for (int j = 0; j < A.m; j++)
		{
		    Asmuo x = A.ImtiReiksme(i, j);
		    suma = suma + x.ImtiPinigus();
		}
		Islaidos[i] = suma;
	    }
	}
	static decimal IslaidosSavaitesDienaX(Matrica A, int nr)
	{
	    double suma = 0;
	    for (int i = 0; i < A.n; i++)
	    {
		Asmuo x = A.ImtiReiksme(i, nr-1);
		suma = suma + x.ImtiPinigus();
	    }
	    return (decimal)suma;
	}
	static void DienaMaxIslaidos(Matrica A, out int eilNr, out int stNr)
	{
	    eilNr = -1;
	    stNr = -1;
	    double max = 0;
	    for (int i = 0; i < A.n; i++)
	    {
		for (int j = 0; j < A.m; j++)
		{
		    double x = A.ImtiReiksme(i, j).ImtiPinigus();
		    if (x > max)
		    {
			max = x;
			eilNr = i + 1;
			stNr = j + 1;
		    }
		}
	    }
	}
    }
}
