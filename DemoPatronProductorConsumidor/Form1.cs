namespace DemoPatronProductorConsumidor
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Usuario> colaUsuarios;
        private Productor Productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaUsuarios = new Cola<Usuario>(10);
            Productor = new Productor(colaUsuarios);
            consumidor = new Consumidor(colaUsuarios);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(
                contadorId++,
                txtNombres.Text,
                txtCorreo.Text
                );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuarios.Agregar(nuevoUsuario);
                }
                );
            txtNombres.Clear();
            txtCorreo.Clear();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
            hiloConsumidor.Start();
        }

        private void ProcesarUsuario()
        {
            Usuario usuario = colaUsuarios.Extraer();
            AgregarUsuarioADataGrid(usuario);
        }
        private void AgregarUsuarioADataGrid(Usuario usuario)
        {
            if (DGVUsuarios.InvokeRequired)
            {
                DGVUsuarios.Invoke(new Action(() =>
                {
                    DGVUsuarios.Rows.Add(
                      usuario.Id, usuario.Nombre,
                      usuario.CorreoElectronico,
                      usuario.FechaCreacion
                     );
                })
             );
            }
            else
            {
                DGVUsuarios.Rows.Add(
                    usuario.Id, usuario.Nombre,
                    usuario.CorreoElectronico,
                    usuario.FechaCreacion
                    );
            }
        }
    }
}
