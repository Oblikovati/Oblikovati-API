namespace Oblikovati.API;

public interface IRxGeometricLocate
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pBoreline">pBoreline</param>
    /// <param name="dwNumTypes">dwNumTypes</param>
    /// <param name="pTypes">pTypes</param>
    /// <param name="ppEnumReferenceKey">ppEnumReferenceKey</param>
    void PointLocate([In] ref BoreLineStruct pBoreline, [In] uint dwNumTypes, [In] ref Guid pTypes, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumReferenceKeys ppEnumReferenceKey);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pShape">pShape</param>
    /// <param name="dwNumTypes">dwNumTypes</param>
    /// <param name="pTypes">pTypes</param>
    /// <param name="ppEnumReferenceKey">ppEnumReferenceKey</param>
    void ShapeLocate([In] ref SelectPrismStruct pShape, [In] uint dwNumTypes, [In] ref Guid pTypes, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumReferenceKeys ppEnumReferenceKey);
}
