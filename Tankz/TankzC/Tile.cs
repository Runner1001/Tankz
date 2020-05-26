﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace TankzC
{
    class Tile : Groundable
    {
        public Tile(Vector2 spritePosition, string textureName="crate") : base(spritePosition, textureName, DrawManager.Layer.Playground)
        {
            RigidBody = new RigidBody(sprite.position, this);
            RigidBody.Type = (uint)PhysicsManager.ColliderType.Tile;
            RigidBody.SetCollisionMask((uint)PhysicsManager.ColliderType.Tile);
            RigidBody.IsGravityAffected = true;
        }
    }
}
