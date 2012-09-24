using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CommandLine
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Written by Sam Contapay");
            Console.Out.WriteLine("This program takes in an argument that is the full path to an MP3 file and prints out the ID tag of the MP3 file.");
            try
            {
                Mp3DisplayTag mp3Display = new Mp3DisplayTag(args[0]);
                Console.Out.WriteLine(mp3Display.DisplayTags());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Out.WriteLine("The first argument can not be empty and must be the full path to the mp3 file. For example: 'c:\\path\\to\\my.mp3'");
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.Out.WriteLine("Unable to find the file designated by the path " + args[0] + ". Please make sure the file exists and try again.");
            }
            catch (TagLib.UnsupportedFormatException e)
            {
                Console.Out.WriteLine("Unsupported file format please make sure it is an MP3 file and try again.");
            }
        }
    }
}
