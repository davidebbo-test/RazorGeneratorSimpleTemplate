﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RazorGeneratorSimpleTemplate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class SampleTemplate : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 3 "..\..\SampleTemplate.cshtml"

    public int Max { get; set; }
    public string Message { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n\r\n");


WriteLiteral("\r\n\r\n\r\n<ul>\r\n");


            
            #line 10 "..\..\SampleTemplate.cshtml"
 for (int i = 0; i < Max; i++)
{

            
            #line default
            #line hidden
WriteLiteral("    <li>Hello ");


            
            #line 12 "..\..\SampleTemplate.cshtml"
         Write(Message);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 12 "..\..\SampleTemplate.cshtml"
                  Write(i);

            
            #line default
            #line hidden
WriteLiteral("!</li>  \r\n");


            
            #line 13 "..\..\SampleTemplate.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</ul>");


        }
    }
}
#pragma warning restore 1591
