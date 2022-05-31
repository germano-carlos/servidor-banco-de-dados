// See https://aka.ms/new-console-template for more information

using System.Collections;
using servidor_banco_de_dados;

Console.WriteLine("Hello, World!");

var x = SqlUtil.From<Filme>(new Dictionary<string, List<string>>());

var Z = "";