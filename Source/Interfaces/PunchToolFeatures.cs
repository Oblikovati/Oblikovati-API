namespace Oblikovati.API;

/// <summary>
/// The PunchToolFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface PunchToolFeatures : IEnumerable
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
    /// Returns the specified PunchToolFeature object from the collection. This is the default property of the PunchToolFeatures collection object.
    /// </summary>
    PunchToolFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PunchCenterPoints">PunchCenterPoints</param>
    /// <param name="Definition">Definition</param>
    /// <param name="Angle">Angle</param>
    [PreserveSig]
    PunchToolFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PunchCenterPoints, [In] [MarshalAs(UnmanagedType.Interface)] iFeatureDefinition Definition, [In] [MarshalAs(UnmanagedType.Struct)] object? Angle = default);
    /// <summary>
    /// Creates a new PunchToolFeature using the input placement information.
    /// </summary>
    /// <param name="PunchCenterPoints">Input ObjectCollection of SketchPoint objects that define the placement position(s) of the punch tool. All of the supplied SketchPoint objects must be owned by the same sketch.</param>
    /// <param name="Definition">Input iFeatureDefinition object used to define the various input required for the placement of a PunchToolFeature. Appropriate input must be defined in the iFeatureDefinition object in order to place the punch tool.</param>
    /// <param name="Angle">Optional Input Variant that defines the placement angle of the punch tool. If not supplied, the punch tool will be placed with a rotation angle of zero. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="AcrossBends">Input Boolean specifies whether the punch tool feature goes across bends or not.</param>
    /// <returns></returns>
    [PreserveSig]
    PunchToolFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PunchCenterPoints, [In] [MarshalAs(UnmanagedType.Interface)] iFeatureDefinition Definition, [In] [MarshalAs(UnmanagedType.Struct)] object? Angle = default, [In] bool? AcrossBends = false);
    /// <summary>
    /// Method that creates a new iFeatureDefinition.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the name of the iFeature file (.ide) to create the definition for. The file must be an existing iFeature file. If an invalid file is specified an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    iFeatureDefinition CreateiFeatureDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
