using EjercicioGato;
using EjercicioGato.Razas;

internal class Program
{
    private static void Main(string[] args)
    {
           Siames gatoSi= new Siames();
        gatoSi.Nombre="Snow";
        gatoSi.Tamaño="G";
        gatoSi.Peso=7;
        gatoSi.color="Blanco";

        gatoSi.Comer();
        gatoSi.Jugar();
        gatoSi.Correr();

    Egipcio gatoEgipcio = new Egipcio();
    gatoEgipcio.Nombre="Rufus";
    gatoEgipcio.Tamaño="M";
    gatoEgipcio.Peso=6;
    gatoEgipcio.color="Gris";

    gatoEgipcio.Correr();

    Persa gatoPersa= new Persa();
    gatoPersa.Nombre="Kitty";
    gatoPersa.Tamaño = "M";
    gatoPersa.Peso=5;
    gatoPersa.color="Gris";
    
    gatoPersa.Correr();

    Abisinio gatoAbis= new Abisinio();
    gatoAbis.Nombre="Michi";
    gatoAbis.Tamaño="M";
    gatoAbis.Peso=6;
    gatoAbis.color="Café";
    
    gatoAbis.Correr();

    MostrarHijos(gatoSi);
    MostrarHijos(gatoEgipcio);
    MostrarHijos(gatoPersa);
    MostrarHijos(gatoAbis);

    BuscarPresa(gatoSi);
    BuscarPresa(gatoEgipcio);
    BuscarPresa(gatoPersa);
    BuscarPresa(gatoAbis);

    }
public static void MostrarHijos(IMamifero m)
{
    m.TenerHijo();
}

public static void BuscarPresa(IMamifero m)
{
    m.BuscarPresa();
}
}

/*
SIAMES 
EGIPCIO
PERSA
*/
