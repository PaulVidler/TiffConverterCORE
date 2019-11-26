using System;
using System.Collections.Generic;
using System.IO;
using OSGeo.GDAL;

namespace GDALTranslate
{
    public class TcTranslate
    {
        static TcTranslate()
        {

        }



        public string OutputDirName { get; set; }
        public string KMZFileName { get; set; }
        public List<string> TiffFiles { get; set; }
        public string TIFFDirectory { get; set; }


        public TcTranslate(string KMZName, string inputDir, string outputDir)
        {

            OutputDirName = outputDir;
            KMZFileName = KMZName;
            TIFFDirectory = inputDir;

        }

        public void TranslateAction(List<string> files)
        {
            
            GDALTranslateOptions transOptions = new GDALTranslateOptions(new[] { "-of", "KMLSUPEROVERLAY", "-co", "format=png" });
            
            var vrtOptions = new GDALBuildVRTOptions(new[] { "-overwrite" });
            var vrtFile = BuildVRT("tempVRT", files, vrtOptions);

            Gdal.wrapper_GDALTranslate(Path.Combine(OutputDirName, KMZFileName), vrtFile, transOptions, null, null);
        }

        private Dataset BuildVRT(string vrtFile, List<string> tiffFiles, GDALBuildVRTOptions vrtOptions)
        {
            return Gdal.wrapper_GDALBuildVRT_names(vrtFile, tiffFiles.ToArray(), vrtOptions, null, null);
        }

        // TcTranslate test = new TcTranslate("test.kmz", @"C:\Users\relia\Documents\GitHub\TiffConverterCORE\TiffConverterCORE\BR01899_Mackenzie_09_EXPORT\", Environment.CurrentDirectory);

    }

}
