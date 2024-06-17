using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
namespace VlcControlApp
{
    public class VlcControl
    {
        private TcpClient? _tcpClient;
        private NetworkStream? _stream;
        private StreamReader? _reader;
        private int _port;
        private string _ip;

        /// <summary>
        /// コンストラクタ(vlcを起動しているPCのIPアドレス、アプリで設定したポート番号、パスワード)
        /// を用いてvlcアプリと接続し、さらに映像データをvlcに設定します。
        /// </summary>
        /// <param name="port">vlcアプリのポート番号</param>
        /// <param name="ip">vlcアプリを起動しているパソコンのipアドレス</param>
        /// <param name="password">vlcのパスワード</param>
        public VlcControl(int port, string ip) {
            _port = port;
            _ip = ip;
        }

        /// <summary>
        /// 再生開始
        /// </summary>
        public void Play () {
            SendCommand("play\n");
        }

        public void Help () {
            SendCommand("help\n");
        }

        /// <summary>
        /// 再生終了
        /// </summary>
        public void Pouse () {
            SendCommand("pause\n");
        }

        /// <summary>
        /// 再生停止
        /// </summary>
        public void Stop () {
            SendCommand("stop\n");
        }

        /// <summary>
        /// 指定した時刻から再生を開始
        /// </summary>
        /// <param name="iniTime">再生開始時間</param>
        public void SeekMovie (int iniTime) {
            SendCommand($"seek {iniTime}\n");
        }

        /// <summary>
        /// vlcに音声ファイル設定
        /// </summary>
        /// <param name="filePath"></param>
        public void OpenMovieFile(string filePath) {
            if(!string.IsNullOrEmpty(filePath))
            {
                SendCommand($"add {filePath}\n");
            }
        }

        /// <summary>
        /// vlcに接続するメソッド
        /// </summary>
        public void ConnectToVLC () {
            try
            {
                _tcpClient = new TcpClient(_ip, _port);
                _stream = _tcpClient.GetStream();
                _reader = new StreamReader(_stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// vlcにコマンドを送るメソッド
        /// </summary>
        /// <param name="command">コマンド文字列</param>
        private void SendCommand (string command) {
            if(command == null) return;

            byte[] sendCmd = Encoding.UTF8.GetBytes(command);

            if (_tcpClient == null || _reader == null || _stream == null || _reader == null)
            {
                return;
            }

            if (_tcpClient.Connected)
            {
                _stream.Write(sendCmd, 0, sendCmd.Length);
            }
            else
            {
                ConnectToVLC();
            }
        }

    }
}
