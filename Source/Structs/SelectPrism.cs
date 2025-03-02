namespace Oblikovati.API;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct SelectPrism
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public double[] m_point;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public double[] m_direction;
	public double m_front;
	public double m_back;
	public uint m_nPoints;
	[ComConversionLoss]
	public IntPtr m_pPoints;
	public uint m_type;
}
