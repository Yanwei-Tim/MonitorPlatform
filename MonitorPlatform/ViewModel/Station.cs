﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MonitorPlatform.ViewModel
{
    public class Station : INotifyPropertyChanged
    {
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }


        private int cameraNumber;
        public int CameraNumber
        {
            get
            {
                return cameraNumber;
            }
            set
            {
                cameraNumber = value;
                NotifyPropertyChanged("CameraNumber");
            }
        }


        private DateTime upBeginTime;
        public DateTime UpBeginTime
        {
            get
            {
                return upBeginTime;
            }
            set
            {
                upBeginTime = value;
                NotifyPropertyChanged("UpBeginTime");
            }
        }

        private DateTime downBeginTime;
        public DateTime DownBeginTime
        {
            get
            {
                return downBeginTime;
            }
            set
            {
                downBeginTime = value;
                NotifyPropertyChanged("DownBeginTime");
            }
        }


        private DateTime upEndTime;
        public DateTime UpEndTime
        {
            get
            {
                return upEndTime;
            }
            set
            {
                upEndTime = value;
                NotifyPropertyChanged("UpEndTime");
            }
        }

        private DateTime downEndTime;
        public DateTime DownEndTime
        {
            get
            {
                return downEndTime;
            }
            set
            {
                downEndTime = value;
                NotifyPropertyChanged("DownEndTime");
            }
        }

        private int inNumber;
        public int InNumber
        {
            get
            {
                return inNumber;
            }
            set
            {
                inNumber = value;
                NotifyPropertyChanged("InNumber");
            }
        }

        private int outNumber;
        public int OutNumber
        {
            get
            {
                return outNumber;
            }
            set
            {
                outNumber = value;
                NotifyPropertyChanged("OutNumber");
            }
        }

        private int trafficJam;
        public int TrafficJam
        {
            get
            {
                return trafficJam;
            }
            set
            {
                trafficJam = value;
                NotifyPropertyChanged("TrafficJam");
            }
        }

        private int brokenNumber;
        public int BrokenNumber
        {
            get
            {
                return brokenNumber;
            }
            set
            {
                brokenNumber = value;
                NotifyPropertyChanged("BrokenNumber");
            }
        } 

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}