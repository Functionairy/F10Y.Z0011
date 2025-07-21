using System;


namespace F10Y.Z0011.Z001
{
    public class PathParts : IPathParts
    {
        #region Infrastructure

        public static IPathParts Instance { get; } = new PathParts();


        private PathParts()
        {
        }

        #endregion
    }
}
