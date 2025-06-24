using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0011.Z001
{
    [ValuesMarker]
    public partial interface IPaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IPaths _Raw => Raw.Paths.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="Raw.IPaths.N001"/>
        public string C_Directory01 => _Raw.N001;

        /// <summary>
        /// <para><value>C:\Temp\Temp.txt</value></para>
        /// </summary>
        public string C_Temp_Temp_txt => @"C:\Temp\Temp.txt";
    }
}
