using FireAlarmClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Media;
using System.Net;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FireAlarmClient
{
    public partial class Home : Form
    {
        public string EstadoAlerta = "inactiva";
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string mediaFolder = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Media\";
        static HttpClient client = new HttpClient();
        string url = "https://localhost:5001/api/Alertas/Activas";
        bool search = true;
        int idAlerta;

        public Home()
        {
            InitializeComponent();
            
        }
        private async void btnactivar_Click(object sender, EventArgs e)
        {
            while(search == true)
            {
                string respuesta = await GetHttp();
                List<AlertasModel> alertasModels = JsonConvert.DeserializeObject<List<AlertasModel>>(respuesta);
                
                if(alertasModels != null)
                {
                    var datos = alertasModels.First();
                    dataAlertas.DataSource = alertasModels;
                    idAlerta = datos.id;
                    Alerta(datos.alerta_fuego, datos.alerta_humo, datos.alerta_calor, datos.ubicacion, datos.codigo, datos.temperatura);
                }

                wait(30);
            
            }
        }

        public async void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public async void Alerta(bool Fuego, bool Humo, bool Calor, string Area, string Dispositivo, int Temperatura)
        {
            lblArea2.Text = Area;
            lblDispositivo2.Text = Dispositivo;
            lblTemperatura.Text = Temperatura.ToString();
            if (Fuego == true)
            {
                pctFuego.Image = Image.FromFile(mediaFolder + @"\fuego.png");
                EstadoAlerta = "activa";
            }
            if (Humo == true)
            {
                pctHumo.Image = Image.FromFile(mediaFolder + @"\humo.png");
                EstadoAlerta = "activa";
            }
            if (Calor == true)
            {
                pctCalor.Image = Image.FromFile(mediaFolder + @"\calor.png");
                EstadoAlerta = "activa";
            }


            if(EstadoAlerta == "activa")
            {
                SoundPlayer simpleSound = new SoundPlayer(mediaFolder + @"\alarm.wav");
                simpleSound.Play();
                wait(2000);
                pctAlerta.Image = Image.FromFile(mediaFolder + @"\alarm1.jpg");
                wait(2000);
                pctAlerta.Image = Image.FromFile(mediaFolder + @"\alarm2.jpg");
                wait(200);
            }

            if(EstadoAlerta == "respondida")
            {
                pctAlerta.Image = Image.FromFile(mediaFolder + @"\ok.png");
                pctFuego.Image = null;
                pctHumo.Image = null;
                pctCalor.Image = null;
            }

            
        }

        private async void btnborrar_Click(object sender, EventArgs e)
        {
            EstadoAlerta = "respondida";
            bool Fuego=false;
            bool Humo = false;
            bool Calor = false;
            string Area="";
            string Dispositivo="";
            int Temperatura=0;
            Alerta(Fuego, Humo, Calor, Area, Dispositivo, Temperatura);
            wait(1000);

            DateTime now = DateTime.Now;

            ApagarAlerta apagarAlerta = new ApagarAlerta();
            apagarAlerta.fecha_respuesta = now;
            apagarAlerta.id = idAlerta;

            ResponderAsync(apagarAlerta);
        }

        private async void label3_Click(object sender, EventArgs e)
        {

        }

        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        static async Task<Uri> ResponderAsync(ApagarAlerta apagarAlerta)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:5001/api/Alertas/Apagar", apagarAlerta);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }
        private async void dataAlertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataAlertas.Rows[e.RowIndex];

            string data0, data1, data2, data3, data4, data5, data6, data7, data8, data9;
            data0 = selectedRow.Cells[0].Value.ToString();
            data1 = selectedRow.Cells[1].Value.ToString();
            data2 = selectedRow.Cells[2].Value.ToString();
            data3 = selectedRow.Cells[3].Value.ToString();
            data4 = selectedRow.Cells[4].Value.ToString();
            data5 = selectedRow.Cells[5].Value.ToString();
            data6 = selectedRow.Cells[6].Value.ToString();
            data7 = selectedRow.Cells[7].Value.ToString();
            data8 = selectedRow.Cells[8].Value.ToString();
            data9 = selectedRow.Cells[9].Value.ToString();

            string Dispositivo = data1;
            bool Fuego = Convert.ToBoolean(data2);
            bool Humo = Convert.ToBoolean(data3);
            bool Calor = Convert.ToBoolean(data4);
            int Temperatura = (int)Convert.ToInt64(data5);
            string Area = data9;
            Alerta(Fuego, Humo, Calor, Area, Dispositivo, Temperatura);

            //MessageBox.Show(" "+s1+" "+s2+" "+s3+" "+s4+" ");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


    }
}