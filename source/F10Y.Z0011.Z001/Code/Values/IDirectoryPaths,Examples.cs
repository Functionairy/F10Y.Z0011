using System;


namespace F10Y.Z0011.Z001
{
    public partial interface IDirectoryPaths
    {
        /// <summary>
        /// A good example directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_009" path="descendant::value"/></para>
        /// Windows, rooted, directory-indicated, resolved, valid.
        /// </summary>
        public string Example => _Paths._Raw.N_009;

        /// <summary>
        /// A good example Windows directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_009" path="descendant::value"/></para>
        /// Windows, rooted, directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Windows => _Paths._Raw.N_009;

        /// <summary>
        /// A good example non-Windows directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_017" path="descendant::value"/></para>
        /// Non-Windows, rooted, directory-indicated, resolved, valid.
        /// </summary>
        public string Example_NonWindows => _Paths._Raw.N_017;

        /// <summary>
        /// A good example relative directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_028" path="descendant::value"/></para>
        /// Windows, relative, directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Relative => _Paths._Raw.N_028;

        /// <summary>
        /// A good example relative Windows directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_028" path="descendant::value"/></para>
        /// Windows, relative, directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Relative_Windows => _Paths._Raw.N_028;

        /// <summary>
        /// A good example relative non-Windows directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_029" path="descendant::value"/></para>
        /// Non-Windows, relative, directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Relative_NonWindows => _Paths._Raw.N_029;

        /// <summary>
        /// A good example rooted directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_007" path="descendant::value"/></para>
        /// Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Rooted => _Paths._Raw.N_007;

        /// <summary>
        /// A good example rooted Windows directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_007" path="descendant::value"/></para>
        /// Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Rooted_Windows => _Paths._Raw.N_007;

        /// <summary>
        /// A good example rooted non-Windows directory path.
        /// <para><inheritdoc cref="Raw.IPaths.N_015" path="descendant::value"/></para>
        /// Non-Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Rooted_NonWindows => _Paths._Raw.N_015;
    }
}