using System;


namespace F10Y.Z0011.Z001
{
    public partial interface IFilePaths
    {
        /// <summary>
        /// A good example file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_025" path="descendant::value"/></para>
        /// Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example => _Paths._Raw.N_025;

        /// <summary>
        /// A good example Windows file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_025" path="descendant::value"/></para>
        /// Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Windows => _Paths._Raw.N_025;

        /// <summary>
        /// A good example non-Windows file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_024" path="descendant::value"/></para>
        /// Non-Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_NonWindows => _Paths._Raw.N_024;

        /// <summary>
        /// A good example relative file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_023" path="descendant::value"/></para>
        /// Windows, relative, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Relative => _Paths._Raw.N_023;

        /// <summary>
        /// A good example relative Windows file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_023" path="descendant::value"/></para>
        /// Windows, relative, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Relative_Windows => _Paths._Raw.N_023;

        /// <summary>
        /// A good example relative non-Windows file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_022" path="descendant::value"/></para>
        /// Non-Windows, relative, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Relative_NonWindows => _Paths._Raw.N_022;

        /// <summary>
        /// A good example rooted file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_025" path="descendant::value"/></para>
        /// Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Rooted => _Paths._Raw.N_025;

        /// <summary>
        /// A good example rooted Windows file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_025" path="descendant::value"/></para>
        /// Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Rooted_Windows => _Paths._Raw.N_025;

        /// <summary>
        /// A good example rooted non-Windows file path.
        /// <para><inheritdoc cref="Raw.IPaths.N_026" path="descendant::value"/></para>
        /// Non-Windows, rooted, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Rooted_NonWindows => _Paths._Raw.N_026;
    }
}
