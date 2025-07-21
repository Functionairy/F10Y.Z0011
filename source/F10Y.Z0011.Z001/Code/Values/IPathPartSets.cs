using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IPathPartSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDriveNames _DriveNames => DriveNames.Instance;
        private static IDirectoryNames _DirectoryNames => DirectoryNames.Instance;
        private static IFileNames _FileNames => FileNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string[] C_Diretory01_Directory02_temp_txt => new[]
        {
            _DriveNames.C_Drive,
            _DirectoryNames.Directory01,
            _DirectoryNames.Directory02,
            _FileNames.temp_txt
        };
    }
}
