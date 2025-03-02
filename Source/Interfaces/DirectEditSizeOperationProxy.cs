namespace Oblikovati.API;

/// <summary>
/// Part DirectEdit Size Operation Proxy Object.
/// </summary>
public interface DirectEditSizeOperationProxy
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the faces that are operated in the direct edit operation.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Gets the name of this direct edit operation within the scope of this Document.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the direct edit operation type.
    /// </summary>
    DirectEditOperationTypeEnum DirectEditOperationType { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    DirectEditFeature Parent { get; }
    /// <summary>
    /// Get the source object in the context of the definition instead of the containing assembly.
    /// </summary>
    DirectEditSizeOperation NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Delete this operation from the model.
    /// </summary>
    /// <param name="RetainConsumedSketches">Optional input Boolean indicating if consumed sketches within the feature should be deleted. If the feature being deleted is not a sketch based feature this argument is ignored.</param>
    /// <param name="RetainDependentFeaturesAndSketches">Optional input Boolean that specifies if dependent features should be deleted. If there are no dependent features this argument is ignored.</param>
    /// <param name="RetainDependentWorkFeatures">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void Delete([In] bool? RetainConsumedSketches = false, [In] bool? RetainDependentFeaturesAndSketches = false, [In] bool? RetainDependentWorkFeatures = false);
}
