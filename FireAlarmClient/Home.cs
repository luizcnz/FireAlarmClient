using FireAlarmClient.Models;
using Newtonsoft.Json;
using System.Media;
using System.Net;
using System.Net.Http.Json;

namespace FireAlarmClient
{
    public partial class Home : Form
    {
        public bool EstadoAlerta = false;
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string mediaFolder = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Media\";
        static HttpClient client = new HttpClient();
        SoundPlayer sonidoAlerta = new SoundPlayer(mediaFolder + @"\alarm.wav");
        string urlServidor = "http://192.168.1.60:5094/api/";
        bool search = true;
        bool modificar = false;
        int deviceId;
        int idAlerta;

        public Home()
        {
            InitializeComponent();

        }
        private async void btnactivar_Click(object sender, EventArgs e)
        {
            while (search == true)
            {
                string apiEndPoint = "Alertas/Activas";
                string respuesta = await GetHttp(apiEndPoint);
                if (respuesta != null)
                {
                    List<AlertasModel> alertasModels = JsonConvert.DeserializeObject<List<AlertasModel>>(respuesta);
                    List<listaAlertas> lista = new List<listaAlertas>();

                    if (alertasModels != null)
                    {
                        search = false;
                        foreach (AlertasModel data in alertasModels)
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
                            inf.Respuesta = data.fecha_respuesta;

                            lista.Add(inf);
                        }
                        var datos = alertasModels.First();
                        dataAlertas.DataSource = lista; //Remover Id de la lista
                        dataAlertas.Columns["id"].Visible = false;
                        dataAlertas.Columns["Respuesta"].Visible = false;
                        dataAlertas.Columns["Ubicacion"].Width = 200;
                        dataAlertas.Columns["Creacion"].Width = 150;
                        idAlerta = datos.id;
                        await DatosInterfaz(datos.alerta_fuego, datos.alerta_humo, datos.alerta_calor, datos.ubicacion, datos.codigo, datos.temperatura);
                        await alertas();
                    }
                }
                
                await Task.Delay(30000);

            }
        }


        private async void btnborrar_Click(object sender, EventArgs e)
        {
            EstadoAlerta = false;
            bool Fuego = false;
            bool Humo = false;
            bool Calor = false;
            string Area = "";
            string Dispositivo = "";
            int Temperatura = 0;
            DatosInterfaz(Fuego, Humo, Calor, Area, Dispositivo, Temperatura);
            //await Task.Delay(5000);

            DateTime now = DateTime.Now;
            ApagarAlerta apagarAlerta = new ApagarAlerta();
            apagarAlerta.fecha_respuesta = now;
            apagarAlerta.id = idAlerta;
            await TurnOffAlert(apagarAlerta);

            dataAlertas.DataSource = null;

            search = true;
            btnactivar_Click(sender, e);
        }


        private void Home_Load(object sender, EventArgs e)
        {
        }
        private async void dataAlertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
            }

        }

        private async Task<string> alertas()
        {
            if (EstadoAlerta == true)
            {
                //await Task.Delay(5000);
                while (EstadoAlerta == true)
                {

                    await Task.Delay(5000);
                    sonidoAlerta.Play();
                    pctAlerta.Image = Image.FromFile(mediaFolder + @"\alarm1.jpg");
                    await Task.Delay(5000);
                    pctAlerta.Image = Image.FromFile(mediaFolder + @"\alarm2.jpg");

                    //sonidoAlerta.Play();
                    //await Task.Delay(5000);
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

        private async void btnBuscarDispositivos_Click(object sender, EventArgs e)
        {
            string apiEndPoint = "Dispositivos";
            string devices = await GetHttp(apiEndPoint);
            if (devices!=null)
            {
                List<DispositivosModel> dispositivosModel = JsonConvert.DeserializeObject<List<DispositivosModel>>(devices);
                //var datosDispositivos = dispositivosModel.First();
                dataDispositivos.DataSource = dispositivosModel; //Remover Id de la lista
                dataDispositivos.Columns["id"].Visible = false;
                dataDispositivos.Columns["estado"].Visible = false;
                dataDispositivos.Columns["ubicacion_id"].Visible = false;
                dataDispositivos.Columns["ubicacion"].Width = 200;
                dataDispositivos.Columns["codigo"].Width = 100;
                //idAlerta = datos.id;
            }

        }

        private async void dataDispositivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataDispositivos.Rows[e.RowIndex];

                int idDevice = (int)Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                string apiEndPoint = "Alertas/DeviceId/" + idDevice + "";
                string history = await GetHttp(apiEndPoint);
                List<AlertasModel> alertasModels = JsonConvert.DeserializeObject<List<AlertasModel>>(history);

                List<listaAlertas> lista = new List<listaAlertas>();

                if (alertasModels != null)
                {
                    foreach (AlertasModel data in alertasModels)
                    {
                        listaAlertas inf = new listaAlertas();

                        inf.id = data.id;
                        inf.Creacion = data.fecha_creacion;
                        inf.Respuesta = data.fecha_respuesta;
                        inf.Codigo = data.codigo;
                        inf.Fuego = data.alerta_fuego;
                        inf.Humo = data.alerta_humo;
                        inf.Calor = data.alerta_calor;
                        inf.Temperatura = data.temperatura;
                        inf.Ubicacion = data.ubicacion;

                        lista.Add(inf);
                    }
                    dataHistorial.DataSource = lista; //Remover Id de la lista
                    //dataHistorial.Columns[""].Visible = false;
                    dataHistorial.Columns["id"].Visible = false;
                    dataHistorial.Columns["Codigo"].Visible = false;
                    dataHistorial.Columns["Ubicacion"].Visible = false;
                    dataHistorial.Columns["Fuego"].Visible = true;
                    dataHistorial.Columns["Fuego"].Width = 55;
                    dataHistorial.Columns["Humo"].Visible = true;
                    dataHistorial.Columns["Humo"].Width = 55;
                    dataHistorial.Columns["Calor"].Visible = true;
                    dataHistorial.Columns["Calor"].Width = 55;
                    dataHistorial.Columns["Temperatura"].Visible = false;
                    dataHistorial.Columns["Creacion"].Visible = true;
                    dataHistorial.Columns["Creacion"].Width = 140;
                    dataHistorial.Columns["Respuesta"].Visible = true;
                    dataHistorial.Columns["Respuesta"].Width = 140;
                }
                else
                {
                    dataHistorial.DataSource = null;
                }
            }
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
            }
            
        }

        private async void dataHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow selectedRow = dataHistorial.Rows[e.RowIndex];

                int idHistory = (int)Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                string apiEndPoint = "Alertas/Id/" + idHistory + "";
                string history = await GetHttp(apiEndPoint);
                List<AlertasModel> historyDetails = JsonConvert.DeserializeObject<List<AlertasModel>>(history);

                foreach (AlertasModel data in historyDetails)
                {
                    lblHistDispositivo.Text = data.codigo;
                    lblHistUbicacion.Text = data.ubicacion;
                    lblHistTemperatura.Text = Convert.ToString(data.temperatura);
                    lblHistFecha.Text = Convert.ToString(data.fecha_creacion);
                    lblHistRespuesta.Text = Convert.ToString(data.fecha_respuesta);

                    if (data.alerta_fuego == true)
                    {
                        pctminifuego.Image = Image.FromFile(mediaFolder + @"\fuego.png");
                    }
                    else
                    {
                        pctminifuego.Image = null;
                    }
                    if (data.alerta_humo == true)
                    {
                        pctminihumo.Image = Image.FromFile(mediaFolder + @"\humo.png");
                    }
                    else
                    {
                        pctminihumo.Image = null;
                    }
                    if (data.alerta_calor == true)
                    {
                        pctminicalor.Image = Image.FromFile(mediaFolder + @"\calor.png");
                    }
                    else
                    {
                        pctminicalor.Image = null;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private async void FillCbox(object sender, TabControlEventArgs e)
        {
            string apiEndPoint = "Ubicaciones";
            string respuesta = await GetHttp(apiEndPoint);
            if (respuesta != null)
            {
                List<UbicacionesModel> ubicacionModel = JsonConvert.DeserializeObject<List<UbicacionesModel>>(respuesta);

                cBoxUbicacion.DataSource = ubicacionModel;
                cBoxUbicacion.DisplayMember = "ubicacion";
                cBoxUbicacion.ValueMember = "id";
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataDispositivos.CurrentRow;

            if(selectedRow!=null)
            {
                modificar = true;
                lblAccion.Text = "Actualizar Dispositivo"; //Dispositivos/Actualizar para el update
                btnCrear.Text = "Actualizar Dispositivo";
                deviceId = (int)Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                txtCodgo.Text = selectedRow.Cells[1].Value.ToString();
                var inf = selectedRow.Cells[2].Value.ToString();
                cBoxUbicacion.SelectedIndex = (int)Convert.ToInt64(selectedRow.Cells[2].Value.ToString()) - 1;
                if (selectedRow.Cells[4].Value.ToString() == "True")
                {
                    checkBoxActivo.Checked = true;
                }
                else
                {
                    checkBoxActivo.Checked = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            modificar = false;
            lblAccion.Text = "Crear Dispositivo";
            btnCrear.Text = "Crear Dispositivo";
            deviceId = 0;
            txtCodgo.Text = "";
            cBoxUbicacion.SelectedIndex = 0;
            checkBoxActivo.Checked = false;
            dataDispositivos.DataSource = null;
            dataHistorial.DataSource = null;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if(modificar == false)
            {
                CrearDispositivos crearDispositivos = new CrearDispositivos();
                crearDispositivos.codigo = txtCodgo.Text;
                crearDispositivos.ubicacion_id = (int)cBoxUbicacion.SelectedValue;
                if (checkBoxActivo.Checked == true)
                {
                    crearDispositivos.estado = true;
                }
                else
                {
                    crearDispositivos.estado = false;
                }
                await CreateDevice(crearDispositivos);
            }
            else
            {
                ActualizarDispositivos actualizarDispositivos = new ActualizarDispositivos();
                actualizarDispositivos.Id = deviceId;
                actualizarDispositivos.codigo = txtCodgo.Text;
                actualizarDispositivos.ubicacion_id = (int)cBoxUbicacion.SelectedValue;
                if (checkBoxActivo.Checked == true)
                {
                    actualizarDispositivos.estado = true;
                }
                else
                {
                    actualizarDispositivos.estado = false;
                }
                await UpdateDevice(actualizarDispositivos);

                modificar = false;
                btnLimpiar_Click(sender, e);
            }

            btnBuscarDispositivos_Click(sender, e);
        }

        private void btnAdmUbicaciones_Click(object sender, EventArgs e)
        {
            AdmUbicaciones form = new AdmUbicaciones();
            form.Show();
        }

        static async Task<Uri> TurnOffAlert(ApagarAlerta apagarAlerta)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                "http://192.168.1.60:5094/api/Alertas/Apagar", apagarAlerta);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                return response.Headers.Location;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        static async Task<Uri> UpdateDevice(ActualizarDispositivos actDispositivos)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                "http://192.168.1.60:5094/api/Dispositivos/Actualizar", actDispositivos);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                return response.Headers.Location;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        static async Task<Uri> CreateDevice(CrearDispositivos crearDispositivos)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    "http://192.168.1.60:5094/api/Dispositivos", crearDispositivos);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                return response.Headers.Location;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<string> GetHttp(string endpoint)
        {
            try
            {
                WebRequest oRequest = WebRequest.Create(urlServidor + endpoint);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();
            }
            catch (Exception e)
            {
                return null;
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

    }
}
