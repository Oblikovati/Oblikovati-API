namespace Oblikovati.API;

/// <summary>
/// DWGBlockDefinitionProxy Object.
/// </summary>
public interface DWGBlockDefinitionProxy
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the DWGArcsEnumerator collection object.
    /// </summary>
    DWGArcsEnumerator Arcs { get; }
    /// <summary>
    /// Read-only property that returns the DWGBlockReferencesEnumerator collection object.
    /// </summary>
    DWGBlockReferencesEnumerator BlockReferences { get; }
    /// <summary>
    /// Read-only property that returns the DWGEllipticalArcsEnumerator collection object.
    /// </summary>
    DWGEllipticalArcsEnumerator EllipticalArcs { get; }
    /// <summary>
    /// Read-only property that returns the DWGEntitiesEnumerator collection object.
    /// </summary>
    DWGEntitiesEnumerator Entities { get; }
    /// <summary>
    /// Read-only property that returns whether this DWGBlockDefinition is indicating the model space definition.
    /// </summary>
    bool IsModelSpaceDefinition { get; }
    /// <summary>
    /// Read-only property that returns the DWGLinesEnumerator collection object.
    /// </summary>
    DWGLinesEnumerator Lines { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ImportedDWGComponent Parent { get; }
    /// <summary>
    /// Read-only property that returns the DWGPointsEnumerator collection object.
    /// </summary>
    DWGPointsEnumerator Points { get; }
    /// <summary>
    /// Read-only property that returns the DWGPolylinesEnumerator collection object.
    /// </summary>
    DWGPolylinesEnumerator Polylines { get; }
    /// <summary>
    /// Read-only property that returns the DWGPolylines2DEnumerator collection object.
    /// </summary>
    DWGPolylines2DEnumerator Polylines2D { get; }
    /// <summary>
    /// Read-only property that returns the DWGPolylines3DEnumerator collection object.
    /// </summary>
    DWGPolylines3DEnumerator Polylines3D { get; }
    /// <summary>
    /// Read-only property that returns the DWGSplinesEnumerator collection object.
    /// </summary>
    DWGSplinesEnumerator Splines { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DWGACMStandardPartsEnumerator ACMStandardParts { get; }
    /// <summary>
    /// Read-only property that returns the DWGAcadSupportedProxiesEnumerator collection object.
    /// </summary>
    DWGAcadSupportedProxiesEnumerator AcadSupportedProxies { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGBlockDefinition NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
