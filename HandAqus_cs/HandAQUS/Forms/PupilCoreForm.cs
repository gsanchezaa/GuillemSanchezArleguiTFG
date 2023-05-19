using HandAQUS.API;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using HandAQUS.Classes.API;

namespace HandAQUS.Forms
{

    //TFG GSA
    public partial class PupilCoreForm : Form
    {
        private PupilCoreAPI PupilCoreObject;
        private HandAQUS HandAQUS_instace;
        private string path;

        //atributs varis de dídac

        public PupilCoreForm()
        {
            InitializeComponent();
            disableButtons("initialize");
            this.MaximumSize = new System.Drawing.Size(1000, 800);//que fa això? (668,412). Programa peta quan es tanca i es torna a obrir PupilCoreForm
        }

        private void btnFindGlasses_Click(object sender, EventArgs e)//nom del botó el mateix?
        {
            //Method for button "Find Glasses" that initialises the PupilCore object.
            try
            {
         //       PupilCoreObject = new PupilCoreAPI();
                disableButtons("find");
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(
                    @"Glasses Not connected! Please connect them via WIFI.",
                    @"Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Debug.WriteLine("Message :{0} ", ex.Message);
            }
            // cancelRecording = false;// crec que el fa servir per algo concret del parkinson
        }

        /*
        private void btnCallibrate_Click(object sender, EventArgs e)
        {
            //Method for button "Callibrate" that calls calibration of object, and creates new recording.
            try
            {
                PupilCoreObject.callibrate();
                PupilCoreObject.createRecording();
                disableButtons("callibrate");
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine("Message :{0} ", ex.Message);
            }

        }

        private void btnStartRec_Click(object sender, EventArgs e)
        {
            //Method for button "Start" that calls "start recording" of G3 object.
            try
            {
                listTimeStampTasks = new List<string>();
                PupilCoreObject.StartRecording();
                disableButtons("start");
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine("Message :{0} ", ex.Message);
            }

        }

        private void btnStopRec_Click(object sender, EventArgs e)
        {
            //Method for button "Stop" that calls "Stop recording" of G3 object.
            try
            {
                PupilCoreObject.StopRecording();
                disableButtons("stop");
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine("Message :{0} ", ex.Message);
            }
        }

        private void btnSaveRec_Click(object sender, EventArgs e)
        {
            //Method for button "Save" that calls "Save recording" of G3 object.
            disableButtons("saveStarts");
            // Set cursor as wait.
            Application.UseWaitCursor = true;
            try
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = "C:\\Users";
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    SavingDirectory = dialog.FileName;
                    this.path = SavingDirectory;
                    PupilCoreObject.saveRecording(SavingDirectory, "file");
                }
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine("Message :{0} ", ex.Message);
            }
            HandAQUS_instace = System.Windows.Forms.Application.OpenForms.OfType<HandAQUS>().FirstOrDefault();
            if (HandAQUS_instace != null)
            {
                HandAQUS_instace.saveSVCFileFromGlassesSave(path);
            }
            // Set cursor as default.
            Application.UseWaitCursor = false;
            saveFileWithPatientInfoInJSON(this.path);
            this.recordingTask = 1;
            this.lblNumberTask.Text = this.recordingTask.ToString();
            this.Close();
        }

        private void btnCancelRec_Click(object sender, EventArgs e)
        {
            //Method for button "Cancel" that calls "Cancel recording" of G3 object.
            //If this is the second time canceling, form closes.
            try
            {
                if (cancelRecording)
                {
                    this.Close();
                }
                PupilCoreObject.cancelRecording();
                disableButtons("cancel");
                cancelRecording = true;
                this.recordingTask = 1;
                this.lblNumberTask.Text = this.recordingTask.ToString();
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine("Message :{0} ", ex.Message);
            }
        }

        private void btnGazeOFF_Click(object sender, EventArgs e)
        {
            //A method for button "Gaze Off" that calls "GazeOff" of G3 object.
            try
            {
                PupilCoreObject.GazeOff();
                disableButtons("gazeoff");
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine("Message :{0} ", ex.Message);
            }
        }
        */
        private void disableButtons(string button)
        {
            //Swtitch method to enable and disable the buttons of TobiiGlasses3 Forms.
            switch (button)
            {
                case "initialize":
                    btnCallibrate.Enabled = false;
                    //   btnCancelRec.Enabled = false;
                    //   btnSaveRecording.Enabled = false;
                    btnSTART.Enabled = false;
                    btnSTOP.Enabled = false;
                    //    btnGazeOFF.Enabled = false;
                    //pictureBox1.Enabled = false;
                    //     btnAddTask.Enabled = false;
               //     btnStopCallibrate.Enabled = false;
                    break;
                case "find":
                    btnCallibrate.Enabled = true;
                    //btnFindGlasses.Enabled = false;
                    button1.Enabled = false;
                    // pictureBox1.Enabled = true;
                    LblForButtons.Text = "Glasses Found. Next Step: CALLIBRATE.";
                    break;
                case "callibrate":
                    btnSTART.Enabled = true;
                    //    btnCancelRec.Enabled = true;
                    //     btnGazeOFF.Enabled = true;
                    btnCallibrate.Enabled = false;
               //     btnStopCallibrate.Enabled = true;
                    LblForButtons.Text = "Callibrated. Next Step: START Recording";
                    break;
                case "stopCalibration":
             //       btnStopCallibrate.Enabled = false;
                    btnCallibrate.Enabled = true;
                    btnSTART.Enabled = true;
                    btnSTOP.Enabled = false;
                    LblForButtons.Text = "Callibration Stopped";
                    break;
                case "start":
                    btnSTOP.Enabled = true;
                    btnCallibrate.Enabled = false;
                //    btnStopCallibrate.Enabled = false;
                    btnSTART.Enabled = false;
                    //  btnGazeOFF.Enabled = false;
                    //  btnAddTask.Enabled = true;
                    LblForButtons.Text = "Glasses Recording. Next Step: STOP Recording";
                    break;

                case "stop":
                    //    btnSaveRecording.Enabled = true;
                    btnSTOP.Enabled = false;
                    btnSTART.Enabled = true;
                    //    btnCancelRec.Enabled = false;
                    //   btnAddTask.Enabled = false;
                    LblForButtons.Text = "Recording Stopped and Saved";
                    break;

                case "saveStarts":
                    //    btnSaveRecording.Enabled = false;
                    //  pictureBox1.Enabled = false;
                    LblForButtons.Text = "Recording Saving. PLEASE WAIT until data is saved";
                    break;

                case "cancel":
                    btnCallibrate.Enabled = true;
                    //    btnCancelRec.Enabled = false;
                    //   btnSaveRecording.Enabled = false;
                    btnSTART.Enabled = false;
                    btnSTOP.Enabled = false;
                    //   btnAddTask.Enabled = false;
                    LblForButtons.Text = "Canceling Recording. Next Step: Calibrate Glasses.";
                    break;
                case "gazeoff":
                    //   btnGazeOFF.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //Method for button "Find Glasses" that initialises the PupilCore object.
          //  try
           // {
                PupilCoreObject = new PupilCoreAPI();
                disableButtons("find");
           // }
            /*
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(
                    @"Glasses Not connected! Please connect them via WIFI.",
                    @"Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Debug.WriteLine("Message :{0} ", ex.Message);
            }
            
            // cancelRecording = false;// crec que el fa servir per algo concret del parkinson

        }
    */

        //"Find Glasses"
        private void button1_Click(object sender, EventArgs e)
        {
            //Method for button "Find Glasses" that initialises the PupilCore object.
            PupilCoreObject = new PupilCoreAPI();
            disableButtons("find");
            //si no estan connectades les ulleres, hauria de dir algo i no poder seguir (ara mateix segueix com si res)
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            PupilCoreObject.StartRecording(); // posar excepcions (quan no estan connectades, es queda aquí atrapat
            disableButtons("start");
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            PupilCoreObject.StopRecording(); // posar excepcions (quan no estan connectades, es queda aquí atrapat
            disableButtons("stop");
            //quan s'acaba es guarda automàticament
        }

        private void btnCallibrate_Click(object sender, EventArgs e)
        {
            PupilCoreObject.callibrate(); // posar excepcions (quan no estan connectades, es queda aquí atrapat
            disableButtons("callibrate");
        }

        private void PupilCore_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Method to control when form has to close, of maximize, minimize.
            this.Hide();
            e.Cancel = true;
            //   btnFindGlasses.Enabled = true;
            button1.Enabled = true;
            btnCallibrate.Enabled = false;
        //    btnCancelRec.Enabled = false;
        //    btnSaveRecording.Enabled = false;
            btnSTART.Enabled = false;
            btnSTOP.Enabled = false;
        }
        /*
        private void btnSaveRecording_Click(object sender, EventArgs e)//, string dest_dir, string identifier)
        {
            // PupilCoreObject.saveRecording(dest_dir, identifier);
            disableButtons("saveStarts");
        }

        private void btnCancelRec_Click(object sender, EventArgs e)
        {
           // PupilCoreObject.cancelRecording();
            disableButtons("cancel");

        }

        */
        /*
private void TobiiPROGlasses3_FormClosing(object sender, FormClosingEventArgs e)
{
//Method to control when form has to close, of maximize, minimize.
this.Hide();
e.Cancel = true;
btnFindGlasses.Enabled = true;
btnCallibrate.Enabled = false;
btnCancelRec.Enabled = false;
btnSaveRecording.Enabled = false;
btnSTART.Enabled = false;
btnSTOP.Enabled = false;
}

private void pictureBox1_Click(object sender, EventArgs e)
{
//Method to open web browser with TobiiGlasses3 IP, to see live video and other many API funcitons.
System.Diagnostics.Process.Start("http://192.168.75.51/live.html");
}

private void btnAddTask_Click(object sender, EventArgs e)
{
//Method to add the task's number when button pressed.
if (this.recordingTask < 9)
{
this.recordingTask++;
this.lblNumberTask.Text = this.recordingTask.ToString();
this.listTimeStampTasks.Add(DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ssffffff"));
}

}
private void saveFileWithPatientInfoInJSON(string path)
{
//TFG
//Method to save file of task's timestamps in JSON object.
int counter = 2;
foreach (string timeStamp in this.listTimeStampTasks)
{
addToJSON(counter, timeStamp);
counter++;
}
var json_fname = String.Format("{0}/{1}.json", path, "fileTimeStampTasks");
using (StreamWriter file = File.CreateText(json_fname))
using (JsonTextWriter writer = new JsonTextWriter(file))
{
this.jsonTaskInfo.WriteTo(writer);
}
}

private void addToJSON(int counter, string timeStamp)
{
//This methos lets adding values to json of aprox 15 jsons. Each timestamp goes with the startint time of the tasks number.
switch (counter)
{
/*case 1:
  this.jsonTaskInfo.one = timeStamp;
  break;*//*
case 2:
  this.jsonTaskInfo.two = timeStamp;
  break;
case 3:
  this.jsonTaskInfo.three = timeStamp;
  break;
case 4:
  this.jsonTaskInfo.four = timeStamp;
  break;
case 5:
  this.jsonTaskInfo.five = timeStamp;
  break;
case 6:
  this.jsonTaskInfo.six = timeStamp;
  break;
case 7:
  this.jsonTaskInfo.seven = timeStamp;
  break;
case 8:
  this.jsonTaskInfo.eight = timeStamp;
  break;
case 9:
  this.jsonTaskInfo.nine = timeStamp;
  break;
default:
  break;
}
}
*/
    }
}
