using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // currently there is file sample.txt in \bin\debug
                //renamed here to create exception
                StreamReader myStreamReader = new StreamReader(@"sample1.txt");
                string line = "";
                while (line != null)
                {
                    line = myStreamReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }
                myStreamReader.Close();
            }
            catch (DirectoryNotFoundException de)
            {
                Console.WriteLine("Couldn't find the file, are u sure directory exists");
            }
            catch (FileNotFoundException fe)
            {
                // here in this case it will come here and go to finally , at a time only one catch is executed
                Console.WriteLine("Couldn't find the file, are u sure you're looking for the correct file ");
            }
            catch (Exception unExpectedException)
            {
                Console.WriteLine("unExpectedException happened");

            }

            finally {
                
            // perform any cleanup or close the connections 
            }

            Console.ReadLine();

        }
    }
}
