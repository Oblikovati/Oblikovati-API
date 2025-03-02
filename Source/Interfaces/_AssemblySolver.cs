namespace Oblikovati.API;

public interface _AssemblySolver
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Object">Object</param>
    [PreserveSig]
    _AssemblySolverNode FindSolverNode([In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
}
