namespace Oblikovati.API;

/// <summary>
/// The MeasureTools object provides methods for various measurement related utilities.
/// </summary>
public interface MeasureTools
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
    /// Property that returns the parent object. It can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServerComponent' when running with the Apprentice Server.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityOne">EntityOne</param>
    /// <param name="EntityTwo">EntityTwo</param>
    /// <param name="EntityOneInferredType">EntityOneInferredType</param>
    /// <param name="EntityTwoInferredType">EntityTwoInferredType</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    double GetMinimumDistance([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] InferredTypeEnum? EntityOneInferredType = InferredTypeEnum.kNoInference);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityOne">EntityOne</param>
    /// <param name="EntityTwo">EntityTwo</param>
    /// <param name="EntityOneInferredType">EntityOneInferredType</param>
    /// <param name="EntityTwoInferredType">EntityTwoInferredType</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    double GetMinimumDistance([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] InferredTypeEnum EntityOneInferredType, [In] InferredTypeEnum EntityTwoInferredType, [In] [Out] [MarshalAs(UnmanagedType.Struct)] ref object Context);
    /// <summary>
    /// Method that returns the angle between the input entities. The input entities must all belong to the same document, unless they are transient objects.
    /// </summary>
    /// <param name="EntityOne">Object that specifies the first entity. Valid inputs include Face, Edge, Vertex, transient objects (Point, Plane, Cylinder, etc.), work features, 2d and 3d sketch entities, DrawingViewCurve and GeometryIntent objects. Proxy object inputs are supported for assembly documents. For spherical and circular entity inputs, the center is assumed. For cylindrical and conical inputs, the axis is assumed. For toroidal inputs, the axis is assumed, unless the third argument of the method is also supplied in which case the center is assumed. For position inputs (such as Vertex, WorkPoint, Point, etc.) to be valid, all three inputs to the method should be supplied and they must all be position inputs (this implies a 3-point angle measurement).</param>
    /// <param name="EntityTwo">Input object that specifies the second entity. Valid inputs include Face, Edge, Vertex, transient objects (Point, Plane, Cylinder, etc.), work features, 2d and 3d sketch entities, DrawingViewCurve and GeometryIntent objects. Proxy object inputs are supported for assembly documents. For spherical and circular entity inputs, the center is assumed. For cylindrical and conical inputs, the axis is assumed. For toroidal inputs, the axis is assumed, unless the third argument of the method is also supplied in which case the center is assumed. For position inputs (such as Vertex, WorkPoint, Point, etc.) to be valid, all three inputs to the method should be supplied and they must all be position inputs (this implies a 3-point angle measurement).</param>
    /// <param name="EntityThree">Optional input object that specifies the third entity for a 3-point angle measurement. Valid inputs include spherical & toroidal Face, Vertex, transient objects defining a position (Point, Sphere, etc.), work points, 2d & 3d sketch points, and GeometryIntent objects. Proxy object inputs are supported for assembly documents.</param>
    /// <returns></returns>
    [PreserveSig]
    double GetAngle([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? EntityThree = default);
    /// <summary>
    /// Method that returns the total length of a loop.
    /// </summary>
    /// <param name="Curves">Object that specifies the loop. Valid inputs are:
    /// An Edge object
    /// A 2d/3d sketch curve (SketchLine, SketchArc, etc.) (For the above inputs, the method returns the length of the loop that the input entity is a part of (whether open or closed). Based on the input, the method looks for a unique closed loop or a unique open loop (in that order). If one is found, the length is returned else the method returns an error.)
    /// An ObjectCollection containing Edge objects or 2d/3d sketch curve objects. (The collection can contain all the elements of a loop or must contain enough number of elements to uniquely identify a loop. Else the method returns an error. Also, the input curves must be end to end connected and in order.)
    /// An EdgeLoop object
    /// A ProfilePath object
    /// A ProfilePath3D object</param>
    /// <returns></returns>
    [PreserveSig]
    double GetLoopLength([In] [MarshalAs(UnmanagedType.IDispatch)] object Curves);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    int GetAnglePrecision([In] [MarshalAs(UnmanagedType.Interface)] _Document Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="Precision">Precision</param>
    [PreserveSig]
    int SetAnglePrecision([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] int Precision);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    int GetLengthPrecision([In] [MarshalAs(UnmanagedType.Interface)] _Document Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="Precision">Precision</param>
    [PreserveSig]
    int SetLengthPrecision([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] int Precision);
}
