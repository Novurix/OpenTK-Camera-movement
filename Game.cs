using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace CAMERA_MOVEMENT
{
    public class Game
    {
        GameWindow window;
        Cube cube;

        Camera camera;

        public Game(GameWindow window) {
            this.window = window;

            cube = new Cube();
            camera = new Camera(window);
            updater();
        }

        void updater() {

            window.RenderFrame += render;
            window.UpdateFrame += camera.update;
            window.Resize += resize;
            window.Load += loaded;

            window.Run(1/60);
        }

        void render(object sender, EventArgs e) { 

            var view = Matrix4.LookAt(camera.position,camera.position + camera.front, camera.up);
            GL.LoadMatrix(ref view);
            GL.MatrixMode(MatrixMode.Modelview);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            cube.render();

            window.SwapBuffers();
        }

        void resize(object sender, EventArgs e) {

            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 perspectiveMatrix =
                Matrix4.CreatePerspectiveFieldOfView(1, window.Width / window.Height, 1.0f, 1000.0f);
            GL.LoadMatrix(ref perspectiveMatrix);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.End();
        }

        void loaded(object sender, EventArgs e) {
            GL.ClearColor(0, 0, 0, 0);
            GL.Enable(EnableCap.DepthTest);
        }
    }
}
