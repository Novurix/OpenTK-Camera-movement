using System;
using OpenTK.Graphics.OpenGL;

namespace CAMERA_MOVEMENT
{
    public class Cube
    {
        public void render()
        {
            GL.Begin(BeginMode.Quads);

            GL.Color3(1.0, 1.0, 1.0); 
            // Front
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(-10, -10, 10);

            GL.Color3(1.0, 0.0, 0.0); 

            // Back
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(10, 10, -10);
            GL.Vertex3(10, -10, -10);
            GL.Vertex3(-10, -10, -10);

            GL.Color3(0.0, 1.0, 0.0); 

            // Left
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(-10, -10, 10);
            GL.Vertex3(-10, -10, -10);

            GL.Color3(0.0, 0.0, 1.0); 

            // Right
            GL.Vertex3(10, 10, -10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(10, -10, -10);

            GL.Color3(1.0, 1.0, 0.0);

            // Top
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, 10, -10);

            GL.Color3(1.0, 0.5, 0.0);

            // Bottom
            GL.Vertex3(-10, -10, -10);
            GL.Vertex3(-10, -10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(10, -10, -10);

            GL.End();
        }
    }
}
