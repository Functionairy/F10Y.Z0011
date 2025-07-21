using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IDriveNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDriveNames _DriveNames => Z001.DriveNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string[] All => new[]
        {
            _DriveNames.C_Drive,
            _DriveNames.C_Drive_NonDirectoryIndicated,
            _DriveNames.mnt,
            _DriveNames.mnt_NonRootIndicated
        };
    }
}
