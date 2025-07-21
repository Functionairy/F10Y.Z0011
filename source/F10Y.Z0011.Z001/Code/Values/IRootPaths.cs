using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    /// <summary>
    /// Paths of path roots (like the Windows "C:" drive, or the non-Windows "mnt" drive).
    /// </summary>
    [ValuesMarker]
    public partial interface IRootPaths :
        N001.IRootPaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public N001.IRootPaths _N001 => N001.RootPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
