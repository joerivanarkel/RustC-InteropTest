using System.Runtime.InteropServices;

namespace CsharpProject;

public class RustFunction
{
    [DllImport("rust_project.dll")]
    public static extern Int32 add_numbers(Int32 number1, Int32 number2);

}