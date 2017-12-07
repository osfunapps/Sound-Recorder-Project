using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sound_Recorder_Project
{
    internal class TrayManager
    {
        private AppCoordinator appCoordinator;
        private Container components;
        private ContextMenu contextMenu1;
        private MenuItem exitItem;
        private NotifyIcon trayIcon;
        private ITrayCallback _callback;
        private MenuItem pathItem;
        private MenuItem settingsItem;

        public TrayManager(ITrayCallback callback)
        {
            _callback = callback;
        }

        public void CreateNotifyicon(object sender)
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            /*
            this.exitItem = new System.Windows.Forms.MenuItem();

            // Initialize menuItem1
            this.exitItem.Index = 0;
            this.exitItem.Text = "E&xit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            */

            SetExitItem();
            SetOpenPathItem();
            SetSettingsItem();
            // Initialize contextMenu1
            this.contextMenu1.MenuItems.Add(settingsItem);
            this.contextMenu1.MenuItems.Add(pathItem);
            this.contextMenu1.MenuItems.Add(exitItem);

            // Create the NotifyIcon.
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            trayIcon.Icon = new Icon("ear_mini.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            trayIcon.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            trayIcon.Text = "...";
            trayIcon.Visible = true;

            // Handle the DoubleClick event to activate the form.
            trayIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);

        }


        private void SetOpenPathItem()
        {
            this.pathItem = new System.Windows.Forms.MenuItem();

            // Initialize exitItem
            pathItem.Index = 1;
            this.pathItem.Text = "Open Path";
            this.pathItem.Click += new System.EventHandler(this.pathItem_Click);
        }

        private void pathItem_Click(object sender, EventArgs e)
        {
            _callback.OnGoToPathClicked();
        }

        private void SetExitItem()
        {
            this.exitItem = new System.Windows.Forms.MenuItem();

            // Initialize exitItem
            this.exitItem.Index = 2;
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
        }

        private void SetSettingsItem()
        {
            this.settingsItem = new System.Windows.Forms.MenuItem();

            // Initialize exitItem
            this.settingsItem.Index = 0;
            this.settingsItem.Text = "Settings";
            this.settingsItem.Click += new System.EventHandler(this.settingsItem_Click);
        }

        private void settingsItem_Click(object sender, EventArgs e)
        {
            _callback.OnSettingsClicked();
        }

        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            _callback.OnShowClicked();
            //show the displayer
        }

        private void exitItem_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            _callback.OnExitClicked();
        }

    }

    internal interface ITrayCallback
    {
        void OnExitClicked();
        void OnShowClicked();
        void OnGoToPathClicked();
        void OnSettingsClicked();
    }
}
