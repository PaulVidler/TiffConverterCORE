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

            // GdalConfiguration.ConfigureGdal();
            // https://stackoverflow.com/questions/55386597/gdal-c-sharp-wrapper-for-vrt-doesnt-write-a-vrt-file


            string outputName = Environment.CurrentDirectory + @"\BR01899_Mackenzie_09_EXPORT";
            string vrtfile = outputName + @"\tempMosaic.vrt";
            string filenameKMZ = outputName + @"\test.kmz";
            string[] tiffFiles = Directory.GetFiles(outputName, "*.tif");

            Gdal.AllRegister();

            var vrtOptions = new GDALBuildVRTOptions(new[] { "-overwrite" });
            
            GDALTranslateOptions transOptions = new GDALTranslateOptions(new[] { "-of", "KMLSUPEROVERLAY", "-co", "format=png" });

            Dataset vrtDataset = Gdal.wrapper_GDALBuildVRT_names(vrtfile, tiffFiles, vrtOptions, null, null);
            // vrtDataset.Dispose();

            Gdal.wrapper_GDALTranslate(filenameKMZ, vrtDataset, transOptions, null, null);

            
        }
    }
}
