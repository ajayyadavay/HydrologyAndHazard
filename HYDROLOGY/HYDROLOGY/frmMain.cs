using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYDROLOGY
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hydrology_Click(object sender, EventArgs e)
        {
            Lblcaption1.Text = Btn_hydrology.Text;
            Btn_hydrology.BackColor = Color.LightSalmon;
  
            ComboBoxMain.Items.Clear();
            ComboBoxMain.Text = "";

            ComboBoxMain.Items.Add("STREAM ROUTING");
            //ComboBoxMain.Items.Add("CATCHMENT ROUTING");
            //ComboBoxMain.Items.Add("UNIT HYDROGRAPH");
            //ComboBoxMain.Items.Add("INFILTRATION");
            ComboBoxMain.Items.Add("MODEL");
            ComboBoxMain.Items.Add("PET");
            ComboBoxMain.Items.Add("MONTHLY");

        }

        private void comboBoxMain_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxMethod.Items.Clear();

            ComboBoxMethod.Text = "";
            Lblcaption2.Text = "FOR " + ComboBoxMain.Text;
            
            // H    Y   D   R   O   L   O   G   Y

            if (ComboBoxMain.Text == "STREAM ROUTING")
            {
                ComboBoxMethod.Items.Add("MUSKINGHUM");
                //ComboBoxMethod.Items.Add("MUSKINGHUM-CUNGE");
                //ComboBoxMethod.Items.Add("CONVEX METHOD");
            }
            if (ComboBoxMain.Text == "CATCHMENT ROUTING")
            {
                ComboBoxMethod.Items.Add("TIME AREA METHOD");
                ComboBoxMethod.Items.Add("CASCADE OF LINEAR RESERVOIR");
                ComboBoxMethod.Items.Add("KINEMATIC WAVE MODEL");
                ComboBoxMethod.Items.Add("DYNAMIC WAVE MODEL");
            }
            if (ComboBoxMain.Text == "UNIT HYDROGRAPH")
            {
                ComboBoxMethod.Items.Add("CLARK UH METHOD");
                ComboBoxMethod.Items.Add("CASCADE OF LINEAR RESERVOIR");
                ComboBoxMethod.Items.Add("NASH MODEL");
            }
            if (ComboBoxMain.Text == "INFILTRATION")
            {
                ComboBoxMethod.Items.Add("STEADY-M&L");
            }
            if (ComboBoxMain.Text == "MODEL")
            {
                ComboBoxMethod.Items.Add("CRAWFORD");
                ComboBoxMethod.Items.Add("MUSKINGUM PARAMETER");
            }
            if (ComboBoxMain.Text == "PET")
            {
                ComboBoxMethod.Items.Add("THORNTHWAITE");
                ComboBoxMethod.Items.Add("PENMAN");
            }
            if (ComboBoxMain.Text == "MONTHLY")
            {
                ComboBoxMethod.Items.Add("SUM & AVERAGE");
            }

            // W    A   T   E   R   I   N   D   U   C   E   D   H   A   Z   A   R   D

            if (ComboBoxMain.Text == "KSM")
            {
                ComboBoxMethod.Items.Add("STABILITY");
            }
            if (ComboBoxMain.Text == "RIVER BED VARIATION MODEL")
            {
                ComboBoxMethod.Items.Add("STEADY FLOW MODEL");
                ComboBoxMethod.Items.Add("UNSTEADY FLOW MODEL");
            }
            if (ComboBoxMain.Text == "DEBRIS FLOW")
            {
                ComboBoxMethod.Items.Add("LEAP FROG SCHEME");
            }
        }

        private void Btn_proceed_Click(object sender, EventArgs e)
        {
            // HYDROLOGY

            FrmMuskinghum fMuskinghum = new FrmMuskinghum();
            if(ComboBoxMethod.Text == "MUSKINGHUM")
            {
                fMuskinghum.Show();
            }
            FrmCrawford fcrawford = new FrmCrawford();
            if (ComboBoxMethod.Text == "CRAWFORD")
            {
                fcrawford.Show();
            }
            FrmMuskingumParameter fMuskingumParameter = new FrmMuskingumParameter();
            if (ComboBoxMethod.Text == "MUSKINGUM PARAMETER")
            {
                fMuskingumParameter.Show();
            }
            FrmThornthwaite fThornthwaite = new FrmThornthwaite();
            if (ComboBoxMethod.Text == "THORNTHWAITE")
            {
                 fThornthwaite.Show();
            }
            FrmPenmann_PET fpenman = new FrmPenmann_PET();
            if (ComboBoxMethod.Text == "PENMAN")
            {
                fpenman.Show();
            }
            FrmMonthly fmonthly = new FrmMonthly();
            if (ComboBoxMethod.Text == "SUM & AVERAGE")
            {
                fmonthly.Show();
            }

            // WATER INDUCED HAZARD

            FrmStability fStability = new FrmStability();
            if (ComboBoxMethod.Text == "STABILITY")
            {
                fStability.Show();
            }
            FrmSteadyFlowModel fsteadyflowmodel = new FrmSteadyFlowModel();
            if (ComboBoxMethod.Text == "STEADY FLOW MODEL")
            {
                fsteadyflowmodel.Show();
            }
            FrmUnsteadyRiverBedVariation funsteadyriverbed = new FrmUnsteadyRiverBedVariation();
            if (ComboBoxMethod.Text == "UNSTEADY FLOW MODEL")
            {
                funsteadyriverbed.Show();
            }
            FrmDebrisFlow fdebrisflow = new FrmDebrisFlow();
            if (ComboBoxMethod.Text == "LEAP FROG SCHEME")
            {
                fdebrisflow.Show();
            }

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Created in C# \n AJAY YADAV \n E-mail: ajayyadavay02@gmail.com");
            FrmAbout fabout = new FrmAbout();
            fabout.Show();
        }

        private void Btn_WIH_Click(object sender, EventArgs e)
        {
            Lblcaption1.Text = Btn_WIH.Text;
            Btn_WIH.BackColor = Color.LightSalmon;

            ComboBoxMain.Items.Clear();
            ComboBoxMain.Text = "";

            ComboBoxMain.Items.Add("KSM");
            ComboBoxMain.Items.Add("RIVER BED VARIATION MODEL");
            ComboBoxMain.Items.Add("DEBRIS FLOW");

        }
    }
}
