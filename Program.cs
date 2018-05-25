using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Novacode;

namespace gerenciador_propostas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var doc = DocX.Create(@"MyFile.docx");
            var p = doc.InsertParagraph();
            p.Append("Hello World");
            doc.Save();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
