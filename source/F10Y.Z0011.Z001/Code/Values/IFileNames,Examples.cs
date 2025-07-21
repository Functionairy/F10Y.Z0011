using System;


namespace F10Y.Z0011.Z001
{
    public partial interface IFileNames
    {
        /// <summary>
        /// A good example file name.
        /// <para><inheritdoc cref="IFileNames.temp_txt" path="descendant::value"/></para>
        /// With file extension and file extension separator (.txt), not root-indicated, valid.
        /// </summary>
        public string Example => this.temp_txt;
    }
}
