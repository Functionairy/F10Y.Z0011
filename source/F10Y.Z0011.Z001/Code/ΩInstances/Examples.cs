using System;


namespace F10Y.Z0011.Z001
{
    public class Examples : IExamples
    {
        #region Infrastructure

        public static IExamples Instance { get; } = new Examples();


        private Examples()
        {
        }

        #endregion
    }
}
