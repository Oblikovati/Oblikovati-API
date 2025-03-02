namespace Oblikovati.API;

/// <summary>
/// The object represented the base solid that was created when a file was imported into Autodesk Inventor.
/// </summary>
public interface NonParametricBaseFeatures : IEnumerable
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
    /// Returns the specified NonParametricBaseFeature object from the collection.
    /// </summary>
    NonParametricBaseFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a NonParametricBaseFeature to the collection.
    /// </summary>
    /// <param name="SurfaceBody">Input SurfaceBody to create the new NonParametricBaseFeature in the collection.</param>
    /// <param name="Transform">Optional input Variant that specifies the transformation for the new NonParametricBaseFeature in the collection.</param>
    /// <returns></returns>
    [PreserveSig]
    NonParametricBaseFeature Add([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody SurfaceBody, [In] [MarshalAs(UnmanagedType.Struct)] object? Transform = default);
    /// <summary>
    /// Method that creates a new NonParametricBaseFeature object.
    /// </summary>
    /// <param name="Definition">Input NonParametricBaseFeatureDefinition object that defines all of the input required to create a non-parametric base feature. A NonParametricBaseFeatureDefinition object is created using the CreateDefinition method of the NonParametricBaseFeatures collection object.</param>
    /// <returns></returns>
    [PreserveSig]
    NonParametricBaseFeature AddByDefinition([In] [MarshalAs(UnmanagedType.Interface)] NonParametricBaseFeatureDefinition Definition);
    /// <summary>
    /// Method that creates and returns a NonParametricBaseFeatureDefinition object. This object is not a non-parametric base feature but contains the information that defines one and be used to create a new non-parametric base feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    NonParametricBaseFeatureDefinition CreateDefinition();
}
