﻿namespace DSPDemo {
	partial class CircularBufferForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircularBufferForm));
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem2 = new Dew.Signal.Tee.SignalTeeItem();
            this.spectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.signalStoreBuffer1 = new Dew.Signal.TSignalStoreBuffer(this.components);
            this.signalBuffer1 = new Dew.Signal.TSignalBuffer(this.components);
            this.signalGenerator1 = new Dew.Signal.TSignalGenerator(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
            this.fastLine3 = new Steema.TeeChart.Styles.FastLine();
            this.spectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.signalUpdateLabel = new System.Windows.Forms.Label();
            this.storeBufferLabel = new System.Windows.Forms.Label();
            this.writeCursorLabel = new System.Windows.Forms.Label();
            this.unreadBufferDataLabel = new System.Windows.Forms.Label();
            this.readCursorLabel = new System.Windows.Forms.Label();
            this.inputBufferSizeLabel = new System.Windows.Forms.Label();
            this.dataReadLabel = new System.Windows.Forms.Label();
            this.bufferSizeLabel = new System.Windows.Forms.Label();
            this.bufferSizeEdit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBufferEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.signalChart2 = new Dew.Signal.Tee.SignalChart();
            this.signalChart1 = new Dew.Signal.Tee.SignalChart();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // spectrumAnalyzer1
            // 
            this.spectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.spectrumAnalyzer1.Bands.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates")));
            this.spectrumAnalyzer1.BlockAssign = false;
            this.spectrumAnalyzer1.Complex = false;
            this.spectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.spectrumAnalyzer1.FloatPrecisionLock = false;
            this.spectrumAnalyzer1.Input = this.signalStoreBuffer1;
            this.spectrumAnalyzer1.IsDouble = true;
            this.spectrumAnalyzer1.Logarithmic = true;
            this.spectrumAnalyzer1.LogBase = 0D;
            this.spectrumAnalyzer1.LogScale = 0D;
            this.spectrumAnalyzer1.LogSpan = Dew.Signal.TLogSpan.ls200;
            this.spectrumAnalyzer1.Name = null;
            this.spectrumAnalyzer1.Output = null;
            this.spectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.spectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.spectrumAnalyzer1.Report.FrequencyFormat = null;
            this.spectrumAnalyzer1.Report.PhaseFormat = null;
            this.spectrumAnalyzer1.Report.UseTab = false;
            this.spectrumAnalyzer1.SidelobeAtt = 90D;
            this.spectrumAnalyzer1.SpectrumScale = 0D;
            this.spectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtKaiser;
            this.spectrumAnalyzer1.ZeroPadding = 16;
            // 
            // signalStoreBuffer1
            // 
            this.signalStoreBuffer1.ActualBufferSize = 0;
            this.signalStoreBuffer1.BandwidthL = 0D;
            this.signalStoreBuffer1.BlockAssign = false;
            this.signalStoreBuffer1.Complex = false;
            this.signalStoreBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalStoreBuffer1.FloatPrecisionLock = false;
            this.signalStoreBuffer1.Input = this.signalBuffer1;
            this.signalStoreBuffer1.IsDouble = true;
            this.signalStoreBuffer1.Length = 0;
            this.signalStoreBuffer1.Name = null;
            // 
            // signalBuffer1
            // 
            this.signalBuffer1.BandwidthL = 0D;
            this.signalBuffer1.BlockAssign = false;
            this.signalBuffer1.Complex = false;
            this.signalBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalBuffer1.FloatPrecisionLock = false;
            this.signalBuffer1.IncrementStep = 1D;
            this.signalBuffer1.Input = this.signalGenerator1;
            this.signalBuffer1.IsDouble = true;
            this.signalBuffer1.Length = 500;
            this.signalBuffer1.Name = null;
            this.signalBuffer1.OnAfterUpdate += new Dew.Math.TNotifyEvent(this.signalBuffer1_OnAfterUpdate);
            this.signalBuffer1.OnBeforeUpdate += new Dew.Math.TNotifyEvent(this.signalBuffer1_OnBeforeUpdate);
            // 
            // signalGenerator1
            // 
            this.signalGenerator1.BandwidthL = 0D;
            this.signalGenerator1.BlockAssign = false;
            this.signalGenerator1.Complex = false;
            this.signalGenerator1.ComputeMessage = "";
            this.signalGenerator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalGenerator1.FloatPrecisionLock = false;
            this.signalGenerator1.Input = null;
            this.signalGenerator1.IsDouble = true;
            this.signalGenerator1.Length = 900;
            this.signalGenerator1.Name = null;
            this.signalGenerator1.SamplingFrequency = 40D;
            this.signalGenerator1.Sounds.TemplateIndex = 1;
            this.signalGenerator1.Sounds.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates1")));
            this.signalGenerator1.OnAfterUpdate += new Dew.Math.TNotifyEvent(this.signalGenerator1_OnAfterUpdate);
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine1.Legend.Brush.Color = System.Drawing.Color.White;
            this.fastLine1.Legend.Brush.Solid = true;
            this.fastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine1.Legend.Font.Brush.Solid = true;
            this.fastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Legend.Font.Shadow.Brush.Solid = true;
            this.fastLine1.Legend.Font.Shadow.Brush.Visible = true;
            this.fastLine1.Legend.Font.Size = 8;
            this.fastLine1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine1.Legend.ImageBevel.Brush.Solid = true;
            this.fastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Legend.Shadow.Brush.Solid = true;
            this.fastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine1.Marks.Brush.Solid = true;
            this.fastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine1.Marks.Font.Brush.Solid = true;
            this.fastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Marks.Font.Shadow.Brush.Solid = true;
            this.fastLine1.Marks.Font.Shadow.Brush.Visible = true;
            this.fastLine1.Marks.Font.Size = 8;
            this.fastLine1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine1.Marks.ImageBevel.Brush.Solid = true;
            this.fastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.fastLine1.Marks.Shadow.Brush.Solid = true;
            this.fastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.fastLine1.Marks.Symbol.Brush.Solid = true;
            this.fastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.fastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.fastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.fastLine1.Marks.TailParams.Margin = 0F;
            this.fastLine1.Marks.TailParams.PointerHeight = 8D;
            this.fastLine1.Marks.TailParams.PointerWidth = 8D;
            this.fastLine1.OriginalCursor = System.Windows.Forms.Cursors.Default;
            this.fastLine1.Title = "fastLine1";
            this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine1.XValues.DataMember = "X";
            this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine1.YValues.DataMember = "Y";
            // 
            // fastLine2
            // 
            this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine2.Legend.Brush.Color = System.Drawing.Color.White;
            this.fastLine2.Legend.Brush.Solid = true;
            this.fastLine2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine2.Legend.Font.Brush.Solid = true;
            this.fastLine2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Legend.Font.Shadow.Brush.Solid = true;
            this.fastLine2.Legend.Font.Shadow.Brush.Visible = true;
            this.fastLine2.Legend.Font.Size = 8;
            this.fastLine2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine2.Legend.ImageBevel.Brush.Solid = true;
            this.fastLine2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Legend.Shadow.Brush.Solid = true;
            this.fastLine2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine2.Marks.Brush.Solid = true;
            this.fastLine2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine2.Marks.Font.Brush.Solid = true;
            this.fastLine2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Marks.Font.Shadow.Brush.Solid = true;
            this.fastLine2.Marks.Font.Shadow.Brush.Visible = true;
            this.fastLine2.Marks.Font.Size = 8;
            this.fastLine2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine2.Marks.ImageBevel.Brush.Solid = true;
            this.fastLine2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.fastLine2.Marks.Shadow.Brush.Solid = true;
            this.fastLine2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.fastLine2.Marks.Symbol.Brush.Solid = true;
            this.fastLine2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.fastLine2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.fastLine2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.fastLine2.Marks.TailParams.Margin = 0F;
            this.fastLine2.Marks.TailParams.PointerHeight = 8D;
            this.fastLine2.Marks.TailParams.PointerWidth = 8D;
            this.fastLine2.OriginalCursor = System.Windows.Forms.Cursors.Default;
            this.fastLine2.Title = "fastLine2";
            this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine2.XValues.DataMember = "X";
            this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine2.YValues.DataMember = "Y";
            // 
            // fastLine3
            // 
            this.fastLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine3.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine3.Legend.Brush.Color = System.Drawing.Color.White;
            this.fastLine3.Legend.Brush.Solid = true;
            this.fastLine3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine3.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine3.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine3.Legend.Font.Brush.Solid = true;
            this.fastLine3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine3.Legend.Font.Shadow.Brush.Solid = true;
            this.fastLine3.Legend.Font.Shadow.Brush.Visible = true;
            this.fastLine3.Legend.Font.Size = 8;
            this.fastLine3.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine3.Legend.ImageBevel.Brush.Solid = true;
            this.fastLine3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine3.Legend.Shadow.Brush.Solid = true;
            this.fastLine3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine3.Marks.Brush.Solid = true;
            this.fastLine3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine3.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine3.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine3.Marks.Font.Brush.Solid = true;
            this.fastLine3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine3.Marks.Font.Shadow.Brush.Solid = true;
            this.fastLine3.Marks.Font.Shadow.Brush.Visible = true;
            this.fastLine3.Marks.Font.Size = 8;
            this.fastLine3.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine3.Marks.ImageBevel.Brush.Solid = true;
            this.fastLine3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.fastLine3.Marks.Shadow.Brush.Solid = true;
            this.fastLine3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine3.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.fastLine3.Marks.Symbol.Brush.Solid = true;
            this.fastLine3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.fastLine3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine3.Marks.Symbol.Shadow.Brush.Solid = true;
            this.fastLine3.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine3.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.fastLine3.Marks.TailParams.Margin = 0F;
            this.fastLine3.Marks.TailParams.PointerHeight = 8D;
            this.fastLine3.Marks.TailParams.PointerWidth = 8D;
            this.fastLine3.OriginalCursor = System.Windows.Forms.Cursors.Default;
            this.fastLine3.Title = "fastLine1";
            this.fastLine3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine3.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine3.XValues.DataMember = "X";
            this.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine3.YValues.DataMember = "Y";
            // 
            // spectrumChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.spectrumChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Depth.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Depth.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.spectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Left.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Left.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Right.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Right.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Right.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Right.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Top.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Top.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Top.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Top.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.spectrumChart1.Color = System.Drawing.Color.White;
            this.spectrumChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.spectrumChart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Footer.Brush.Solid = true;
            this.spectrumChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart1.Footer.Font.Brush.Solid = true;
            this.spectrumChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Footer.Font.Size = 8;
            this.spectrumChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Footer.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Footer.Shadow.Brush.Solid = true;
            this.spectrumChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart1.Header.Brush.Solid = true;
            this.spectrumChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Header.Font.Brush.Solid = true;
            this.spectrumChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Header.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Header.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Header.Font.Size = 12;
            this.spectrumChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Header.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Header.ImageBevel.Brush.Visible = true;
            this.spectrumChart1.Header.Lines = new string[] {
        "Spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart1.Header.Shadow.Brush.Solid = true;
            this.spectrumChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Legend.Brush.Solid = true;
            this.spectrumChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Legend.Font.Brush.Solid = true;
            this.spectrumChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Legend.Font.Size = 9;
            this.spectrumChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Legend.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spectrumChart1.Legend.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Legend.Title.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.spectrumChart1.Legend.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Legend.Title.Font.Size = 8;
            this.spectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.spectrumChart1.Legend.Visible = false;
            this.spectrumChart1.Location = new System.Drawing.Point(0, 0);
            this.spectrumChart1.Name = "spectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Panel.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Panel.Brush.Solid = true;
            this.spectrumChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Panel.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Panel.Shadow.Brush.Solid = true;
            this.spectrumChart1.Panel.Shadow.Brush.Visible = true;
            this.spectrumChart1.Series.Add(this.fastLine1);
            this.spectrumChart1.Size = new System.Drawing.Size(905, 152);
            this.spectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = this.spectrumAnalyzer1;
            spectrumTeeItem1.Inputs = null;
            spectrumTeeItem1.InputsItemIndex = 0;
            spectrumTeeItem1.Series = this.fastLine1;
            spectrumTeeItem1.SeriesName = "fastLine1";
            this.spectrumChart1.Spectrums.Add(spectrumTeeItem1);
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.SubFooter.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart1.SubFooter.Font.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.SubFooter.Font.Size = 8;
            this.spectrumChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.SubFooter.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart1.SubHeader.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.SubHeader.Font.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.SubHeader.Font.Size = 12;
            this.spectrumChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart1.SubHeader.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Shadow.Brush.Visible = true;
            this.spectrumChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Walls.Back.Brush.Solid = true;
            this.spectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Walls.Bottom.Brush.Solid = true;
            this.spectrumChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart1.Walls.Left.Brush.Solid = true;
            this.spectrumChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart1.Walls.Right.Brush.Solid = true;
            this.spectrumChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.spectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.spectrumChart1.Zoom.Brush.Solid = true;
            this.spectrumChart1.Zoom.Brush.Visible = false;
            this.spectrumChart1.Zoom.FullRepaint = true;
            this.spectrumChart1.Zoom.Pen.Visible = true;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.signalUpdateLabel);
            this.panel1.Controls.Add(this.storeBufferLabel);
            this.panel1.Controls.Add(this.writeCursorLabel);
            this.panel1.Controls.Add(this.unreadBufferDataLabel);
            this.panel1.Controls.Add(this.readCursorLabel);
            this.panel1.Controls.Add(this.inputBufferSizeLabel);
            this.panel1.Controls.Add(this.dataReadLabel);
            this.panel1.Controls.Add(this.bufferSizeLabel);
            this.panel1.Controls.Add(this.bufferSizeEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputBufferEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 126);
            this.panel1.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(737, 91);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(818, 91);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // signalUpdateLabel
            // 
            this.signalUpdateLabel.AutoSize = true;
            this.signalUpdateLabel.Location = new System.Drawing.Point(450, 8);
            this.signalUpdateLabel.Name = "signalUpdateLabel";
            this.signalUpdateLabel.Size = new System.Drawing.Size(173, 13);
            this.signalUpdateLabel.TabIndex = 5;
            this.signalUpdateLabel.Text = "Signal generator has been updated";
            // 
            // storeBufferLabel
            // 
            this.storeBufferLabel.AutoSize = true;
            this.storeBufferLabel.Location = new System.Drawing.Point(12, 85);
            this.storeBufferLabel.Name = "storeBufferLabel";
            this.storeBufferLabel.Size = new System.Drawing.Size(65, 13);
            this.storeBufferLabel.TabIndex = 4;
            this.storeBufferLabel.Text = "Store buffer:";
            // 
            // writeCursorLabel
            // 
            this.writeCursorLabel.AutoSize = true;
            this.writeCursorLabel.Location = new System.Drawing.Point(171, 68);
            this.writeCursorLabel.Name = "writeCursorLabel";
            this.writeCursorLabel.Size = new System.Drawing.Size(67, 13);
            this.writeCursorLabel.TabIndex = 3;
            this.writeCursorLabel.Text = "Write cursor:";
            // 
            // unreadBufferDataLabel
            // 
            this.unreadBufferDataLabel.AutoSize = true;
            this.unreadBufferDataLabel.Location = new System.Drawing.Point(12, 68);
            this.unreadBufferDataLabel.Name = "unreadBufferDataLabel";
            this.unreadBufferDataLabel.Size = new System.Drawing.Size(76, 13);
            this.unreadBufferDataLabel.TabIndex = 3;
            this.unreadBufferDataLabel.Text = "Unread Buffer:";
            // 
            // readCursorLabel
            // 
            this.readCursorLabel.AutoSize = true;
            this.readCursorLabel.Location = new System.Drawing.Point(171, 51);
            this.readCursorLabel.Name = "readCursorLabel";
            this.readCursorLabel.Size = new System.Drawing.Size(68, 13);
            this.readCursorLabel.TabIndex = 3;
            this.readCursorLabel.Text = "Read cursor:";
            // 
            // inputBufferSizeLabel
            // 
            this.inputBufferSizeLabel.AutoSize = true;
            this.inputBufferSizeLabel.Location = new System.Drawing.Point(12, 51);
            this.inputBufferSizeLabel.Name = "inputBufferSizeLabel";
            this.inputBufferSizeLabel.Size = new System.Drawing.Size(85, 13);
            this.inputBufferSizeLabel.TabIndex = 3;
            this.inputBufferSizeLabel.Text = "Input buffer size:";
            // 
            // dataReadLabel
            // 
            this.dataReadLabel.AutoSize = true;
            this.dataReadLabel.Location = new System.Drawing.Point(171, 34);
            this.dataReadLabel.Name = "dataReadLabel";
            this.dataReadLabel.Size = new System.Drawing.Size(61, 13);
            this.dataReadLabel.TabIndex = 2;
            this.dataReadLabel.Text = "Stream OK:";
            // 
            // bufferSizeLabel
            // 
            this.bufferSizeLabel.AutoSize = true;
            this.bufferSizeLabel.Location = new System.Drawing.Point(12, 34);
            this.bufferSizeLabel.Name = "bufferSizeLabel";
            this.bufferSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.bufferSizeLabel.TabIndex = 2;
            this.bufferSizeLabel.Text = "Buffer size:";
            // 
            // bufferSizeEdit
            // 
            this.bufferSizeEdit.Increment = "1";
            this.bufferSizeEdit.Location = new System.Drawing.Point(270, 6);
            this.bufferSizeEdit.Name = "bufferSizeEdit";
            this.bufferSizeEdit.ReFormat = "0";
            this.bufferSizeEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.bufferSizeEdit.Scientific = false;
            this.bufferSizeEdit.Size = new System.Drawing.Size(60, 20);
            this.bufferSizeEdit.TabIndex = 1;
            this.bufferSizeEdit.Value = "500";
            this.bufferSizeEdit.Click += new System.EventHandler(this.bufferSizeEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output buffer size:";
            // 
            // inputBufferEdit
            // 
            this.inputBufferEdit.Increment = "1";
            this.inputBufferEdit.Location = new System.Drawing.Point(103, 6);
            this.inputBufferEdit.Name = "inputBufferEdit";
            this.inputBufferEdit.ReFormat = "0";
            this.inputBufferEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.inputBufferEdit.Scientific = false;
            this.inputBufferEdit.Size = new System.Drawing.Size(60, 20);
            this.inputBufferEdit.TabIndex = 1;
            this.inputBufferEdit.Value = "500";
            this.inputBufferEdit.Click += new System.EventHandler(this.inputBufferEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input buffer size:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 152);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(905, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.signalChart2);
            this.panel2.Controls.Add(this.signalChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 238);
            this.panel2.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 117);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(905, 3);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // signalChart2
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Grid.DrawEvery = 1;
            this.signalChart2.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Axes.Bottom.Labels.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Bottom.Labels.Font.Size = 9;
            this.signalChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Axes.Bottom.Title.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Bottom.Title.Font.Size = 11;
            this.signalChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Axes.Depth.Labels.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Depth.Labels.Font.Size = 9;
            this.signalChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Axes.Depth.Title.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Depth.Title.Font.Size = 11;
            this.signalChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.DepthTop.Labels.Font.Size = 9;
            this.signalChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Axes.DepthTop.Title.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.DepthTop.Title.Font.Size = 11;
            this.signalChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Axes.Left.Labels.Brush.Solid = true;
            this.signalChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            this.signalChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Left.Labels.Font.Size = 9;
            this.signalChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Axes.Left.Title.Brush.Solid = true;
            this.signalChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Axes.Left.Title.Font.Brush.Solid = true;
            this.signalChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Left.Title.Font.Size = 11;
            this.signalChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Axes.Right.Labels.Brush.Solid = true;
            this.signalChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            this.signalChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Right.Labels.Font.Size = 9;
            this.signalChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Axes.Right.Title.Brush.Solid = true;
            this.signalChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Axes.Right.Title.Font.Brush.Solid = true;
            this.signalChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Right.Title.Font.Size = 11;
            this.signalChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Axes.Top.Labels.Brush.Solid = true;
            this.signalChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            this.signalChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Top.Labels.Font.Size = 9;
            this.signalChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Axes.Top.Title.Brush.Solid = true;
            this.signalChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Axes.Top.Title.Font.Brush.Solid = true;
            this.signalChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Axes.Top.Title.Font.Size = 11;
            this.signalChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.signalChart2.Color = System.Drawing.Color.White;
            this.signalChart2.Cursor = System.Windows.Forms.Cursors.Default;
            this.signalChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Footer.Brush.Solid = true;
            this.signalChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart2.Footer.Font.Brush.Solid = true;
            this.signalChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Footer.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Footer.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Footer.Font.Size = 8;
            this.signalChart2.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Footer.ImageBevel.Brush.Solid = true;
            this.signalChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Footer.Shadow.Brush.Solid = true;
            this.signalChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart2.Header.Brush.Solid = true;
            this.signalChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.Header.Font.Brush.Solid = true;
            this.signalChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Header.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Header.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Header.Font.Size = 12;
            this.signalChart2.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Header.ImageBevel.Brush.Solid = true;
            this.signalChart2.Header.ImageBevel.Brush.Visible = true;
            this.signalChart2.Header.Lines = new string[] {
        "Signal buffer chart"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart2.Header.Shadow.Brush.Solid = true;
            this.signalChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Legend.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Legend.Brush.Solid = true;
            this.signalChart2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart2.Legend.Font.Brush.Solid = true;
            this.signalChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Legend.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Legend.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Legend.Font.Size = 9;
            this.signalChart2.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Legend.ImageBevel.Brush.Solid = true;
            this.signalChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signalChart2.Legend.Shadow.Brush.Solid = true;
            this.signalChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            this.signalChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Legend.Title.Brush.Solid = true;
            this.signalChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.signalChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.signalChart2.Legend.Title.Font.Brush.Solid = true;
            this.signalChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart2.Legend.Title.Font.Size = 8;
            this.signalChart2.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            this.signalChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Legend.Title.Shadow.Brush.Solid = true;
            this.signalChart2.Legend.Title.Shadow.Brush.Visible = true;
            this.signalChart2.Legend.Visible = false;
            this.signalChart2.Location = new System.Drawing.Point(0, 117);
            this.signalChart2.Name = "signalChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Panel.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Panel.Brush.Solid = true;
            this.signalChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Panel.ImageBevel.Brush.Solid = true;
            this.signalChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Panel.Shadow.Brush.Solid = true;
            this.signalChart2.Panel.Shadow.Brush.Visible = true;
            this.signalChart2.Series.Add(this.fastLine3);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = this.signalStoreBuffer1;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = this.fastLine3;
            signalTeeItem1.SeriesName = "fastLine1";
            this.signalChart2.Signals.Add(signalTeeItem1);
            this.signalChart2.Size = new System.Drawing.Size(905, 121);
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.SubFooter.Brush.Solid = true;
            this.signalChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart2.SubFooter.Font.Brush.Solid = true;
            this.signalChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            this.signalChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            this.signalChart2.SubFooter.Font.Size = 8;
            this.signalChart2.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.SubFooter.ImageBevel.Brush.Solid = true;
            this.signalChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.SubFooter.Shadow.Brush.Solid = true;
            this.signalChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart2.SubHeader.Brush.Solid = true;
            this.signalChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart2.SubHeader.Font.Brush.Solid = true;
            this.signalChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            this.signalChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            this.signalChart2.SubHeader.Font.Size = 12;
            this.signalChart2.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.SubHeader.ImageBevel.Brush.Solid = true;
            this.signalChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart2.SubHeader.Shadow.Brush.Solid = true;
            this.signalChart2.SubHeader.Shadow.Brush.Visible = true;
            this.signalChart2.TabIndex = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart2.Walls.Back.Brush.Solid = true;
            this.signalChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            this.signalChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Walls.Back.Shadow.Brush.Solid = true;
            this.signalChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.signalChart2.Walls.Bottom.Brush.Solid = true;
            this.signalChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.signalChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            this.signalChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart2.Walls.Left.Brush.Solid = true;
            this.signalChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            this.signalChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Walls.Left.Shadow.Brush.Solid = true;
            this.signalChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart2.Walls.Right.Brush.Solid = true;
            this.signalChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            this.signalChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart2.Walls.Right.Shadow.Brush.Solid = true;
            this.signalChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart2.Zoom.Animated = true;
            // 
            // 
            // 
            this.signalChart2.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.signalChart2.Zoom.Brush.Solid = true;
            this.signalChart2.Zoom.Brush.Visible = false;
            this.signalChart2.Zoom.History = true;
            this.signalChart1.Zoom.FullRepaint = true;
            this.signalChart1.Zoom.Pen.Visible = true;
            // 
            // signalChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.signalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.signalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Font.Size = 11;
            this.signalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Depth.Labels.Font.Size = 9;
            this.signalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Depth.Title.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Depth.Title.Font.Size = 11;
            this.signalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.signalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.signalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Left.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.Labels.Font.Size = 9;
            this.signalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Left.Title.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.Title.Font.Size = 11;
            this.signalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Right.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Right.Labels.Font.Size = 9;
            this.signalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Right.Title.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Right.Title.Font.Size = 11;
            this.signalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Top.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Top.Labels.Font.Size = 9;
            this.signalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Top.Title.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Top.Title.Font.Size = 11;
            this.signalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.signalChart1.Color = System.Drawing.Color.White;
            this.signalChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.signalChart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Footer.Brush.Solid = true;
            this.signalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart1.Footer.Font.Brush.Solid = true;
            this.signalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Footer.Font.Size = 8;
            this.signalChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Footer.ImageBevel.Brush.Solid = true;
            this.signalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Footer.Shadow.Brush.Solid = true;
            this.signalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart1.Header.Brush.Solid = true;
            this.signalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Header.Font.Brush.Solid = true;
            this.signalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Header.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Header.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Header.Font.Size = 12;
            this.signalChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Header.ImageBevel.Brush.Solid = true;
            this.signalChart1.Header.ImageBevel.Brush.Visible = true;
            this.signalChart1.Header.Lines = new string[] {
        "Signal generator chart"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart1.Header.Shadow.Brush.Solid = true;
            this.signalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Legend.Brush.Solid = true;
            this.signalChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Legend.Font.Brush.Solid = true;
            this.signalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Font.Size = 9;
            this.signalChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Legend.ImageBevel.Brush.Solid = true;
            this.signalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signalChart1.Legend.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Legend.Title.Brush.Solid = true;
            this.signalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.signalChart1.Legend.Title.Font.Brush.Solid = true;
            this.signalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Title.Font.Size = 8;
            this.signalChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Visible = false;
            this.signalChart1.Location = new System.Drawing.Point(0, 0);
            this.signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Panel.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Panel.Brush.Solid = true;
            this.signalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Panel.ImageBevel.Brush.Solid = true;
            this.signalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Panel.Shadow.Brush.Solid = true;
            this.signalChart1.Panel.Shadow.Brush.Visible = true;
            this.signalChart1.Series.Add(this.fastLine2);
            signalTeeItem2.Caption = null;
            signalTeeItem2.Input = this.signalGenerator1;
            signalTeeItem2.Inputs = null;
            signalTeeItem2.InputsItemIndex = 0;
            signalTeeItem2.Series = this.fastLine2;
            signalTeeItem2.SeriesName = "fastLine2";
            this.signalChart1.Signals.Add(signalTeeItem2);
            this.signalChart1.Size = new System.Drawing.Size(905, 117);
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.SubFooter.Brush.Solid = true;
            this.signalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart1.SubFooter.Font.Brush.Solid = true;
            this.signalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.signalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.signalChart1.SubFooter.Font.Size = 8;
            this.signalChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.signalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubFooter.Shadow.Brush.Solid = true;
            this.signalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart1.SubHeader.Brush.Solid = true;
            this.signalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.SubHeader.Font.Brush.Solid = true;
            this.signalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.signalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.signalChart1.SubHeader.Font.Size = 12;
            this.signalChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.signalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart1.SubHeader.Shadow.Brush.Solid = true;
            this.signalChart1.SubHeader.Shadow.Brush.Visible = true;
            this.signalChart1.TabIndex = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Walls.Back.Brush.Solid = true;
            this.signalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Walls.Bottom.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart1.Walls.Left.Brush.Solid = true;
            this.signalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart1.Walls.Right.Brush.Solid = true;
            this.signalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.signalChart1.Zoom.Brush.Solid = true;
            this.signalChart1.Zoom.Brush.Visible = false;
            this.signalChart1.Zoom.History = true;
            this.signalChart1.Zoom.FullRepaint = true;
            this.signalChart1.Zoom.Pen.Visible = true;
            // 
            // CircularBufferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spectrumChart1);
            this.Name = "CircularBufferForm";
            this.Text = "CircularBufferForm";
            this.Load += new System.EventHandler(this.CircularBufferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Dew.Signal.Tee.SpectrumChart spectrumChart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private Dew.Signal.TSignalGenerator signalGenerator1;
		private Dew.Signal.TSignalBuffer signalBuffer1;
		private Dew.Signal.TSignalStoreBuffer signalStoreBuffer1;
		private Dew.Signal.TSpectrumAnalyzer spectrumAnalyzer1;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private System.Windows.Forms.Splitter splitter2;
		private Dew.Signal.Tee.SignalChart signalChart2;
		private Dew.Signal.Tee.SignalChart signalChart1;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private Steema.TeeChart.Styles.FastLine fastLine3;
		private System.Windows.Forms.Label storeBufferLabel;
		private System.Windows.Forms.Label unreadBufferDataLabel;
		private System.Windows.Forms.Label inputBufferSizeLabel;
		private System.Windows.Forms.Label bufferSizeLabel;
		private Dew.Math.Controls.FloatEdit bufferSizeEdit;
		private System.Windows.Forms.Label label2;
		private Dew.Math.Controls.FloatEdit inputBufferEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label signalUpdateLabel;
		private System.Windows.Forms.Label writeCursorLabel;
		private System.Windows.Forms.Label readCursorLabel;
		private System.Windows.Forms.Label dataReadLabel;
	}
}