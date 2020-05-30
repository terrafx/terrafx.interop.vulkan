// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        public static event DllImportResolver? ResolveLibrary;

        static Vulkan()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
        }

        private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            IntPtr nativeLibrary;

            if (TryResolveLibrary(libraryName, assembly, searchPath, out nativeLibrary))
            {
                return nativeLibrary;
            }

            if (libraryName.Equals("vulkan") && TryResolveVulkan(assembly, searchPath, out nativeLibrary))
            {
                return nativeLibrary;
            }

            return IntPtr.Zero;
        }

        private static bool TryResolveVulkan(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (NativeLibrary.TryLoad("vulkan", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }

                if (NativeLibrary.TryLoad("vulkan-1", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }
            else
            {
                if (NativeLibrary.TryLoad("libvulkan", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    if (NativeLibrary.TryLoad("vulkan.so.1", assembly, searchPath, out nativeLibrary))
                    {
                        return true;
                    }

                    if (NativeLibrary.TryLoad("libvulkan.so.1.2.135", assembly, searchPath, out nativeLibrary))
                    {
                        return true;
                    }
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    if (NativeLibrary.TryLoad("libvulkan.1.dylib", assembly, searchPath, out nativeLibrary))
                    {
                        return true;
                    }

                    if (NativeLibrary.TryLoad("libvulkan.1.2.135.dylib", assembly, searchPath, out nativeLibrary))
                    {
                        return true;
                    }
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
}
