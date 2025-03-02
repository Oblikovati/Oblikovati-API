namespace Oblikovati.API;

public interface IStream : ISequentialStream
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="dlibMove">dlibMove</param>
    /// <param name="dwOrigin">dwOrigin</param>
    /// <param name="plibNewPosition">plibNewPosition</param>
    void RemoteSeek([In] _LARGE_INTEGER dlibMove, [In] uint dwOrigin, [Out] out _ULARGE_INTEGER plibNewPosition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="libNewSize">libNewSize</param>
    void SetSize([In] _ULARGE_INTEGER libNewSize);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pstm">pstm</param>
    /// <param name="cb">cb</param>
    /// <param name="pcbRead">pcbRead</param>
    /// <param name="pcbWritten">pcbWritten</param>
    void RemoteCopyTo([In] [MarshalAs(UnmanagedType.Interface)] IStream pstm, [In] _ULARGE_INTEGER cb, [Out] out _ULARGE_INTEGER pcbRead, [Out] out _ULARGE_INTEGER pcbWritten);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="grfCommitFlags">grfCommitFlags</param>
    void Commit([In] uint grfCommitFlags);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Revert();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="libOffset">libOffset</param>
    /// <param name="cb">cb</param>
    /// <param name="dwLockType">dwLockType</param>
    void LockRegion([In] _ULARGE_INTEGER libOffset, [In] _ULARGE_INTEGER cb, [In] uint dwLockType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="libOffset">libOffset</param>
    /// <param name="cb">cb</param>
    /// <param name="dwLockType">dwLockType</param>
    void UnlockRegion([In] _ULARGE_INTEGER libOffset, [In] _ULARGE_INTEGER cb, [In] uint dwLockType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pstatstg">pstatstg</param>
    /// <param name="grfStatFlag">grfStatFlag</param>
    void Stat([Out] out tagSTATSTG pstatstg, [In] uint grfStatFlag);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppstm">ppstm</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IStream ppstm);
}
