using System;


namespace F10Y.Z0011.Z001
{
    public class RootPaths : IRootPaths
    {
        #region Infrastructure

        public static IRootPaths Instance { get; } = new RootPaths();


        private RootPaths()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0011.Z001.N001
{
    public class RootPaths : IRootPaths
    {
        #region Infrastructure

        public static IRootPaths Instance { get; } = new RootPaths();


        private RootPaths()
        {
        }

        #endregion
    }
}