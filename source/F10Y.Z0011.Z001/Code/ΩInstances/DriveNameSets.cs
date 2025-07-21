using System;


namespace F10Y.Z0011.Z001
{
    public class DriveNameSets : IDriveNameSets
    {
        #region Infrastructure

        public static IDriveNameSets Instance { get; } = new DriveNameSets();


        private DriveNameSets()
        {
        }

        #endregion
    }
}
