using System.IO;

var directories = listaArquivosEPastasNoCaminho(@"D:\");

imprime(directories);

void imprime<Tipo>(Tipo[] lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }

}


string[] listaArquivosEPastasNoCaminho (string caminhoParaListar)
{
    var diretoriosNoCaminho = Directory.GetDirectories(caminhoParaListar);
    var arquivosNoCaminho = Directory.GetFiles(caminhoParaListar);
    return Concat(diretoriosNoCaminho, arquivosNoCaminho);
}

Type[] Concat<Type>(Type[] x, Type[] y)
{
    var z = new Type[x.Length + y.Length];
    x.CopyTo(z, 0);
    y.CopyTo(z, x.Length);
    return z;
}