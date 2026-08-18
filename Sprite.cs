using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Vector2 = Microsoft.Xna.Framework.Vector2;
namespace Project1
{
    internal class Sprite
    {
        public Texture2D texture;
        public Vector2 position;

        public Sprite  (Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }
    
    }



}
