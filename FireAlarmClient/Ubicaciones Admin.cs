using FireAlarmClient.Models;
using Newtonsoft.Json;
using System.Net;

namespace FireAlarmClient
{
    public partial class AdmUbicaciones : Form
    {
        string url = "http://192.168.1.60:5094/api/";
        static HttpClient client = new HttpClient();
        bool actualizar = false;
        int ubicacionId;
        public AdmUbicaciones()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void dataAdmUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataAdmUbicaciones.CurrentRow;

                if (selectedRow != null)
                {
                    actualizar = true;
                    lblAdmUbicacnes.Text = "Actualizar Ubicacion"; //Dispositivos/Actualizar para el update
                    btnCrearUbicaciones.Text = "Actualizar Ubicacion";
                    ubicacionId = (int)Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    txtAdmUbicaciones.Text = selectedRow.Cells[1].Value.ToString();
                
                
                    if (selectedRow.Cells[2].Value.ToString() == "True")
                    {
                        checkUbicacionActiva.Checked = true;
                    }
                    else
                    {
                        checkUbicacionActiva.Checked = false;
                    }
                }
            }
            catch(Exception error)
            {

            }
            
        }

        private async void btnBuscarUbicaciones_Click(object sender, EventArgs e)
        {
            try
            {
                string apiEndPoint = "Ubicaciones";
                string devices = await GetHttp(apiEndPoint);
                if (devices != null)
                {
                    List<UbicacionesModel> ubicacionesModel = JsonConvert.DeserializeObject<List<UbicacionesModel>>(devices);
                    //var datosDispositivos = dispositivosModel.First();
                    dataAdmUbicaciones.DataSource = ubicacionesModel; //Remover Id de la lista
                    dataAdmUbicaciones.Columns["id"].Visible = false;
                    dataAdmUbicaciones.Columns["estado"].Visible = false;
                    dataAdmUbicaciones.Columns["ubicacion"].Width = 300;
                    //dataAdmUbicaciones.Columns["codigo"].Width = 100;
                    //idAlerta = datos.id;
                }
            }
            catch(Exception error)
            {

            }
        }


        private async void btnCrearUbicaciones_Click(object sender, EventArgs e)
        {
            try
            {

                if (actualizar == false)
                {
                    CrearUbicacion crearUbicacion = new CrearUbicacion();
                    crearUbicacion.ubicacion = txtAdmUbicaciones.Text;
                
                    if (checkUbicacionActiva.Checked == true)
                    {
                        crearUbicacion.estado = true;
                    }
                    else
                    {
                        crearUbicacion.estado = false;
                    }
                    await CreateUbication(crearUbicacion);
                    btnLimpiarUbicaciones_Click(sender, e);
                }
                else
                {
                    ActualizarUbicacion actualizarUbicacion = new ActualizarUbicacion();

                    actualizarUbicacion.id = ubicacionId;
                    actualizarUbicacion.ubicacion = txtAdmUbicaciones.Text;
                    if (checkUbicacionActiva.Checked == true)
                    {
                        actualizarUbicacion.estado = true;
                    }
                    else
                    {
                        actualizarUbicacion.estado = false;
                    }
                    await UpdateUbication(actualizarUbicacion);

                    actualizar = false;
                    btnLimpiarUbicaciones_Click(sender, e);
                }

            }
            catch
            {

            }
            btnBuscarUbicaciones_Click(sender, e);
        }

        private void btnLimpiarUbicaciones_Click(object sender, EventArgs e)
        {
            lblAdmUbicacnes.Text = "Crear Ubicaciones";
            txtAdmUbicaciones.Text = "";
            btnCrearUbicaciones.Text = "Crear Ubicaciones";
            checkUbicacionActiva.Checked = false;
            dataAdmUbicaciones.DataSource = null;
        }
        static async Task<Uri> UpdateUbication(ActualizarUbicacion actUbicacion)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    "http://192.168.1.60:5094/api/Ubicaciones/Actualizar", actUbicacion);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                return response.Headers.Location;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        static async Task<Uri> CreateUbication(CrearUbicacion crearUbicacion)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    "http://192.168.1.60:5094/api/Ubicaciones", crearUbicacion);
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
                WebRequest oRequest = WebRequest.Create(url + endpoint);
                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();
            }
            catch (Exception e)
            {
                return null;
            }

        }

    }
}