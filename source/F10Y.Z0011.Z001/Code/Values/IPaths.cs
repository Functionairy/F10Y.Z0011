using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    /// <summary>
    /// All path values.
    /// </summary>
    /// <remarks>
    /// Example use: values for testing path parsing code.
    /// </remarks>
    [ValuesMarker]
    public partial interface IPaths :
        N001.IRootPaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IPaths _Raw => Raw.Paths.Instance;

        [Ignore]
        public N001.IRootPaths _RootPaths_N001 => N001.RootPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPaths.N_001"/>
        public string C_Directory01 => _Raw.N_001;

        /// <inheritdoc cref="Raw.IPaths.N_001"/>
        public string C_Directory01_ => @"C:\Directory01\";

        /// <inheritdoc cref="Raw.IPaths.N_006"/>
        public string C_Directory01_Directory02 => _Raw.N_006;

        /// <inheritdoc cref="Raw.IPaths.N_007"/>
        public string C_Directory01_Directory02_ => _Raw.N_007;

        /// <inheritdoc cref="Raw.IPaths.N_008"/>
        public string C_Directory01_Directory02_Directory03 => _Raw.N_008;

        /// <inheritdoc cref="Raw.IPaths.N_009"/>
        public string C_Directory01_Directory02_Directory03_ => _Raw.N_009;

        /// <inheritdoc cref="Raw.IPaths.N_010"/>
        public string C_Directory01_Directory04 => _Raw.N_010;

        /// <inheritdoc cref="Raw.IPaths.N_011"/>
        public string C_Directory01_Directory04_ => _Raw.N_011;

        /// <summary>
        /// <para><value>C:\Temp\Temp.txt</value></para>
        /// </summary>
        public string C_Temp_Temp_txt => @"C:\Temp\Temp.txt";

        /// <inheritdoc cref="Raw.IPaths.N_003"/>
        public string mnt_Drive_NonRootIndicated => _Raw.N_003;

        /// <inheritdoc cref="Raw.IPaths.N_003_01"/>
        public string mnt_Drive_RootIndicated => _Raw.N_003_01;

        /// <inheritdoc cref="Raw.IPaths.N_012"/>
        public string mnt_Directory01 => _Raw.N_012;

        /// <inheritdoc cref="Raw.IPaths.N_013"/>
        public string mnt_Directory01_ => _Raw.N_013;

        /// <inheritdoc cref="Raw.IPaths.N_014"/>
        public string mnt_Directory01_Directory02 => _Raw.N_014;

        /// <inheritdoc cref="Raw.IPaths.N_015"/>
        public string mnt_Directory01_Directory02_ => _Raw.N_015;

        /// <inheritdoc cref="Raw.IPaths.N_016"/>
        public string mnt_Directory01_Directory02_Directory03 => _Raw.N_016;

        /// <inheritdoc cref="Raw.IPaths.N_017"/>
        public string mnt_Directory01_Directory02_Directory03_ => _Raw.N_017;

        /// <inheritdoc cref="Raw.IPaths.N_018"/>
        public string mnt_Directory01_Directory04 => _Raw.N_018;

        /// <inheritdoc cref="Raw.IPaths.N_019"/>
        public string mnt_Directory01_Directory04_ => _Raw.N_019;

        #region Resolved/Unresolved

        /// <summary>
        /// <para><inheritdoc cref="Raw.IPaths.N_005" path="descendant::value"/></para>
        /// The resolved version of <see cref="Unresolved01"/>.
        /// </summary>
        public string Resolved01 => _Raw.N_005;

        /// <summary>
        /// <para><inheritdoc cref="Raw.IPaths.N_004" path="descendant::value"/></para>
        /// An unresolved version of <see cref="Resolved01"/>.
        /// </summary>
        public string Unresolved01 => _Raw.N_004;

        /// <summary>
        /// <para><inheritdoc cref="Raw.IPaths.N_020" path="descendant::value"/></para>
        /// An unresolved version of <see cref="Resolved02_NonWindows"/>.
        /// </summary>
        public string Unresolved02_NonWindows => _Raw.N_020;

        /// <summary>
        /// <para><inheritdoc cref="Raw.IPaths.N_021" path="descendant::value"/></para>
        /// The resolved version of <see cref="Unresolved02_NonWindows"/>.
        /// </summary>
        public string Resolved02_NonWindows => _Raw.N_021;

        #endregion

        #region Pathological

        /// <inheritdoc cref="Raw.IPaths.N_000"/>
        public string EmptyPath => _Raw.N_000;

        /// <inheritdoc cref="Raw.IPaths.N_000_00"/>
        public string NullPath => _Raw.N_000_00;

        #endregion

#pragma warning restore IDE1006 // Naming Styles
    }
}
