namespace Oblikovati.API;

/// <summary>
/// FlatPatternOrientation Object.
/// </summary>
public interface FlatPatternOrientation
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    FlatPattern Parent { get; }
    /// <summary>
    /// Read-only property that returns the parameter object controlling the alignment rotation angle of flat pattern.
    /// </summary>
    Parameter AlignmentRotation { get; }
    /// <summary>
    /// Read-write property that gets and sets the alignment axis of flat pattern orientation.
    /// </summary>
    object AlignmentAxis { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the alignment type of flat pattern orientation.
    /// </summary>
    AlignmentTypeEnum AlignmentType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether alignment direction of flat pattern orientation is the opposite of the natural direction of the alignment axis.
    /// </summary>
    bool FlipAlignmentAxis { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to flip the flat pattern by swapping the top and bottom faces or not.
    /// </summary>
    bool FlipBaseFace { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name for the FlatPatternOrientation object.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Method that activates the FlatPatternOrientation object.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that creates a new FlatPatternOrientation by copying an existing FlatPatternOrientation object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FlatPatternOrientation Copy([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that deletes the FlatPatternOrientation object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
