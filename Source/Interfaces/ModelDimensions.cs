namespace Oblikovati.API;

/// <summary>
/// The ModelDimensions collection object provides access to all of the model dimensions in a part or assembly.
/// </summary>
public interface ModelDimensions : IEnumerable
{
    /// <summary>
    /// Read-only property that returns a collection providing access to the existing angular dimensions and provides functionality to create new angular dimensions.
    /// </summary>
    AngularModelDimensions AngularModelDimensions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns a collection providing access to the existing diameter dimensions and provides functionality to create new diameter dimensions.
    /// </summary>
    DiameterModelDimensions DiameterModelDimensions { get; }
    /// <summary>
    /// Read-only property that returns a collection providing access to the existing linear dimensions and provides functionality to create new linear dimensions.
    /// </summary>
    LinearModelDimensions LinearModelDimensions { get; }
    /// <summary>
    /// Read-only property that returns a collection providing access to the existing radial dimensions and provides functionality to create new radial dimensions.
    /// </summary>
    RadiusModelDimensions RadiusModelDimensions { get; }
    /// <summary>
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    ModelDimension Item { get; }
    /// <summary>
    /// Read-only property returning kModelDimensionsObject indicating this objects type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that promotes a dimension constraint to ModelDimension.
    /// </summary>
    /// <param name="pDimConstr">Input dimension constraint object to be promoted as model dimension. Valid object is DimensionConstraint.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDimension PromoteFrom([In] [MarshalAs(UnmanagedType.IDispatch)] object pDimConstr);
}
