using BBLevelEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BBLevelEditor
{
    public partial class Form1 : Form
    {
        string filePath;
        XmlWriterSettings settings = new XmlWriterSettings();
        public Form1()
        {
            InitializeComponent();
            ResourceManager rm = Resources.ResourceManager;
            //filePath = (string)rm.GetObject("BBlevel");
            filePath = System.AppDomain.CurrentDomain.BaseDirectory + "\\BBlevel.xml";
            settings.Indent = true; // Enable indentation for readability
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create(filePath, settings);
            writer.WriteStartDocument();

            // Write the root element
            writer.WriteStartElement("level");
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    WriteData(writer, c.Location, Convert.ToInt32(c.Text), c.Size);
                }
            }
            writer.WriteEndElement();
            // End the root element

            // End the XML document
            writer.Close();
        }
        static void WriteData(XmlWriter writer, Point point, int id, Size size)
        {
            writer.WriteStartElement("brick");
            writer.WriteElementString("x", "" + point.X);
            writer.WriteElementString("y", "" + point.Y);
            writer.WriteElementString("width", "" + size.Width);
            writer.WriteElementString("height", "" + size.Height);
            writer.WriteElementString("id", "" + id);
            writer.WriteEndElement();
        }

    }
}
