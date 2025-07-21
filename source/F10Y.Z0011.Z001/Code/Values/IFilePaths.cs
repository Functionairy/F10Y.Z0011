using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPaths _Paths => Paths.Instance;


        [Ignore]
        public Raw.IFilePaths _Raw => Raw.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IFilePaths.N_001"/>
        public string F10Y_L0027_Construction_csproj => _Raw.N_001;
    }
}
