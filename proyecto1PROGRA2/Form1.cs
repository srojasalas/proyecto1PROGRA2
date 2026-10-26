using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1PROGRA2
{
    public partial class Form1 : Form
    {
        private static readonly Random rng = new Random();
        float n1 = 0, n2 = 0, resultado = 0;
        char operador = ' ';
        int N = 11;
        int nivelActual = 1;
        int contaciertos = 0;
        int contfallos = 0;
        const int MAX_FALLOS = 3;
        private int modoActual = 1;
        string[] nombresJugadores = { "Jugador 1", "Jugador 2" };
        int[] puntajesJugadores = { 0, 0 };
        int turnoActual = 0;
        int rondasJugadas = 0;
        const int MAX_RONDAS = 6;
        int[] historialPuntajes = new int[10];
        int indiceHistorial = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ElegirModoDeJuego();
        }

        private void ElegirModoDeJuego()
        {
            DialogResult resultadoDialogo = MessageBox.Show(
                "¿Quiere jugar en modo de dos jugadores?\n\n(Sí = Dos Jugadores | No = Modo Individual)",
                "Selección de Modo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultadoDialogo == DialogResult.Yes)
            {
                modoActual = 2;
            }
            else
            {
                modoActual = 1;
            }

            IniciarPartida();
        }

        private void IniciarPartida()
        {
            contaciertos = 0;
            contfallos = 0;
            nivelActual = 1;
            N = 11;
            indiceHistorial = 0;
            rondasJugadas = 0;
            turnoActual = 0;
            puntajesJugadores[0] = 0;
            puntajesJugadores[1] = 0;

            if (modoActual == 2)
            {
                MessageBox.Show("Modo Dos Jugadores\nPrimer turno para: " + nombresJugadores[0], "Comenzar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Modo Individual\nTienes un límite de 3 vidas.", "Comenzar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ActualizarInterfaz();
            GenerarOperacion();
        }

        private void GenerarOperacion()
        {
            n1 = rng.Next(1, N);
            n2 = rng.Next(1, N);
            int op = rng.Next(1, 5);

            switch (op)
            {
                case 1:
                    resultado = n1 + n2;
                    operador = '+';
                    break;
                case 2:
                    resultado = n1 - n2;
                    operador = '-';
                    break;
                case 3:
                    resultado = n1 * n2;
                    operador = '*';
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        resultado = (float)Math.Round(n1 / n2, 2);
                        operador = '/';
                    }
                    else
                    {
                        resultado = n1 + n2;
                        operador = '+';
                    }
                    break;
            }

            lnum1.Text = n1.ToString();
            lnum2.Text = n2.ToString();
            lop.Text = operador.ToString();
            tresultado.Clear();
            tresultado.Focus();
        }

        private void Baceptar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tresultado.Text, out float respuestaUsuario))
            {
                if (modoActual == 1)
                {
                    if (Math.Abs(resultado - respuestaUsuario) < 0.01f)
                    {
                        DialogResult dialogResult = MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        contaciertos++;
                        GuardarPuntajeEnArreglo(contaciertos);
                        if (contaciertos % 3 == 0)
                        {
                            nivelActual++;
                            N += 15;
                            MessageBox.Show($"Subiste al Nivel {nivelActual}", "Dificultad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Incorrecto. El resultado era: {resultado}", "Fallaste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        contfallos++;

                        if (contfallos >= MAX_FALLOS)
                        {
                            MessageBox.Show($"Perdiste tus 3 vidas.\nAciertos totales: {contaciertos}", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            MostrarHistorialArreglo();
                            ElegirModoDeJuego();
                            return;
                        }
                    }
                }
                else
                {
                    if (Math.Abs(resultado - respuestaUsuario) < 0.01f)
                    {
                        MessageBox.Show($"¡Correcto, {nombresJugadores[turnoActual]}!", "Punto anotado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        puntajesJugadores[turnoActual]++;

                        if ((puntajesJugadores[0] + puntajesJugadores[1]) % 3 == 0)
                        {
                            nivelActual++;
                            N += 15;
                            MessageBox.Show($"¡Dificultad aumentada! Nivel {nivelActual}", "Escalabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Incorrecto, {nombresJugadores[turnoActual]}. El resultado era: {resultado}", "Fallaste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        contfallos++;

                        if (contfallos >= MAX_FALLOS)
                        {
                            MessageBox.Show("¡Límite de fallos globales alcanzado!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            FinalizarYMostrarRankingDosJugadores();
                            return;
                        }
                    }

                    rondasJugadas++;
                    if (rondasJugadas >= MAX_RONDAS)
                    {
                        FinalizarYMostrarRankingDosJugadores();
                        return;
                    }

                    turnoActual = (turnoActual == 0) ? 1 : 0;
                    MessageBox.Show($"Cambio de turno. Ahora le toca a: {nombresJugadores[turnoActual]}", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ActualizarInterfaz();
                GenerarOperacion();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tresultado.Clear();
                tresultado.Focus();
            }
        }

        private void GuardarPuntajeEnArreglo(int puntaje)
        {
            if (indiceHistorial < historialPuntajes.Length)
            {
                historialPuntajes[indiceHistorial] = puntaje;
                indiceHistorial++;
            }
        }

        private void MostrarHistorialArreglo()
        {
            string reporte = "Historial de progreso\n\n";
            for (int i = 0; i < indiceHistorial; i++)
            {
                reporte += $"Intento {i + 1}: {historialPuntajes[i]} aciertos\n";
            }
            MessageBox.Show(reporte, "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FinalizarYMostrarRankingDosJugadores()
        {
            for (int i = 0; i < puntajesJugadores.Length - 1; i++)
            {
                for (int j = 0; j < puntajesJugadores.Length - i - 1; j++)
                {
                    if (puntajesJugadores[j] < puntajesJugadores[j + 1])
                    {
                        int tempPuntaje = puntajesJugadores[j];
                        puntajesJugadores[j] = puntajesJugadores[j + 1];
                        puntajesJugadores[j + 1] = tempPuntaje;

                        string tempNombre = nombresJugadores[j];
                        nombresJugadores[j] = nombresJugadores[j + 1];
                        nombresJugadores[j + 1] = tempNombre;
                    }
                }
            }

            string ranking = "Tabla de calificacion\n\n";
            for (int i = 0; i < nombresJugadores.Length; i++)
            {
                ranking += $"{i + 1}. {nombresJugadores[i]} - {puntajesJugadores[i]} Aciertos\n";
            }

            if (puntajesJugadores[0] > puntajesJugadores[1])
            {
                ranking += $"\nGanador: {nombresJugadores[0]}!";
            }
            else if (puntajesJugadores[0] < puntajesJugadores[1])
            {
                ranking += $"\nGanador: {nombresJugadores[1]}!";
            }
            else
            {
                ranking += "\nEmpate";
            }

            MessageBox.Show(ranking, "Resultados Finales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ElegirModoDeJuego();
        }

        private void ActualizarInterfaz()
        {
            if (modoActual == 1)
            {
                laciertos.Text = contaciertos.ToString();
            }
            else
            {
                laciertos.Text = puntajesJugadores[turnoActual].ToString();
            }

            lfallos.Text = contfallos.ToString();
            lnivel.Text = nivelActual.ToString();
        }
    }
}