using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Asteroid
{
    public class AsteroidInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Asteroid";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("370671a5-809b-495b-a45f-bbcf6591b665");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
