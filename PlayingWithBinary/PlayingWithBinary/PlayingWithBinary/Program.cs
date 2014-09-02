using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlayingWithBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            
            //Display as encoded values
            foreach (byte b in eurekaBytes)
                Console.Write("{0} ", b);
            Console.WriteLine(); 
            
            //Display as hex value
            foreach (byte b in eurekaBytes)
                Console.Write("{0:x2} ", b);
            Console.WriteLine();

            //Display as unicode
            foreach (byte b in eurekaBytes)
                Console.Write("{0:x2} ", b, Encoding.Unicode);
            Console.WriteLine();

            int intValue = 48769414;
            string stringValue = "Hello!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            using (BinaryWriter writer = new BinaryWriter(File.Create("binarydata.dat"))) 
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(byteArray);
                writer.Write(floatValue);
                writer.Write(charValue);
            }

            //Display written data
            byte[] dataWritten = File.ReadAllBytes("binarydata.dat");
            foreach (byte b in dataWritten)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine(" - {0} bytes written", dataWritten.Length);

            //Display data read from file

            int intRead;
            string stringRead;
            byte[] bytesRead;
            float floatRead;
            char charRead;

            using (BinaryReader reader = new BinaryReader(File.OpenRead("binarydata.dat")))
            {
                intRead = reader.ReadInt32();
                stringRead = reader.ReadString();
                bytesRead = reader.ReadBytes(4);
                floatRead = reader.ReadSingle();
                charRead = reader.ReadChar();
            }

            Console.Write("int: {0} string: {1} bytes: ", intRead, stringRead);
            foreach (byte b in bytesRead)
                Console.Write("{0} ", b);
            Console.Write(" float: {0} char: {1} ", floatRead, charRead);

            Console.ReadKey();
        }
    }
}
