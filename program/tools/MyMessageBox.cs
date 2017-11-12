using System.Windows.Forms;

public static class MyMessageBox
{
    public static bool Showed { get; set; }
    public delegate void OnOK();

    public static event OnOK OnOkClick;
    public static void Show(string text, string title)
    {
        System.Threading.ParameterizedThreadStart pT = new System.Threading.ParameterizedThreadStart(InvokeShow);
        pT.BeginInvoke(new MsgBoxOBject(text,title), null, null);
    }

    
    private static void InvokeShow(object obj)
    {
        if (Showed) return;
        MsgBoxOBject msgBoxOBject = (MsgBoxOBject) obj;
        Showed = true;
        if (MessageBox.Show(msgBoxOBject.text, msgBoxOBject.title) == DialogResult.OK)
        {
            Showed = false;
        }
    }


    public class MsgBoxOBject
    {

        public MsgBoxOBject(string text, string title)
        {
            this.text = text;
            this.title = title;
        }

        public string title { get; set; }

        public string text { get; set; }
    }

}