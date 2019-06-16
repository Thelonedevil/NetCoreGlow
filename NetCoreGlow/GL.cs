using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NetCoreGlow
{
    public static class GL
    {
        public const string GLFW_DLL = "glfw";
        [DllImport(GLFW_DLL, EntryPoint = "glfwInit")] public static extern bool Initialise();
        [DllImport(GLFW_DLL, EntryPoint = "glfwWindowHint")] public static extern void WindowHint(uint hint, uint value);
        [DllImport(GLFW_DLL, EntryPoint = "glfwCreateWindow")] public static extern IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);
        [DllImport(GLFW_DLL, EntryPoint = "glfwMakeContextCurrent")] public static extern void MakeContextCurrent(IntPtr window);
        [DllImport(GLFW_DLL, EntryPoint = "glfwSwapBuffers")] public static extern void SwapBuffers(IntPtr window);
        [DllImport(GLFW_DLL, EntryPoint = "glfwGetProcAddress")] public static extern IntPtr GetProcAddress(string procname);
        [DllImport(GLFW_DLL, EntryPoint = "glfwPollEvents")] public static extern void PollEvents();
        [DllImport(GLFW_DLL, EntryPoint = "glfwWindowShouldClose")] public static extern int WindowShouldClose(IntPtr window);

        public static GL11 GL11;
        public static GL12 GL12;
        public static GL13 GL13;
        public static GL14 GL14;
        public static GL15 GL15;
        public static GL20 GL20;
        public static GL21 GL21;
        public static GL30 GL30;
        public static GL31 GL31;
        public static GL32 GL32;
        public static GL33 GL33;
        public static GL40 GL40;
        public static GL42 GL42;
        public static GL43 GL43;
        public static GL44 GL44;
        public static GL45 GL45;
        public static GL46 GL46;

        private static void Initialise(uint majorVersion, uint minorVersion)
        {
            Initialise();
            WindowHint(0x00022002, majorVersion);
            WindowHint(0x00022003, minorVersion);
            WindowHint(0x00022008, 0x00032001);
            WindowHint(0x00022006, 1);
            WindowHint(0x00021005, 24);
            WindowHint(0x00020003, 0);
        }
        public static IntPtr Initialise(uint majorVersion,uint minorVersion,int width,int height) {
            Initialise(majorVersion, minorVersion);
            var window = CreateWindow(width, height, ".NET Core Graphics Example", IntPtr.Zero, IntPtr.Zero);
            MakeContextCurrent(window);
            var field = typeof(GL).GetField("GL" + majorVersion.ToString() + minorVersion.ToString(), System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            if(field == null)
            {
                throw new UnsupportedNetCoreGlowVersion(majorVersion + "." + minorVersion);
            }
            field.SetValue(null, Activator.CreateInstance(field.FieldType));
            ((IFunctionPointerHolder)field.GetValue(null)).LoadFunctionPointers();
            return window;
        }

        public static T GetMethod<T>()
        {
            var funcPtr = GetProcAddress(typeof(T).Name.Split('`')[0]);
            if (funcPtr == IntPtr.Zero)
            {
                Console.WriteLine($"Unable to load Function Pointer: {typeof(T).Name}");
                return default(T);
            }
            return Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
        }
    }
    public class UnsupportedNetCoreGlowVersion : Exception
    {
        public UnsupportedNetCoreGlowVersion(string version)
        {

        }
    }
    public interface IFunctionPointerHolder
    {
        void LoadFunctionPointers();
    }
}
