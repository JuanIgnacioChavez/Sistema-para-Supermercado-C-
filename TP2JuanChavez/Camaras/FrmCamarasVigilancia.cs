using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP2JuanChavez.Camaras
{
	public partial class FrmCamarasVigilancia : Form
	{
		#region Declarar cámaras
		private VideoCapture videoCapture1;
		private VideoCapture videoCapture2;
		private VideoCapture videoCapture3;
		private Mat currentFrame1;
		private Mat currentFrame2;
		private Mat currentFrame3;
		#endregion

		public FrmCamarasVigilancia()
		{
			InitializeComponent();
			videoCapture1 = new VideoCapture(@"C:\Users\juani\source\repos\TP2_JuanChavez\CAMARAS\CAMARA 1.mp4");
			videoCapture2 = new VideoCapture(@"C:\Users\juani\source\repos\TP2_JuanChavez\CAMARAS\CAMARA 2.mp4");
			videoCapture3 = new VideoCapture(@"C:\Users\juani\source\repos\TP2_JuanChavez\CAMARAS\CAMARA 3.mp4");

			currentFrame1 = new Mat();
			currentFrame2 = new Mat();
			currentFrame3 = new Mat();
		}

		private void FrmCamarasVigilancia_Load(object sender, EventArgs e)
		{
			Application.Idle += ProcessFrame;
		}

		#region Métodos para hacer reproducir los videos
		private void ProcessFrame(object sender, EventArgs e)
		{
			ShowVideoInPictureBox(videoCapture1, currentFrame1, pictureBox1);
			ShowVideoInPictureBox(videoCapture2, currentFrame2, pictureBox2);
			ShowVideoInPictureBox(videoCapture3, currentFrame3, pictureBox3);
		}

		private void ShowVideoInPictureBox(VideoCapture videoCapture, Mat currentFrame, PictureBox pictureBox)
		{
			if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
			{
				videoCapture.Read(currentFrame);
				if (!currentFrame.IsEmpty)
				{
					pictureBox.Image = currentFrame.ToImage<Bgr, byte>().ToBitmap();
				}
				else
				{
					videoCapture.SetCaptureProperty(CapProp.PosFrames, 0);
				}
			}

			int frameInterval = 30;
			System.Threading.Thread.Sleep(frameInterval);
		}
		#endregion


		private void FrmCamarasVigilancia_FormClosing(object sender, FormClosingEventArgs e)
		{
			videoCapture1.Dispose();
			videoCapture2.Dispose();
			videoCapture3.Dispose();
		}
	}
}
