using System;
using System.IO;
using OSGeo.GDAL;

namespace GDALTranslate
{
    public class TcTranslate
    {
        public string OutputDirName { get; set; }
        public string VrtFile { get; set; }
        public string KMZFileName { get; set; }
        public string[] TiffFiles { get; set; }
        public string TIFFDirectory { get; set; }
        // public string OutputDirectory { get; set; }

        private GDALBuildVRTOptions _vRTOptions = new GDALBuildVRTOptions(new[] { "-overwrite" });

        public GDALBuildVRTOptions VRTOptions
        {
            get { return new GDALBuildVRTOptions(new[] { "-overwrite" }); }
            private set { _vRTOptions = VRTOptions; }
        }

        private GDALTranslateOptions _translateOptions;
        public GDALTranslateOptions TranslateOptions
        {
            get { return TranslateOptions; }
            private set { _translateOptions = new GDALTranslateOptions(new[] { "-of", "KMLSUPEROVERLAY", "-co", "format=png" }); }
        }

        private Dataset _vrtDataset;
        public Dataset VRTDataset
        {
            get { return VRTMethod(); }
            private set { _vrtDataset = VRTMethod(); }
        }

        public TcTranslate(string KMZName, string inputDir, string outputDir)
        {
            Gdal.AllRegister();
            OutputDirName = outputDir;
            KMZFileName = KMZName;
            TIFFDirectory = outputDir;
            _vrtDataset = VRTDataset;
        }

        public Dataset VRTMethod()
        {
            Gdal.AllRegister();
            return Gdal.wrapper_GDALBuildVRT_names(VrtFile, TiffFiles, VRTOptions, null, null);
        }

        public void TranslateMethod()
        {
            VRTMethod();
            Gdal.wrapper_GDALTranslate(KMZFileName, VRTDataset, TranslateOptions, null, null);
        }

    }

}
