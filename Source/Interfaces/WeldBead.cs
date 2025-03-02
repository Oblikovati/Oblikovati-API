namespace Oblikovati.API;

/// <summary>
/// The WeldBead object represents a weld bead within an assembly. The WeldBead object is derived from the Weld object.
/// </summary>
public interface WeldBead
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the name of the Weld.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the coordinate where the weld symbol attached to the weld geometry.
    /// </summary>
    Point SymbolAttachPoint { get; }
    /// <summary>
    /// Property that returns the coordinate where the weld symbol leader line break point is.
    /// </summary>
    Point SymbolBreakPoint { get; }
    /// <summary>
    /// Gets the weld description information as a String containing XML formatted data. For more information on XML formatting see More XML Weld Info...
    /// </summary>
    string WeldInfo { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the set of <link Inventor::Faces, Faces> that define the geometric result of the weld bead.
    /// </summary>
    Faces BeadFaces { get; }
    /// <summary>
    /// Gets the length of the weld bead.
    /// </summary>
    double BeadLength { get; }
    /// <summary>
    /// Gets the set of faces that define the ends of the weld bead.
    /// </summary>
    Faces EndFaces { get; }
    /// <summary>
    /// Gets the set of faces that define the sides of the weld bead.
    /// </summary>
    Faces SideFaces { get; }
    /// <summary>
    /// Returns the first set of faces the weld bead is on.
    /// </summary>
    Faces FaceSetOne { get; }
    /// <summary>
    /// Returns the second set of faces the weld bead is on.
    /// </summary>
    Faces FaceSetTwo { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsLegacyWeldBead { get; }
    /// <summary>
    /// Method that deletes the weld. The arguments allow control over which dependent objects are also deleted.
    /// </summary>
    /// <param name="RetainConsumedSketches">Optional input Boolean indicating if consumed sketches within the feature should be deleted. If the feature being deleted is not a sketch based feature this argument is ignored.</param>
    /// <param name="RetainDependentFeaturesAndSketches">Optional input Boolean that specifies if dependent features should be deleted. If there are no dependent features this argument is ignored.</param>
    /// <param name="RetainDependentWorkFeatures">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void Delete([In] bool? RetainConsumedSketches = false, [In] bool? RetainDependentFeaturesAndSketches = false, [In] bool? RetainDependentWorkFeatures = false);
}
