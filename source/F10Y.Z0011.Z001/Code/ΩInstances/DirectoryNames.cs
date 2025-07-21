using System;


namespace F10Y.Z0011.Z001
{
    public class DirectoryNames : IDirectoryNames
    {
        #region Infrastructure

        public static IDirectoryNames Instance { get; } = new DirectoryNames();


        private DirectoryNames()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0011.Z001.Raw
{
    public class DirectoryNames : IDirectoryNames
    {
        #region Infrastructure

        public static IDirectoryNames Instance { get; } = new DirectoryNames();


        private DirectoryNames()
        {
        }

        #endregion
    }
}