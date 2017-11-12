using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.project;
using Console = System.Console;

namespace Sound_Recorder_Project.program.tools.keyboardhook
{
    class KeyboardActionListener : KeyboardIntercepter.IKeyboardIntercepterCallback
    {
        private KeyboardIntercepter keyboardIntercepter;
        private string KEY_LEFT_CONTROL = "LControlKey";
        private string KEY_LEFT_ALT = "LMenu";
        private string KEY_F8 = "f8";
        private string KEY_R = "R";

        private bool leftCtrlDown, leftAltDown, f8Down, rDown;
        private bool alreadyAskedRec, alreadyAskedSetting;

        public KeyboardActionListener()
        {
            KeyboardIntercepter.SetCallback(this);
        }

        public void RunHook(){KeyboardIntercepter.Hook();}


        public void OnBtnDown(Keys key)
        {
            if (IsKey(key, Keys.LControlKey))
                leftCtrlDown = true;
            else if (IsKey(key, Keys.LShiftKey))
                leftAltDown = true;
            else if (IsKey(key, Keys.F8))
                f8Down = true;
            else if (IsKey(key, Keys.R))
                rDown = true;

            if (RequestedSettings())
                MyUtils.ShowSettingsForm();
            else if (AskedIfRecording())
            {
                if (SoundManager.Recording)
                    MyMessageBox.Show(SoundManager.RECORDING_MSG, Logger.TITLE);
                else
                    MyMessageBox.Show(SoundManager.NO_RECORDING_MSG, Logger.TITLE);
            }

        }

        private bool AskedIfRecording()
        {
            return leftCtrlDown && leftAltDown && rDown && !alreadyAskedRec;
        }

        private bool RequestedSettings()
        {
            return leftCtrlDown && leftAltDown && f8Down && !alreadyAskedSetting;
        }

        public void OnBtnUp(Keys key)
        {

            if (IsKey(key, Keys.LControlKey))
                leftCtrlDown = false;
            else if (IsKey(key, Keys.LShiftKey))
                leftAltDown = false;
            else if (IsKey(key, Keys.F8))
                f8Down = false;
            else if (IsKey(key, Keys.R))
                rDown = false;

        }


        private bool IsKey(Keys pressedKey, Keys desiredKey)
        {
            return pressedKey.Equals(desiredKey);
        }
    }


}
