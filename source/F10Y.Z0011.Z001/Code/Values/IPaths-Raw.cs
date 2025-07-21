using System;

using F10Y.T0003;


namespace F10Y.Z0011.Z001.Raw
{
    /// <summary>
    /// All raw (absolutely named) path values.
    /// </summary>
    [ValuesMarker]
    public partial interface IPaths
    {
        /// <summary>
        /// <para><value>"" (the empty path)</value></para>
        /// </summary>
        public string N_000 => "";

        /// <summary>
        /// <para><value>&lt;null&gt; (the null path)</value></para>
        /// </summary>
        public string N_000_00 => null;

        /// <summary>
        /// <para><value>C:\Directory01</value></para>
        /// </summary>
        public string N_001 => @"C:\Directory01";

        /// <summary>
        /// <para><value>C:\</value></para>
        /// The Windows C-drive.
        /// </summary>
        public string N_002 => @"C:\";

        /// <summary>
        /// <para><value>C:</value></para>
        /// The Windows C-drive, but non-directory indicated.
        /// </summary>
        public string N_002_01 => @"C:";

        /// <summary>
        /// <para><value>mnt</value></para>
        /// An example non-Windows drive name.
        /// </summary>
        public string N_003 => @"mnt";

        /// <summary>
        /// <para><value>/mnt</value></para>
        /// An example non-Windows drive path.
        /// </summary>
        public string N_003_01 => @"/mnt";

        /// <summary>
        /// <para><value>C:\Code\DEV\Git\GitHub\Functionairy\F10Y.L0027\source\F10Y.L0027.Construction\..\..\..\F10Y.Z0011\source\F10Y.Z0011.Z001\F10Y.Z0011.Z001.csproj</value></para>
        /// An unresolved path.
        /// (A project directory plus the relative path of a project reference).
        /// </summary>
        public string N_004 => @"C:\Code\DEV\Git\GitHub\Functionairy\F10Y.L0027\source\F10Y.L0027.Construction\..\..\..\F10Y.Z0011\source\F10Y.Z0011.Z001\F10Y.Z0011.Z001.csproj";

        /// <summary>
        /// <para><value>C:\Code\DEV\Git\GitHub\Functionairy\F10Y.Z0011\source\F10Y.Z0011.Z001\F10Y.Z0011.Z001.csproj</value></para>
        /// A project file path. (The resolved version of <see cref="N_004"/>.)
        /// </summary>
        public string N_005 => @"C:\Code\DEV\Git\GitHub\Functionairy\F10Y.Z0011\source\F10Y.Z0011.Z001\F10Y.Z0011.Z001.csproj";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02</value></para>
        /// </summary>
        public string N_006 => @"C:\Directory01\Directory02";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\</value></para>
        /// </summary>
        public string N_007 => @"C:\Directory01\Directory02\";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03</value></para>
        /// </summary>
        public string N_008 => @"C:\Directory01\Directory02\Directory03";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03\</value></para>
        /// </summary>
        public string N_009 => @"C:\Directory01\Directory02\Directory03\";

        /// <summary>
        /// <para><value>C:\Directory01\Directory04</value></para>
        /// </summary>
        public string N_010 => @"C:\Directory01\Directory04";

        /// <summary>
        /// <para><value>C:\Directory01\Directory04\</value></para>
        /// </summary>
        public string N_011 => @"C:\Directory01\Directory04\";

        /// <summary>
        /// <para><value>/mnt/Directory01</value></para>
        /// </summary>
        public string N_012 => @"/mnt/Directory01";

        /// <summary>
        /// <para><value>/mnt/Directory01/</value></para>
        /// </summary>
        public string N_013 => @"/mnt/Directory01/";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02</value></para>
        /// </summary>
        public string N_014 => @"/mnt/Directory01/Directory02";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/</value></para>
        /// </summary>
        public string N_015 => @"/mnt/Directory01/Directory02/";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/Directory03</value></para>
        /// </summary>
        public string N_016 => @"/mnt/Directory01/Directory02/Directory03";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/Directory03/</value></para>
        /// </summary>
        public string N_017 => @"/mnt/Directory01/Directory02/Directory03/";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory04</value></para>
        /// </summary>
        public string N_018 => @"/mnt/Directory01/Directory04";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory04/</value></para>
        /// </summary>
        public string N_019 => @"/mnt/Directory01/Directory04/";

        /// <summary>
        /// <para><value>/mnt/Directory02/Directory03/../Directory04/</value></para>
        /// </summary>
        public string N_020 => @"/mnt/Directory02/Directory03/../Directory04/";

        /// <summary>
        /// <para><value>/mnt/Directory02/Directory04/</value></para>
        /// </summary>
        public string N_021 => @"/mnt/Directory02/Directory04/";

        /// <summary>
        /// <para><value>Directory03/Directory04/temp.txt</value></para>
        /// An example non-Windows relative file path.
        /// </summary>
        public string N_022 => @"Directory03/Directory04/temp.txt";

        /// <summary>
        /// <para><value>Directory03\Directory04\temp.txt</value></para>
        /// An example Windows relative file path.
        /// </summary>
        public string N_023 => @"Directory03\Directory04\temp.txt";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/Directory03/Directory04/temp.txt</value></para>
        /// </summary>
        public string N_024 => @"/mnt/Directory01/Directory02/Directory03/Directory04/temp.txt";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03\Directory04\temp.txt</value></para>
        /// </summary>
        public string N_025 => @"C:\Directory01\Directory02\Directory03\Directory04\temp.txt";

        /// <summary>
        /// <para><value>/mnt/Directory01/Directory02/Directory03/Directory04/temp.txt</value></para>
        /// </summary>
        public string N_026 => @"/mnt/Directory01/Directory02/Directory03\Directory04\temp.txt";

        /// <summary>
        /// <para><value>C:\Directory01\Directory02\Directory03\Directory04\temp.txt</value></para>
        /// </summary>
        public string N_027 => @"C:\Directory01\Directory02\Directory03/Directory04/temp.txt";

        /// <summary>
        /// <para><value>Directory03/Directory04/</value></para>
        /// An example non-Windows relative directory path.
        /// </summary>
        public string N_028 => @"Directory03/Directory04/";

        /// <summary>
        /// <para><value>Directory03\Directory04\</value></para>
        /// An example Windows relative directory path.
        /// </summary>
        public string N_029 => @"Directory03\Directory04\";
    }
}
