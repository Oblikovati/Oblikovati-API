namespace Oblikovati.API;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct BoreLineStruct
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public double[] m_point;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public double[] m_direction;
	public double m_front;
	public double m_back;
	public double m_radius;
}
