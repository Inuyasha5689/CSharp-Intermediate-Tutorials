using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
////            Text text = new Text();
////            Shape shape = text;
////
////            text.Width = 200;
////            shape.Width = 100;
////
////            Console.WriteLine(text.Width);
//
////            StreamReader reader = new StreamReader(new MemoryStream());
//            ArrayList list = new ArrayList();
//            list.Add(1);
//            list.Add("Drake");
//            list.Add(new Text());
//
//            var anotherList = new List<Shape>();

            Shape shape = new Text();
            Text text = (Text) shape;
            

        }
        
        
    }
}
