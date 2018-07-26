using System;

namespace lecturatxt
{
    class Program
    {
        static void Main()
        {
            //Inicializar la variable que realiza la lectura del archivo de texto
            var myreader = new System.IO.StreamReader("valores.txt");

            var line="";
            while (line!=null)
                //Ciclo para recorrer el archivo hasta el final del documento
                {
	                line=myreader.ReadLine();
                    if (line!=null)
                    {
                    Console.WriteLine("Informacion Linea leida: " + line.ToString());                    
                }
	    }
            //Cierre de la conexion
            myreader.Close();
            Console.ReadLine();
        }
    }
}
