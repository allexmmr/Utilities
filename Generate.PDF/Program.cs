using Generate.PDF.Business;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace Generate.PDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Generate the new PDF files
            
            // Original file
            const string originalFile = @"C:\Users\Allex Rocha\Documents\GitHub\Utilities\Generate.PDF\Source\Building.pdf";

            // Counter to show the final amount of files which were created
            int counter = 0;

            Customer customer = new Customer();
            
            foreach (Customer item in customer.List())
            {
                // Sets the name for the new file
                string filename = $"Building {item.Building} - {item.SerialNumber.Replace("/", "-")}.pdf";
                // New file which will be created after fillin PDF
                string newFile = $@"C:\Users\Allex Rocha\Documents\GitHub\Utilities\Generate.PDF\Source\PDF\{filename}";
                PdfReader pdfReader = new PdfReader(originalFile);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;

                // Fill in the form fields
                pdfFormFields.SetField("Serial Number", item.SerialNumber);
                pdfFormFields.SetField("House/Unit #", item.HouseUnitNo);
                pdfFormFields.SetField("Street Name", item.Street);
                pdfFormFields.SetField("Suburb Name", item.Suburb);
                pdfFormFields.SetField("Postcode", item.Postcode);
                pdfFormFields.SetField("Nearest X Street", item.NearestStreet);
                pdfFormFields.SetField("Municipality / Shire", item.MunicipalityShire);
                pdfFormFields.SetField("Meter Number", item.MeterNumber);
                pdfFormFields.SetField("Gas Leak Check - DD", item.GasLeakCheck.Day.ToString());
                pdfFormFields.SetField("Gas Leak Check - MM", item.GasLeakCheck.Month.ToString());
                pdfFormFields.SetField("Gas Leak Check - YYYY", item.GasLeakCheck.Year.ToString());

                // Flatten the form to remove editting options, set it to false to leave the form open to subsequent manual edits
                pdfStamper.FormFlattening = false;
                pdfStamper.FormFlattening = false;
                pdfStamper.Close();

                // Increase the counter
                counter++;

                Console.WriteLine($"The file '{filename}' was created successfully.");
            }

            Console.WriteLine(counter == 1 ? "1 file has been created." : $"{counter} files have been created.");

            #endregion

            Console.WriteLine("Press <Enter> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}