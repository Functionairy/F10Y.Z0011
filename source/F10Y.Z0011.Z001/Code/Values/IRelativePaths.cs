using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IRelativePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IRelativePaths _Raw => Raw.RelativePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IRelativePaths.N_001"/>
        public string RelativePath01 => _Raw.N_001;
    }
}
