using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryRodriguezSP4A_2_.frmTriatlon;

namespace pryRodriguezSP4A_2_
{
    public partial class frmTriatlon : Form
    {
        public int participantes;
        public struct Datos
        {
            public int puntos;
            public int participante;
        }
        public frmTriatlon()
        {
            InitializeComponent();
        }

        private void dgvParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTriatlon_Load(object sender, EventArgs e)
        {
            int filasParticipantes;
            for (filasParticipantes = 1; filasParticipantes < 6; filasParticipantes++)
            {
                dgvParticipantes.Rows.Add(filasParticipantes.ToString());
            }
            dgvParticipantes.Columns[0].ReadOnly = true;
        }

        private void btnAsignarParticipantes_Click(object sender, EventArgs e)
        {

            for (int participantes = 1; participantes < 6; participantes++)
            {
                if (dgvParticipantes.Rows[participantes].Cells[1].Value == null || dgvParticipantes.Rows[participantes].Cells[2].Value == null)
                {
                    MessageBox.Show("Faltan completar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }
            for (int participantes = 1; participantes < 6; participantes++)
            {
                dgvPosiciones.Columns[participantes + 1].HeaderText = dgvParticipantes.Rows[participantes].Cells[1].ToString();
            }
            for (int participantes = 1; participantes < 3; participantes++)
            {
                dgvPosiciones.Rows[0].Cells[0].Value = "Natacion";
                dgvPosiciones.Rows[1].Cells[0].Value = "Ciclismo";
                dgvPosiciones.Rows[2].Cells[0].Value = "Carrera";
                dgvPosiciones.Columns[0].ReadOnly = true;
                dgvPosiciones.ClearSelection();
                dgvPosiciones.Enabled = true;
            }
        }

        private void btnGanadores_Click(object sender, EventArgs e)
        {
            int fila;
            int col;
            int i;
            int valor;
            string nombre;
            string nacionalidad;
            // controlar los datos ingresados en la grilla de posiciones
            if (!ValidarPosiciones())
            {
                MessageBox.Show("Los datos son incorrectos, revise las posiciones asignadas",
                "Error", MessageBoxButtons.OK);
                return;
            }
            dgvPosiciones.ClearSelection();
            int[,] puestos = new int[3, 6]; // arreglo bidimensional
                                            // copiar el contenido de la grilla al arreglo bidimensional
            for (fila = 0; fila < 3; fila++) // se recorren las filas de la grilla
            {
                for (col = 0; col < 6; col++) // se recorren las columnas de la grilla
                {
                    // obtener el valor de cada celda
                    valor = (int)dgvPosiciones.Rows[fila].Cells[col + 1].Value;
                     // convertirlo a entero
                }
            }

            Datos[] datos = new Datos[6];
            for (i = 0; i < 6; i++)
            {
                datos[i].participante = i + 1; // número de participante
                datos[i].puntos = 0; // cantidad de puntos del participante
            }
            // recorrer el arreglo bidimensional de los puestos y sumar los puntos
            for (col = 0; col < 6; col++) // las columnas son los participantes
            {
                // las filas son las posiciones obtenidas por cada participante
                for (fila = 0; fila < 3; fila++)
                {
                    datos[col].puntos += ObtenerPuntos(puestos[fila, col]);
                }
            }
            Datos[] ganadores = new Datos[3];
            // obtener el primer puesto
            ganadores[0] = BuscarMayorPuntaje(datos, ganadores);
            // obtener el segundo puesto
            ganadores[1] = BuscarMayorPuntaje(datos, ganadores);
            // obtener el tercer puesto
            ganadores[2] = BuscarMayorPuntaje(datos, ganadores);

            dgvGanadores.Rows.Clear();
            for (fila = 0; fila < 3; fila++)
            {
                dgvGanadores.Rows.Add(); // se agrega una nueva fila
                dgvGanadores.Rows[fila].Cells[0].Value = fila + 1; // posición final
                                                                   // obtener la fila que ocupa el participante en la grilla 1
                int f = ganadores[fila].participante - 1;
                // obtener el nombre del participante
                nombre = dgvParticipantes.Rows[f].Cells[1].Value.ToString();
                dgvGanadores.Rows[fila].Cells[1].Value = nombre;
                // obtener la nacionalidad del participante
                nacionalidad = dgvParticipantes.Rows[f].Cells[2].Value.ToString();
                dgvGanadores.Rows[fila].Cells[2].Value = nacionalidad;
                // puntos obtenidos por el participante
                dgvGanadores.Rows[fila].Cells[3].Value = ganadores[fila].puntos.ToString();
            }
            dgvGanadores.ClearSelection();
            EscribirGanadores();
        }
        private Datos BuscarMayorPuntaje(Datos[] datos, Datos[] ganadores)
        {
            throw new NotImplementedException();
        }

        private bool ValidarPosiciones()
        {
            int f;
            int c;
            int i;
            int valor;
            bool resultado = true;
            for (f = 0; f < dgvPosiciones.RowCount; f++)
            {
                for (c = 1; c < dgvPosiciones.ColumnCount; c++)
                {
                    valor = int.Parse(dgvPosiciones.Rows[f].Cells[c].Value.ToString());
                    if (valor < 1 || valor > 6)
                    {
                        resultado = false;
                        break;
                    }

                    for (i = c + 1; i < dgvPosiciones.ColumnCount; i++)
                    {
                        if (valor == int.Parse(dgvPosiciones.Rows[f].Cells[i].Value.ToString()))
                        {
                            resultado = false;
                            break;
                        }
                    }
                }
            }
            return resultado;
        }

        private int ObtenerPuntos(int puesto)
        {
            int[] puntos = new int[6] { 1000, 920, 830, 740, 650, 560 };
            return puntos[puesto-1];
        }

        private Datos BuscarMayorPuntajee(Datos[] d, Datos[] g)
        {
            Datos resultado;
            int i;
            int f;
            int ganadorPrevio;
            resultado.participante = 0;
            resultado.puntos = 0;
            for (i = 0; i < 6; i++)
            {
                if (d[i].puntos > resultado.puntos)
                {
                    ganadorPrevio = 0;
                    for (f = 0; f < g.Length; f++) // recorre 'g' (ganadores)
                    {
                        if (d[i].participante == g[f].participante)
                        {
                            ganadorPrevio = 1;
                        }
                    }
                    if (ganadorPrevio == 0)
                    {
                        resultado.puntos = d[i].puntos;
                        resultado.participante = d[i].participante;
                    }
                }
            }
            return resultado;
        }

        private void EscribirGanadores()
        {
            int ancho = picGanadores.Width;
            int alto = picGanadores.Height;
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            // agregar los nombre de los ganadores al gráfico del podio
            Graphics gra = picGanadores.CreateGraphics();
            string nombre = dgvGanadores.Rows[0].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
            (ancho / 2), alto / 4, formato);
            nombre = dgvGanadores.Rows[1].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
            (ancho / 4), alto / 2.75f, formato);
            nombre = dgvGanadores.Rows[2].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
            (ancho / 1.33f), alto / 2, formato);
        }

    }
}   
