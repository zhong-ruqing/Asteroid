using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace Asteroid
{
    struct Particle
    {
        public Point3d Position { get; set; }
        public double Mass { get; set; }

        public Particle(Point3d position, double mass)
        {
            this.Position = position;
            this.Mass = mass;
        }

        public double DistanceTo(Particle particle)
        {
            return this.Position.DistanceTo(particle.Position);
        }

        public override string ToString()
        {
            return $"particle(position: ({this.Position.X}, {this.Position.Y}, {this.Position.Z}), mass: {this.Mass})";
        }
    }
}
