using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace ParallelProject
{
    public partial class Form1 : Form
    {
        //crea las variables globales de la aplicación
        String nombre;
        List<String> listaDiferentes = new List<String>();
        List<int> listaCantidad = new List<int>();
        List<int> listaPalabras = new List<int>();
        int totalCaracteres = 0;
        int suma = 0;
        bool iscontinue = true;

        public Form1()
        {
            InitializeComponent();
        }

        //hace que el hilo de CPU_RAMInfoThread() se cargue al iniciar la aplicación
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Thread demoThread = new Thread(new ThreadStart(this.CPU_RAMInfoThread));

            demoThread.Start();
        }

        //crea el hilo con el que se ejecutan el estado de la RAM y el CPU durante la ejecución del programa
        private void CPU_RAMInfoThread()
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(delegate ()
                {
                    try
                    {
                        while (iscontinue)
                        {
                            CPUprogressBar.Value = (int)(CPU.NextValue());
                            lblCPU.Text = CPUprogressBar.Value.ToString() + " %";

                            RAMprogressBar.Value = (int)(RAM.NextValue());
                            lblRAM.Text = RAMprogressBar.Value.ToString() + " %";

                            Thread.Sleep(1000);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }));

                thread.Priority = ThreadPriority.Highest;
                thread.IsBackground = true;
                thread.Start();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //ejecuta las funciones del botón 1 para buscar, y leer el archivo
        private void button1_Click(object sender, EventArgs e)
        {
            if (nombre != null)
            {
                this.Controls.OfType<TextBox>().ToList().ForEach(limpiar => limpiar.Text = "");
                this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(apagar => apagar.Checked = false);
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Controls.OfType<TextBox>().ToList().ForEach(limpiar => limpiar.Text = "");
                this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(apagar => apagar.Checked = false);
                string extension = Path.GetExtension(openFileDialog1.FileName);
                nombre = openFileDialog1.FileName;
                if (extension == ".docx" | extension == ".doc")
                {

                }
                else
                {
                    
                }

                lblArchivo.Text = nombre;

                Thread thread = new Thread(new ThreadStart(delegate ()
                {
                    try
                    {
                        archivo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }));

                thread.Priority = ThreadPriority.Highest;
                thread.IsBackground = true;
                thread.Start();
                
            }
        }

        //realiza las funciones del botón 2 que se encarga de inicializar todos los métodos y funciones
        private void button2_Click(object sender, EventArgs e)
        {
            if (nombre == null)
            {
                this.Controls.OfType<TextBox>().ToList().ForEach(limpiar => limpiar.Text = "");
                this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(apagar => apagar.Checked = false);
                MessageBox.Show("Debe seleccionar un archivo", "Error");
            }
            else
            {
                Thread thread = new Thread(new ThreadStart(delegate ()
                {
                    try
                    {
                        if (radioButton1.Checked == true)
                        {
                            Stopwatch secuencial = Stopwatch.StartNew();
                            if (checkBox1.Checked == true)
                            {
                                secuencial1();
                            }
                            if (checkBox2.Checked == true)
                            {
                                secuencial2();
                            }
                            if (checkBox3.Checked == true)
                            {
                                secuencial3();
                            }
                            if (checkBox4.Checked == true)
                            {
                                secuencial4();
                            }
                            if (checkBox5.Checked == true)
                            {
                                secuencial5();
                            }
                            if (checkBox6.Checked == true)
                            {
                                secuencial6();
                            }
                            if (checkBox7.Checked == true)
                            {
                                secuencial7();
                            }
                            if (checkBox8.Checked == true)
                            {
                                secuencial8();
                            }
                            if (checkBox9.Checked == true)
                            {
                                sec_ranking();
                            }
                            float milisegundos = secuencial.ElapsedMilliseconds;
                            ejecucionSecuencial.Text = string.Format("{0:0 ms} ", milisegundos);
                        }
                        else if (radioButton2.Checked == true)
                        {
                            Stopwatch paralela = Stopwatch.StartNew();
                            Parallel.Invoke(() =>
                                {
                                    if (checkBox1.Checked == true)
                                    {
                                        paralela1();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox1.Checked == true)
                                    {
                                        paralela2();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox3.Checked == true)
                                    {
                                        paralela3();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox4.Checked == true)
                                    {
                                        paralela4();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox5.Checked == true)
                                    {
                                        paralela5();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox6.Checked == true)
                                    {
                                        paralela6();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox7.Checked == true)
                                    {
                                        paralela7();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox8.Checked == true)
                                    {
                                        paralela8();
                                    }
                                },
                                () =>
                                {
                                    if (checkBox9.Checked == true)
                                    {
                                        paral_ranking();
                                    }
                                }
                            );
                            float milisegundos = paralela.ElapsedMilliseconds;
                            ejecucionParalela.Text = string.Format("{0:0 ms} ", milisegundos);
                        }
                        else
                        {
                            MessageBox.Show("Debe elegir de qué manera se realizarán las operaciones", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }));

                thread.Priority = ThreadPriority.Highest;
                thread.IsBackground = true;
                thread.Start();
            }

        }

        //realiza las funciones del botón 3 el cual se encarga de seleccionar todos los checkbox
        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(encender => encender.Checked = true);
        }

        //realiza las funciones del botón 4 que limpia los checkbox, textfield, las tablas y reestablece los contadores
        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(apagar => apagar.Checked = false);
            this.Controls.OfType<TextBox>().ToList().ForEach(limpiar => limpiar.Text = "");
            this.Controls.OfType<ListView>().ToList().ForEach(limpiar => limpiar.Clear());
            ejecucion1.Text = Convert.ToString(0);
            ejecucion2.Text = Convert.ToString(0);
            ejecucion3.Text = Convert.ToString(0);
            ejecucion4.Text = Convert.ToString(0);
            ejecucion5.Text = Convert.ToString(0);
            ejecucion6.Text = Convert.ToString(0);
            ejecucion7.Text = Convert.ToString(0);
            ejecucion8.Text = Convert.ToString(0);
            ejecucion9.Text = Convert.ToString(0);
            lblRepeats.Text = Convert.ToString(0);
            ColumnHeader header1, header2, header3, head1;
            head1 = new ColumnHeader();
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header3 = new ColumnHeader();
            head1.Text = "Palabras más comunes";
            header1.Text = "Cant. caracteres";
            header2.Text = "Núm. de incidencias";
            header3.Text = "Porcentaje";
            head1.Width = 155;
            header1.Width = 107;
            header2.Width = 110;
            header3.Width = 68;
            listView1.Columns.Add(head1);
            listView2.Columns.Add(header1);
            listView2.Columns.Add(header2);
            listView2.Columns.Add(header3);
        }

        //se ejecuta al cargar el archivo y llena las listas listaCantidad, listaDiferentes y listaPalabras
        public void archivo()
        {
            label8.Text = "Cargando...";
            Stopwatch temporizador = Stopwatch.StartNew();
            String palabra = "";
            String linea = "";
            int contador = 0;
            int contador1 = 1;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    for (int i = 0; i < linea.Length; i++)
                    {
                        if (char.IsLetter(linea[i]))
                        {
                            palabra += linea[i];
                            contador += 1;
                        }
                        else
                        {
                            if (palabra != "")
                            {
                                palabra = palabra.ToLower();
                                if (listaDiferentes == null)
                                {
                                    listaDiferentes.Add(palabra.ToLower());
                                }
                                else
                                {
                                    if (listaDiferentes.Contains(palabra))
                                    {
                                        if (listaPalabras == null)
                                        {
                                            listaPalabras.Add(contador1);
                                            suma += contador1;
                                        }
                                        else
                                        {
                                            int posicion = listaDiferentes.IndexOf(palabra);
                                            int numero = listaPalabras[posicion];
                                            numero += 1;
                                            listaPalabras[posicion] = numero;
                                        }
                                    }
                                    else
                                    {
                                        listaCantidad.Add(contador);
                                        listaDiferentes.Add(palabra.ToLower());
                                        listaPalabras.Add(contador1);
                                        suma += contador1;
                                    }
                                }
                                palabra = "";
                                contador = 0;
                            }
                        }
                    }
                    tex.Add(linea);
                    linea = archivo.ReadLine();
                }
                Console.WriteLine(listaPalabras.Count);
                Console.WriteLine(listaDiferentes.Count);
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion0.Text = string.Format("{0:0 ms} ", milisegundos);
            label8.Text = "Archivo listo";
        }

        //realiza la función de encontrar la palabra más larga del texto de manera secuencial
        public void secuencial1()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String palabra = "";
            for (int a = 0; a < listaDiferentes.Count; a++)
            {
                if (palabra == "")
                {
                    palabra = listaDiferentes[a];
                }
                else
                {
                    if (palabra.Length <= listaDiferentes[a].Length)
                    {
                        palabra = listaDiferentes[a];
                    }
                }
            }
            textBox1.AppendText(palabra);
        
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion1.Text = string.Format("{0:0 ms} ", milisegundos);
        }

        //realiza la función de contar el total de palabras del texto de manera secuencial
        public void secuencial2()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            int suma = 0;
            for (int a = 0; a < listaPalabras.Count; a++)
            {
                suma += listaPalabras[a];
            }
            textBox2.AppendText(Convert.ToString(suma));

            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion2.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de palabras diferentes del texto de manera secuencial
        public void secuencial3()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            if (checkBox2.Checked == true)
            {
                textBox3.AppendText(Convert.ToString(listaDiferentes.Count));
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion3.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de carácteres del texto de manera secuencial
        public void secuencial4()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String linea = "";
            int contador = 0;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    tex.Add(linea);
                    contador += linea.Length;
                    linea = archivo.ReadLine();
                }
                textBox4.AppendText(Convert.ToString(contador));
                totalCaracteres = contador;
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion4.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de carácteres sin contar los espacios del texto de manera secuencial
        public void secuencial5()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String linea = "";
            int contador = 0;
            int espacios = 0;
            char letras;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    contador += linea.Length;
                    for (int a = 0; a < linea.Length; a++)
                    {
                        letras = linea[a];
                        if (letras.Equals(' '))
                        {
                            espacios += 1;
                        }
                    }
                    tex.Add(linea);
                    linea = archivo.ReadLine();
                }
                contador = contador - espacios;
                textBox5.AppendText(Convert.ToString(contador));
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion5.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de oraciones del texto de manera secuencial
        public void secuencial6()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String linea = "";
            int contador = 0;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    for (int i = 0; i < linea.Length; i++)
                    {
                        if (linea[i] == '.')
                        {
                            contador += 1;
                        }
                    }
                    tex.Add(linea);
                    linea = archivo.ReadLine();
                }
                textBox6.AppendText(Convert.ToString(contador));
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion6.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar las repeticiones de una palabra en el texto de manera secuencial
        public void secuencial7()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String N_palabra = textBox7.Text;
            if (N_palabra == "")
            {
                MessageBox.Show("Debe ingresar la palabra", "Repetición de una palabra");

                this.Controls.OfType<TextBox>().ToList().ForEach(limpiar => limpiar.Text = "");
                this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(apagar => apagar.Checked = false);
            }
            else
            {
                String palabra = "";
                String linea = "";
                int contador = 0;
                ArrayList tex = new ArrayList();
                if (nombre != "")
                {
                    System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                    while (linea != null)
                    {
                        for (int i = 0; i < linea.Length; i++)
                        {
                            if (char.IsLetter(linea[i]))
                            {
                                palabra += linea[i];
                            }
                            else
                            {
                                if (palabra != "")
                                {
                                    if (palabra.ToLower() == N_palabra.ToLower())
                                    {
                                        contador += 1;
                                    }
                                    palabra = "";
                                }
                            }
                        }
                        tex.Add(linea);
                        linea = archivo.ReadLine();
                    }
                    lblRepeats.Text = Convert.ToString(contador);
                    archivo.Close();
                }
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion7.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar las N palabras más comunes del texto y acomodarlas en una lista de manera secuencial
        public void secuencial8()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            int contador = 0;
            int posicion = 0;
            List<int> listaPosiciones = new List<int>();
            if (textBox8.Text == "")
            {
                MessageBox.Show("Debe ingresar un número en la parte de abajo de la función", "Número de palabras más comunes");
            }
            else
            {
                int numero = Convert.ToInt32(textBox8.Text);
                int var = 0;

                while (contador < numero)
                {
                    if (contador < listaDiferentes.Count)
                    {
                        int mayor = 0;
                        int a = 0;
                        while (a < listaDiferentes.Count)
                        {
                            if (!listaPosiciones.Contains(a))
                            {
                                if (mayor == 0)
                                {
                                    mayor = listaPalabras[a];
                                    var = a;
                                }
                                else
                                {
                                    if (listaPalabras[a] > mayor)
                                    {
                                        mayor = listaPalabras[a];
                                        var = a;
                                    }
                                }
                            }
                            Console.WriteLine(listaPalabras[a]);
                            a += 1;
                        }
                        contador += 1;
                        listaPosiciones.Add(var);
                        Console.WriteLine(listaDiferentes[posicion]);
                        ListViewItem lv = new ListViewItem(Convert.ToString(listaDiferentes[var]));
                        listView1.Items.Add(lv);
                    }
                    else
                    {
                        MessageBox.Show("El texto no contiene esa cantidad de palabras solo se mostrará la cantidad que el documento posea", "Palabras más comunes");
                        break;
                    }
                }
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion8.Text = string.Format("{0:0} ms", milisegundos);
        }

        //realiza la función de hacer el ranking de palabras y acomodarlas en una lista de manera secuencial
        public void sec_ranking()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            int suma = 0;
            List<int> listaRe = new List<int>();
            List<int> Posiciones = new List<int>();
            for (int e = 0; e < listaPalabras.Count; e++)
            {
                suma += listaPalabras[e];
            }
            for (int conta = 0; conta < listaPalabras.Count; conta++)
            {
                int SumaCantidad = 0;
                int cantidad = 0;
                for (int a = 0; a < listaCantidad.Count; a++)
                {
                    if (cantidad == 0)
                    {
                        cantidad = listaCantidad[conta];
                        SumaCantidad += listaPalabras[conta];
                        Posiciones.Add(conta);
                    }
                    else
                    {
                        if (cantidad == listaCantidad[a])
                        {
                            if (!Posiciones.Contains(a))
                            {
                                Console.WriteLine(listaPalabras[a]);
                                SumaCantidad += listaPalabras[a];
                                Posiciones.Add(a);
                            }
                        }
                    }
                }
                if (!listaRe.Contains(cantidad))
                {
                    ListViewItem lista = new ListViewItem(Convert.ToString(cantidad));
                    lista.SubItems.Add(Convert.ToString(SumaCantidad));
                    double porcentaje = SumaCantidad * 100;
                    porcentaje = porcentaje / suma;
                    porcentaje = Math.Round(porcentaje, 2);
                    lista.SubItems.Add(Convert.ToString(porcentaje));
                    listView2.Items.Add(lista);
                    listaRe.Add(cantidad);
                }
                float milisegundos = temporizador.ElapsedMilliseconds;
                ejecucion9.Text = string.Format("{0:0 ms}", milisegundos);
            }
        }

        //realiza la función de encontrar la palabra más larga del texto de manera paralela
        public void paralela1()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String palabra1 = "";
            String palabra2 = "";
            String palabraLarga = "";
            Parallel.Invoke(() =>
            {
                for (int a = 0; a <= listaDiferentes.Count / 2; a++)
                {
                    if (palabra1 == "")
                    {
                        palabra1 = listaDiferentes[a];
                    }
                    else
                    {
                        if (palabra1.Length <= listaDiferentes[a].Length)
                        {
                            palabra1 = listaDiferentes[a];
                        }
                    }
                }
            }, 
            () =>
            {
                for (int a = listaDiferentes.Count; a < listaDiferentes.Count / 2 + 1; a--)
                {
                    if (palabra2 == "")
                    {
                        palabra2 = listaDiferentes[a];
                    }
                    else
                    {
                        if (palabra2.Length <= listaDiferentes[a].Length)
                        {
                            palabra2 = listaDiferentes[a];
                        }
                    }
                }
            });

            if (palabra1.Length <= palabra2.Length)
            {
                palabraLarga = palabra2;
            }
            else
            {
                palabraLarga = palabra1;
            }
            textBox1.AppendText(palabraLarga);

            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion1.Text = string.Format("{0:0 ms} ", milisegundos);
        }

        //realiza la función de contar el total de palabras del texto de manera paralela
        public void paralela2()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            int suma1 = 0;
            int suma2 = 0;
            int sumaMayor = 0;
            Parallel.Invoke(() =>
            {
                for (int a = 0; a <= listaPalabras.Count / 2; a++)
                {
                    suma1 += listaPalabras[a];
                }
            }, () =>
            {
                for (int a = listaPalabras.Count ; a < listaPalabras.Count / 2 + 1; a++)
                {
                    suma2 += listaPalabras[a];
                }
            });

            if (suma1 <= suma2)
            {
                sumaMayor = suma2;
            }
            else
            {
                sumaMayor = suma1;
            }

            textBox2.AppendText(Convert.ToString(suma));
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion2.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de palabras diferentes del texto de manera paralela
        public void paralela3()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            if (checkBox2.Checked == true)
            {
                textBox3.AppendText(Convert.ToString(listaDiferentes.Count));
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion3.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de carácteres del texto de manera paralela
        public void paralela4()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String linea = "";
            int contador = 0;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    tex.Add(linea);
                    contador += linea.Length;
                    linea = archivo.ReadLine();
                }
                textBox4.AppendText(Convert.ToString(contador));
                totalCaracteres = contador;
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion4.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de carácteres sin contar los espacios del texto de manera paralela
        public void paralela5()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String linea = "";
            int contador = 0;
            int espacios = 0;
            char letras;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    contador += linea.Length;
                    for (int a = 0; a < linea.Length; a++)
                    {
                        letras = linea[a];
                        if (letras.Equals(' '))
                        {
                            espacios += 1;
                        }
                    }
                    tex.Add(linea);
                    linea = archivo.ReadLine();
                }
                contador = contador - espacios;
                textBox5.AppendText(Convert.ToString(contador));
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion5.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar el total de oraciones del texto de manera paralela
        public void paralela6()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String linea = "";
            int contador = 0;
            ArrayList tex = new ArrayList();
            if (nombre != "")
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                while (linea != null)
                {
                    for (int i = 0; i < linea.Length; i++)
                    {
                        if (linea[i] == '.')
                        {
                            contador += 1;
                        }
                    }
                    tex.Add(linea);
                    linea = archivo.ReadLine();
                }
                textBox6.AppendText(Convert.ToString(contador));
                archivo.Close();
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion6.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar las repeticiones de una palabra en el texto de manera paralela
        public void paralela7()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            String N_palabra = textBox7.Text;
            if (N_palabra == "")
            {
                MessageBox.Show("Debe ingresar la palabra", "Repetición de una palabra");

                this.Controls.OfType<TextBox>().ToList().ForEach(limpiar => limpiar.Text = "");
                this.Controls.OfType<System.Windows.Forms.CheckBox>().ToList().ForEach(apagar => apagar.Checked = false);
            }
            else
            {
                String palabra = "";
                String linea = "";
                int contador = 0;
                ArrayList tex = new ArrayList();
                if (nombre != "")
                {
                    System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName,
                       System.Text.Encoding.Default, false);
                    while (linea != null)
                    {
                        for (int i = 0; i < linea.Length; i++)
                        {
                            if (char.IsLetter(linea[i]))
                            {
                                palabra += linea[i];
                            }
                            else
                            {
                                if (palabra != "")
                                {
                                    if (palabra.ToLower() == N_palabra.ToLower())
                                    {
                                        contador += 1;
                                    }
                                    palabra = "";
                                }
                            }
                        }
                        tex.Add(linea);
                        linea = archivo.ReadLine();
                    }
                    lblRepeats.Text = Convert.ToString(contador);
                    archivo.Close();
                }
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion7.Text = string.Format("{0:0 ms}", milisegundos);
        }

        //realiza la función de contar las N palabras más comunes del texto y acomodarlas en una lista de manera paralela
        public void paralela8()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            int contador = 0;
            int posicion = 0;
            List<int> listaPosiciones = new List<int>();
            if (textBox8.Text == "")
            {
                MessageBox.Show("Debe ingresar un número en la parte de abajo de la función", "Número de palabras más comunes");
            }
            else
            {
                int numero = Convert.ToInt32(textBox8.Text);
                int var = 0;

                while (contador < numero)
                {
                    if (contador < listaDiferentes.Count)
                    {
                        int mayor = 0;
                        int a = 0;
                        while (a < listaDiferentes.Count)
                        {
                            if (!listaPosiciones.Contains(a))
                            {
                                if (mayor == 0)
                                {
                                    mayor = listaPalabras[a];
                                    var = a;
                                }
                                else
                                {
                                    if (listaPalabras[a] > mayor)
                                    {
                                        mayor = listaPalabras[a];
                                        var = a;
                                    }
                                }
                            }
                            Console.WriteLine(listaPalabras[a]);
                            a += 1;
                        }
                        contador += 1;
                        listaPosiciones.Add(var);
                        Console.WriteLine(listaDiferentes[posicion]);
                        ListViewItem lv = new ListViewItem(Convert.ToString(listaDiferentes[var]));
                        listView1.Items.Add(lv);
                    }
                    else
                    {
                        MessageBox.Show("El texto no contiene esa cantidad de palabras solo se mostrará la cantidad que el documento posea", "Palabras más comunes");
                        break;
                    }
                }
            }
            float milisegundos = temporizador.ElapsedMilliseconds;
            ejecucion8.Text = string.Format("{0:0} ms", milisegundos);
        }

        //realiza la función de hacer el ranking de palabras y acomodarlas en una lista de manera paralela
        public void paral_ranking()
        {
            Stopwatch temporizador = Stopwatch.StartNew();
            int suma = 0;
            List<int> listaRe = new List<int>();
            List<int> Posiciones = new List<int>();
            for (int e = 0; e < listaPalabras.Count; e++)
            {
                suma += listaPalabras[e];
            }
            for (int conta = 0; conta < listaPalabras.Count; conta++)
            {
                int SumaCantidad = 0;
                int cantidad = 0;
                for (int a = 0; a < listaCantidad.Count; a++)
                {
                    if (cantidad == 0)
                    {
                        cantidad = listaCantidad[conta];
                        SumaCantidad += listaPalabras[conta];
                        Posiciones.Add(conta);
                    }
                    else
                    {
                        if (cantidad == listaCantidad[a])
                        {
                            if (!Posiciones.Contains(a))
                            {
                                Console.WriteLine(listaPalabras[a]);
                                SumaCantidad += listaPalabras[a];
                                Posiciones.Add(a);
                            }
                        }
                    }
                }
                if (!listaRe.Contains(cantidad))
                {
                    ListViewItem lista = new ListViewItem(Convert.ToString(cantidad));
                    lista.SubItems.Add(Convert.ToString(SumaCantidad));
                    double porcentaje = SumaCantidad * 100;
                    porcentaje = porcentaje / suma;
                    porcentaje = Math.Round(porcentaje, 2);
                    lista.SubItems.Add(Convert.ToString(porcentaje));
                    listView2.Items.Add(lista);
                    listaRe.Add(cantidad);
                }
                float milisegundos = temporizador.ElapsedMilliseconds;
                ejecucion9.Text = string.Format("{0:0 ms}", milisegundos);
            }
        }
    }
}