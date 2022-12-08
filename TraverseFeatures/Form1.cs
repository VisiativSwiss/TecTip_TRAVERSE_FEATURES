using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;

namespace TraverseFeatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();
            ModelDoc2 Part = (ModelDoc2)swApp.ActiveDoc;

            foreach (Feature feature in (object[])Part.FeatureManager.GetFeatures(false))
            {
                if (feature.GetTypeName2() == "ProfileFeature")
                {
                    feature.Name = "MySketch";
                }
            }
        }
    }
}
