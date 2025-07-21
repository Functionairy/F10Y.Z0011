using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001.N001
{
    /// <summary>
    /// An inheritable root paths.
    /// </summary>
    [ValuesMarker]
    public partial interface IRootPaths
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPaths _Paths => Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="C_Drive_DirectoryIndicated" path="/summary"/>
        /// <remarks>
        /// Chooses <see cref="C_Drive_DirectoryIndicated"/> as the default.
        /// </remarks>
        public string C_Drive => this.C_Drive_DirectoryIndicated;

        /// <inheritdoc cref="Raw.IPaths.N_002"/>
        public string C_Drive_DirectoryIndicated => _Paths._Raw.N_002;

        /// <inheritdoc cref="Raw.IPaths.N_002_01"/>
        public string C_Drive_NonDirectoryIndicated => _Paths._Raw.N_002_01;

        /// <inheritdoc cref="Raw.IPaths.N_003"/>
        public string mnt_Drive => _Paths._Raw.N_003;
        
#pragma warning restore IDE1006 // Naming Styles
    }
}
