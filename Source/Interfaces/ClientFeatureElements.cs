namespace Oblikovati.API;

/// <summary>
/// Provides access to the composited elements within a ClientFeature and provides methods to add elements.
/// </summary>
public interface ClientFeatureElements : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified ClientFeatureElement object from the collection. This is the default method of the ClientFeatureElement collection object.
    /// </summary>
    ClientFeatureElement Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds an element to the client feature definition and returns a ClientFeatureElement object.
    /// </summary>
    /// <param name="Element">Input Object that specifies an object to add to the client feature. The input object must correspond to a node in the browser tree. This method fails if the input object is not adjacent to the client feature in the browser tree in the case where the client feature already composites certain elements. If the ClientFeature does not already composite any native object, the ClientFeature is moved to the position of the element in the browser. This can be a PartFeature, DerivedPartComponent, DerivedAssemblyComponent, iFeatureComponent, Sketch, Sketch3D, WorkPoint, WorkPlane, or a WorkAxis.</param>
    /// <param name="BrowserVisible">Optional input Boolean that indicates whether this element is visible in the browser under the client feature node. If not specified, the argument defaults to False.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientFeatureElement Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Element, [In] bool? BrowserVisible = false);
}
