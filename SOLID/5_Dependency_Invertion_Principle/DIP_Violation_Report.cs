using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_Dependency_Invertion_Principle
{
    public class PdfReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating PDF file..");
        }
    }

    public class Report
    {
        private PdfReport _pdfReport;
        public Report() {
        this._pdfReport = new PdfReport(); // tightly coupled to PdfReport Class
        }

        public void GenerateReport()
        {
            _pdfReport.Generate();
        }
    }
}
