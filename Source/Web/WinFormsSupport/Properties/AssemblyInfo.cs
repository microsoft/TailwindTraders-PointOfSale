using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WinFormsSupport")]
[assembly: AssemblyProduct("WinFormsSupport")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace WinFormsSupport
{
    /// <summary>
    /// This class is used to easily identify the library
    /// </summary>
    public class AssemblyIdentifier
    {
        public string Name => typeof(AssemblyIdentifier).Assembly.GetName().Name;
    }
}
