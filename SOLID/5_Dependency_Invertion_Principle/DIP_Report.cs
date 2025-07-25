using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_Dependency_Invertion_Principle
{

    public interface IReportGenerator
    {
        void Generate();
    }
    public class DIP_Report
    {
        private readonly IReportGenerator reportGenerator;

        public DIP_Report(IReportGenerator reportGenerator) { // Report now depends on the interface rather than dependency
            this.reportGenerator = reportGenerator;
        }

        public void GenerateReport()
        {
            reportGenerator.Generate();
        }
    }

    public class pdfReport : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("PDF report generated");
        }
    }

    public class wordReport : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Word report generated");
        }
    }

    public class CrystalReport : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Crystal report generated");
        }
    }
}
