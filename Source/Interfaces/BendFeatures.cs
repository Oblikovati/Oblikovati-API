namespace Oblikovati.API;

/// <summary>
/// The BendFeatures collection object provides access to all of the objects in a sheet metal component definition. It"s also through the BendFeatures object that you create new BendFeature objects.
/// </summary>
public interface BendFeatures : IEnumerable
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
    /// Returns the specified BendFeature object from the collection. This is the default property of the BendFeatures collection object.
    /// </summary>
    BendFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new bend feature. The newly created BendFeature object is returned.
    /// </summary>
    /// <param name="BendDefinition">Input BendDefinition object that defines the bend feature you want to create. A BendDefinition object can be created using the BendFeatures.CreateBendDefinition method. It can also be obtained from an existing feature that has an associated bend.</param>
    /// <returns></returns>
    [PreserveSig]
    BendFeature Add([In] [MarshalAs(UnmanagedType.Interface)] BendDefinition BendDefinition);
    /// <summary>
    /// Method that creates a new BendDefinition object. This object is not a bend feature but contains the information that defines bend information and can be used to help create a new feature that contains bends or edit the bend of an existing feature.
    /// </summary>
    /// <param name="Edges">Input EdgeCollection object that defines the existing edges on the sheet metal part that you want to create bends for. The EdgeCollection can contain either one or two edges depending on the geometry where you want to apply the bend and the type of feature the definition is being used with. To best understand what's valid you should try creating the same feature interactively to see what edges can be selected to create a valid bend.</param>
    /// <returns></returns>
    [PreserveSig]
    BendDefinition CreateBendDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges);
}
