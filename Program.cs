using System;
class ArrayExample
{
    static void Main()
    {
        //define un array de caracteres llamado letters
        //se reserva memoria para los elementos de tipo char
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        //le da el espacio suficiente para poder mostrar el mensaje que queremos
        int[] a = new int[10];
        //bucle que se encarga de mostrar las letras 1 a 1 hasta que se completen todos los array de caracteres
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        //muestra por pantalla el mensaje que se especifica en la siguiente linea y va cambiando los valores name y msg, ya que son varibles
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
