using System;

namespace lecturatxt
{
    class Program
    {
        static void Main()
        {
            var myreader = new System.IO.StreamReader("valores.txt");
            var line="";
            while (line!=null)
                {
	                line=myreader.ReadLine();
                    if (line!=null)
                    {
                        Console.WriteLine(line)	 ;
                    }
	    }
            myreader.Close();
            Console.ReadLine();
        }
    }
}
