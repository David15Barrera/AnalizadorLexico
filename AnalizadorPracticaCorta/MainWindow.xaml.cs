using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnalizadorPracticaCorta
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
            private void Analizar_Click(object sender, RoutedEventArgs e)
        {
            //GenerarLatabla           
            generarTabla();
            //Llamar a la clase
            AnalizadorLexico palabra = new AnalizadorLexico();
           // Instruccion para mandar los datos a la tabla
            lVresultados.Items.Add(new items { Lexema = palabra.DatoInicial(txbOracion.Text)});

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txbOracion.Text = " " ;
            lVresultados.Items.Clear();
        }

        public class items
        {
            //atributos de la tabla
            public string Lexema { get; set; }
        }
        public void generarTabla()
        {
            // Agrega las columnas
            var gridView = new GridView();
            lVresultados.View = gridView;
            gridView.Columns.Add(new GridViewColumn
            {
                //Atributos de las columnas
                Header = "Lexema",
                DisplayMemberBinding = new Binding("Lexema"),
                Width = 300

            });
       }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autor: David Enrique Lux Barrera Carnet 201931344 \n" +
                " \n Ingrese el el cuadro de texto una oracion cualquiera \n" +
                " Despues precione el boton de Analizar en su pantalla \n" +
                " y en la tabla de resultados a parecera el analisis léxico \n" +
                " de su oracion.\n" +
                " Si quiere seguir analizando oraciones, presione limpiar para limpiar \n" +
                " la tabla de resultados y así de esa manera trabajar mas \n" +
                " ordenado.");
        }
    }
}
