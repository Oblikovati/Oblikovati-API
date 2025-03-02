OblikovatiRootDirectory = os.getenv("OBLIKOVATI_DIR")

project "Oblikovati.API"
	kind "SharedLib"
	language "C#"
	dotnetframework "net9.0"
	clr "Unsafe"
	targetdir "%{OblikovatiRootDirectory}/Oblikovati/Resources/Scripts"
	objdir "%{OblikovatiRootDirectory}/Oblikovati/Resources/Scripts/Intermediates"

	vsprops {
		AppendTargetFrameworkToOutputPath = "false",
		Nullable = "enable",
		CopyLocalLockFileAssemblies = "true",
		EnableDynamicLoading = "true",
	}

	files {
		"%{OblikovatiRootDirectory}/lib_internal_source/Oblikovati-API/source/**.cs",
	}