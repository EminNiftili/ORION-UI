using HelixToolkit.Wpf;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThreeDRocket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HelixViewport3D hVp3D;
        public MainWindow()
        {
            InitializeComponent();
            Create3DViewPort();
        }
        public void TranformX(int degree)
        {

            var axis = new Vector3D(1, 0, 0);
            var angle = degree;
            TranformRocket(axis, angle);
        }
        public void TranformY(int degree)
        {

            var axis = new Vector3D(0, 1, 0);
            var angle = degree;
            TranformRocket(axis, angle);
        }
        public void TranformZ(int degree)
        {

            var axis = new Vector3D(0, 0, 1);
            var angle = degree;
            TranformRocket(axis, angle);
        }
        private void Create3DViewPort()
        {
            Model3DGroup group = new ModelImporter().Load(@"C:\Users\eminn\Downloads\ROKET.STL");
            var items = group.Children.ToList();
            hVp3D = new HelixViewport3D();
            hVp3D.Name = "ThreeD";
            var lights = new DefaultLights();
            hVp3D.Children.Add(lights);
            //hVp3D.Children.Add(teaPot);
            //this.gridName.Children.Add(hVp3D);
            
            foreach(var item in items)
            {
                ModelVisual3D visual3D = new ModelVisual3D();
                visual3D.Content = item;
                hVp3D.Children.Add(visual3D);
            }
            this.gridName.Children.Add(hVp3D);
        }
        private void TranformRocket(Vector3D axis, int angle)
        {
            foreach (var item in hVp3D.Children)
            {
                var matrix = item.Transform.Value;
                matrix.Rotate(new Quaternion(axis, angle));

                item.Transform = new MatrixTransform3D(matrix);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TranformY(-20);
            string[] txt = X.Content.ToString().Split('=');
            X.Content = X.Content.ToString().Replace(txt[1], (Convert.ToInt32(txt[1]) + 20).ToString());
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TranformY(20);
            string[] txt = Y.Content.ToString().Split('=');
            Y.Content = Y.Content.ToString().Replace(txt[1], (Convert.ToInt32(txt[1]) + 20).ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var axis = new Vector3D(0, 0, 1);
            var angle = 10;
            TranformRocket(axis, angle);
            string[] txt = Z.Content.ToString().Split('=');
            Z.Content = Z.Content.ToString().Replace(txt[1], (Convert.ToInt32(txt[1]) + angle).ToString());
        }
    }
}
