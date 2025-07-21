using System;


namespace F10Y.Z0011.Z001
{
    public class DriveNames : IDriveNames
    {
        #region Infrastructure

        public static IDriveNames Instance { get; } = new DriveNames();


        private DriveNames()
        {
        }

        #endregion
    }
}
