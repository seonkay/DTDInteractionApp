using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DTDInteractionWindowsFormApp
{
    public partial class Form1 : Form
    {

        public Action Worker { get; set; }
            
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            RestClient rClient= new RestClient();

            rClient.rxNormCodes = rxNormCodesBox.Text;
            string strJSON = string.Empty;
            strJSON = rClient.makeRequest();

            debugOutput(strJSON);
        }

        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                responseBox.Text = responseBox.Text + strDebugText + Environment.NewLine;
                responseBox.SelectionStart = responseBox.TextLength;
                responseBox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void displayQueryResult(string strDebugText)
        {
            try
            {
                // System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                medicationListBox.Text = medicationListBox.Text + strDebugText + Environment.NewLine;
                medicationListBox.SelectionStart = medicationListBox.TextLength;
                medicationListBox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DTDSqlClient sClient = new DTDSqlClient();
            sClient.patientID = patientIDBox.Text;

            string strResult = string.Empty;
            //strResult = sClient.makeQuery();
            strResult = sClient.getMedicationsWithPatientID(patientIDBox.Text);
            Console.WriteLine("Returned Result: " + strResult);

            displayQueryResult(strResult);
            displayQueryResult("===========================================");

            RestClient rClient = new RestClient();
            if(rClient.dTDInteractionExist(strResult))
                displayQueryResult("Drug to Drug Interaction Found");
            else
                displayQueryResult("No Drug To Drug Interaction");

        }

        private void getPatientListButton_Click(object sender, EventArgs e)
        {
            DTDSqlClient sClient = new DTDSqlClient();

            var strResult = new List<string>();
            //strResult = sClient.makeQuery();
            strResult = sClient.getPatientIDList();

            foreach (var pID in strResult)
            {
                displayQueryResult(pID);
            } 
        }

        private void findDTDIAllButton_Click(object sender, EventArgs e)
        {
            // this.timer1.Start();
            DTDSqlClient sClient = new DTDSqlClient();
            RestClient rClient = new RestClient();

            var strResult = new List<string>();
            var rxNormCode = string.Empty;
            var displayString = string.Empty;
            //strResult = sClient.makeQuery();
            int count = 0;
            strResult = sClient.getPatientIDList();
            // ListViewItem lvItem = null;

            int index = 0;
            foreach (var pID in strResult)
            {
                index++;
                //this.listView1.BeginUpdate();
                rxNormCode = sClient.getMedicationsWithPatientID(pID);
                if (rClient.dTDInteractionExist(rxNormCode))
                {
                    displayString = pID + "  ||  " + rxNormCode + "  ||  Interaction Found ";
                    /*
                    ListViewItem lvItem = new ListViewItem(pID);
                    lvItem.SubItems.Add(rxNormCode);
                    lvItem.SubItems.Add("Found");
                    listView1.Items.Add(lvItem);
                    */
                    dataGridView2.Rows.Add(index.ToString(), pID, rxNormCode, "Found");
                    dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                    dataGridView2.Refresh();

                    count++;
                }
                else
                {
                    displayString = pID + "  ||  " + rxNormCode + "  ||  Interaction Not Found ";
                    /*
                    ListViewItem lvItem = new ListViewItem(pID);
                    lvItem.SubItems.Add(rxNormCode);
                    lvItem.SubItems.Add("Not Found");
                    listView1.Items.Add(lvItem);
                    */   
                    
                    dataGridView2.Rows.Add(index.ToString(), pID, rxNormCode, "Not Found");
                    dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                    dataGridView2.Refresh();
                }
                //listView1.Items.Add(lvItem);
                // this.listView1.EndUpdate();
                //displayQueryResult(displayString);
            }

            totalNumberLabel.Text = count.ToString() + " out of total " + strResult.Count + " patients"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'syntheticMassDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.syntheticMassDataSet.patients);

        }

        private void totalNumberLable_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                string pID = row.Cells["pID"].Value.ToString();

                int rowIndex = -1;
                foreach (DataGridViewRow row2 in dataGridView1.Rows)
                {
                    // Console.WriteLine("Row: " + row2.Cells[2].Value.ToString());
                    // Console.WriteLine("PID: " + pID);
                    if (row2.Cells[2].Value.ToString().Equals(pID))
                    {
                       // Console.WriteLine(row2.Cells[2].Value.ToString());
                        rowIndex = row2.Index;
                        break;
                    }
                }
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
               // Console.WriteLine(pID + " Selected");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
