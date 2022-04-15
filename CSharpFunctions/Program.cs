//Funzioni

int[] array = { 2, 6, 7, 5, 3, 9};

void StampaArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {

        if (i != array.Length-1)
        {
            Console.Write(array[i]);
            Console.Write(" , ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine(" ] ");
}


int Quadrato(int numero)
{
    return numero * numero;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQudarato = (int[])array.Clone();

    for (int i = 0; i < arrayQudarato.Length; i++)
    {
        arrayQudarato[i] = Quadrato(arrayQudarato[i]);
    }
    return arrayQudarato;
}


int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
        somma = somma + array[i];
    return somma;
}


void stampa(int[] array)
{
    Console.WriteLine("Stampo array: ");
    StampaArray(array);
    Console.WriteLine("Stampo array con gli elementi elevati al quadrato: ");
    StampaArray(ElevaArrayAlQuadrato(array));
    Console.WriteLine("Controllo che l'array sia rimasto incontaminato:");
    StampaArray(array);
    Console.WriteLine("Stampo la somma degli elementi nel array: ");
    Console.WriteLine(sommaElementiArray(array));
    Console.WriteLine("Stampo la somma degli elementi nel array che è stato elevato al quadrato: ");
    Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(array)));
}

stampa(array);


//BONUS
Console.WriteLine("------------Bonus-----------");

Console.WriteLine("Ciao, di che dimensione vuoi l'array: ");
Console.WriteLine("Perfetto, ora inserisci uno ad uno i numeri per popolare questo array");

int[] creaArrayInput(int dimensione)
{
    int[] array = new int[dimensione];
    for (int i = 0; i < dimensione; i++)
    {
        array[i] = Int32.Parse(Console.ReadLine());
    }
    return array;
}

int input = Int32.Parse(Console.ReadLine());
int[] arrayInput = creaArrayInput(input);

stampa(arrayInput);