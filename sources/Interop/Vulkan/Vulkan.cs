// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    public static event DllImportResolver? ResolveLibrary;

    static Vulkan()
    {
        if (!Configuration.DisableResolveLibraryHook)
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
        }
    }

    private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (TryResolveLibrary(libraryName, assembly, searchPath, out var nativeLibrary))
        {
            return nativeLibrary;
        }

        if (libraryName.Equals("vulkan", StringComparison.OrdinalIgnoreCase) && TryResolveVulkan(assembly, searchPath, out nativeLibrary))
        {
            return nativeLibrary;
        }

        return IntPtr.Zero;
    }

    private static bool TryResolveVulkan(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (NativeLibrary.TryLoad("vulkan-1", assembly, searchPath, out nativeLibrary))
            {
                return true;
            }

            if (NativeLibrary.TryLoad("vulkan", assembly, searchPath, out nativeLibrary))
            {
                return true;
            }
        }
        else
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (NativeLibrary.TryLoad("libvulkan.so.1.4.328.1", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }

                if (NativeLibrary.TryLoad("vulkan.so.1", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                if (NativeLibrary.TryLoad("libvulkan.1.4.328.1.dylib", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }

                if (NativeLibrary.TryLoad("libvulkan.1.dylib", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }

            if (NativeLibrary.TryLoad("libvulkan", assembly, searchPath, out nativeLibrary))
            {
                return true;
            }
        }

        return false;
    }

    private static bool TryResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
    {
        var resolveLibrary = ResolveLibrary;

        if (resolveLibrary != null)
        {
            var resolvers = resolveLibrary.GetInvocationList();

            foreach (DllImportResolver resolver in resolvers)
            {
                nativeLibrary = resolver(libraryName, assembly, searchPath);

                if (nativeLibrary != IntPtr.Zero)
                {
                    return true;
                }
            }
        }

        nativeLibrary = IntPtr.Zero;
        return false;
    }
}
