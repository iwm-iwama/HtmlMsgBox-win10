using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iwm_HtmlMsgBox
{
	public partial class Form1 : Form
	{
		private const string VER = "HtmlMessageBox iwm20201121";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();

		private readonly int[] WebBrowser1_HEIGHT = { 0, 0 };
		private readonly int[] BtnYes_POSX = { 0, 0 };

		private readonly string ExecPath = Application.StartupPath;
		private string sStartUrl = "help/index.html";

		private Color BtnGoStartPageColor;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 初期化
			Text = "";

			BtnGoStartPageColor = BtnGoStartPage.BackColor;
			BtnGoStartPage.Enabled = false;

			WebBrowser1_HEIGHT[0] = WebBrowser1.Height;
			WebBrowser1_HEIGHT[1] = WebBrowser1_HEIGHT[0] + 20;
			WebBrowser1.Height = WebBrowser1_HEIGHT[1];

			CbAccept.Checked = true;

			BtnYes_POSX[0] = BtnYes.Location.X;
			BtnYes_POSX[1] = BtnNo.Location.X;
			BtnYes.Visible = false;
			BtnNo.Visible = false;

			int iW = Width;
			int iH = Height;
			string sUrl = "";

			// [0] は Program なので読み飛ばす
			for (int _i1 = 1; _i1 < ARGS.Length; _i1++)
			{
				string _s1 = ARGS[_i1];
				string[] _as1;

				if (Regex.IsMatch(_s1, @"^\-size\=\d+\,\d+"))
				{
					_as1 = _s1.Substring(6).Split(',');

					iW = int.Parse(_as1[0]);
					iH = int.Parse(_as1[1]);

					if (iW < MinimumSize.Width)
					{
						iW = MinimumSize.Width;
					}
					else if (iW > Screen.PrimaryScreen.WorkingArea.Width)
					{
						iW = Screen.PrimaryScreen.WorkingArea.Width;
					}

					if (iH < MinimumSize.Height)
					{
						iH = MinimumSize.Height;
					}
					else if (iH > Screen.PrimaryScreen.WorkingArea.Height)
					{
						iH = Screen.PrimaryScreen.WorkingArea.Height;
					}
				}
				else if (Regex.IsMatch(_s1, @"^\-title\=.+"))
				{
					Text = _s1.Substring(7);
				}
				else if (Regex.IsMatch(_s1, @"^\-url\=.+"))
				{
					sUrl = _s1.Substring(5);
				}
				else if (Regex.IsMatch(_s1, @"^\-checkbox\=.*"))
				{
					CbAccept.Text = _s1.Substring(10);
					CbAccept.Checked = false;
					WebBrowser1.Height = WebBrowser1_HEIGHT[0];
				}
				else if (Regex.IsMatch(_s1, @"^\-button\=\d+\,\d+"))
				{
					_as1 = _s1.Substring(8).Split(',');
					BtnYes.Visible = int.Parse(_as1[0]) > 0;
					BtnNo.Visible = int.Parse(_as1[1]) > 0;
				}
				else if (Regex.IsMatch(_s1, @"^\-buttontext\=.+\,.+\,.+"))
				{
					_as1 = _s1.Substring(12).Split(',');
					BtnYes.Text = _as1[0];
					BtnNo.Text = _as1[1];
					BtnCancel.Text = _as1[2];
				}
			}

			sStartUrl = Regex.IsMatch(sStartUrl, @"^(http[s]*|file)://") ? sStartUrl : ("file:///" + ExecPath + "/" + sStartUrl).Replace(@"\", "/");

			if (sUrl.Length > 0)
			{
				sUrl = Regex.IsMatch(sUrl, @"^(http[s]*|file)://") ? sUrl : ("file:///" + ExecPath + "/" + sUrl).Replace(@"\", "/");
			}

			if (sUrl.Length == 0 || sUrl == sStartUrl)
			{
				Text = VER;
			}
			else
			{
				sStartUrl = sUrl;
			}

			WebBrowser1.Navigate(sStartUrl);

			// 再描画
			BtnYes.Enabled = CbAccept.Checked;
			BtnYes.Location = BtnYes.Visible && !BtnNo.Visible ? new Point(BtnYes_POSX[1], BtnYes.Location.Y) : new Point(BtnYes_POSX[0], BtnYes.Location.Y);

			Width = iW;
			Height = iH;

			StartPosition = FormStartPosition.CenterScreen;
			Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
			Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
		}

		private Point MousePoint;

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				MousePoint = new Point(e.X, e.Y);
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				Left += e.X - MousePoint.X;
				Top += e.Y - MousePoint.Y;
			}
		}

		private void BtnGoStartPage_Click(object sender, EventArgs e)
		{
			WebBrowser1.Navigate(sStartUrl);
		}

		private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			TbUrl.Text = WebBrowser1.Url.ToString();

			if (TbUrl.Text == sStartUrl)
			{
				BtnGoStartPage.Enabled = false;
				BtnGoStartPage.BackColor = BackColor;
			}
			else
			{
				BtnGoStartPage.Enabled = true;
				BtnGoStartPage.BackColor = BtnGoStartPageColor;
			}
		}

		private void CbAccept_CheckedChanged(object sender, EventArgs e)
		{
			if (CbAccept.Checked)
			{
				BtnYes.Enabled = true;
				_ = BtnYes.Focus();
			}
			else
			{
				BtnYes.Enabled = false;
				_ = BtnNo.Visible ? BtnNo.Focus() : BtnCancel.Focus();
			}
		}

		private void BtnYes_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 1;
			Close();
		}

		private void BtnNo_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 2;
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 0;
			Close();
		}
	}

	public class Pub
	{
		public static int Rtn = 0;
	}

	public class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			Console.Write(Pub.Rtn);
		}
	}
}
