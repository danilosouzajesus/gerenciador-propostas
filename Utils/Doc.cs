using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gerenciador_propostas.Models;
using Novacode;

namespace gerenciador_propostas.Utils
{
    public class Doc
    {
        private DocX document;
        private Dictionary<String, Table> tables = new Dictionary<string, Table>();

        public DocX createDocument(string fileName) {
            DocX doc = DocX.Create(fileName+".docx");
            return doc;
        }

        public DocX getDocument() {
            return document;
        }

        public void addTable(String name, int rows, int cols) {
            Table t = document.AddTable(rows, cols);
            tables.Add(name, t);
        }

        public Table getTable(String name) {
            return tables[name];
        }

    }
}
