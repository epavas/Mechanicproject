using MongoDB.Bson;

using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Descripción breve de Mongodb
/// </summary>
public class Mongodb
{
    public Mongodb()
    {

    }
    public IMongoDatabase connect()
    {
        String uri = "mongodb://admin:admin123@ds115446.mlab.com:15446/mechanic";
        var client = new MongoClient(uri);
        return client.GetDatabase("mechanic");
    }
    public void insert(String colleccion, BsonDocument documento)
    {
        /*var db = connect().GetDatabase("unilink");*/
        var col = connect().GetCollection<BsonDocument>(colleccion);
        col.InsertOne(documento);
    }
    public string find(String colleccion, String campo, String valor)
    {
        var col = connect().GetCollection<BsonDocument>(colleccion);
        BsonDocument buscar = new BsonDocument { { campo, valor } };
        var document = col.Find(buscar).FirstOrDefault();
        if (document == null)
        {
            return "null";
        }
        String resul = document.ToString();
        return resul;
    }
    public string[] login(String collecion, String campo, String correo, String contraseña)
    {
        String[] val;
        String resultado = find(collecion, campo, correo);
        if (resultado == "null")
        {
            val = new String[] { "null" };
        }
        else
        {
            for (int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    resultado = resultado.Replace("{", "");
                }
                else
                {
                    resultado = resultado.Replace("}", "");
                }
            }
            return resultado.Split(',');

        }
        return val;
    }
    public string[] ofertas(String collecion, String campo, String valor)
    {
        String[] val;
        List<String> documentos = new List<String>();
        var col = connect().GetCollection<BsonDocument>(collecion);
        BsonDocument buscar = new BsonDocument { { campo, valor } };
        var cursor = col.Find(buscar).ToCursor();
        foreach (var document in cursor.ToEnumerable())
        {
            if (document == null)
            {
                return val = new String[] { "null" };
            }
            else
            {
                String resultado = document.ToString();
                for (int i = 0; i <= 1; i++)
                {
                    if (i == 0)
                    {
                        resultado = resultado.Replace("{", "");
                    }
                    else
                    {
                        resultado = resultado.Replace("}", "");
                    }
                }
                documentos.Add(resultado);
            }
        }
        return documentos.ToArray();
    }
    public string[] trabajos(String collecion, String campo, String valor)
    {
        String[] val;
        List<String> documentos = new List<String>();
        var col = connect().GetCollection<BsonDocument>(collecion);
        BsonDocument buscar = new BsonDocument { { campo, valor } };
        var cursor = col.Find(buscar).ToCursor();
        foreach (var document in cursor.ToEnumerable())
        {
            if (document == null)
            {
                return val = new String[] { "null" };
            }
            else
            {
                String resultado = document.ToString();
                for (int i = 0; i <= 1; i++)
                {
                    if (i == 0)
                    {
                        resultado = resultado.Replace("{", "");
                    }
                    else
                    {
                        resultado = resultado.Replace("}", "");
                    }
                }
                documentos.Add(resultado);
            }
        }
        return documentos.ToArray();
    }

    public string[] amigos(String collecion, String campo, String valor)
    {
        String[] val;
        List<String> documentos = new List<String>();
        var col = connect().GetCollection<BsonDocument>(collecion);
        BsonDocument buscar = new BsonDocument { { campo, valor } };
        var cursor = col.Find(buscar).ToCursor();
        foreach (var document in cursor.ToEnumerable())
        {
            if (document == null)
            {
                return val = new String[] { "null" };
            }
            else
            {
                String resultado = document.ToString();
                for (int i = 0; i <= 1; i++)
                {
                    if (i == 0)
                    {
                        resultado = resultado.Replace("{", "");
                    }
                    else
                    {
                        resultado = resultado.Replace("}", "");
                    }
                }
                documentos.Add(resultado);
            }
        }
        return documentos.ToArray();
    }
}
