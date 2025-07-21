using System;


namespace F10Y.Z0011.Construction
{
    public static class Instances
    {
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static L0004.L000.IFilePaths FilePaths => L0004.L000.FilePaths.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        /// <inheritdoc cref="Z001.IPaths"/>
        public static Z001.IPaths Paths => Z001.Paths.Instance;
    }
}