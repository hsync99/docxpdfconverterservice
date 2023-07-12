﻿using System.IO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;


namespace docxpdfconverterservice.Services
{
    public class ConvertationService : IConvertationService
    {
        public async Task<string> ConvertToPdf(string filepath)
        {
            using (FileStream fileStream = new FileStream(Path.GetFullPath(filepath), FileMode.Open))
            {
                //Loads an existing Word document.
                using (WordDocument wordDocument = new WordDocument(fileStream, Syncfusion.DocIO.FormatType.Automatic))
                {
                    //Creates an instance of DocIORenderer.
                    using (DocIORenderer renderer = new DocIORenderer())
                    {
                        //Sets true to preserve document structured tags in the converted PDF document.
                        renderer.Settings.AutoTag = true;
                        //Converts Word document into PDF document.
                        using (PdfDocument pdfDocument = renderer.ConvertToPDF(wordDocument))
                        {
                            //Saves the PDF file to file system.    
                            using (FileStream outputStream = new FileStream(Path.GetFullPath(@"../../../WordToPDF.pdf"), FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                            {
                                pdfDocument.Save(outputStream);
                                return @"../../../WordToPDF.pdf";
                            }
                        }
                    }
                }
            }
        }
    }
}
