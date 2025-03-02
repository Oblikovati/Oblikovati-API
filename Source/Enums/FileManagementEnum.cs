namespace Oblikovati.API;

public enum FileManagementEnum {
	kNoForceFile,
	kForceFile,
	kOverwriteExistingFile,
	kOverwriteReservedFile,
	kOverwriteReadOnlyFile,
	kCopyFileMask,
	kDeleteFileMask,
	kMoveFileMask,
}
