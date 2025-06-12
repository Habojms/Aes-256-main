using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES_256Practice
{
    public partial class Form1 : Form
    {
        cript256 cript = new cript256();
        private bool valorModificado = false; // Bandera para evitar múltiples intentos tras error

        private string ultimaClave = "";
        private string ultimoIV = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void btGen_Click(object sender, EventArgs e)
        {
            // Generar nueva clave e IV
            txtSixteen.Text = Convert.ToBase64String(cript.sixTeen());
            txtSeven.Text = Convert.ToBase64String(cript.thirteen());

            // Guardar copia para verificación posterior
            ultimaClave = txtSeven.Text;
            ultimoIV = txtSixteen.Text;
            valorModificado = false;

            tbResPlane.Clear();
            tbResEn.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] iv = Convert.FromBase64String(txtSixteen.Text);
                byte[] key = Convert.FromBase64String(txtSeven.Text);

                if (iv.Length != 16 || key.Length != 32)
                {
                    MessageBox.Show("Error: Longitud incorrecta de clave o IV (se esperan 16 y 32 bytes)");
                    return;
                }

                tbResEn.Text = Convert.ToBase64String(cript.Encrypt(tbPlane.Text, key, iv));

                // Guardar claves válidas actuales
                ultimaClave = txtSeven.Text;
                ultimoIV = txtSixteen.Text;
                valorModificado = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Texto no válido en formato Base64");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar si la clave o IV fueron modificados desde el último cifrado
            if (valorModificado || txtSeven.Text != ultimaClave || txtSixteen.Text != ultimoIV)
            {
                tbResPlane.Text = "Valor modificado";
                valorModificado = true;
                return;
            }

            try
            {
                byte[] iv = Convert.FromBase64String(txtSixteen.Text);
                byte[] key = Convert.FromBase64String(txtSeven.Text);

                if (iv.Length != 16 || key.Length != 32)
                {
                    tbResPlane.Text = "Valor modificado";
                    valorModificado = true;
                    return;
                }

                byte[] cipherBytes = Convert.FromBase64String(tbEn.Text);
                tbResPlane.Text = cript.Decrypt(cipherBytes, key, iv);
            }
            catch (FormatException)
            {
                tbResPlane.Text = "Valor modificado";
                valorModificado = true;
            }
            catch (CryptographicException)
            {
                tbResPlane.Text = "Valor modificado";
                valorModificado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void btngeneral_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar Llave e IV";
            saveFileDialog.FileName = "llave_iv.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Solo guardamos la Llave y el IV
                    string contenido = "Llave (Key): " + txtSeven.Text + Environment.NewLine +
                                       "IV: " + txtSixteen.Text;

                    File.WriteAllText(saveFileDialog.FileName, contenido, Encoding.UTF8);
                    MessageBox.Show("Llave e IV guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Title = "Seleccionar archivo de llave e IV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lineas = File.ReadAllLines(openFileDialog.FileName);

                    string llaveArchivo = "";
                    string ivArchivo = "";

                    // Leer valores del archivo
                    foreach (string linea in lineas)
                    {
                        if (linea.StartsWith("Llave (Key):"))
                        {
                            llaveArchivo = linea.Replace("Llave (Key):", "").Trim();
                        }
                        else if (linea.StartsWith("IV:"))
                        {
                            ivArchivo = linea.Replace("IV:", "").Trim();
                        }
                    }

                    // Comparar con los valores actuales en el formulario
                    if (llaveArchivo == txtSeven.Text && ivArchivo == txtSixteen.Text)
                    {
                        MessageBox.Show("✅ Llave e IV no se han modificado.", "Verificación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Llave o IV han sido modificados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al comparar: " + ex.Message);
                }
            }
        }
    }
}

