using System;


namespace F10Y.Z0011.Z001
{
    public class PathsSets : IPathsSets
    {
        #region Infrastructure

        public static IPathsSets Instance { get; } = new PathsSets();


        private PathsSets()
        {
        }

        #endregion
    }
}
