using WMPLib;
namespace reprudoctor_de_MP3
{
    public partial class Form1 : Form
    {
        //objeto que se encarga de reproducir el audio

        private WindowsMediaPlayer reproductor;
        // guardar la ruta del archivo selecciionado
        private string archivoSeleccionado = "";

        public Form1()
        {
            InitializeComponent();
            //creamos reproductor
            reproductor = new WindowsMediaPlayer();
            //evita a reproducir audio
            reproductor.settings.autoStart = false;
            // configuramos el openFileDIalog
            openFileDialog1.Filter =
                "Archivo de audio (*.mp3)|*.mp3";
            openFileDialog1.Title = "selecciona un archivo mp3";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //si no hay un archivo selecionado 
                //Abrimos el explorador de archivo
                if (string.IsNullOrEmpty(archivoSeleccionado))
                {
                    DialogResult resultado =
                        openFileDialog1.ShowDialog();
                    if (resultado != DialogResult.OK)
                    {
                        archivoSeleccionado = openFileDialog1.FileName;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }
    }
}
