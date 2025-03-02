namespace Oblikovati.API;

/// <summary>
/// The LoftRails object is used to define the rails and their conditions in a loft feature.
/// </summary>
public interface LoftRails : IEnumerable
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
    /// Method that returns the specified LoftRail object from the collection.
    /// </summary>
    LoftRail this[int Index] { get; }
    /// <summary>
    /// Property that specifies the number of LoftRail objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new LoftRail that represents a rail for a loft feature.
    /// </summary>
    /// <param name="Value">Input Object that defines a rail for a loft feature. Valid input objects for rails are Profile, Profile3D, EdgeLoop and EdgeCollection objects. The EdgeCollection object may contain either a single edge or a set of tangentially connected edges. Since all the rails for a loft must be either open or all closed, if the existing rails in the collection are open, then the rail specified using this argument must be open. Similarly, if the existing rails in the collection are closed, then the rail specified using this argument must be closed.</param>
    /// <param name="Condition">Optional input constant that defines the condition of the loft at the rail. Valid input is one of the following constants in LoftConditionEnum: kFreeLoftCondition, kTangentLoftCondition or kSmoothLoftCondition. If any other constant in LoftConditionEnum is specified, then the creation of the loft rail will fail. Since the condition is only applicable for a rail to which boundary conditions can be applied, the rail condition must not be specified using this argument if boundary conditions cannot be applied to the rail specified by the Rail argument, otherwise the creation of the loft rail will fail. If the rail is a rail to which boundary conditions can be applied and if no value is explicitly specified for this argument, then the default value of kFreeLoftCondition will be assumed.</param>
    /// <param name="Impact">Optional input Variant that defines the impact the rail's condition has on the shape of the entire loft. The value can be specified either as a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is \input, it is unitless. If a string is input it must resolve to a unitless value. Since the impact is only applicable for a rail to which the tangent or smooth condition can been applied, the impact value should be specified only if both of the following conditions are satisfied:
    /// The loft rail is a rail to which boundary conditions can be applied.
    /// The Condition argument is specified to be kTangentLoftCondition or kSmoothLoftCondition to indicate tangent or smooth condition.
    /// If any one or both of the above conditions are not satisfied and an impact value is specified, then this method will fail to create the loft rail. If both the conditions are satisfied and if no value is explicitly specified for this argument, then the default value of 0 will be assumed.</param>
    /// <returns></returns>
    [PreserveSig]
    LoftRail Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Value, [In] [MarshalAs(UnmanagedType.Struct)] object? Condition = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Impact = default);
}
