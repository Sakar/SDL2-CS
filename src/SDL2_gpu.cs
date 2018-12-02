#region License
/* SDL2# - C# Wrapper for SDL2
 *
 * Copyright (c) 2013-2016 Ethan Lee.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */
#endregion

#region Using Statements
using System;
using System.Runtime.InteropServices;
#endregion

namespace SDL2
{
	public static class SDL_gpu
	{
		#region SDL2# Variables

		/* Used by DllImport to load the native library. */
		private const string nativeLibName = "SDL2_gpu";

		#endregion

		#region SDL_gpu.h

		public const int SDL_GPU_MAJOR_VERSION = 0;
		public const int SDL_GPU_MINOR_VERSION = 10;
		public const int SDL_GPU_PATCHLEVEL = 0;

		// Types
		public static void SDL_GPU_VERSION(out SDL.SDL_version X)
		{
			X.major = SDL_GPU_MAJOR_VERSION;
			X.minor = SDL_GPU_MINOR_VERSION;
			X.patch = SDL_GPU_PATCHLEVEL;
		}

		[Flags]
		public enum GPU_InitFlagEnum
		{
			GPU_INIT_ENABLE_VSYNC = 0x1,
			GPU_INIT_DISABLE_VSYNC = 0x2,
			GPU_INIT_DISABLE_DOUBLE_BUFFER = 0x4,
			GPU_INIT_DISABLE_AUTO_VIRTUAL_RESOLUTION = 0x8
		}

		[Flags]
		public enum GPU_FeatureEnum
		{
			GPU_FEATURE_NON_POWER_OF_TWO = 0x1,
			GPU_FEATURE_RENDER_TARGETS = 0x2,
			GPU_FEATURE_BLEND_EQUATIONS = 0x4,
			GPU_FEATURE_BLEND_FUNC_SEPARATE = 0x8,
			GPU_FEATURE_BLEND_EQUATIONS_SEPARATE = 0x10,
			GPU_FEATURE_GL_BGR = 0x20,
			GPU_FEATURE_GL_BGRA = 0x40,
			GPU_FEATURE_GL_ABGR = 0x80,
			GPU_FEATURE_VERTEX_SHADER = 0x100,
			GPU_FEATURE_FRAGMENT_SHADER = 0x200,
			GPU_FEATURE_PIXEL_SHADER = 0x200,
			GPU_FEATURE_GEOMETRY_SHADER = 0x400,
			GPU_FEATURE_WRAP_REPEAT_MIRRORED = 0x800
		}

		[Flags]
		public enum GPU_RendererEnum
		{
			GPU_RENDERER_UNKNOWN = 0,
			GPU_RENDERER_OPENGL_1_BASE = 1,
			GPU_RENDERER_OPENGL_1 = 2,
			GPU_RENDERER_OPENGL_2 = 3,
			GPU_RENDERER_OPENGL_3 = 4,
			GPU_RENDERER_OPENGL_4 = 5,
			GPU_RENDERER_GLES_1 = 11,
			GPU_RENDERER_GLES_2 = 12,
			GPU_RENDERER_GLES_3 = 13,
			GPU_RENDERER_D3D9 = 21,
			GPU_RENDERER_D3D10 = 22,
			GPU_RENDERER_D3D11 = 23
		}

		public enum GPU_ShaderLanguageEnum
		{
			GPU_LANGUAGE_NONE = 0,
			GPU_LANGUAGE_ARB_ASSEMBLY = 1,
			GPU_LANGUAGE_GLSL = 2,
			GPU_LANGUAGE_GLSLES = 3,
			GPU_LANGUAGE_HLSL = 4,
			GPU_LANGUAGE_CG = 5
		}

		public enum GPU_FormatEnum
		{
			GPU_FORMAT_LUMINANCE = 1,
			GPU_FORMAT_LUMINANCE_ALPHA = 2,
			GPU_FORMAT_RGB = 3,
			GPU_FORMAT_RGBA = 4,
			GPU_FORMAT_ALPHA = 5,
			GPU_FORMAT_RG = 6,
			GPU_FORMAT_YCbCr422 = 7,
			GPU_FORMAT_YCbCr420P = 8
		}

		public enum GPU_BlendEqEnum : uint
		{
			GPU_EQ_ADD = 0x8006,
			GPU_EQ_SUBTRACT = 0x800A,
			GPU_EQ_REVERSE_SUBTRACT = 0x800B
		}

		public enum GPU_BlendFuncEnum : uint
		{
			GPU_FUNC_ZERO = 0,
			GPU_FUNC_ONE = 1,
			GPU_FUNC_SRC_COLOR = 0x0300,
			GPU_FUNC_DST_COLOR = 0x0306,
			GPU_FUNC_ONE_MINUS_SRC = 0x0301,
			GPU_FUNC_ONE_MINUS_DST = 0x0307,
			GPU_FUNC_SRC_ALPHA = 0x0302,
			GPU_FUNC_DST_ALPHA = 0x0304,
			GPU_FUNC_ONE_MINUS_SRC_ALPHA = 0x0303,
			GPU_FUNC_ONE_MINUS_DST_ALPHA = 0x0305
		}

		public enum GPU_FilterEnum
		{
			GPU_FILTER_NEAREST = 0,
			GPU_FILTER_LINEAR = 1,
			GPU_FILTER_LINEAR_MIPMAP = 2
		}

		public enum GPU_SnapEnum
		{
			GPU_SNAP_NONE = 0,
			GPU_SNAP_POSITION = 1,
			GPU_SNAP_DIMENSIONS = 2,
			GPU_SNAP_POSITION_AND_DIMENSIONS = 3
		}

		public enum GPU_WrapEnum
		{
			GPU_WRAP_NONE = 0,
			GPU_WRAP_REPEAT = 1,
			GPU_WRAP_MIRRORED = 2
		}

		public enum GPU_BlendPresetEnum
		{
			GPU_BLEND_NORMAL = 0,
			GPU_BLEND_PREMULTIPLIED_ALPHA = 1,
			GPU_BLEND_MULTIPLY = 2,
			GPU_BLEND_ADD = 3,
			GPU_BLEND_SUBTRACT = 4,
			GPU_BLEND_MOD_ALPHA = 5,
			GPU_BLEND_SET_ALPHA = 6,
			GPU_BLEND_SET = 7,
			GPU_BLEND_NORMAL_KEEP_ALPHA = 8,
			GPU_BLEND_NORMAL_ADD_ALPHA = 9
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_RendererID
		{
			public string name;
			public GPU_RendererEnum renderer;
			public int major_version;
			public int minor_version;
			public int index;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_Renderer
		{
			public GPU_RendererID id;
			public GPU_RendererID requested_id;
			public SDL.SDL_RendererFlags SDL_init_flags;
			public GPU_InitFlagEnum GPU_init_flags;
			public GPU_ShaderLanguageEnum shader_language;
			public int shader_version;
			public GPU_FeatureEnum enabled_features;
			public IntPtr current_context_target; // GPU_Target*
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_Target
		{
			public IntPtr image; // GPU_Image*
			public IntPtr data; // void*
			public UInt16 w, h;
			public byte using_virtual_resolution;
			public UInt16 base_w, base_h;
			public byte use_clip_rect;
			public GPU_Rect clip_rect;
			public byte use_color;
			public SDL.SDL_Color color;
			public GPU_Rect viewport;
			public GPU_Camera camera;
			public IntPtr context; // GPU_Context*
			public int refcount;
			public byte is_alias;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_Image
		{
			public IntPtr target; // GPU_Target*
			public UInt16 w, h;
			public GPU_FormatEnum format;
			public int num_layers;
			public int bytes_per_pixel;
			public UInt16 base_w, base_h;
			public byte has_mipmaps;
			public SDL.SDL_Color color;
			public byte use_blending;
			public GPU_BlendMode blend_mode;
			public GPU_FilterEnum filter_mode;
			public GPU_SnapEnum snap_mode;
			public GPU_WrapEnum wrap_mode_x;
			public GPU_WrapEnum wrap_mode_y;
			public IntPtr data; // void*
			public int refcount;
			public byte is_alias;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_BlendMode
		{
			public GPU_BlendFuncEnum source_color;
			public GPU_BlendFuncEnum dest_color;
			public GPU_BlendFuncEnum source_alhpa;
			public GPU_BlendFuncEnum dest_alpha;
			public GPU_BlendEqEnum color_equation;
			public GPU_BlendEqEnum alpha_equation;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_Rect
		{
			public float x, y;
			public float w, h;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GPU_Camera
		{
			public float x, y, z;
			public float angle;
			public float zoom;
		}

		// Functions
		internal static byte[] UTF8_ToNative(string s)
		{
			if (s == null)
			{
				return null;
			}

			// Add a null terminator. That's kind of it... :/
			return System.Text.Encoding.UTF8.GetBytes(s + '\0');
		}

		[DllImport(nativeLibName, EntryPoint = "GPU_GetLinkedVersion", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_GPU_GetLinkedVersion();
		public static SDL.SDL_version GPU_GetLinkedVersion()
		{
			SDL.SDL_version result;
			IntPtr result_ptr = INTERNAL_GPU_GetLinkedVersion();
			result = (SDL.SDL_version)Marshal.PtrToStructure(
				result_ptr,
				typeof(SDL.SDL_version)
			);
			return result;
		}

		#region Initialization

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetInitWindow(UInt32 windowID);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern UInt32 GPU_GetInitWindow();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetPreInitFlags(GPU_InitFlagEnum gpu_flags);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_InitFlagEnum GPU_GetPreInitFlags();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetRequiredFeatures(GPU_FeatureEnum GPU_flags);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_FeatureEnum GPU_GetRequiredFeatures();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_GetDefaultRendererOrder(ref int order_size, out GPU_RendererID order);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_GetRendererOrder(ref int order_size, out GPU_RendererID order);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetRendererOrder(int order_size, ref GPU_RendererID order);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_Init(UInt16 w, UInt16 h, SDL.SDL_WindowFlags SDL_flags);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_InitRenderer(GPU_RendererEnum renderer_enum, UInt16 w, UInt16 h, SDL.SDL_WindowFlags SDL_flags);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_InitRendererByID(GPU_RendererID renderer_request, UInt16 w, UInt16 h, SDL.SDL_WindowFlags SDL_flags);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern byte GPU_IsFeatureEnabled(GPU_FeatureEnum feature);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_CloseCurrentRenderer();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Quit();

		#endregion

		#region Logging

		// TODO: All of these

		#endregion

		#region Renderer Setup

		[DllImport(nativeLibName, EntryPoint = "GPU_MakeRendererID", CallingConvention = CallingConvention.Cdecl)]
		private static extern GPU_RendererID INTERNAL_GPU_MakeRendererID(
			byte[] name,
			GPU_RendererEnum renderer,
			int major_version,
			int minor_version
		);
		public static GPU_RendererID GPU_MakeRendererID(string name, GPU_RendererEnum renderer, int major_version, int minor_version)
		{
			return INTERNAL_GPU_MakeRendererID(
				UTF8_ToNative(name),
				renderer,
				major_version,
				minor_version
			);
		}

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_RendererID GPU_GetRendererID(GPU_RendererEnum renderer);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_RendererID GPU_GetRendererIDByIndex(uint index);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern int GPU_GetNumRegisteredRenderers();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_GetRegisteredRendererList(
			[Out()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct)]
				GPU_RendererID[] renderers_array
			);

		// TODO: GPU_RegisterRenderer

		#endregion

		#region Renderer Controls

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_RendererEnum GPU_ReserveNextRendererEnum();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern int GPU_GetNumActiveRenderers();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_GetActiveRendererList(
			[Out()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct)]
				GPU_RendererID[] renderers_array
			);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_GetRenderer(uint index);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_GetRendererByID(GPU_RendererID id);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_GetCurrentRenderer();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetCurrentRenderer(GPU_RendererID id);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_ResetRendererState();

		#endregion

		#region Context Controls

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_GetContextTarget();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_GetWindowTarget(UInt32 windowID);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CreateTargetFromWindow(UInt32 windowID);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_MakeCurrent(IntPtr target, UInt32 windowID);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern byte GPU_SetWindowResolution(UInt16 w, UInt16 h);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern byte GPU_SetFullscreen(byte enable_fullscreen, byte use_desktop_resolution);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern byte GPU_GetFullscreen();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetShapeBlending(byte enable);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_BlendMode GPU_GetBlendModeFromPreset(GPU_BlendPresetEnum preset);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetShapeBlendFunction(GPU_BlendFuncEnum source_color, GPU_BlendFuncEnum dest_color, GPU_BlendFuncEnum source_alpha, GPU_BlendFuncEnum dest_alpha);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetShapeBlendEquation(GPU_BlendEqEnum color_equation, GPU_BlendEqEnum alpha_equation);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetShapeBlendMode(GPU_BlendPresetEnum mode);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern float GPU_SetLineThickness(float thickness);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern float GPU_GetLineThickness();

		#endregion

		#region Target Controls

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CreateAliasTarget(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_LoadTarget(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_FreeTarget(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetVirtualResolution(IntPtr target, UInt16 w, UInt16 h);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_GetVirtualCoords(IntPtr image, ref float x, ref float y, float displayX, float displayY);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UnsetVirtualResolution(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_Rect GPU_MakeRect(float x, float y, float w, float h);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern SDL.SDL_Color GPU_MakeColor(byte r, byte g, byte b, byte a);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetViewport(IntPtr target, GPU_Rect viewport);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_Camera GPU_GetDefaultCamera();

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_Camera GPU_GetCamera(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_Camera GPU_SetCamera(IntPtr target, IntPtr cam);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern SDL.SDL_Color GPU_GetPixel(IntPtr target, Int16 x, Int16 y);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_Rect GPU_SetClipRect(IntPtr target, GPU_Rect rect);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_Rect GPU_SetClip(IntPtr target, Int16 x, Int16 y, UInt16 w, UInt16 h);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UnsetClip(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetTargetColor(IntPtr target, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetTargetRGB(IntPtr target, byte r, byte g, byte b);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetTargetRGBA(IntPtr target, byte r, byte g, byte b, byte a);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UnsetTargetColor(IntPtr target);

		#endregion

		#region Surface Controls

		// TODO: GPU_LoadSurface
		// TODO: GPU_SaveSurface

		#endregion

		#region Image Controls

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CreateImage(UInt16 w, UInt16 h, GPU_FormatEnum format);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CreateImageUsingTexture(UInt32 handle, byte take_ownership);

		[DllImport(nativeLibName, EntryPoint = "GPU_LoadImage", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_GPU_LoadImage(
			byte[] name
		);
		public static IntPtr GPU_LoadImage(string name)
		{
			return INTERNAL_GPU_LoadImage(UTF8_ToNative(name));
		}

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CreateAliasImage(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CopyImage(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_FreeImage(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UpdateImage(IntPtr image, IntPtr surface, ref GPU_Rect surface_rect);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UpdateSubImage(IntPtr image, ref GPU_Rect image_rect, IntPtr surface, ref GPU_Rect surface_rect);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UpdateImageBytes(
			IntPtr image,
			ref GPU_Rect image_rect,
			[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
				byte[] bytes,
			int bytes_per_row);

		// TODO: GPU_SaveImage

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_GenerateMipmaps(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetColor(IntPtr image, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetRGB(IntPtr image, byte r, byte g, byte b);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetRGBA(IntPtr image, byte r, byte g, byte b, byte a);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_UnsetColor(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern byte GPU_GetBlending(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetBlending(IntPtr image, byte enable);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetBlendFunction(IntPtr image, GPU_BlendFuncEnum source_color, GPU_BlendFuncEnum dest_color, GPU_BlendFuncEnum source_alhpa, GPU_BlendFuncEnum dest_alpha);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetBlendEquation(IntPtr image, GPU_BlendEqEnum color_equation, GPU_BlendEqEnum alpha_equation);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetBlendMode(IntPtr image, GPU_BlendPresetEnum mode);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetImageFilter(IntPtr image, GPU_FilterEnum filter);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern GPU_SnapEnum GPU_GetSnapMode(IntPtr image);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetSnapMode(IntPtr image, GPU_SnapEnum mode);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SetWrapMode(IntPtr image, GPU_WrapEnum wrap_mode_x, GPU_WrapEnum wrap_mode_y);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CopyImageFromSurface(IntPtr surface);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CopyImageFromTarget(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CopySurfaceFromTarget(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GPU_CopySurfaceFromImage(IntPtr image);

		#endregion

		#region Matrix

		// TODO: All of these

		#endregion

		#region Rendering

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Clear(IntPtr target);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_ClearColor(IntPtr target, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_ClearRGB(IntPtr target, byte r, byte g, byte b);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_ClearRGBA(IntPtr target, byte r, byte g, byte b, byte a);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Blit(IntPtr image, ref GPU_Rect src_rect, IntPtr target, float x, float y);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_BlitRotate(IntPtr image, ref GPU_Rect src_rect, IntPtr target, float x, float y, float degrees);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_BlitScale(IntPtr image, ref GPU_Rect src_rect, IntPtr target, float x, float y, float scaleX, float scaleY);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_BlitTransform(IntPtr image, ref GPU_Rect src_rect, IntPtr target, float x, float y, float degrees, float scaleX, float scaleY);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_BlitTransformX(IntPtr image, ref GPU_Rect src_rect, IntPtr target, float x, float y, float pivot_x, float pivot_y, float degrees, float scaleX, float scaleY);

		// TODO: GPU_BlitTransformMatrix
		// TODO: GPU_BlitBatch
		// TODO: GPU_BlitBatchSeparate
		// TODO: GPU_TriangleBatch
		// TODO: GPU_FlushBlitBuffer

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Flip(IntPtr target);

		#endregion

		#region Shapes

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Pixel(IntPtr target, float x, float y, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Line(IntPtr target, float x1, float y1, float x2, float y2, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Arc(IntPtr target, float x, float y, float radius, float start_angle, float end_angle, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_ArcFilled(IntPtr target, float x, float y, float radius, float start_angle, float end_angle, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Circle(IntPtr target, float x, float y, float radius, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_CircleFilled(IntPtr target, float x, float y, float radius, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Ellipse(IntPtr target, float x, float y, float rx, float ry, float degrees, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_EllipseFilled(IntPtr target, float x, float y, float rx, float ry, float degrees, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Sector(IntPtr target, float x, float y, float inner_radius, float outer_radius, float start_angle, float end_angle, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_SectorFilled(IntPtr target, float x, float y, float inner_radius, float outer_radius, float start_angle, float end_angle, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Tri(IntPtr target, float x1, float y1, float x2, float y2, float x3, float y3, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_TriFilled(IntPtr target, float x1, float y1, float x2, float y2, float x3, float y3, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Rectangle(IntPtr target, float x1, float y1, float x2, float y2, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_RectangleFilled(IntPtr target, float x1, float y1, float x2, float y2, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_RectangleRound(IntPtr target, float x1, float y1, float x2, float y2, float radius, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_RectangleRoundFilled(IntPtr target, float x1, float y1, float x2, float y2, float radius, SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_Polygon(
			IntPtr target, 
			uint num_vertices,
			[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
				float[] vertices,
			SDL.SDL_Color color);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GPU_PolygonFilled(
			IntPtr target,
			uint num_vertices,
			[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]
				float[] vertices,
			SDL.SDL_Color color);

		#endregion

		#region Shader Interface

		// TODO: All of these

		#endregion

		#endregion
	}
}
