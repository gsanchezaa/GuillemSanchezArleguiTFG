using HandAQUS.API;
using HandAQUS.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;


namespace HandAQUS.Classes.API
{
    internal class PupilCoreAPI : InterfaceRecording
    {
        private readonly RequestSocket pupil_remote;

        public PupilCoreAPI()
        {
            //findGlasses();

            // create a new Pupil Remote client
            pupil_remote = new RequestSocket();
            pupil_remote.Connect("tcp://127.0.0.1:50020");
        }

        //A method that plays a sound if glasses are connected to the computer device.
        public void findGlasses()
        {
            //no cal. ja es crea al constructor.
        }

        //A method that plays a sound when callibration petiton for the glasses is complete.
        public void callibrate()
        {
            // start callibration
            pupil_remote.SendFrame(Encoding.UTF8.GetBytes("C"));
            Console.WriteLine(Encoding.UTF8.GetString(pupil_remote.ReceiveFrameBytes()));

        }
        
        public void stopCallibration()
        {
            // stop callibration
            pupil_remote.SendFrame(Encoding.UTF8.GetBytes("c"));
            Console.WriteLine(Encoding.UTF8.GetString(pupil_remote.ReceiveFrameBytes()));

        }


        //A method that plays a sound.
        private void playSound()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            System.IO.Stream filePath = Properties.Resources.callibrated;
            System.Media.SoundPlayer mp3SoundPlayer = new System.Media.SoundPlayer(filePath);
            mp3SoundPlayer.Play();
        }

        //A method that creates a new Recording object, and adds it to the "recCollection" list of Recordings.
        public void createRecording()
        {
            
        }

        //A method that calls the petition for "setting overlay" false.
        //Objective: To not have the users gaze rendered on the video.
        public void GazeOff()
        {
            
        }

        public void cancelRecording()
        {
            throw new NotImplementedException();
        }

        public void saveRecording(string dest_dir, string identifier)
        {
            throw new NotImplementedException();
        }

        public void StartRecording()
        {
            pupil_remote.SendFrame(Encoding.UTF8.GetBytes("R"));
            Console.WriteLine(Encoding.UTF8.GetString(pupil_remote.ReceiveFrameBytes()));
        }

        public void StopRecording()
        {
            pupil_remote.SendFrame(Encoding.UTF8.GetBytes("r"));
            Console.WriteLine(Encoding.UTF8.GetString(pupil_remote.ReceiveFrameBytes()));
        }
    }
}
