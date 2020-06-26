

namespace appAlcancia
{
    public class Menus
    {
		int varLongitudCadena;
		string[] varVectorOpcionesMenu;
		consola objConsola = new consola();
		public void ImprimirMenu()
		{
			for (int VarContador = 0; VarContador < varLongitudCadena; VarContador++)
			{
				objConsola.EscribirConSalto(varVectorOpcionesMenu[VarContador], 0);
			}
		}
		public void ConfigurarMenuPrincipal()
        {
			int varRespuesta;

			varLongitudCadena = 5;
			varVectorOpcionesMenu = new string[5];
			varVectorOpcionesMenu[0] = "1. Establecer Preferencias de la alcancia";
			varVectorOpcionesMenu[1] = "2. Introducir Moneda";
			varVectorOpcionesMenu[2] = "3. Extraer moneda";
			varVectorOpcionesMenu[3] = "4. Extractos";
			varVectorOpcionesMenu[4] = "5. Salir";
			do
			{
				objConsola.LimpiarPantalla();
				objConsola.ImprimirTextoImportante("appAlcancia - MENU PRINCIPAL");
				ImprimirMenu();
				varRespuesta = objConsola.leerEnteroConLinea("Ingrese un entre valor [1..5] para <Opcion>:=", 0);
				switch (varRespuesta)
				{
					case 1: ConfigurarMenuPreferenciasAlcancia(); break;
					//case 2: informacionIngMoneda(); break;
					//case 3: informacionExtMoneda(); break;
					//case 4: ConfigurarMenuExtractosAlcancia(); break;
					//case 5:
					//	ImprimirTextoImportante("[AVISO]: Ha salido de este Menu");
					//	pausar(); break;
					//default:
					//	objConsola.ImprimirTextoImportante("[AVISO] El Valor digitado no se encuentra entre las opciones disponibles");
					////	pausar();
				}
			} while (varRespuesta > varLongitudCadena || varRespuesta <= 0);
		}
		public void ConfigurarMenuPreferenciasAlcancia()
		{
			int VarRespuesta;
			operaciones objOperaciones = new operaciones();
			varLongitudCadena = 4;
			varVectorOpcionesMenu = new string[4];
			varVectorOpcionesMenu[0] = "1. Establecer Capacidad de monedas y Billetes";
			varVectorOpcionesMenu[1] = "2. Establecer Denominaciones Aceptadas";
			varVectorOpcionesMenu[2] = "3. Ver Preferencias y Estado de la Alcancia";
			varVectorOpcionesMenu[3] = "4. Regresar al Menu Anterior....";

			do
			{
				objConsola.LimpiarPantalla();
				objConsola.ImprimirTextoImportante("[MENU PREFERENCIAS DE ALCANCIA]");
				ImprimirMenu();
				VarRespuesta = objConsola.leerEnteroConLinea("Ingrese un entre valor [1..4] para <Opcion>:=", 0);
				switch (VarRespuesta)
				{
					case 1: objOperaciones.definirTamañoAlcancia(); 
						break;
					case 2: objOperaciones.DefinirDenominacionesAceptadas(); break;
					//case 3: PreferenciasEstadoAlcancia(); break;
					//case 4:
					//	ImprimirTextoImportante("[AVISO] Ha Salido de este Menu");
					//	pausar();
					//	ConfigurarMenuPrincipal();
					//	break;
					//default:
					//	ImprimirTextoImportante("[AVISO] El Valor digitado no se encuentra entre las opciones disponibles");
					//	pausar();
				}
			} while (VarRespuesta > varLongitudCadena || VarRespuesta <= 0);
		}

	}
}