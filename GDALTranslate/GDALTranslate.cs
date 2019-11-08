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

        private GDALBuildVRTOptions _vRTOptions;

        public GDALBuildVRTOptions VRTOptions
        {
            get { return VRTOptions; }
            private set { _vRTOptions = new GDALBuildVRTOptions(new[] { "-overwrite" }); }
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
            get { return VRTDataset; }
            private set { _vrtDataset = Gdal.wrapper_GDALBuildVRT_names(VrtFile, TiffFiles, VRTOptions, null, null); }
        }

        public TcTranslate(string KMZName, string inputDir, string outputDir)
        {
            OutputDirName = outputDir;
            KMZFileName = KMZName;
            TIFFDirectory = outputDir;
            _vrtDataset = VRTDataset;
        }

        public void TranslateMethod()
        {
            Gdal.wrapper_GDALTranslate(KMZFileName, VRTDataset, TranslateOptions, null, null);
        }

    }
    


}
