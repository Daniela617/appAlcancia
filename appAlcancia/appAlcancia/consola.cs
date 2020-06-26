using System;


namespace appAlcancia
{
    public class consola
    {
		public void Escribir(string PrmTexto, float PrmEntero)
		{
			Console.WriteLine(PrmTexto, PrmEntero);
		}
		public void EscribirConSalto(string PrmTexto, float PrmEntero)
		{
			Escribir(PrmTexto, PrmEntero);
			//Escribir("\n", 0);
		}
		public void ImprimirTextoImportante(string PrmTexto)
		{
			EscribirConSalto("***********************************************************************", 0);
			EscribirConSalto(PrmTexto, 0);
			EscribirConSalto("***********************************************************************", 0);
		}
		public int leerEnteroConLinea(string PrmTexto, float PrmEntero)
		{
			EscribirConSalto("************************************************************************", 0);
			Escribir(PrmTexto, PrmEntero);
			int varResultado = int.Parse(Console.ReadLine());
			return varResultado;
		}
		public int LeerEnteroSinLinea(string PrmTexto, float PrmEntero)
		{
			Escribir(PrmTexto, PrmEntero);
			int varResultado = int.Parse(Console.ReadLine());
			return varResultado;
		}
		public int LeerEnteroSinLineaCon(string PrmTexto, float PrmEntero)
		{
			Escribir(PrmTexto, PrmEntero);
			int varResultado = int.Parse(Console.ReadLine());
			return varResultado;
		}
		public string LeerCaracterCon(string PrmTexto, float PrmEntero)
		{
			Escribir(PrmTexto, PrmEntero);
			string varCaracter = Console.ReadLine();
			return varCaracter;
		}
		public void pausar()
		{
			ConsoleKeyInfo cki;
			cki = Console.ReadKey();
		}
		public void LimpiarPantalla()
		{
			Console.Clear();
		}
	}
}
