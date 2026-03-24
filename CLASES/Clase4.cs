using System;

List<string> estudiantes = new List<string> ();
estudiantes = new
List<string> ();
estudiantes.Add("Ana");
estudiantes.Add("Luis");
estudiantes.Add("Maria");
        
foreach (string estudiante in estudiantes)
{
    Console.WriteLine(estudiante);
}

HashSet<string> correos = new HashSet<string>();
correos.Add("Ana@email.com");
correos.Add("Luis@email.com");
correos.Add("Ana@email.com");

foreach (string correo in correos)
{
    Console.WriteLine(correo);
}