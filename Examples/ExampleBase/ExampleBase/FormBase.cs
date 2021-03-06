﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExampleBase
{
    /// <summary>
    /// the main form for the application, implements also IHost to represent the host application for the examples.
    /// this is not -state of the art- in software development but example code has to keep the lines of code as small as possible.
    /// </summary>
    public partial class FormBase : Form, IHost
    {
        #region Fields

        private List<IExample> _listExamples = new List<IExample>();
        private string _rootDirectory = FormOptions.DefaultRootDirectory;
  
        #endregion

        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public FormBase()
        {
            InitializeComponent();     
        }

        #endregion

        #region Properties

        /// <summary>
        /// Containter to use in localization
        /// </summary>
        internal IContainer Components
        {
            get
            {
                return this.components;
            }
        }

        #endregion

        #region IHost

        public DialogResult ShowQuestion(string message)
        {
            return MessageBox.Show(this, message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(this, message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowFinishDialog(string message, string fullDocumentPath)
        {
            try
            {
                FormFinish dialog = new FormFinish(message, fullDocumentPath);
                dialog.ShowDialog(this);
            }
            catch(Exception exception)
            {
                FormError.Show(this, exception);           
            }
        }

        public void ShowErrorDialog(string message, Exception exception)
        {
            FormError.Show(this, exception);  
        }

        public Icon DisplayIcon
        {
            get 
            {
                return this.Icon;
            }
        }

        public int LCID 
        {
            get
            {
                return FormOptions.LCID;
            }
        }

        public string RootDirectory
        {
            get
            {
                return _rootDirectory;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Loads an example to the instance
        /// </summary>
        /// <param name="example">example instance as any</param>
        protected internal void LoadExample(IExample example)
        {
            example.Connect(this);
            ListViewItem viewItem = listViewExamples.Items.Add(example.Caption);
            viewItem.BackColor = listViewExamples.Items.Count % 2 != 0 ? Color.White : Color.AliceBlue;
            viewItem.SubItems.Add(example.Description);
            viewItem.ImageIndex = 0;
            viewItem.Tag = example;
            _listExamples.Add(example);
            // select first item if nothing selected
            if (listViewExamples.SelectedItems.Count <= 0)
                listViewExamples.Items[0].Selected = true;
        }

        #endregion

        #region Trigger

        private void listViewExamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buttonStartExample.Enabled = listViewExamples.SelectedItems.Count > 0;
                if(panelExamples.Controls.Count == 0)
                    return;

                UserControl control = panelExamples.Controls[0] as UserControl;
                panelExamples.Controls.Clear();
            }
            catch(Exception exception)         
            {
                FormError.Show(this, exception);           
            }
        }

        private void listViewExamples_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listViewExamples.SelectedItems.Count == 0)
                    return;

                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                IExample selectedExample = listViewExamples.SelectedItems[0].Tag as IExample;
                if (null == selectedExample.Panel)
                    selectedExample.RunExample();
                else
                {
                    panelExamples.Controls.Add(selectedExample.Panel);
                    selectedExample.Panel.Dock = DockStyle.Fill;
                    selectedExample.Panel.Visible = true;
                }
            }
            catch (Exception exception)
            {
                FormError.Show(this, exception);
            }
            finally
            {
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void buttonStartExample_Click(object sender, EventArgs e)
        {
            listViewExamples_MouseDoubleClick(this, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left,0,0,0,0));
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            try
            {
                FormOptions dialog = new FormOptions(_rootDirectory);
                if (DialogResult.OK == dialog.ShowDialog(this))
                {
                    _rootDirectory = dialog.RootDirectory;


                    foreach (ListViewItem item in listViewExamples.Items)
                    {
                        IExample example = item.Tag as IExample;
                        item.Text = example.Caption;
                        item.SubItems[1].Text = example.Description;
                    }

                    Translator.TranslateControls(this, "FormBase.txt", FormOptions.LCID);
                }
            }
            catch(Exception exception)
            {
                FormError.Show(this, exception);  
            }
        }

        private void linkLabelRessource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel label = sender as LinkLabel;
                string link = label.Tag as string;
                string[] array = link.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
                string root = "http://netoffice.codeplex.com";
                if (FormOptions.LCID == 1033)
                    link = root + array[0];
                else
                    link = root + array[1];
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception exception)
            {
                FormError.Show(this, null, exception.Message, exception);
            }
        }

        private void linkLabelDiscussionBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string link = linkLabelDiscussionBoard.Tag as string;
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception exception)
            {
                FormError.Show(this, null, exception.Message, exception);
            }
        }

        private void linkLabelEmployeWanted_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string link = linkLabelEmployeWanted.Tag as string;
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception exception)
            {
                FormError.Show(this, null, exception.Message, exception);
            }
        }

        #endregion
    }
}
