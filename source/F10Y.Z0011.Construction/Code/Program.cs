using System;
using System.Threading.Tasks;


namespace F10Y.Z0011.Construction
{
    class Program
    {
        static async Task Main()
        {
            /// Inputs.
            var path = Instances.Paths
                .C_Drive
                ;

            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var lines_ForOutput = Instances.EnumerableOperator.From($"Path:\n\t{path}");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}