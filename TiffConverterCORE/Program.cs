using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSGeo.GDAL;

namespace TestingTIFFtoKMZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputName = Environment.CurrentDirectory + @"\BR01899_Mackenzie_09_EXPORT";
            string vrtfile = outputName + @"\tempMosaic.vrt";
            string filenameKMZ = outputName + @"\" + Environment.CurrentDirectory + ".kmz";
            string[] tiffFiles = Directory.GetFiles(outputName, "*.tif");

            var vrtOptions = new GDALBuildVRTOptions(new[] { "-overwrite" });
            

            GDALTranslateOptions transOptions1 = new GDALTranslateOptions(new[] { "-of", "KMLSUPEROVERLAY", "-co", "format=png" });

            var vrtDataset = Gdal.wrapper_GDALBuildVRT_names(vrtfile, tiffFiles, vrtOptions, null, null);

            Gdal.wrapper_GDALTranslate(filenameKMZ, vrtDataset, transOptions1, null, null);


        }
    }
}
