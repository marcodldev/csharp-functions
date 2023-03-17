
int[] arrayEs = { 2, 6, 7, 5, 3, 9 };

// Func Array
string StampaArray(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

//Func Quadrato

int Quadrato(int num2)
{
    int num1 = num2*num2;

    return num1 ;
}


//Func Array al quadrato
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayAlQuadrato = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayAlQuadrato[i] = array[i] * array[i];
    }

    return arrayAlQuadrato;
}

// Func Somma elementi di un array

int sommaElementiArray(int[] array)
{

    int somma = 0;

    foreach (int elemento in array)
    {
        somma += elemento;
    }

    return somma;

}

/*int sommaElementiArray(int[] array) *: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
 * 
 * 
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice,
    si vogliono utilizzare le funzioni per:
-Stampare l’array di numeri fornito a video
- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato
modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
-Stampare la somma di tutti i numeri
- Stampare la somma di tutti i numeri elevati al quadrati */


Console.WriteLine( $"il nostro array: {StampaArray(arrayEs)} ");

int[] ArrayalQuadrato = ElevaArrayAlQuadrato(arrayEs);

Console.WriteLine($"il nostro array stampato al quadrato: {StampaArray(ArrayalQuadrato)} , l'array originale: {StampaArray(arrayEs)}");

Console.WriteLine($"La somma degli elementi dell'array: {sommaElementiArray(arrayEs)} ");

Console.WriteLine($"il nostro array stampato al quadrato: {StampaArray(ArrayalQuadrato)} , la somma dei numeri: {sommaElementiArray(ArrayalQuadrato)}");