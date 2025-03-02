namespace Oblikovati.API;

/// <summary>
/// The ASideFaceDefinitions collection object provides access to all of the ASideFaceDefinition objects in this sheet metal component definition and provides methods to create additional ASideFaceDefinition.
/// </summary>
public interface ASideDefinitions : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    SheetMetalComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ASideDefinition this[object Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new ASideFaceDefinition object with the input face.
    /// </summary>
    /// <param name="pInput">Input Face object to specify a face to create an A-side face definition on it.</param>
    /// <returns></returns>
    [PreserveSig]
    ASideDefinition Add([In] [MarshalAs(UnmanagedType.Interface)] Face pInput);
}
