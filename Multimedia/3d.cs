using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using NAudio;
using NAudio.Wave;

namespace Multimedia
{
    public partial class _3d : Form
    {
        private GLControl glControl;
        WaveFileReader reader;
        WaveOutEvent waveOut;
        private float rotationAngle = 0;

        public _3d()
        {
            InitializeComponent();
            initGLControl(this.Width,this.Height);
            playAudio();
        }

        private void initGLControl(int w, int h)
        {
            glControl = new GLControl();
            glControl.Dock = DockStyle.Fill;
            glControl.Load += GLControl_Load;
            glControl.Paint += GLControl_Paint;
            Controls.Add(glControl);
        }

        private void GLControl_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void GLControl_Paint(object sender, EventArgs e)
        {
            GL.ClearColor(System.Drawing.Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Viewport(0, 0, glControl.Width, glControl.Height);
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45), (float)glControl.Width / (float)glControl.Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref perspective);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Matrix4 lookat = Matrix4.LookAt(Vector3.UnitZ * 5, Vector3.Zero, Vector3.UnitY);
            GL.LoadMatrix(ref lookat);

            GL.Rotate(rotationAngle, Vector3.UnitY);

            if (rotationAngle < 360)
            {
                DrawPyramid();
            }
            else
            {
                DrawCube();
                if (rotationAngle > 720)
                {
                    rotationAngle = 0;
                }
            }

            glControl.SwapBuffers();
        }
        private void Application_Idle(object sender, EventArgs e)
        {
            rotationAngle += (float)1;
            glControl.Invalidate(); 
        }
        private void DrawPyramid()
        {
            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(System.Drawing.Color.Red);
            GL.Vertex3(-1, -1, -1);
            GL.Vertex3(1, -1, -1);
            GL.Vertex3(0, 1, 0);

            GL.Color3(System.Drawing.Color.Green);
            GL.Vertex3(-1, -1, -1);
            GL.Vertex3(0, -1, 1);
            GL.Vertex3(0, 1, 0);

            GL.Color3(System.Drawing.Color.Blue);
            GL.Vertex3(1, -1, -1);
            GL.Vertex3(0, -1, 1);
            GL.Vertex3(0, 1, 0);

            GL.Color3(System.Drawing.Color.Yellow);
            GL.Vertex3(-1, -1, -1);
            GL.Vertex3(1, -1, -1);
            GL.Vertex3(0, -1, 1);

            GL.End();
        }

        private void DrawCube()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(System.Drawing.Color.Red);
            GL.Vertex3(-1, -1, -1);
            GL.Vertex3(1, -1, -1);
            GL.Vertex3(1, 1, -1);
            GL.Vertex3(-1, 1, -1);

            GL.Color3(System.Drawing.Color.Blue);
            GL.Vertex3(-1, -1, 1);
            GL.Vertex3(1, -1, 1);
            GL.Vertex3(1, 1, 1);
            GL.Vertex3(-1, 1, 1);

            GL.Color3(System.Drawing.Color.Green);
            GL.Vertex3(-1, 1, -1);
            GL.Vertex3(1, 1, -1);
            GL.Vertex3(1, 1, 1);
            GL.Vertex3(-1, 1, 1);

            GL.Color3(System.Drawing.Color.Yellow);
            GL.Vertex3(-1, -1, -1);
            GL.Vertex3(1, -1, -1);
            GL.Vertex3(1, -1, 1);
            GL.Vertex3(-1, -1, 1);

            GL.Color3(System.Drawing.Color.Cyan);
            GL.Vertex3(1, -1, -1);
            GL.Vertex3(1, 1, -1);
            GL.Vertex3(1, 1, 1);
            GL.Vertex3(1, -1, 1);

            GL.Color3(System.Drawing.Color.Magenta);
            GL.Vertex3(-1, -1, -1);
            GL.Vertex3(-1, 1, -1);
            GL.Vertex3(-1, 1, 1);
            GL.Vertex3(-1, -1, 1);

            GL.End();
        }

        private void playAudio()
        {
            try
            {
                String route = Environment.CurrentDirectory + "/music-brackground.wav";
                reader = new WaveFileReader(route);
                waveOut = new WaveOutEvent();
                waveOut.Init(reader);
                waveOut.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _3d_FormClosed(object sender, FormClosedEventArgs e)
        {
            waveOut.Stop();
        }
    }
}
