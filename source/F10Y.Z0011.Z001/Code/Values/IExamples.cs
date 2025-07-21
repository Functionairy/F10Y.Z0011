using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IExamples
    {
#pragma warning disable IDE1006 // Naming Styles

        private static Raw.IPaths _Raw_Paths => Raw.Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPaths.N_022"/>
        public string NonWindows_Relative_FilePath => _Raw_Paths.N_022;

        /// <inheritdoc cref="Raw.IPaths.N_023"/>
        public string Windows_Relative_FilePath => _Raw_Paths.N_023;

        /// <inheritdoc cref="Raw.IPaths.N_015"/>
        public string NonWindows_Rooted_DirectoryPath => _Raw_Paths.N_015;

        /// <inheritdoc cref="Raw.IPaths.N_007"/>
        public string Windows_Rooted_DirectoryPath => _Raw_Paths.N_007;

        /// <inheritdoc cref="Raw.IPaths.N_024"/>
        public string NonWindows_Rooted_FilePath => _Raw_Paths.N_024;

        /// <inheritdoc cref="Raw.IPaths.N_025"/>
        public string Windows_Rooted_FilePath => _Raw_Paths.N_025;

        /// <inheritdoc cref="Raw.IPaths.N_026"/>
        public string Mixed_NonWindowsDominant_Rooted_FilePath => _Raw_Paths.N_026;

        /// <inheritdoc cref="Raw.IPaths.N_027"/>
        public string Mixed_WindowsDominant_Rooted_FilePath => _Raw_Paths.N_027;
    }
}
