using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IDriveNames
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>C:\</value></para>
        /// </summary>
        public string C_Drive => @"C:\";

        /// <summary>
        /// <para><value>C:</value></para>
        /// </summary>
        public string C_Drive_NonDirectoryIndicated => "C:";

        /// <summary>
        /// <para><value>/mnt</value></para>
        /// </summary>
        public string mnt => "/mnt";

        /// <summary>
        /// <para><value>mnt</value></para>
        /// </summary>
        public string mnt_NonRootIndicated => "mnt";

#pragma warning restore IDE1006 // Naming Styles
    }
}
