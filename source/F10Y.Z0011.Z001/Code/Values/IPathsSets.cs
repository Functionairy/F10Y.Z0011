using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IPathsSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IExamples _Examples => Examples.Instance;
        private static IPaths _Paths => Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string[] All => new[]
        {
            _Examples.Mixed_NonWindowsDominant_Rooted_FilePath,
            _Examples.Mixed_WindowsDominant_Rooted_FilePath,
            _Examples.NonWindows_Relative_FilePath,
            _Examples.NonWindows_Rooted_DirectoryPath,
            _Examples.NonWindows_Rooted_FilePath,
            _Examples.Windows_Relative_FilePath,
            _Examples.Windows_Rooted_DirectoryPath,
            _Examples.Windows_Rooted_FilePath,

            _Paths.C_Drive_NonDirectoryIndicated,
            _Paths.C_Drive,
            _Paths.C_Directory01,
            _Paths.C_Directory01_,
            _Paths.C_Directory01_Directory02,
            _Paths.C_Directory01_Directory02_,
            _Paths.C_Directory01_Directory02_Directory03,
            _Paths.C_Directory01_Directory02_Directory03_,
            _Paths.C_Directory01_Directory04,
            _Paths.C_Directory01_Directory04_,

            _Paths.mnt_Drive_NonRootIndicated,
            _Paths.mnt_Drive_RootIndicated,
            _Paths.mnt_Directory01,
            _Paths.mnt_Directory01_,
            _Paths.mnt_Directory01_Directory02,
            _Paths.mnt_Directory01_Directory02_,
            _Paths.mnt_Directory01_Directory02_Directory03,
            _Paths.mnt_Directory01_Directory02_Directory03_,
            _Paths.mnt_Directory01_Directory04,
            _Paths.mnt_Directory01_Directory04_,

            _Paths.C_Temp_Temp_txt,

            _Paths.Unresolved01,
            _Paths.Resolved01,
            _Paths.Unresolved02_NonWindows,
            _Paths.Resolved02_NonWindows,

            // Pathological.
            _Paths.EmptyPath,
            _Paths.NullPath
        };
    }
}
