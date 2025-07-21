using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    /// <summary>
    /// All directory names.
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Raw.IDirectoryNames"/>
        [Ignore]
        public Raw.IDirectoryNames _Raw => Raw.DirectoryNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDirectoryNames.N_000"/>
        public string Current => _Raw.N_000;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_01"/>
        public string Directory01 => _Raw.N_004_01;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_01_1"/>
        public string Directory01_RootIndicated_Windows => _Raw.N_004_01_1;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_01_2"/>
        public string Directory01_RootIndicated_NonWindows => _Raw.N_004_01_2;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_01_3"/>
        public string Directory01_DirectoryIndicated_Windows => _Raw.N_004_01_3;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_01_4"/>
        public string Directory01_DirectoryIndicated_NonWindows => _Raw.N_004_01_4;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_02"/>
        public string Directory02 => _Raw.N_004_02;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_03"/>
        public string Directory03 => _Raw.N_004_03;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_04"/>
        public string Directory04 => _Raw.N_004_04;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_004_05"/>
        public string Directory05 => _Raw.N_004_05;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_002"/>
        public string Directory_Name => _Raw.N_002;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_003"/>
        public string Directory__Name => _Raw.N_003;

        /// <inheritdoc cref="Raw.IDirectoryNames.N_001"/>
        public string Parent => _Raw.N_001;
    }
}
