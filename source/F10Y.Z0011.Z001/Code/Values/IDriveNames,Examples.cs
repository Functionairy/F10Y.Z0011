using System;


namespace F10Y.Z0011.Z001
{
    public partial interface IDriveNames
    {
        /// <summary>
        /// A good example Windows drive name.
        /// <para><inheritdoc cref="IDriveNames.C_Drive" path="descendant::value"/></para>
        /// Windows, root-indicated, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example => this.C_Drive;

        /// <summary>
        /// A good example Windows drive name.
        /// <para><inheritdoc cref="IDriveNames.C_Drive" path="descendant::value"/></para>
        /// Windows, root-indicated, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_Windows => this.C_Drive;

        /// <summary>
        /// A good example non-Windows drive name.
        /// <para><inheritdoc cref="IDriveNames.mnt" path="descendant::value"/></para>
        /// Non-Windows, root-indicated, not directory-indicated, resolved, valid.
        /// </summary>
        public string Example_NonWindows => this.mnt;
    }
}
