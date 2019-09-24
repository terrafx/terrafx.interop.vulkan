// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_layer.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkEnumerateInstanceLayerPropertiesChain
    {
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate VkResult _pfnNextLayer([NativeTypeName("const struct VkEnumerateInstanceLayerPropertiesChain *")] VkEnumerateInstanceLayerPropertiesChain* pNextLink, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        public VkResult CallDown([NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_pfnNextLayer>(pfnNextLayer)(pNextLink, pPropertyCount, pProperties);
        }
    }
}
