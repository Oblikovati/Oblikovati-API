OblikovatiRootDirectory = os.getenv("OBLIKOVATI_DIR")

include (path.join(OblikovatiRootDirectory, "lib_vendor_source", "Coral", "Coral.Managed"))

project "Oblikovati-API"
	kind "SharedLib"
	language "C#"
	dotnetframework "net9.0"
	clr "Unsafe"
	targetdir "%{OblikovatiRootDirectory}/oblikovati_runtime/Resources/Scripts"
	objdir "%{OblikovatiRootDirectory}/oblikovati_runtime/Resources/Scripts/Intermediates"

	links {
		"Coral.Managed"
	}

	--vsprops {
	--	AppendTargetFrameworkToOutputPath = "false",
	--	Nullable = "enable",
	--	CopyLocalLockFileAssemblies = "true",
	--	EnableDynamicLoading = "true",
	--}

	files {
		"%{OblikovatiRootDirectory}/lib_internal_source/Oblikovati-API/source/**.cs",
	}