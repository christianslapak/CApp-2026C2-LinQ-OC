using CApp_2026C2_LinQ_OC;

Console.WriteLine("LinQ");

Estudiante[] Estudiantes =
            {
                new Estudiante() {Id = 1, Nombre = "Pedro", Edad = 18},
                new Estudiante() {Id = 2, Nombre = "Ariela", Edad = 14},
                new Estudiante() {Id = 3, Nombre = "Graciela", Edad = 22},
                new Estudiante() {Id = 4, Nombre = "Martina", Edad = 17},
                new Estudiante() {Id = 5, Nombre = "Daniel", Edad = 21},
                new Estudiante() {Id = 6, Nombre = "Marisa", Edad = 15},
                new Estudiante() {Id = 7, Nombre = "Miriam", Edad = 27},
                new Estudiante() {Id = 8, Nombre = "Osvaldo", Edad = 29},
            };

Console.WriteLine("Salida por proceso / filtramos por edad preguntnado con IF/ ");
Estudiante[] Proceso = new Estudiante[8];
int i = 0;

foreach (var itemEstu in Estudiantes)
{
    if (itemEstu.Edad >= 13 && itemEstu.Edad <= 18)
    {
        Proceso[i] = itemEstu;
        i++;
    }
}

for (int x = 0; x < i; x++)
{
    Console.WriteLine("Alumno teen :" + Proceso[x].Nombre + " " + Proceso[x].Edad);
}

Console.ReadKey();


Console.WriteLine("Linq - QE");
var queryE = from estu in Estudiantes  where estu.Edad >= 13 && estu.Edad <= 18 select estu;
foreach (var itemEstu in queryE)
{
    Console.WriteLine("Alumno teen :" + itemEstu.Nombre + " " + itemEstu.Edad);
}

Console.ReadKey();

Console.WriteLine("Linq - LE");
var queryL = Estudiantes.Where(estu => estu.Edad >= 13 && estu.Edad <= 18);
foreach (var itemEstu in queryL)
{
    Console.WriteLine("Alumno teen :" + itemEstu.Nombre + " " + itemEstu.Edad);
}
Console.ReadKey();
