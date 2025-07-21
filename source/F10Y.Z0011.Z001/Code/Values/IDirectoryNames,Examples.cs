using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001
{
    public partial interface IDirectoryNames
    {
        /// <summary>
        /// A good example directory name.
        /// <para><inheritdoc cref="Raw.IDirectoryNames.N_004_01" path="descendant::value"/></para>
        /// Not root-indicated, not directory-indicated, valid.
        /// </summary>
        public string Example => _Raw.N_004_01;
    }
}
