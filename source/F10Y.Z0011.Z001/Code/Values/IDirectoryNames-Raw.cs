using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001.Raw
{
    /// <summary>
    /// All raw (absolutely named) directory names.
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames
    {
        /// <summary>
        /// <para><value>.</value></para>
        /// The current directory.
        /// </summary>
        public string N_000 => ".";

        /// <summary>
        /// <para><value>..</value></para>
        /// The parent directory.
        /// </summary>
        public string N_001 => "..";

        /// <summary>
        /// <para><value>Directory.Name</value></para>
        /// A directory name containing a dot.
        /// </summary>
        public string N_002 => "Directory.Name";

        /// <summary>
        /// <para><value>Directory..Name</value></para>
        /// A directory name containing two dots.
        /// </summary>
        public string N_003 => "Directory..Name";

        /// <summary>
        /// <para><value>Directory01</value></para>
        /// </summary>
        public string N_004_01 => "Directory01";

        /// <summary>
        /// <para><value>\Directory01</value></para>
        /// Root-indicated, Windows.
        /// </summary>
        public string N_004_01_1 => @"\Directory01";

        /// <summary>
        /// <para><value>/Directory01</value></para>
        /// Root-indicated, non-Windows.
        /// </summary>
        public string N_004_01_2 => "/Directory01";

        /// <summary>
        /// <para><value>Directory01\</value></para>
        /// Directory-indicated, Windows.
        /// </summary>
        public string N_004_01_3 => @"Directory01\";

        /// <summary>
        /// <para><value>Directory01/</value></para>
        /// Directory-indicated, non-Windows.
        /// </summary>
        public string N_004_01_4 => "Directory01/";

        /// <summary>
        /// <para><value>Directory01//</value></para>
        /// Double-directory-indicated, non-Windows.
        /// </summary>
        public string N_004_01_5 => "Directory01//";

        /// <summary>
        /// <para><value>Directory02</value></para>
        /// </summary>
        public string N_004_02 => "Directory02";

        /// <summary>
        /// <para><value>Directory03</value></para>
        /// </summary>
        public string N_004_03 => "Directory03";

        /// <summary>
        /// <para><value>Directory04</value></para>
        /// </summary>
        public string N_004_04 => "Directory04";

        /// <summary>
        /// <para><value>Directory05</value></para>
        /// </summary>
        public string N_004_05 => "Directory05";
    }
}
