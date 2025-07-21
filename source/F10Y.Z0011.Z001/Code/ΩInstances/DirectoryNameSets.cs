using System;


namespace F10Y.Z0011.Z001
{
    public class DirectoryNameSets : IDirectoryNameSets
    {
        #region Infrastructure

        public static IDirectoryNameSets Instance { get; } = new DirectoryNameSets();


        private DirectoryNameSets()
        {
        }

        #endregion
    }
}
