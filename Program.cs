using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

namespace htmlPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            WebKitConverterSettings settings = new WebKitConverterSettings();
             
            //string htmlText = "<html><body Align='Left'><br><p> <font size='12'>Hello World </p></font> </body></html>";
            //string baseUrl = string.Empty;
            
            settings.WebKitPath = "C:\\Users\\Shiva\\source\\repos\\htmlPDF\\htmlPDF\\QtBinariesWindows";
             
            settings.Orientation = PdfPageOrientation.Portrait;
            
            htmlConverter.ConverterSettings = settings;
                      
            PdfDocument document = htmlConverter.Convert("F:\\finalhtml.html");
            MemoryStream stream = new MemoryStream();         
            document.Save(stream);
            //MemoryStream ms = new MemoryStream();
            FileStream file = new FileStream("F:\\final.pdf", FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            document.Close(true);
        }
    }
}
