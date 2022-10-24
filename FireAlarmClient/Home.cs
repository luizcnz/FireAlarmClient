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
        public bool EstadoAlerta = false;
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string mediaFolder = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Media\";
        static HttpClient client = new HttpClient();
        SoundPlayer sonidoAlerta = new SoundPlayer(mediaFolder + @"\alarm.wav");
        string url = "https://localhost:5001/api/Alertas/Activas";
        bool search = true;
        int idAlerta;

        public Home()
        {
            InitializeComponent();
            
        }
        private async void btnactivar_Click(object sender, EventArgs e)
        {
            while (search == true)
            {
                string respuesta = await GetHttp();
                List<AlertasModel> alertasModels = JsonConvert.DeserializeObject<List<AlertasModel>>(respuesta);
                List<listaAlertas> lista = new List<listaAlertas>();
                
                if(alertasModels != null)
                {
                    search = false;
                    foreach(AlertasModel data in alertasModels)
                    {
                        listaAlertas inf = new listaAlertas();

                        inf.id = data.id;
                        inf.Codigo = data.codigo;
                        inf.Fuego = data.alerta_fuego;
                        inf.Humo = data.alerta_humo;
                        inf.Calor = data.alerta_calor;
                        inf.Temperatura = data.temperatura;
                        inf.Ubicacion = data.ubicacion;
                        inf.Creacion = data.fecha_creacion;

                        lista.Add(inf);
                    }
                    var datos = alertasModels.First();
                    dataAlertas.DataSource = lista; //Remover Id de la lista
                    dataAlertas.Columns["id"].Visible = false;
                    idAlerta = datos.id;
                    await DatosInterfaz(datos.alerta_fuego, datos.alerta_humo, datos.alerta_calor, datos.ubicacion, datos.codigo, datos.temperatura);
                    await alertas();
                }

                await Task.Delay(30000);

            }
        }


        public async Task<string> DatosInterfaz(bool Fuego, bool Humo, bool Calor, string Area, string Dispositivo, int Temperatura)
        {
            lblArea2.Text = Area;
            lblDispositivo2.Text = Dispositivo;
            lblTemperatura.Text = Temperatura.ToString();
            if (Fuego == true)
            {
                pctFuego.Image = Image.FromFile(mediaFolder + @"\fuego.png");
                EstadoAlerta = true;
            }
            else
            {
                pctFuego.Image = null;
            }
            if (Humo == true)
            {
                pctHumo.Image = Image.FromFile(mediaFolder + @"\humo.png");
                EstadoAlerta = true;
            }
            else
            {
                pctHumo.Image = null;
            }
            if (Calor == true)
            {
                pctCalor.Image = Image.FromFile(mediaFolder + @"\calor.png");
                EstadoAlerta = true;
            }
            else
            {
                pctCalor.Image = null;
            }
            return null;

        }

        private async void btnborrar_Click(object sender, EventArgs e)
        {
            EstadoAlerta = false;
            bool Fuego=false;
            bool Humo = false;
            bool Calor = false;
            string Area="";
            string Dispositivo="";
            int Temperatura=0;
            DatosInterfaz(Fuego, Humo, Calor, Area, Dispositivo, Temperatura);
            //await Task.Delay(5000);

            DateTime now = DateTime.Now;
            ApagarAlerta apagarAlerta = new ApagarAlerta();
            apagarAlerta.fecha_respuesta = now;
            apagarAlerta.id = idAlerta;
            await ResponderAsync(apagarAlerta);

            dataAlertas.DataSource = null;
            
            search = true;
            btnactivar_Click(sender, e);
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

            idAlerta = (int)Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
            string Dispositivo = selectedRow.Cells[1].Value.ToString();
            bool Fuego = Convert.ToBoolean(selectedRow.Cells[2].Value.ToString());
            bool Humo = Convert.ToBoolean(selectedRow.Cells[3].Value.ToString());
            bool Calor = Convert.ToBoolean(selectedRow.Cells[4].Value.ToString());
            int Temperatura = (int)Convert.ToInt64(selectedRow.Cells[5].Value.ToString());
            string Area = selectedRow.Cells[6].Value.ToString();
            
            await DatosInterfaz(Fuego, Humo, Calor, Area, Dispositivo, Temperatura);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async Task<string> alertas()
        {
            if (EstadoAlerta == true)
            {
                while(EstadoAlerta==true)
                {

                sonidoAlerta.Play();
                await Task.Delay(5000);
                pctAlerta.Image = Image.FromFile(mediaFolder + @"\alarm1.jpg");
                await Task.Delay(5000);

                sonidoAlerta.Play();
                await Task.Delay(5000);
                pctAlerta.Image = Image.FromFile(mediaFolder + @"\alarm2.jpg");
                await Task.Delay(5000);
                }
            }

            if (EstadoAlerta == false)
            {
                pctAlerta.Image = Image.FromFile(mediaFolder + @"\ok.png");
                pctFuego.Image = null;
                pctHumo.Image = null;
                pctCalor.Image = null;
            }
            return null;
        }

        private void btnBuscarDispositivos_Click(object sender, EventArgs e)
        {

        }
    }
}