namespace VlcControlApp
{
    public partial class Form1 : Form
    {
        private string _ipAddress = "127.0.0.1";
        private int _port = 50000;
        private string _videoPath = "C:\\Users\\erica\\Desktop\\ExpoMovie.mp4";
        VlcControl? _vclControl;
        public Form1 () {
            InitializeComponent();
        }

        private void PlayVLCMovie (object sender, EventArgs e) {
            if (_vclControl == null)
                return;

            _vclControl.Play();
        }

        private async void ConnectClick (object sender, EventArgs e) {
            await Task.Run(() =>
            {
                if (!string.IsNullOrEmpty(MovieFile.Text))
                {
                    _videoPath = MovieFile.Text;
                }
                
                _vclControl = new VlcControl(_port, _ipAddress);
                _vclControl.ConnectToVLC();
                _vclControl.OpenMovieFile(_videoPath);
            });

            Connect.Text = "DisConnect";
        }

        private void SeekClick (object sender, EventArgs e) {
            if (_vclControl == null)
                return;

            int time = int.Parse(SeekTime.Text);
            _vclControl.SeekMovie(time);
        }

        private void StopClick (object sender, EventArgs e) {
            if (_vclControl == null)
                return;

            _vclControl.Stop();
        }

        private void PauseClick (object sender, EventArgs e) {
            if (_vclControl == null)
                return;

            _vclControl.Pouse();
        }
    }
}
