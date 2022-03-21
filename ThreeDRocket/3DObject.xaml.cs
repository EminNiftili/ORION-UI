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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThreeDRocket
{
    /// <summary>
    /// Interaction logic for _3DObject.xaml
    /// </summary>
    public partial class _3DObject : UserControl
    {
        public _3DObject()
        {
            InitializeComponent();
            Create3DViewPort();
        }
        HelixViewport3D hVp3D;
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
            
            foreach (var item in items)
            {
                ModelVisual3D visual3D = new ModelVisual3D();
                visual3D.Content = item;
                hVp3D.Children.Add(visual3D);
            }
            TranformY(90);
            hVp3D.CameraMode = CameraMode.FixedPosition;
            hVp3D.CameraRotationMode = CameraRotationMode.Trackball;
            //hVp3D.CameraController.CameraPosition = new Point3D(100,100,100);
            //hVp3D.ChangeCameraDirection(new Vector3D(100, 100, 100));
            //hVp3D.Camera.Transform.Transform(new Point3D(100, 100, 100));


            Vector3D vector3D = new Vector3D(0, 0, 1);
            var matrix = hVp3D.Camera.Transform.Value;
            matrix.OffsetX = 300;
            matrix.OffsetY = 2000;
            matrix.OffsetZ = 1500;
            matrix.Rotate(new Quaternion(vector3D, 90));
            hVp3D.Camera.Transform = new MatrixTransform3D(matrix);

            this.gridName.Children.Add(hVp3D);
        }
        private void TranformRocket(Vector3D axis, int angle)
        {
            foreach (var item in hVp3D.Children)
            {
                var matrix = item.Transform.Value;
                //matrix.Rotate(new Quaternion(axis, angle)); // Default My Rotate
                matrix.RotateAtPrepend(new Quaternion(axis, angle), new Point3D(0, 0, 0));
                item.Transform = new MatrixTransform3D(matrix);
            }
        }
    }
}
