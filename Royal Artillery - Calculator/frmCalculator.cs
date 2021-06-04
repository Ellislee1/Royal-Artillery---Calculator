using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Artillery___Calculator
{
    public partial class frmCalculator : Form
    {
        private int distance = 0;
        private int altitude = 0;

        private int batAlt = 0;
        private int tgtAlt = 0;

        private List<Record> rangeCard = new List<Record>();


        public frmCalculator()
        {
            InitializeComponent();
        }

        private void txtDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void radDistance_CheckedChanged(object sender, EventArgs e)
        {
            txtDist.Enabled = true;
        }

        private void radGrid_CheckedChanged(object sender, EventArgs e)
        {
            txtDist.Enabled = false;
        }

        private void txtAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBatAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTgtAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBatAlt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                batAlt = Int32.Parse(txtBatAlt.Text);
            }
            catch (System.FormatException)
            {
                batAlt = 0;
            }

            get_Alt();
        }

        private void txtTgtAlt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tgtAlt = Int32.Parse(txtTgtAlt.Text);
            }
            catch (System.FormatException)
            {
                tgtAlt = 0;
            }


            get_Alt();
        }

        private void get_Alt()
        {
            altitude = tgtAlt-batAlt;

            lblAlt.Text = altitude.ToString();

            getElev();
        }

        private void artilleryRangeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialogImportGun = new OpenFileDialog();
            openFileDialogImportGun.ShowDialog();

            try
            {
                using (var reader = new StreamReader(openFileDialogImportGun.FileName))
                using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Record>();

                    foreach (Record r in records)
                    {
                        rangeCard.Add(r);
                    }
                }
            } catch (System.IO.IOException)
            {
                MessageBox.Show("File: "+ openFileDialogImportGun.FileName+" is already open. Can not open file", "Can not open file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getElev()
        {
            lstResults.Items.Clear();
            List<Record> trimmed = new List<Record>();
            List<Result> results = new List<Result>();
            Result best = new Result(0,0,0);
            int min = int.MaxValue;

            foreach(Record x in rangeCard)
            {
                int split = x.Split;
                int range = x.Range;

                if (range == distance)
                {
                    trimmed.Add(x);
                } else
                {
                    if (Math.Abs(distance-range) < split)
                    {
                        trimmed.Add(x);
                    }
                }
            }

            if (trimmed.Count > 1)
            {

                for (int i = 0; i < trimmed.Count; i++)
                {
                    Record A = trimmed[i];

                    if (A.Range != distance)
                    {
                        try
                        {
                            Record B = trimmed[i + 1];


                            if (A.Charge != B.Charge)
                            {
                                continue;
                            }
                            results.Add(workOut(A, B));
                        }
                        catch (Exception) { continue; }
                            
                    }
                    else
                    {
                        results.Add(workOut(A, A));
                    }

                }
            } else if (trimmed.Count == 1)
            {
                Record A = trimmed[0];

                if (A.Range == distance)
                {
                    results.Add(workOut(A, A));
                }
            }


            foreach (Result x in results)
            {
                lstResults.Items.Add("CH: " + x.charge + " | Elevation: " + x.elevation.ToString("F2")+" | Time (est.): "+x.flightTime.ToString("F1"));
                if (x.charge < min)
                {
                    min = x.charge;
                    best = x;
                }
            }

            lblCharge.Text = "Charge (CH): " + best.charge.ToString();
            lblElevation.Text = "Elevation: " + Math.Round((double)best.elevation).ToString();
            lblFlightTime.Text = "Flight Time: " + best.flightTime.ToString("F1");
            
        }

        private void txtDist_TextChanged(object sender, EventArgs e)
        {
            try
            {
                distance = Int32.Parse(txtDist.Text);
            }
            catch (System.FormatException)
            {
                distance = 0;
            }

            getElev();
        }

        private Result workOut(Record A, Record B)
        {
            // Step 1 work out the difference in values between A and B
            int s1 = A.Elev - B.Elev;
            
            // Step 2 work out the ratio of dist
            float s2 = (distance - A.Range) / (float)A.Split;
            // Step 3 work out range adjusted difference.
            float s3 = s1 * s2;
            // Setp 4 work out range adjusted elevation
            float s4 = A.Elev - s3;
       
            // Setp 5 alt at percentage
            float s5 = altitude / (float)100;
   
            // Step 6 altitude offset
            float s6 = ((A.D_Elev + (B.D_Elev - A.D_Elev)) * s5);

            // Step 7 work out altitude offset
            float elevation = s4+s6;


            // Step 8 work out base time difference in values between A and B
            float s8 = A.Time - B.Time;
            // Step 9 work out base time 
            float s9 = A.Time - (s8 * s2);

            // Step 10 Work out alt drop offset
            float s10 = B.FT_DR - A.FT_DR;

            // Step 11
            float s11 = s10 * s5;

            // Step 12
            float estTime = s9 - s11;


            return new Result(A.Charge, elevation, estTime);
        }
    }
}
