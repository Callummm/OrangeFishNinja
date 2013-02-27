using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
namespace PlatformerMonoPort.EntityManagment
{
    interface IEntity
    {
        int MyUniqueID { get; set; }
        PlatformerMonoPort.GameXEntity WorldIBelongTo { get; set; }
        Vector2 Position { get; set; }
        void Update();
    }
}
