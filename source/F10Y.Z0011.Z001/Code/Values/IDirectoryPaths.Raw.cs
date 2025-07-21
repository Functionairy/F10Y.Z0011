using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001.Raw
{
    [ValuesMarker]
    public partial interface IDirectoryPaths
    {
        /// <summary>
        /// <para><value>C:\Temp\</value></para>
        /// </summary>
        public string N_001 => @"C:\Temp\";

        /// <summary>
        /// <para><value>C:\Temp</value></para>
        /// Not directory-indicated.
        /// </summary>
        public string N_001_01 => @"C:\Temp";
    }
}
