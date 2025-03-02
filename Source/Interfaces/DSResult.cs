namespace Oblikovati.API;

/// <summary>
/// The DSResult object represents a specific result from a degree of freedom.
/// </summary>
public interface DSResult
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent degree of freedom that this results object is associated with.
    /// </summary>
    DSDegreeOfFreedom Parent { get; }
    /// <summary>
    /// Gets the name of this result as it is displayed in the Output Grapher dialog.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the type of result this DSResult object represents.
    /// </summary>
    DSResultTypeEnum ResultType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ResultValues">ResultValues</param>
    [PreserveSig]
    void GetResultValues([In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] ResultValues);
    /// <summary>
    /// Returns the value of the current result.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    double GetCurrentResultValue();
}
