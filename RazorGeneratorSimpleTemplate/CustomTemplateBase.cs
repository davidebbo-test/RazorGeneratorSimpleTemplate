using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorGenerator.Templating;

namespace RazorGeneratorSimpleTemplate
{
    public class CustomTemplateBase : RazorTemplateBase
    {
        public string Message { get; set; }
        public CustomTemplateBase(string message)
        {
            Message = message;
        }
    }
}
