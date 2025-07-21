using System;


namespace F10Y.Z0011.Z001
{
    public class RelativePaths : IRelativePaths
    {
        #region Infrastructure

        public static IRelativePaths Instance { get; } = new RelativePaths();


        private RelativePaths()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0011.Z001.Raw
{
    public class RelativePaths : IRelativePaths
    {
        #region Infrastructure

        public static IRelativePaths Instance { get; } = new RelativePaths();


        private RelativePaths()
        {
        }

        #endregion
    }
}
