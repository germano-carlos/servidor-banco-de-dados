using System.Collections;

namespace servidor_banco_de_dados;

public class SqlUtil
{
    public void Select<T>(List<string> colunas, List<T> resultados)
    {
        
    }

    public static List<T> From<T>(Dictionary<string, List<string>> filters)
    {
        var objects = typeof(T).GetMethod("ObterLista")?.Invoke(null, null);
        if (objects is null)
            throw new Exception("Table or view does not exists");
        if (filters.Count == 0)
            return (List<T>)objects;

        var attributes = typeof(T).GetFields();
        var columns = filters.Keys.ToList();
        
        foreach (var column in columns)
        {
            foreach (var attribute in attributes)
            {
                if (attribute.Name == column)
                {
                    // Filtra
                }
            }
        }
        
        // Devolve Filtrado
        return (List<T>)objects;
    }

    public void InnerJoin()
    {
        
    }

    public void OrderBy()
    {
        
    }
}