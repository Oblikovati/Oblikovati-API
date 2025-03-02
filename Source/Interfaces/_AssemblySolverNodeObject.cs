namespace Oblikovati.API;

public interface _AssemblySolverNodeObject
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
    _AssemblySolver Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SolvedAsRigid { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Node">Node</param>
    [PreserveSig]
    void AddDependency([In] [MarshalAs(UnmanagedType.Interface)] _AssemblySolverNode Node);
}
