using System;


namespace F10Y.Z0011.Z001
{
    public class DirectoryPaths : IDirectoryPaths
    {
        #region Infrastructure

        public static IDirectoryPaths Instance { get; } = new DirectoryPaths();


        private DirectoryPaths()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0011.Z001.Raw
{
    public class DirectoryPaths : IDirectoryPaths
    {
        #region Infrastructure

        public static IDirectoryPaths Instance { get; } = new DirectoryPaths();


        private DirectoryPaths()
        {
        }

        #endregion
    }
}
