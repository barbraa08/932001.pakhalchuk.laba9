using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double r, avprob, varprob, av, var, averr, varerr, chi;

		Random rand = new Random();

		double[] prob;
		double[] freq;
		int[] stat;
		int num;

		private void btResult_Click(object sender, EventArgs e)
		{
			prob = new double[5];
			stat = new int[5];
			freq = new double[5];
			num = (int)tbNum.Value;
			prob[0] = (double)tbProb1.Value;
			prob[1] = (double)tbProb2.Value;
			prob[2] = (double)tbProb3.Value;
			prob[3] = (double)tbProb4.Value;
			prob[4] = 1;

			for (int i = 0; i < 4; i++) prob[4] -= prob[i];
			tbProb5.Text = prob[4].ToString();

			for (int i = 0; i < num; i++)
			{
				r = rand.NextDouble();
				double sum = 0;
				for (int k = 0; k < 5; k++)
				{
					sum += prob[k];
					if (r <= sum)
					{
						stat[k]++;
						break;
					}
				}
			}

			for (int i = 0; i < 5; i++) freq[i] = stat[i] / (double)num;
			chart1.Series[0].Points.Clear();
			for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i + 1, freq[i]);

			for (int i = 0; i < 5; i++)
			{
				avprob += (i + 1) * prob[i];
				varprob += (i + 1) * (i + 1) * prob[i] - ((i + 1) * prob[i]) * ((i + 1) * prob[i]);
				av += (i + 1) * freq[i];
				var += (i + 1) * (i + 1) * freq[i] - ((i + 1) * freq[i]) * ((i + 1) * freq[i]);
				chi += stat[i] * stat[i] / ((double)num * prob[i]);
			}

			chi = Math.Round(chi - (double)num, 2);
			averr = Math.Round(Math.Abs(av - avprob) * 100 / avprob, 1);
			varerr = Math.Round(Math.Abs(var - varprob) * 100 / varprob, 1);
			tbAv.Text = av.ToString();
			tbVar.Text = var.ToString();
			tbAvErr.Text = averr.ToString() + "%";
			tbVarErr.Text = varerr.ToString() + "%";
			tbChi.Text = chi.ToString();
			if (chi > 9.488) tbCompare.Text = "> 9.488  true";
			else tbCompare.Text = "> 9.488  NOT true";
		}
	}
}
