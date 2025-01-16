using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;
using UnityEngine;
using System.IO;
public class myWindowMod : MonoBehaviour
{
	public Rect screenPosition;
	//   [DllImport("user32.dll")]
	//  static extern IntPtr SetWindowLong(IntPtr hwnd, int _nIndex, int dwNewLong);
	[DllImport("user32.dll")]
	static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
	[DllImport("user32.dll")]
	static extern IntPtr GetForegroundWindow();
	// not used rigth now
	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);
	const uint SWP_SHOWWINDOW = 0x0040;
	[DllImport("user32.dll")]
	public static extern System.IntPtr FindWindowEx(System.IntPtr parent, System.IntPtr childe, string strclass, string strname);
	
	
	[Flags]
	public enum SetWindowPosFlags : uint
	{
		// ReSharper disable InconsistentNaming
		
		/// <summary>
		///     If the calling thread and the thread that owns the window are attached to different input queues, the system posts the request to the thread that owns the window. This prevents the calling thread from blocking its execution while other threads process the request.
		/// </summary>
		SWP_ASYNCWINDOWPOS = 0x4000,
		
		/// <summary>
		///     Prevents generation of the WM_SYNCPAINT message.
		/// </summary>
		SWP_DEFERERASE = 0x2000,
		
		/// <summary>
		///     Draws a frame (defined in the window's class description) around the window.
		/// </summary>
		SWP_DRAWFRAME = 0x0020,
		
		/// <summary>
		///     Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
		/// </summary>
		SWP_FRAMECHANGED = 0x0020,
		
		/// <summary>
		///     Hides the window.
		/// </summary>
		SWP_HIDEWINDOW = 0x0080,
		
		/// <summary>
		///     Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).
		/// </summary>
		SWP_NOACTIVATE = 0x0010,
		
		/// <summary>
		///     Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.
		/// </summary>
		SWP_NOCOPYBITS = 0x0100,
		
		/// <summary>
		///     Retains the current position (ignores X and Y parameters).
		/// </summary>
		SWP_NOMOVE = 0x0002,
		
		/// <summary>
		///     Does not change the owner window's position in the Z order.
		/// </summary>
		SWP_NOOWNERZORDER = 0x0200,
		
		/// <summary>
		///     Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent window uncovered as a result of the window being moved. When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
		/// </summary>
		SWP_NOREDRAW = 0x0008,
		
		/// <summary>
		///     Same as the SWP_NOOWNERZORDER flag.
		/// </summary>
		SWP_NOREPOSITION = 0x0200,
		
		/// <summary>
		///     Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
		/// </summary>
		SWP_NOSENDCHANGING = 0x0400,
		
		/// <summary>
		///     Retains the current size (ignores the cx and cy parameters).
		/// </summary>
		SWP_NOSIZE = 0x0001,
		
		/// <summary>
		///     Retains the current Z order (ignores the hWndInsertAfter parameter).
		/// </summary>
		SWP_NOZORDER = 0x0004,
		
		/// <summary>
		///     Displays the window.
		/// </summary>
		SWP_SHOWWINDOW = 0x0040,
		
		// ReSharper restore InconsistentNaming
	}
	
	static readonly IntPtr HWND_TOP = new IntPtr(0);

    //

    public int left;
    public int top;
    public int Width;
    public int Height;
    public string Name;
	
	private const int GWL_STYLE = (-16);
	public const int WS_CAPTION = 0xC00000;
	const uint SWP_NOMOVE = 0x2;
	
	const uint SWP_NOSIZE = 1;
	[DllImport("User32.dll", CharSet = CharSet.Auto)]
	public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
	string curpath;
    IntPtr p;


	void Start()
	{
        left = PlayerPrefs.GetInt("left");
        top = PlayerPrefs.GetInt("top");
        Screen.SetResolution(Width, Height, false);
		//  string fileAddress = Application.dataPath + "/FileOperation.txt";
        //curpath = Directory.GetCurrentDirectory();
        //StreamReader sr1 = File.OpenText(curpath + @"\xx.txt");
        //string linew1 = sr1.ReadToEnd();
        //// myplay = linew1.TrimEnd('\r', '\n');
        //int xx = int.Parse(linew1.TrimEnd('\r', '\n'));
        //sr1.Close();
		
        //StreamReader sr2 = File.OpenText(curpath + @"\yy.txt");
        //string linew2 = sr2.ReadToEnd();
        ////  mystop = linew2.TrimEnd('\r', '\n');
        //int yy = int.Parse(linew2.TrimEnd('\r', '\n'));
        //sr2.Close();

        //StreamReader sr3 = File.OpenText(curpath + @"\width.txt");
        //string linew3 = sr3.ReadToEnd();
        ////  mystop = linew2.TrimEnd('\r', '\n');
        //int wid = int.Parse(linew3.TrimEnd('\r', '\n'));
        //sr3.Close();

        //StreamReader sr4 = File.OpenText(curpath + @"\height.txt");
        //string linew4 = sr4.ReadToEnd();
        ////  mystop = linew2.TrimEnd('\r', '\n');
        //int hei = int.Parse(linew4.TrimEnd('\r', '\n'));
        //sr4.Close();

		
		 p = FindWindowEx(System.IntPtr.Zero, System.IntPtr.Zero, null, Name);
		// SetWindowLong(GetForegroundWindow(), GWL_STYLE, 369164288);
		////      SetWindowLong(this.Handle, -16, 369164288);
		
		SetWindowPos(p, -1, 0, 0, Width, Height, SWP_SHOWWINDOW);
		
		SetWindowLong(p, -16, 369164288);
		
		//SetWindowPos(p, 0, (int)screenPosition.x, (int)screenPosition.y, (int)screenPosition.width, (int)screenPosition.height, SWP_NOMOVE | SWP_NOSIZE);
		
		// SetWindowLong(p, GWL_STYLE, GetWindowLong(3, GWL_STYLE )& ~WS_CAPTION).ToString();
		// SetWindowPos(p, HWND_TOP, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_FRAMECHANGED); 
	}
    void Update()
    {   
        SetWindowPos(p, -1, left, top, Width, Height, SWP_SHOWWINDOW);

        SetWindowLong(p, -16, 369164288);
    }


}