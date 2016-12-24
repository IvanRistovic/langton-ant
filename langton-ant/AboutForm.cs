using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace langton_ant
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0) {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            textBoxDescription.Text =
                "Langton's Ant coded in C#!"
                + Environment.NewLine + Environment.NewLine
                + "About Langton's Ant:"
                + Environment.NewLine + Environment.NewLine
                + "Langton's ant is a two-dimensional Turing machine"
                + Environment.NewLine
                + "with a very simple set of rules but complex emergent"
                + Environment.NewLine
                + "behavior.It was invented by Chris Langton in 1986"
                + Environment.NewLine
                + "and runs on a square lattice of black and white"
                + Environment.NewLine
                + "cells. Squares on a plane are colored variously"
                + Environment.NewLine
                + "either black or white. We arbitrarily identify one "
                + Environment.NewLine
                + "square as the \"ant\". The ant can travel in any of "
                + Environment.NewLine
                + "the four cardinal directions at each step it takes."
                + Environment.NewLine + Environment.NewLine
                + "The \"ant\" moves according to the rules below:"
                + Environment.NewLine + Environment.NewLine
                + "  - At a white square, turn 90° right, flip the color of"
                + Environment.NewLine
                + "  the square, move forward one unit"
                + Environment.NewLine
                + "  - At a black square, turn 90° left, flip the color of the"
                + Environment.NewLine
                + "  square, move forward one unit";
        }
    }
}
