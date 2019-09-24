namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSurfaceKHR")]
        public ulong surface;
    }
}
