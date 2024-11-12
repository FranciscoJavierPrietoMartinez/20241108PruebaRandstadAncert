using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using System.ComponentModel;

namespace AncertCrono
{
    public class Crono : INotifyPropertyChanged
    {
        private DispatcherTimer _timer;
        private TimeSpan _increment;
        private TimeSpan _elapsed;
        private EventHandler _clientHandler = null;
        private string _format = @"hh\:\:mm\:\:ss";

        public EventHandler ClientHandler
        {
            get { return _clientHandler; }
            set { _clientHandler = value;  }
        }

        public TimeSpan Elapsed
        {
            get { return _elapsed; }
            set { _elapsed = value;  RaisePropertyChanged("Elapsed"); }
        }

        public string ElapsedFormat
        {
            get { return ShowTime(_format); }
        }

        public Crono()
        {
            _timer = new DispatcherTimer();
            _increment = TimeSpan.FromSeconds(1);
            _elapsed = new TimeSpan(0);
            _clientHandler = null;

            _timer.Interval = _increment;
            _timer.Tick += concreteTimer_Tick;
        }

        public void AddHandlerAction(EventHandler method)
        {
            _clientHandler = method;
        }

        public TimeSpan GetElapsed()
        {
            return _elapsed;
        }

        void concreteTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                _clientHandler(sender, e);
            }
            catch (Exception)
            {
            }
 
            _elapsed = _elapsed + _increment;

            RaisePropertyChanged("Elapsed");
            RaisePropertyChanged("ElapsedFormat");
        }

        public string ShowTime(string format)
        {
            return _elapsed.ToString(@format);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void Reset()
        {
            _timer.Stop();
            _elapsed = new TimeSpan(0);
            RaisePropertyChanged("Elapsed");
            RaisePropertyChanged("ElapsedFormat");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
