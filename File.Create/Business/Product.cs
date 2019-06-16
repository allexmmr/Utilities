using File.Create.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace File.Create.Business
{
    public class Product : IProduct
    {
        #region Properties

        public double Size1 { get; set; }

        public double Size2 { get; set; }

        public string Printer { get; set; }

        public string Paper { get; set; }

        #endregion

        #region Enum

        private enum PrinterEnum
        {
            Canon_1,
            Canon_2,
            Chromira,
            Lambda,
            Noritsu
        }

        private enum PaperEnum
        {
            Canvas,
            Gloss,
            Matt,
            Metallic,
            Rough,
            Smooth
        }

        #endregion

        public List<Product> List()
        {
            #region Product list

            return new List<Product>
            {
                new Product { Size1 =  40, Size2 =   40, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  40, Size2 =   60, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  50, Size2 =   50, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  60, Size2 =   60, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  60, Size2 =   90, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  80, Size2 =   80, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  80, Size2 =  120, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  90, Size2 =   90, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 =  90, Size2 =  135, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 = 100, Size2 =  100, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },
                new Product { Size1 = 100, Size2 =  150, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Gloss.ToString() },

                new Product { Size1 =  40, Size2 =   40, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  40, Size2 =   60, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  50, Size2 =   50, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  60, Size2 =   60, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  60, Size2 =   90, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  80, Size2 =   80, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  80, Size2 =  120, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  90, Size2 =   90, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 =  90, Size2 =  135, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 = 100, Size2 =  100, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },
                new Product { Size1 = 100, Size2 =  150, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Matt.ToString() },

                new Product { Size1 =  40, Size2 =   40, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  40, Size2 =   60, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  50, Size2 =   50, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  60, Size2 =   60, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  60, Size2 =   90, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  80, Size2 =   80, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  80, Size2 =  120, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  90, Size2 =   90, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 =  90, Size2 =  135, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
                new Product { Size1 = 100, Size2 =  100, Printer = PrinterEnum.Lambda.ToString().Replace("_", " "), Paper = PaperEnum.Metallic.ToString() },
            }.ToList();

            #endregion
        }
    }
}