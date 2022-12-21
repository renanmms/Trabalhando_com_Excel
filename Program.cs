// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;

Console.WriteLine($"Match Words");

var filePath = FileSystem.GetFileInfo("Simulacao_tabelas_do_banco.xlsx");
var existingFile = new FileInfo(filePath.ToString());

using(var package = new ExcelPackage(existingFile)){
        
}


class Tabela {
    public List<string>? Colunas;
}


