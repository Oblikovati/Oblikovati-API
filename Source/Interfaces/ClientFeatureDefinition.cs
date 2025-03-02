namespace Oblikovati.API;

/// <summary>
/// The ClientFeatureDefinition object is used to define and query all the inputs of a ClientFeature.
/// </summary>
public interface ClientFeatureDefinition
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
    /// Property that returns the parent ClientFeature object. The property returns Nothing in the forward create scenario (i.e. when the object is created using ClientFeatures.CreateDefinition method).
    /// </summary>
    ClientFeature Parent { get; }
    /// <summary>
    /// Property that returns the ClientFeatureElements collection object that defines the Inventor objects composited by this feature.
    /// </summary>
    ClientFeatureElements ClientFeatureElements { get; }
    /// <summary>
    /// Property that defines the naming of the client feature in the browser. This property returns a non-localized string supplied during the creation.
    /// </summary>
    string FeatureType { get; }
    /// <summary>
    /// Property that returns the ClientGraphicsCollection object. These graphics are persisted with the document.
    /// </summary>
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    /// <summary>
    /// Read-write property that gets and sets the objects that are inputs to the client feature.
    /// </summary>
    ObjectCollection FeatureInputs { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsCustomSolved { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether client graphics owned by this feature should be pre-highlighted, highlighted or selected with the client feature.
    /// </summary>
    bool HighlightClientGraphicsWithFeature { get; set; }
    /// <summary>
    /// Read-only property that returns the GraphicsDataSetsCollection object.
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Method that adds an upstream Oblikovati object as a dependency of the client feature.
    /// </summary>
    /// <param name="Dependency">Input Object that specifies the dependency. This can be any of the following: Parameter, PartFeature, Sketch, Sketch3D, WorkPlane, WorkPoint, WorkAxis, DerivedPartComponent and DerivedAssemblyComponent. If a Parameter is input, the parameter is deleted when the client feature is deleted (unless the parameter has dependents other than the client feature).</param>
    [PreserveSig]
    void AddDependency([In] [MarshalAs(UnmanagedType.IDispatch)] object Dependency);
    /// <summary>
    /// Method that removes a dependency of the client feature.
    /// </summary>
    /// <param name="Dependency">Input Object that specifies the dependency. This can be any of the following: Parameter, PartFeature, Sketch, Sketch3D, WorkPlane, WorkPoint, WorkAxis, DerivedPartComponent and DerivedAssemblyComponent.</param>
    [PreserveSig]
    void RemoveDependency([In] [MarshalAs(UnmanagedType.IDispatch)] object Dependency);
}
