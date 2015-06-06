using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGeneratorSimpleTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = new SampleTemplate { Message = "David", Max = 10 };
            Console.WriteLine(template.TransformText());

            Console.WriteLine("-------------");

            var template2 = new SampleTemplateWithBase { Max = 10 };
            Console.WriteLine(template2.TransformText());
        }
    }
}
