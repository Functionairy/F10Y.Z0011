using System;


namespace F10Y.Z0011.Z001
{
    public class PathPartSets : IPathPartSets
    {
        #region Infrastructure

        public static IPathPartSets Instance { get; } = new PathPartSets();


        private PathPartSets()
        {
        }

        #endregion
    }
}
