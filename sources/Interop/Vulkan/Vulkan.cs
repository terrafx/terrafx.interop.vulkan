// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        private const string libraryPath = "vulkan";

        static Vulkan()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), ResolveLibrary);
        }

        private static IntPtr ResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return NativeLibrary.Load("vulkan-1.dll", assembly, searchPath);
            }
            else
            {
                return NativeLibrary.Load("libvulkan.so.1", assembly, searchPath);
            }
        }
    }
}
