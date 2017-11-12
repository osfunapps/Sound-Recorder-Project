﻿using System;

using System.Diagnostics;

using System.Windows.Forms;

using System.Runtime.InteropServices;
using Sound_Recorder_Project.program.tools.keyboardhook;

internal class KeyboardIntercepter

{
    private const int WH_KEYBOARD_LL = 13;

    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;

    private static LowLevelKeyboardProc _proc = HookCallback;

    private static IntPtr _hookID = IntPtr.Zero;

    private static IKeyboardIntercepterCallback callback;


    public static void Hook()

    {

        _hookID = SetHook(_proc);

        Application.Run();

        UnhookWindowsHookEx(_hookID);

    }


    private static IntPtr SetHook(LowLevelKeyboardProc proc)

    {

        using (Process curProcess = Process.GetCurrentProcess())

        using (ProcessModule curModule = curProcess.MainModule)

        {

            return SetWindowsHookEx(WH_KEYBOARD_LL, proc,

                GetModuleHandle(curModule.ModuleName), 0);

        }

    }


    private delegate IntPtr LowLevelKeyboardProc(

        int nCode, IntPtr wParam, IntPtr lParam);



    //Hook events
    private static IntPtr HookCallback(

        int nCode, IntPtr wParam, IntPtr lParam)

    {
        int vkCode = Marshal.ReadInt32(lParam);

        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            callback.OnBtnDown((Keys)vkCode);

        if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            callback.OnBtnUp((Keys)vkCode);


        return CallNextHookEx(_hookID, nCode, wParam, lParam);

    }


    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

    private static extern IntPtr SetWindowsHookEx(int idHook,

        LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);


    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

    [return: MarshalAs(UnmanagedType.Bool)]

    private static extern bool UnhookWindowsHookEx(IntPtr hhk);


    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,

        IntPtr wParam, IntPtr lParam);


    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

    private static extern IntPtr GetModuleHandle(string lpModuleName);


    public interface IKeyboardIntercepterCallback
    {
        void OnBtnDown(Keys key);
        void OnBtnUp(Keys key);
    }

    public static void SetCallback(IKeyboardIntercepterCallback callback)
    {
        KeyboardIntercepter.callback = callback;
    }
}
