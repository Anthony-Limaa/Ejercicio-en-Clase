using System.Globalization;
using System.Security.Cryptography;

static void Adivina()
{
    const int oportunidades = 4;
    int numerocpu, numerousuario;
    byte intentos, banderacontrol;
    string linea;

    Random rand = new Random();

    do
    {
        numerocpu = Convert.ToInt32(rand.Next(1, 20));
    } while (!(((numerocpu >= 1) & (numerocpu <= 20))));
    //Proceso.

    intentos = 1;
    banderacontrol = 0;
    do
    {
        Console.WriteLine("Hola, estoy pensando en un número, cual crees que es?");
        numerousuario = int.Parse(Console.ReadLine());

        if ((numerousuario == numerocpu))
        {
            Console.WriteLine("Yes! Adivinaste!");
            banderacontrol = 1;
        }
        else
        {
            if (numerousuario > numerocpu)
            {
                Console.WriteLine("El número ingresado es mayor al que estoy pensando.");
            }
            else
            {
                Console.WriteLine("El número ingresado es menor al que estoy pensando");
            }
        }
        intentos++;

    } while (((intentos <= oportunidades) & (banderacontrol == 0)));

    if (banderacontrol == 0)
    {
        Console.WriteLine("El número que pensé era: " + numerocpu);
    }
}

static void buscamayor()
{
    int mayor = 0;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; 1 < 5; i++)
    {
        numero = rand.Next(100);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        } 
    }
    Console.WriteLine("El número mayor es: " + mayor);
}

static void arreglos()
{
    int[] notas = new int[15];
    Random rnd = new Random();
    Console.WriteLine("Cargando información");

    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }
    Console.WriteLine("Desplegando información");
    int mayor = 0;
    float promedio = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
        if (notas[i] > mayor)
        {
            mayor = notas[i];

        }
        promedio += notas[i];
        promedio /= notas.Length;
        Console.WriteLine("La nota mayor es: " + mayor);
        Console.WriteLine("El promedio es de: " + promedio);
    }
}
    static void nombres()
    {
        String[] nombre = new string[10];
        nombre[0] = "Jairo";
        nombre[1] = "Brandom";
        nombre[2] = "Hector";
        nombre[3] = "Yeimi";
        nombre[4] = "Fatima";
        nombre[5] = "Carlos";
        nombre[6] = "Anthony";
        nombre[7] = "Juan";
        nombre[8] = "Steven";
        nombre[9] = "German";
    Random rnd = new Random();
    int iganador1 = rnd.Next(0, 10);
    int iganador2 = rnd.Next(0, 10);

    while (iganador2 == iganador1)
    {
        iganador2 = rnd.Next(0, 10);
    }

    string ganador1 = nombre[iganador1];
    string ganador2 = nombre[iganador2];

    Console.WriteLine("El primer ganador es: " + ganador1);
    Console.WriteLine("El segundo ganador es: " + ganador2);
    }

    nombres();
//arreglos();
//buscamayor();
//Adivina();