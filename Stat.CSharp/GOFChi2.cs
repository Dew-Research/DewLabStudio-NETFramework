using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using static Dew.Math.Tee.TeeChart;
using Dew.Stats;
using Dew.Stats.Units;

namespace StatsMasterDemo
{
    public class GOFChi2 : StatsMasterDemo.BasicForm1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        public GOFChi2()
        {
            InitializeComponent();
            vdata = new Vector(0);
        }

        private int numbins=20;
        Vector vdata;
        string distname;
        double alpha=0.05;

        /// <summary>
        /// This procedure generates observed and expected frequencies for specific distribution
        /// You could also use Statistics.GOFChi2Test oveload to do all this in one routine call,
        /// but since we have to plot observed and expected frequency histograms, we're
        /// doing it "manually" in this unit.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="GOFChiFreqs"></param>
        private void GOFChi2Freqs(Vector data, TDistribution dist, int nbins, TVec bins, TVec freq, TVec ofreq, out int df)
        {
            double par0, par1;
            int intpar0;
            int idf=0;
            Statistics.Histogram(data,numbins,ofreq,bins,false);

            switch (dist)
            {
                case TDistribution.distBETA:  
                    {
                        Statistics.BetaFit(data,out par0, out par1, 500, 1E-8);
                        Probabilities.BetaCDF(bins,par0,par1,freq);
                        idf = -3;
                    }; break;
                case TDistribution.distCHISQUARE :
                    {
                        Statistics.ChiSquareFit(data, out intpar0);
                        Probabilities.ChiSquareCDF(bins,intpar0,freq);
                        idf = -2;
                    } break;
                case TDistribution.distERLANG :
                    {
                        Statistics.ErlangFit(data, out intpar0, out par1);
                        Probabilities.ErlangCDF(bins, intpar0, par1,freq);
                    } break;
				case TDistribution.distEXP : 
                    {
                        Statistics.ExponentFit(data,out par0);
                        Probabilities.ExpCDF(bins,par0,freq);
                        idf = -2;
                    }; break;
                case TDistribution.distGAMMA : 
                    {
                         Statistics.GammaFit(data,out par0, out par1,500,1E-8);
                         Probabilities.GammaCDF(bins,par0,par1,freq);
                         idf = -3;
                    }; break;
                case TDistribution.distLAPLACE : 
                    {
                        Statistics.LaplaceFit(data, out par0, out par1);
                        Probabilities.LaplaceCDF(bins, par0, par1,freq);
                        idf = -3;
                    } break;
                case TDistribution.distLOGNORMAL : 
                    {
                        Statistics.LogNormalFit(data, out par0, out par1);
                        Probabilities.LogNormalCDF(bins,par0,par1,freq);
                        idf = -2;
                    }; break;
                case TDistribution.distMAXWELL :
                    {
                        Statistics.MaxwellFit(data, out par0);
                        Probabilities.MaxwellCDF(bins, par0, freq);
                        idf = -2;
                    }; break;
                case TDistribution.distNORMAL : 
                    {
                        Statistics.NormalFit(data, out par0, out par1);
                        Probabilities.NormalCDF(bins,par0,par1,freq);
                        idf = -3;
                    }; break;
                case TDistribution.distRAYLEIGH : 
                    {
                        Statistics.RayleighFit(data, out par0);
                        Probabilities.RayleighCDF(bins,par0,freq);
                        idf = -2;
                    }; break;
                case TDistribution.distUNIFORM : 
                    {
                        Statistics.UniformFit(data,out par0, out par1); 
                        Probabilities.UniformCDF(bins,par0,par1,freq);
                        idf = -2;
                    }; break;
                case TDistribution.distWEIBULL : 
                    {
                        Statistics.WeibullFit(data, out par0, out par1,500,1E-8); 
                        Probabilities.WeibullCDF(bins,par0,par1,freq);
                        idf = -3;
                    }; break;
            }
            freq.Difference(1);
            freq.Scale(data.Length);
            // calculate Chi2 distribution degrees of freedom
            // Nu = NumBins - NumberofParameters - 1
            idf += ofreq.Length;
            df = idf;
        }

        private void DoChi2Test()
        {
            THypothesisResult hres;
            Vector ofreq = new Vector(0);
            Vector predfreq = new Vector(0);
            Vector bins = new Vector(0);
            Vector sos = new Vector(0);
            alpha = Math387.StrToSample(textBox1.Text);

            int nu;
            double signif;
            this.Cursor = Cursors.WaitCursor;
			TDistribution dist = TDistribution.distNORMAL;
            try
            {
				switch (comboBox1.SelectedIndex)
				{
					case 0 : dist = TDistribution.distBETA; break;
					case 1 : dist = TDistribution.distCHISQUARE; break;
					case 2 : dist = TDistribution.distERLANG; break;
					case 3 : dist = TDistribution.distEXP; break;
					case 4 : dist = TDistribution.distGAMMA; break;
					case 5 : dist = TDistribution.distLAPLACE; break;
					case 6 : dist = TDistribution.distLOGNORMAL; break;
                    case 7: dist = TDistribution.distMAXWELL; break;
                    case 8: dist = TDistribution.distNORMAL; break;
					case 9: dist = TDistribution.distRAYLEIGH; break;
					case 10 : dist = TDistribution.distUNIFORM; break;
					case 11 : dist = TDistribution.distWEIBULL; break;
				}
				// Step 1: Generate necessary frequency lists,
                GOFChi2Freqs(vdata,dist,numbins,bins,predfreq,ofreq,out nu);
                // Step 2: Plot theoretical frequency
                sos.Length = bins.Length -1;
                sos.Add(bins,bins,0,1,0,bins.Length-1);
                sos.Scale(0.5);
                DrawValues(sos,predfreq,tChart1.Series[1],false);
                // Step 3: Do a Chi2 GOF test
                Statistics.GOFChi2Test(ofreq, predfreq, vdata.Length, nu, out hres, out signif, THypothesisType.htTwoTailed, alpha);
                richTextBox2.Clear();
                richTextBox2.Text  = "CHI-SQUARED GOODNESS-OF-FIT TEST\n\n";
                richTextBox2.Text += "Test against " + distname + " distribution\n";
                richTextBox2.Text += "-------------------------------\n";
                richTextBox2.Text += "Ho: Distribution fits the data\n";
                richTextBox2.Text += "Ha: Distribution does not fit the data\n";
                richTextBox2.Text += "-------------------------------\n";
                richTextBox2.Text += "Tested significance:  " + Math387.FormatSample(signif,"0.0000")+"\n";
                richTextBox2.Text += "Alpha: " + Math387.FormatSample(alpha,"0.00%")+"\n";
                if (hres == THypothesisResult.hrNotReject) richTextBox2.Text += "Data comes from tested distribution\n";
                else richTextBox2.Text += "Data does not come from tested distribution\n";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DrawDataHistogram()
        {
            Vector F = new Vector(0);
            Vector B = new Vector(0);
            Statistics.Histogram(vdata,numbins,F,B,true);
            DrawValues(B,F,tChart1.Series[0],false);
        }

        private void GenerateData(int index)
        {
            vdata.Size(1000);
            double par0,par1;
            par0 = Math387.StrToSample(textBoxpar0.Text);
            if (textBoxpar1.Visible) par1 = Math387.StrToSample(textBoxpar1.Text); else par1 = 0.0;

            switch (index)
            {
                case 0: StatRandom.RandomBeta(par0, par1, vdata,-1); break;
                case 1: StatRandom.RandomChiSquare(Convert.ToInt32(par0), vdata, -1); break;
                case 2: StatRandom.RandomErlang(Convert.ToInt32(par0), par1, vdata, -1); break;
                case 3: StatRandom.RandomExponent(par0, vdata,-1); break;
                case 4: StatRandom.RandomGamma(par0, par1, vdata, -1); break;
                case 5: StatRandom.RandomLaplace(par0, par1, vdata, -1); break;
                case 6: StatRandom.RandomLogNormal(par0, par1, vdata, -1); break;
                case 7: StatRandom.RandomMaxwell(par0, vdata, -1); break;
                case 8: StatRandom.RandomNormal(par0, par1, vdata, -1); break;
                case 9: StatRandom.RandomRayleigh(par0, vdata, -1); break;
                case 10: StatRandom.RandomUniform(par0, par1, vdata, -1); break;
                case 11: StatRandom.RandomWeibull(par0, par1, vdata, -1); break;
            }
            tChart1.Series[1].Clear();
            DrawDataHistogram();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double par0, par1;
            switch (comboBox2.SelectedIndex)
            {
                case 0: 
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "a";
                        lblpar1.Text = "b";
                        par0 = 1.3;
                        par1 = 0.7;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 1:
                    {
                        lblpar1.Visible = false;
                        lblpar0.Text = "Nu";
                        par0 = 2;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = "2";
                    }; break;
                case 2:
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "k";
                        lblpar1.Text = "lambda";
                        par0 = 3;
                        par1 = 0.37;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = "3";
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 3: 
                    {
                        lblpar1.Visible = false;
                        lblpar0.Text = "mu";
                        par0 = 0.2;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                    }; break;
                case 4: 
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "a";
                        lblpar1.Text = "b";
                        par0 = 1.8;
                        par1 = 0.5;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 5:
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "mu";
                        lblpar1.Text = "b";
                        par0 = 1.8;
                        par1 = 0.5;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 6: 
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "mu";
                        lblpar1.Text = "sigma";
                        par0 = 1.0;
                        par1 = 0.45;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 7 :
                    {
                        lblpar1.Visible = false;
                        lblpar0.Text = "a";
                        par0 = 1.2;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                    }; break;
                case 8: 
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "mu";
                        lblpar1.Text = "sigma";
                        par0 = 7.2;
                        par1 = 1.0;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 9: 
                    {
                        lblpar1.Visible = false;
                        lblpar0.Text = "b";
                        par0 = 2.2;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                    }; break;
                case 10: 
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "low";
                        lblpar1.Text = "high";
                        par0 = -2.3;
                        par1 = 1.5;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
                case 11: 
                    {
                        lblpar1.Visible = true;
                        lblpar0.Text = "a";
                        lblpar1.Text = "b";
                        par0 = 0.7;
                        par1 = 1.3;
                        textBoxpar1.Visible = lblpar1.Visible;
                        textBoxpar0.Text = par0.ToString("0.00");
                        textBoxpar1.Text = par1.ToString("0.00");
                    }; break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            distname = comboBox1.SelectedItem.ToString();
            tChart1.Header.Text = "Goodness of fit for " + distname + " distribution";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numbins = (int)numericUpDown1.Value;
            tChart1.Series[1].Clear();
            DrawDataHistogram();
        }

        private void GOFChi2_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("The chi-square test (Snedecor and Cochran, 1989) is used to test if a "
                + "sample of data came from a population with a specific distribution.");
            Add("An attractive feature of the chi-square goodness-of-fit test is that it "
                + "can be applied to any univariate distribution for which you can "
                + "calculate the cumulative distribution function (CDF). The chi-square "
                + "goodness-of-fit test is applied to binned data (i.e., data put into "
                + "classes). This is actually not a restriction since for non-binned "
                + "data you can simply calculate a histogram or frequency table before "
                + "generating the chi-square test. However, the value of the chi-square "
                + "test statistic are dependent on how the data is binned. Another "
                + "disadvantage of the chi-square test is that it requires a sufficient "
                + "sample size in order for the chi-square approximation to be valid.");
            Add("If you press the \"GENERATE\" button, a new set of random values for "
                + "specific distribution will be generated. Pressing the \"GOF TEST\" "
                + "button will trigger Chi-Squared GOF test for any of supported "
                + "distributions.�\n");
            Add("NOTE: Data validity is not checked for specific distribution so for "
                + "example, do not test for exponential distribution if values are negative!");

            textBox1.Text = alpha.ToString("0.000");
            comboBox1.SelectedIndex = 4;
            comboBox2.SelectedIndex = 4;
            GenerateData(comboBox2.SelectedIndex);
            DoChi2Test();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateData(comboBox2.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoChi2Test();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GOFChi2));
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxpar1 = new System.Windows.Forms.TextBox();
            this.textBoxpar0 = new System.Windows.Forms.TextBox();
            this.lblpar1 = new System.Windows.Forms.Label();
            this.lblpar0 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ElevationFloat = 345;
            this.tChart1.Aspect.RotationFloat = 345;
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Visible = false;
            this.tChart1.Header.Lines = new string[] {
        "TeeChart"};
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Gradient.Visible = true;
            // 
            // 
            // 
            this.tChart1.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Visible = false;
            this.tChart1.Series.Add(this.bar1);
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(378, 205);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 311);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(648, 139);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxpar1);
            this.groupBox1.Controls.Add(this.textBoxpar0);
            this.groupBox1.Controls.Add(this.lblpar1);
            this.groupBox1.Controls.Add(this.lblpar0);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate data";
            // 
            // textBoxpar1
            // 
            this.textBoxpar1.Location = new System.Drawing.Point(50, 68);
            this.textBoxpar1.Name = "textBoxpar1";
            this.textBoxpar1.Size = new System.Drawing.Size(53, 20);
            this.textBoxpar1.TabIndex = 9;
            // 
            // textBoxpar0
            // 
            this.textBoxpar0.Location = new System.Drawing.Point(50, 45);
            this.textBoxpar0.Name = "textBoxpar0";
            this.textBoxpar0.Size = new System.Drawing.Size(53, 20);
            this.textBoxpar0.TabIndex = 8;
            // 
            // lblpar1
            // 
            this.lblpar1.AutoSize = true;
            this.lblpar1.Location = new System.Drawing.Point(6, 71);
            this.lblpar1.Name = "lblpar1";
            this.lblpar1.Size = new System.Drawing.Size(38, 13);
            this.lblpar1.TabIndex = 7;
            this.lblpar1.Text = "lblpar1";
            // 
            // lblpar0
            // 
            this.lblpar0.AutoSize = true;
            this.lblpar0.Location = new System.Drawing.Point(6, 48);
            this.lblpar0.Name = "lblpar0";
            this.lblpar0.Size = new System.Drawing.Size(38, 13);
            this.lblpar0.TabIndex = 6;
            this.lblpar0.Text = "lblpar0";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(183, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "Beta",
            "Chi2",
            "Erlang",
            "Exponential",
            "Gamma",
            "Laplace",
            "Log-normal",
            "Maxwell",
            "Normal",
            "Rayleigh",
            "Uniform",
            "Weibull"});
            this.comboBox2.Location = new System.Drawing.Point(71, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Distribution";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fit for";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(183, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "GOF test";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(72, 37);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Beta",
            "Chi2",
            "Erlang",
            "Exponential",
            "Gamma",
            "Laplace",
            "Log-normal",
            "Maxwell",
            "Normal",
            "Rayleigh",
            "Uniform",
            "Weibull"});
            this.comboBox1.Location = new System.Drawing.Point(71, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# of bins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribution";
            // 
            // bar1
            // 
            this.bar1.Marks.AutoPosition = false;
            this.bar1.BarWidthPercent = 100;
            // 
            // 
            // 
            this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar1.Marks.Callout.Distance = 0;
            this.bar1.Marks.Callout.Draw3D = false;
            this.bar1.Marks.Callout.Length = 20;
            this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Font.Shadow.Visible = false;
            this.bar1.Marks.Visible = false;
            this.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
            // 
            // 
            // 
            this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bar1.SideMargins = false;
            this.bar1.Title = "bar1";
            // 
            // 
            // 
            this.bar1.XValues.DataMember = "X";
            this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar1.YValues.DataMember = "Bar";
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line1.Marks.Callout.Distance = 0;
            this.line1.Marks.Callout.Draw3D = false;
            this.line1.Marks.Callout.Length = 10;
            this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.line1.Pointer.HorizSize = 3;
            this.line1.Pointer.InflateMargins = false;
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.line1.Pointer.VertSize = 3;
            this.line1.Pointer.Visible = true;
            this.line1.Title = "line1";
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            // 
            // GOFChi2
            // 
            this.ClientSize = new System.Drawing.Size(672, 456);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GOFChi2";
            this.Load += new System.EventHandler(this.GOFChi2_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.richTextBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tChart1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.Styles.Line line1;
        private System.Windows.Forms.TextBox textBoxpar1;
        private System.Windows.Forms.TextBox textBoxpar0;
        private System.Windows.Forms.Label lblpar1;
        private System.Windows.Forms.Label lblpar0;

    }
}