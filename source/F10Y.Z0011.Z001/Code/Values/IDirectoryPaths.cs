using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IDirectoryPaths
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPaths _Paths => Paths.Instance;


        [Ignore]
        public Raw.IDirectoryPaths _Raw => Raw.DirectoryPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDirectoryPaths.N_001"/>
        public string C_Temp => _Raw.N_001;

        /// <inheritdoc cref="Raw.IDirectoryPaths.N_001_01"/>
        public string C_Temp_NotDirectoryIndicated => _Raw.N_001_01;
    }
}

