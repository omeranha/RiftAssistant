using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using work;

internal class MemoryReader : IDisposable
{
	private string _processName;

	[CompilerGenerated]
	private IntPtr intptr_0;

	[CompilerGenerated]
	private Process process_0;

	[CompilerGenerated]
	private IntPtr intptr_1;

	public IntPtr ProcessHandle
	{
		[CompilerGenerated]
		get
		{
			return intptr_0;
		}
		[CompilerGenerated]
		private set
		{
			intptr_0 = value;
		}
	}

	public Process Process
	{
		[CompilerGenerated]
		get
		{
			return process_0;
		}
		[CompilerGenerated]
		private set
		{
			process_0 = value;
		}
	}

	public IntPtr MainModuleHandle
	{
		[CompilerGenerated]
		get
		{
			return intptr_1;
		}
		[CompilerGenerated]
		private set
		{
			intptr_1 = value;
		}
	}

	public string ProcessName
	{
		get
		{
			return _processName;
		}
		set
		{
			Close();
			_processName = value;
			Open();
		}
	}

	public MemoryReader(string string_1, bool bool_0)
	{
		_processName = string_1;
		if (bool_0)
		{
			Open();
		}
	}

	public void Dispose()
	{
		Close();
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	~MemoryReader()
	{
		try
		{
			Close();
		}
		finally
		{
		}
	}

	public bool Close()
	{
		if (Process != null)
		{
			Process = null;
			return Win32.CloseHandle(ProcessHandle);
		}
		return true;
	}

	public bool IsValid()
	{
		Process process = Process;
		if (process != null && !process.HasExited)
		{
			return true;
		}
		Open();
		Process process2 = Process;
		if (process2 == null)
		{
			return false;
		}
		return !process2.HasExited;
	}

	public void Open()
	{
		Process[] processesByName = Process.GetProcessesByName(_processName);
		if (processesByName != null && processesByName.Length != 0)
		{
			try
			{
				Process = processesByName[0];
				Process process = Process;
				if (process != null && !process.HasExited)
				{
					ProcessHandle = Win32.OpenProcess(2035711u, bool_0: false, Process.Id);
					MainModuleHandle = Process.MainModule.BaseAddress;
				}
				return;
			}
			catch (Exception)
			{
				Process = null;
				ProcessHandle = IntPtr.Zero;
				MainModuleHandle = IntPtr.Zero;
				return;
			}
		}
		Process = null;
		ProcessHandle = IntPtr.Zero;
		MainModuleHandle = IntPtr.Zero;
	}

	private IntPtr method_3(int int_0, bool bool_0)
	{
		if (!bool_0)
		{
			return (IntPtr)int_0;
		}
		return (IntPtr)(MainModuleHandle.ToInt32() + int_0);
	}

	private IntPtr method_4(long long_0, bool bool_0)
	{
		if (!bool_0)
		{
			return (IntPtr)long_0;
		}
		return (IntPtr)(MainModuleHandle.ToInt64() + long_0);
	}

	public byte ReadByte_x86(int int_0, bool bool_0 = false)
	{
		byte byte_ = 0;
		Win32.ReadProcessMemory_1(ProcessHandle, method_3(int_0, bool_0), ref byte_, 1, 0);
		return byte_;
	}

	public byte ReadByte_x64(long long_0, bool bool_0 = false)
	{
		byte byte_ = 0;
		Win32.ReadProcessMemory_1(ProcessHandle, method_4(long_0, bool_0), ref byte_, 1, 0);
		return byte_;
	}

	public int ReadInt32_x86(int int_0, bool bool_0 = false)
	{
		int int_1 = 0;
		Win32.ReadProcessMemory_2(ProcessHandle, method_3(int_0, bool_0), ref int_1, 4, 0);
		return int_1;
	}

	public int ReadInt32_x64(long long_0, bool bool_0 = false)
	{
		int int_ = 0;
		Win32.ReadProcessMemory_2(ProcessHandle, method_4(long_0, bool_0), ref int_, 4, 0);
		return int_;
	}

	public int method_17(int int_0, bool bool_0 = false)
	{
		return ReadInt32_x86(int_0, bool_0);
	}

	public long ReadAddress(long long_0, bool bool_0 = false)
	{
		return method_22(long_0, bool_0);
	}

	public uint method_19(int int_0, bool bool_0 = false)
	{
		uint uint_ = 0u;
		Win32.ReadProcessMemoryUInt(ProcessHandle, method_3(int_0, bool_0), ref uint_, 4, 0);
		return uint_;
	}

	public uint ReadUInt(long long_0, bool bool_0 = false)
	{
		uint uint_ = 0u;
		Win32.ReadProcessMemoryUInt(ProcessHandle, method_4(long_0, bool_0), ref uint_, 4, 0);
		return uint_;
	}

	public long method_21(int int_0, bool bool_0 = false)
	{
		long long_ = 0L;
		Win32.ReadProcessMemory_3(ProcessHandle, method_3(int_0, bool_0), ref long_, 8, 0);
		return long_;
	}

	public long method_22(long long_0, bool bool_0 = false)
	{
		long long_1 = 0L;
		Win32.ReadProcessMemory_3(ProcessHandle, method_4(long_0, bool_0), ref long_1, 8, 0);
		return long_1;
	}

	public ulong method_23(int int_0, bool bool_0 = false)
	{
		ulong ulong_ = 0uL;
		Win32.ReadProcessMemory_5(ProcessHandle, method_3(int_0, bool_0), ref ulong_, 8, 0);
		return ulong_;
	}

	public ulong method_24(long long_0, bool bool_0 = false)
	{
		ulong ulong_ = 0uL;
		Win32.ReadProcessMemory_5(ProcessHandle, method_4(long_0, bool_0), ref ulong_, 8, 0);
		return ulong_;
	}

	public float method_25(int int_0, bool bool_0 = false)
	{
		float float_ = 0f;
		Win32.ReadProcessMemory_6(ProcessHandle, method_3(int_0, bool_0), ref float_, 4, 0);
		return float_;
	}

	public float ReadFloat(long long_0, bool bool_0 = false)
	{
		float float_ = 0f;
		Win32.ReadProcessMemory_6(ProcessHandle, method_4(long_0, bool_0), ref float_, 4, 0);
		return float_;
	}

	public string method_27(int int_0, int int_1, Encoding encoding_0, bool bool_0, bool bool_1 = false)
	{
		byte[] bytes = method_29(int_0, int_1, bool_1);
		if (!bool_0)
		{
			return encoding_0.GetString(bytes);
		}
		string text = encoding_0.GetString(bytes);
		int num = text.IndexOf('\0');
		if (num != -1)
		{
			return text.Remove(num).Trim();
		}
		return text;
	}

	public string ReadString(long long_0, int int_0, Encoding encoding_0, bool bool_0, bool bool_1 = false)
	{
		byte[] bytes = method_30(long_0, int_0, bool_1);
		if (!bool_0)
		{
			return encoding_0.GetString(bytes);
		}
		string text = encoding_0.GetString(bytes);
		int num = text.IndexOf('\0');
		if (num != -1)
		{
			return text.Remove(num).Trim();
		}
		return text;
	}

	public byte[] method_29(int int_0, int int_1, bool bool_0 = false)
	{
		byte[] array = new byte[int_1];
		Win32.ReadProcessMemory(ProcessHandle, method_3(int_0, bool_0), array, int_1, 0);
		return array;
	}

	public byte[] method_30(long long_0, int int_0, bool bool_0 = false)
	{
		byte[] array = new byte[int_0];
		Win32.ReadProcessMemory(ProcessHandle, method_4(long_0, bool_0), array, int_0, 0);
		return array;
	}

	public void method_31(int int_0, object object_0, bool bool_0 = false)
	{
		Win32.ReadProcessMemory_7(ProcessHandle, method_3(int_0, bool_0), object_0, Marshal.SizeOf(object_0), 0);
	}

	public void method_32(long long_0, object object_0, bool bool_0 = false)
	{
		Win32.ReadProcessMemory_7(ProcessHandle, method_4(long_0, bool_0), object_0, Marshal.SizeOf(object_0), 0);
	}

	public bool method_33(int int_0, object object_0, int int_1, bool bool_0 = false)
	{
		return Win32.ReadProcessMemory_7(ProcessHandle, method_3(int_0, bool_0), object_0, int_1, 0);
	}

	public bool ReadMem(long long_0, object object_0, int int_0, bool bool_0 = false)
	{
		return Win32.ReadProcessMemory_7(ProcessHandle, method_4(long_0, bool_0), object_0, int_0, 0);
	}

	public unsafe void ReadPointerArray_x64(long long_0, long[] long_1, int int_0, int int_1, bool bool_0 = false)
	{
		fixed (long* ptr = &long_1[int_0])
		{
			void* pVoid_ = ptr;
			Win32.ReadProcessMemory_9(ProcessHandle, method_4(long_0, bool_0), pVoid_, int_1 * 8, IntPtr.Zero);
		}
	}
}
