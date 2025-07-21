using System;


namespace F10Y.Z0011.Z001
{
    public class FilePaths : IFilePaths
    {
        #region Infrastructure

        public static IFilePaths Instance { get; } = new FilePaths();


        private FilePaths()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0011.Z001.Raw
{
    public class FilePaths : IFilePaths
    {
        #region Infrastructure

        public static IFilePaths Instance { get; } = new FilePaths();


        private FilePaths()
        {
        }

        #endregion
    }
}
