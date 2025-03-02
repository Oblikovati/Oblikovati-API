namespace Oblikovati.API;

/// <summary>
/// The CosmeticWeld object represents a cosmetic weld within an assembly. The CosmeticWeld object is derived from the Weld object.
/// </summary>
public interface CosmeticWeld
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Edges Edges { get; }
    /// <summary>
    /// Read-write property that gets and sets the definition object which defines the various inputs that were used to create the cosmetic weld.
    /// </summary>
    CosmeticWeldDefinition Definition { get; set; }
    /// <summary>
    /// Method that deletes the weld. The arguments allow control over which dependent objects are also deleted.
    /// </summary>
    /// <param name="RetainConsumedSketches">Optional input Boolean indicating if consumed sketches within the feature should be deleted. If the feature being deleted is not a sketch based feature this argument is ignored.</param>
    /// <param name="RetainDependentFeaturesAndSketches">Optional input Boolean that specifies if dependent features should be deleted. If there are no dependent features this argument is ignored.</param>
    /// <param name="RetainDependentWorkFeatures">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void Delete([In] bool? RetainConsumedSketches = false, [In] bool? RetainDependentFeaturesAndSketches = false, [In] bool? RetainDependentWorkFeatures = false);
}
