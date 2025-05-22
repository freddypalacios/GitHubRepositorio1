/// <summary>
/// Esta clase crea un diccionario sobre los 17 departamentos de nicaragua con su población
/// </summary>
/// <remarks>
/// Los datos hace referencia al año 2005
/// </remarks>
public class Diccionario
{
    private Dictionary<string, int> diccionario;
    public Dictionary<string, int> ColectDiccionario
    {
        get { return diccionario; }
        set { diccionario = value; }
    }
    /// <summary>
    /// Este constructor inicializa el atributo diccionario de la clase 
    /// </summary>
    /// <param name="Departamento">Es la clave del diccionario</param>
    /// <param name="Poblacion">Es el valor del deccionario</param>
    public Diccionario(string[] Departamento, int[] Poblacion)
    {
        diccionario = Departamento
.Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
.ToDictionary(x => x.Clave, x => x.Valor);
    }
    /// <summary>
    /// Este método se encarga de:
    /// ordenar
    /// Encontrar el mayor y el menor deparmento
    /// y lo muestra en pantalla 
    /// </summary>
    /// <param name="Departamento"> deparmentos ordenado por poblacion</param>
    /// <param name="Poblacion">Clave de ordenamiento</param>
    /// /// <remarks>
    /// Este metodo tambien suma toda las poblaciones
    /// </remarks>

    public void Operaciones(string[] Departamento, int[] Poblacion)
    {
        //Ordenando el diccionario de menor a mayor
        var ordenado = diccionario.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        //fijando los nombres de los departamen tos con menor y mayor poblacion
        string minDepkey = ordenado.First().Key;
        string maxDepkey = ordenado.Last().Key;
        //reasignación de los arreglos en paralelo ya ordenados
        Departamento = ordenado.Keys.ToArray();
        Poblacion = ordenado.Values.ToArray();
        //Mostrar los arreglos ordenados de menor a mayor.
        for (var i = 0; i < Poblacion.Length; i++)
            Console.WriteLine($"{Departamento[i],20} ==> {Poblacion[i],10:N0}");
        //Suma de toda la población y nombre de mayor y menor  con el diccionario 
        Console.WriteLine($" Población General:{Poblacion.Sum():N0}");
        Console.WriteLine($"Mayor Población:{maxDepkey}");
        Console.WriteLine($"Menor Población:{minDepkey}");
    }
}