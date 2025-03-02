namespace Oblikovati.API;

/// <summary>
/// Partial Chamfer edges object.
/// </summary>
public interface PartialChamferEdges : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PartialChamferEdge this[int Index] { get; }
    /// <summary>
    /// Gets and sets which&nbsp;partial chamfer dimension is driven dimension.
    /// </summary>
    PartialChamferDrivenDimensionTypeEnum DrivenDimensionType { get; set; }
    /// <summary>
    /// Adds an item to the collection.
    /// </summary>
    /// <param name="Edge">Input Edge or EdgeCollection object that specifies the which Edge or Edge chain to be partially chamfered. If the AutomaticEdgeChain is True and an Edge is input the Edge chain will be used if there is an Edge chain connected with the Edge.</param>
    /// <param name="Start">Input value that specifies the start of the Edge or Edge chain to be partially chamfered. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="End">Input value that specifies the end of the Edge or Edge chain to be partially chamfered. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    PartialChamferEdge Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Edge, [In] [MarshalAs(UnmanagedType.Struct)] object Start, [In] [MarshalAs(UnmanagedType.Struct)] object End);
}
