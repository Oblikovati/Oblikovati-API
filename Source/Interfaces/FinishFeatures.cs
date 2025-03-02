namespace Oblikovati.API;

/// <summary>
/// Finish Features Object.
/// </summary>
public interface FinishFeatures : IEnumerable
{
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    FinishFeature this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Method that creates a new finish feature. The newly created FinishFeature object is returned.
    /// </summary>
    /// <param name="pDefinition">Input FinishDefinition object that defines the finish feature you want to create.  An FinishDefinition object can be created using the FinishFeatures.CreateFinishDefinition method.  It can also be obtained from an existing FinishFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    FinishFeature Add([In] [MarshalAs(UnmanagedType.Interface)] FinishDefinition pDefinition);
    /// <summary>
    /// Method that creates a new FinishDefinition object. The object created does not represent a finish feature but instead is a representation of the information that defines a finish feature. You can use this object as input to the FinishFeatures.Add method to cre.
    /// </summary>
    /// <param name="pInputFaces">Input FaceCollection object that specifies the faces to create finish feature.</param>
    /// <param name="FinishType">Input FinishTypeEnum value that specifies finish type.</param>
    /// <param name="vtProcessName">Optional  input String value that specifies finish process name.</param>
    /// <param name="vtAppearance">Optional input Asset object that specifies finish appearance.</param>
    /// <returns></returns>
    [PreserveSig]
    FinishDefinition CreateFinishDefinition([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection pInputFaces, [In] FinishTypeEnum FinishType, [In] [MarshalAs(UnmanagedType.Struct)] object? vtProcessName = default, [In] [MarshalAs(UnmanagedType.Struct)] object? vtAppearance = default);
}
