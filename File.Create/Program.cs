using System;
using System.IO;
using File.Create.Business;

namespace File.Create
{
    public class Program
    {
        public static void Main()
        {
            #region Create the new files

            const string path = @"C:\Temp";

            // Counter to show the final amount of files which were created
            int counter = 0;

            // Check if the directory exists, if it does not exist, it is created
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            Product product = new Product();

            foreach (Product item in product.List())
            {
                string file = $@"{path}\{item.Size1} X {item.Size2} cm {item.Printer} {item.Paper}.txt";

                // Check if the file exists, if it does not exist, it is created
                if (!System.IO.File.Exists(file))
                {
                    // Create a file to write to
                    using (StreamWriter sw = System.IO.File.CreateText(file))
                    {
                        #region Document

                        sw.WriteLine($@"FileType:     Layout
Macros:   ~Macros.txt~

Datarecords:   1

Savemetadata:   0

Unitofmeasure:   ~Inches~

Trace:   ~F~

Main:
    Adaptivesharpenlimit:                151
    Adaptivesharpenthreshold:            90
    Autocrop:                            50 50 50 50 100 100 
    Autocropmode:                        ~C~
    Bgcoloropacity:                      100
    Enhancedtextlogos1:                  1
    Enhancedtextlogos2:                  1
    Framemaskfeathering:                 3
    Framemaskinsidecolor:                0 255 255 255 
    Framemasktolerance:                  100
    Framerectoverlapx:                   5
    Framerectoverlapy:                   5
    Frameresize:                         ~L~
    Icolor:                              0 255 255 255 
    Ifileopacity:                        100
    Ilocation:                           0 0 {(item.Size1 + 2) * 0.393701} {(item.Size2 + 2) * 0.393701} 
    Imagecropheight:                     100
    Imagecropwidth:                      100
    Imagecropx:                          50
    Imagecropy:                          50
    Imageresize:                         ~L~
    Logoautorotate:                      1
    Logofont1:                           ~Arial~
    Logofont2:                           ~Arial~
    Logojustification1:                  ~C~
    Logojustification2:                  ~C~
    Logomaxfontsize1:                    24
    Logomaxfontsize2:                    24
    Logominfontsize1:                    1
    Logominfontsize2:                    1
    Logoposition1:                       ~UL~
    Logoposition2:                       ~UL~
    Logoscale:                           100
    Logoscriptsystem1:                   ~Western~
    Logoscriptsystem2:                   ~Western~
    Logostroketextopacity1:              100
    Logostroketextopacity2:              100
    Logotextalignment1:                  ~C~
    Logotextalignment2:                  ~C~
    Logotextantialias1:                  1
    Logotextantialias2:                  1
    Nodename:                            ~Background~
    Sharpenfaster:                       60
    Strokeimagerect:                     0 0 100 0 0 0 0 
    Stroketextrect:                      0 0 100 0 0 0 0 
    Xgamma:                              1

Il:   10000
    Adaptivesharpenlimit:                151
    Adaptivesharpenthreshold:            90
    Autocrop:                            50 50 50 50 100 100 
    Autocropmode:                        ~F~
    Autorotate:                          270
    Bevelimagerect:                      0 1 0 0 0 0 0 
    Beveltextrect:                       0 1 0 0 0 0 0 
    Bgcoloropacity:                      100
    Enhancedtextlogos1:                  1
    Enhancedtextlogos2:                  1
    Framemaskfeathering:                 3
    Framemaskinsidecolor:                0 255 255 255 
    Framemasktolerance:                  100
    Framerectoverlapx:                   5
    Framerectoverlapy:                   5
    Frameresize:                         ~L~
    Ifile:                               ~<$@App.ShareDirectory>\Images\Shirley~
    Ifileopacity:                        100
    Ilocation:                           {2 * 0.393701} {2 * 0.393701} {item.Size1 * 0.393701} {item.Size2 * 0.393701} 
    Imagecropheight:                     100
    Imagecropwidth:                      100
    Imagecropx:                          50
    Imagecropy:                          50
    Imageresize:                         ~L~
    Imageshadowstrength:                 100
    Iprompt:                             ~Insert an image here~
    Logoautorotate:                      1
    Logofont1:                           ~Arial~
    Logofont2:                           ~Arial~
    Logojustification1:                  ~C~
    Logojustification2:                  ~C~
    Logomaxfontsize1:                    24
    Logomaxfontsize2:                    24
    Logominfontsize1:                    1
    Logominfontsize2:                    1
    Logoposition1:                       ~UL~
    Logoposition2:                       ~UL~
    Logoscale:                           100
    Logoscriptsystem1:                   ~Western~
    Logoscriptsystem2:                   ~Western~
    Logoshadowstrength1:                 100
    Logoshadowstrength2:                 100
    Logostroketextopacity1:              100
    Logostroketextopacity2:              100
    Logotextalignment1:                  ~C~
    Logotextalignment2:                  ~C~
    Logotextantialias1:                  1
    Logotextantialias2:                  1
    Nodename:                            ~Node10000~
    Radialblurcenterx:                   50
    Radialblurcentery:                   50
    Sharpenfaster:                       60
    Strokeimagerect:                     0 1 100 0 0 0 0 
    Stroketextrect:                      0 1 100 0 0 0 0 
    Vignettecenterx:                     50
    Vignettecentery:                     50
    Xgamma:                              1

Aftereffects:
    Adaptivesharpenlimit:                151
    Xgamma:                              1

Saveimage:
    Copies:                              1
    Enabled:                             1
    Oemprintersurface:                   0
    Ospotcolorfiletype:                  ~JPEG~
    Paperwidth:                          0
    Printerresize:                       1
    Queuename:                           ~Durst Lambda 200 dpi~
    Rp30:                                0
    Rr30:                                0
    Savefiletype:                        ~JPEG~
    Xres:                                0

Outputtocrt:
    Borderless:                          1
    Copies:                              1
    Enabled:                             0
    Paperadvance:                        8
    Paperwidth:                          10
    Printernumber:                       (-1)
    Rotated:                             0

Outputtoled:
    Borderless:                          1
    Copies:                              1
    Deferred:                            1
    Enabled:                             0
    Fillbackground:                      1
    Idpunch:                             0
    Mediasize:                           ~10~
    Offsetindex:                         0
    Orderpunch:                          0
    Paperadvance:                        8
    Paperwidth:                          10
    Printernumber:                       (-1)
    Resolution:                          250
    Rotated:                             0

Outputtonexpress:
    Bleed:                               0
    Copies:                              1
    Enabled:                             0
    Oemprintersurface:                   0
    Ospotcolorfiletype:                  ~JPEG~
    Paperwidth:                          8.5
    Printerresize:                       0
    Savefiletype:                        ~JPEG~
    Xres:                                300

Outputtolaserprinter:
    Center:                              ~0~
    Copies:                              1
    Enabled:                             0
    Paperadvance:                        10
    Paperwidth:                          8
    Productpageseqcurrent:               0
    Productpageseqlast:                  0
    Xgamma:                              0.7

Productinfo:



# End of Layout. Contains 15 Major Keywords");

                        #endregion
                    }
                }

                // Open the file to read from
                using (StreamReader sr = System.IO.File.OpenText(file))
                {
                    string str;

                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }

                // Increase the counter
                counter++;
            }

            Console.WriteLine(counter == 1 ? "1 file has been created." : $"{counter} files have been created.");

            #endregion

            Console.WriteLine("Press <Enter> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}