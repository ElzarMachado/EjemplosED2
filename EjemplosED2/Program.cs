//string nombre = "Coca";
//Console.WriteLine(nombre.Length);

//if (string.IsNullOrWhiteSpace(nombre))
//{
//    Console.WriteLine("string vacio");
//}
//else
//{
//    Console.WriteLine(nombre);
//}

//int numero = 9;
//string numeroConCeros = "9";
// numeroConCeros = numeroConCeros.PadLeft(3, '0');
//Console.WriteLine(numeroConCeros);

//string nombre = "Elzar";
//string apellido = "Machado";
//int edad = 20;

//string NombreYedad =  nombre + | apellido + | edad;
//Console.WriteLine(NombreYedad);

//String NombreYedad = string.Format("{0}, {1}, {2}"), nombre, apellido, edad);
//Console.WriteLine(NombreYedad);

//string NombreYedad = $"{nombre} | {apellido} | {edad}";
//    Console.WriteLine(NombreYedad);

//Investigar concat

//string numeroString = "5 x";
//// ((((int numeroInt = Convert.ToInt32(numeroString);))))

//int numeroInt = 0;
//bool pudo = int.TryParse(numeroString, out numeroInt);
//Console.WriteLine(pudo);

string cadena = "Hola mundo Jose";
string [] text = cadena.Split('|', ' ', )ToList();
foreach(string s in text)
{
    Console.WriteLine(s);
}
//Console.WriteLine(cadena.IndexOf(" "));