// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, [NativeTypeName("const VkImagePipeSurfaceCreateInfoFUCHSIA *")] VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, [NativeTypeName("const VkMemoryGetZirconHandleInfoFUCHSIA *")] VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [NativeTypeName("zx_handle_t *")] uint* pZirconHandle);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, [NativeTypeName("VkExternalMemoryHandleTypeFlagBits")] VkExternalMemoryHandleTypeFlags handleType, [NativeTypeName("zx_handle_t")] uint zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, [NativeTypeName("const VkImportSemaphoreZirconHandleInfoFUCHSIA *")] VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, [NativeTypeName("const VkSemaphoreGetZirconHandleInfoFUCHSIA *")] VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [NativeTypeName("zx_handle_t *")] uint* pZirconHandle);

        [NativeTypeName("#define VK_FUCHSIA_imagepipe_surface 1")]
        public const int VK_FUCHSIA_imagepipe_surface = 1;

        [NativeTypeName("#define VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION 1")]
        public const int VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME \"VK_FUCHSIA_imagepipe_surface\"")]
        public static ReadOnlySpan<byte> VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x46, 0x55, 0x43, 0x48, 0x53, 0x49, 0x41, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x70, 0x69, 0x70, 0x65, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_FUCHSIA_external_memory 1")]
        public const int VK_FUCHSIA_external_memory = 1;

        [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_FUCHSIA_EXTERNAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_FUCHSIA_external_memory\"")]
        public static ReadOnlySpan<byte> VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x46, 0x55, 0x43, 0x48, 0x53, 0x49, 0x41, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_FUCHSIA_external_semaphore 1")]
        public const int VK_FUCHSIA_external_semaphore = 1;

        [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_SEMAPHORE_SPEC_VERSION 1")]
        public const int VK_FUCHSIA_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME \"VK_FUCHSIA_external_semaphore\"")]
        public static ReadOnlySpan<byte> VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x46, 0x55, 0x43, 0x48, 0x53, 0x49, 0x41, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x00 };
    }
}
