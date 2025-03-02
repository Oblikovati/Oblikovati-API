namespace Oblikovati.API;

/// <summary>
/// Test Program Object.
/// </summary>
public interface TestProgram
{
    /// <summary>
    /// Gets the name of the test program.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the description of the test program.
    /// </summary>
    string Description { get; }
    /// <summary>
    /// Gets the full path of the test program.
    /// </summary>
    string Path { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    string Type { get; }
    /// <summary>
    /// Runs the test program using the given test object and TestIO object. Setting the debug flag, activates the pane in the debugger and sets a breakpoint.
    /// </summary>
    [PreserveSig]
    void Run([In] [MarshalAs(UnmanagedType.IDispatch)] object TestObject, [In] [MarshalAs(UnmanagedType.Interface)] TestInputOutput TestIO, [In] bool bDebug);
    /// <summary>
    /// Activate the pane in the debugger and optionally set a breakpoint.
    /// </summary>
    [PreserveSig]
    void ActivatePane([In] bool bDebug);
}
