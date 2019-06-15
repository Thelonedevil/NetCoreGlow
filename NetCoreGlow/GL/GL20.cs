using System;
using System.Runtime.InteropServices;

namespace NetCoreGlow
{
    public class GL20 : GL15
    {

        public readonly uint SHADING_LANGUAGE_VERSION = 0x8B8C;

        public readonly uint CURRENT_PROGRAM = 0x8B8D;

        public readonly uint
            SHADER_TYPE = 0x8B4F,
            DELETE_STATUS = 0x8B80,
            COMPILE_STATUS = 0x8B81,
            LINK_STATUS = 0x8B82,
            VALIDATE_STATUS = 0x8B83,
            INFO_LOG_LENGTH = 0x8B84,
            ATTACHED_SHADERS = 0x8B85,
            ACTIVE_UNIFORMS = 0x8B86,
            ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87,
            ACTIVE_ATTRIBUTES = 0x8B89,
            ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A,
            SHADER_SOURCE_LENGTH = 0x8B88;

        public readonly uint
            FLOAT_VEC2 = 0x8B50,
            FLOAT_VEC3 = 0x8B51,
            FLOAT_VEC4 = 0x8B52,
            INT_VEC2 = 0x8B53,
            INT_VEC3 = 0x8B54,
            INT_VEC4 = 0x8B55,
            BOOL = 0x8B56,
            BOOL_VEC2 = 0x8B57,
            BOOL_VEC3 = 0x8B58,
            BOOL_VEC4 = 0x8B59,
            FLOAT_MAT2 = 0x8B5A,
            FLOAT_MAT3 = 0x8B5B,
            FLOAT_MAT4 = 0x8B5C,
            SAMPLER_1D = 0x8B5D,
            SAMPLER_2D = 0x8B5E,
            SAMPLER_3D = 0x8B5F,
            SAMPLER_CUBE = 0x8B60,
            SAMPLER_1D_SHADOW = 0x8B61,
            SAMPLER_2D_SHADOW = 0x8B62;

        public readonly uint VERTEX_SHADER = 0x8B31;

        public readonly uint
            MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A,
            MAX_VARYING_FLOATS = 0x8B4B,
            MAX_VERTEX_ATTRIBS = 0x8869,
            MAX_TEXTURE_IMAGE_UNITS = 0x8872,
            MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C,
            MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

        public readonly uint VERTEX_PROGRAM_POINT_SIZE = 0x8642;

        public readonly uint
            VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622,
            VERTEX_ATTRIB_ARRAY_SIZE = 0x8623,
            VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624,
            VERTEX_ATTRIB_ARRAY_TYPE = 0x8625,
            VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,
            CURRENT_VERTEX_ATTRIB = 0x8626;

        public readonly uint VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

        public readonly uint FRAGMENT_SHADER = 0x8B30;

        public readonly uint MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

        public readonly uint FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

        public readonly uint
            MAX_DRAW_BUFFERS = 0x8824,
            DRAW_BUFFER0 = 0x8825,
            DRAW_BUFFER1 = 0x8826,
            DRAW_BUFFER2 = 0x8827,
            DRAW_BUFFER3 = 0x8828,
            DRAW_BUFFER4 = 0x8829,
            DRAW_BUFFER5 = 0x882A,
            DRAW_BUFFER6 = 0x882B,
            DRAW_BUFFER7 = 0x882C,
            DRAW_BUFFER8 = 0x882D,
            DRAW_BUFFER9 = 0x882E,
            DRAW_BUFFER10 = 0x882F,
            DRAW_BUFFER11 = 0x8830,
            DRAW_BUFFER12 = 0x8831,
            DRAW_BUFFER13 = 0x8832,
            DRAW_BUFFER14 = 0x8833,
            DRAW_BUFFER15 = 0x8834;

        public readonly uint POINT_SPRITE_COORD_ORIGIN = 0x8CA0;

        public readonly uint
            LOWER_LEFT = 0x8CA1,
            UPPER_LEFT = 0x8CA2;

        public readonly uint
            BLEND_EQUATION_RGB = 0x8009,
            BLEND_EQUATION_ALPHA = 0x883D;

        public readonly uint
            STENCIL_BACK_FUNC = 0x8800,
            STENCIL_BACK_FAIL = 0x8801,
            STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802,
            STENCIL_BACK_PASS_DEPTH_PASS = 0x8803,
            STENCIL_BACK_REF = 0x8CA3,
            STENCIL_BACK_VALUE_MASK = 0x8CA4,
            STENCIL_BACK_WRITEMASK = 0x8CA5;


        public delegate void glDrawArrays(uint mode, int first, int count);
        public delegate void glDrawElements(uint mode, int count, int type, int offset);
        public delegate void glGenBuffers(int n, ref uint buffers);
        public delegate void glBindBuffer(uint target, uint buffer);
        public delegate void glBufferData(uint target, IntPtr size, [MarshalAs(UnmanagedType.AsAny)]object data, uint usage);
        public delegate void glEnable(uint cap);
        public delegate void glDepthMask(bool flag);
        public delegate void glDisable(uint cap);
        public delegate void glEnableVertexAttribArray(uint index);
        public delegate void glVertexAttribPointer(uint index, int size, uint type, bool normalized, IntPtr stride, IntPtr pointer);
        public delegate void glClearColor(float r, float g, float b, float a);
        public delegate void glClear(uint mask);
        public delegate void glShaderSource(uint shader, uint count, ref string source, IntPtr ptr);
        public delegate uint glCreateShader(uint shaderType);
        public delegate void glCompileShader(uint shader);
        public delegate uint glCreateProgram();
        public delegate void glAttachShader(uint program, uint shader);
        public delegate void glLinkProgram(uint program);
        public delegate void glUseProgram(uint program);
        public delegate uint glGetAttribLocation(uint program, string name);
        public delegate void glUniform3f(uint location, float x, float y, float z);
        public delegate void glUniform1i(uint location, int i);
        public delegate void glUniformMatrix4fv(uint location, int count, bool transpose, float[] value);
        public delegate void glGenTextures(int n, uint[] textures);
        public delegate void glBindTexture(uint target, uint texture);
        public delegate void glTexImage2D(uint target, int level, uint internalFormat, int width, int height, int border, uint format, uint type, [MarshalAs(UnmanagedType.AsAny)] object data);
        public delegate void glGetShaderInfoLog(uint shader, int maxLength, IntPtr length, ref string infoLog);
        public delegate void glActiveTexture(uint texture);
        public delegate void glStencilFunc(uint func, int @ref, int mask);
        public delegate void glStencilOp(uint sfail, uint dpfail, uint dppass);
        public delegate void glStencilMask(uint mask);
        public delegate uint glGetUniformLocation(uint program, string uniform);
        public delegate void glTexParameteri(uint target, uint pname, uint param);

        public glDrawArrays DrawArrays { get; private set; }
        public glDrawElements DrawElements { get; private set; }
        public glGenBuffers GenBuffers { get; private set; }
        public glBindBuffer BindBuffer { get; private set; }
        public glBufferData BufferData { get; private set; }
        public glEnableVertexAttribArray EnableVertexAttribArray { get; private set; }
        public glVertexAttribPointer VertexAttribPointer { get; private set; }
        public glClearColor ClearColor { get; private set; }
        public glClear Clear { get; private set; }
        public glCreateShader CreateShader { get; private set; }
        public glShaderSource ShaderSource { get; private set; }
        public glCompileShader CompileShader { get; private set; }
        public glCreateProgram CreateProgram { get; private set; }
        public glAttachShader AttachShader { get; private set; }
        public glLinkProgram LinkProgram { get; private set; }
        public glUseProgram UseProgram { get; private set; }
        public glGetAttribLocation GetAttribLocation { get; private set; }
        public glGetUniformLocation GetUniformLocation { get; private set; }
        public glUniform3f Uniform3f { get; private set; }
        public glGenTextures GenTextures { get; private set; }
        public glBindTexture BindTexture { get; private set; }
        public glTexImage2D TexImage2D { get; private set; }
        public glGetShaderInfoLog GetShaderInfoLog { get; private set; }
        public glTexParameteri TexParameteri { get; private set; }
        public glUniformMatrix4fv UniformMatrix4fv { get; private set; }
        public glActiveTexture ActiveTexture { get; private set; }
        public glUniform1i Uniform1i { get; private set; }
        public glEnable Enable { get; private set; }
        public glDisable Disable { get; private set; }
        public glDepthMask DepthMask { get; private set; }
        public glStencilFunc StencilFunc { get; private set; }
        public glStencilOp StencilOp { get; private set; }
        public glStencilMask StencilMask { get; private set; }
        public uint NewShader(uint type, string path)
        {
            uint shader = CreateShader(type);
            string fragmentSource = System.IO.File.ReadAllText(path);
            ShaderSource(shader, 1, ref fragmentSource, IntPtr.Zero);
            CompileShader(shader);
            return shader;
        }
        public uint NewShaderProgram(params uint[] shaders)
        {
            uint shaderProgram = CreateProgram();
            foreach (var shader in shaders)
            {
                AttachShader(shaderProgram, shader);
            }
            LinkProgram(shaderProgram);
            return shaderProgram;
        }
        public override void LoadFunctionPointers()
        {
            base.LoadFunctionPointers();
            DrawArrays = GL.GetMethod<glDrawArrays>();
            DrawElements = GL.GetMethod<glDrawElements>();
            GenBuffers = GL.GetMethod<glGenBuffers>();
            BindBuffer = GL.GetMethod<glBindBuffer>();
            BufferData = GL.GetMethod<glBufferData>();
            EnableVertexAttribArray = GL.GetMethod<glEnableVertexAttribArray>();
            VertexAttribPointer = GL.GetMethod<glVertexAttribPointer>();
            ClearColor = GL.GetMethod<glClearColor>();
            Clear = GL.GetMethod<glClear>();
            CreateShader = GL.GetMethod<glCreateShader>();
            ShaderSource = GL.GetMethod<glShaderSource>();
            CompileShader = GL.GetMethod<glCompileShader>();
            CreateProgram = GL.GetMethod<glCreateProgram>();
            AttachShader = GL.GetMethod<glAttachShader>();
            LinkProgram = GL.GetMethod<glLinkProgram>();
            UseProgram = GL.GetMethod<glUseProgram>();
            GetAttribLocation = GL.GetMethod<glGetAttribLocation>();
            GetUniformLocation = GL.GetMethod<glGetUniformLocation>();
            Uniform3f = GL.GetMethod<glUniform3f>();
            GenTextures = GL.GetMethod<glGenTextures>();
            BindTexture = GL.GetMethod<glBindTexture>();
            TexImage2D = GL.GetMethod<glTexImage2D>();
            GetShaderInfoLog = GL.GetMethod<glGetShaderInfoLog>();
            TexParameteri = GL.GetMethod<glTexParameteri>();
            UniformMatrix4fv = GL.GetMethod<glUniformMatrix4fv>();
            ActiveTexture = GL.GetMethod<glActiveTexture>();
            Uniform1i = GL.GetMethod<glUniform1i>();
            Enable = GL.GetMethod<glEnable>();
            Disable = GL.GetMethod<glDisable>();
            DepthMask = GL.GetMethod<glDepthMask>();
            StencilFunc = GL.GetMethod<glStencilFunc>();
            StencilOp = GL.GetMethod<glStencilOp>();
            StencilMask = GL.GetMethod<glStencilMask>();
        }

    }

}
