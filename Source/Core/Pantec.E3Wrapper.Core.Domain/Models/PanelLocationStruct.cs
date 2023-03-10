namespace Pantec.E3Wrapper.Core.Domain.Models
{
    public struct PanelLocationStruct
    {
        public double X;
        public double Y;
        public double Z;
        public string Rotation;

        public PanelLocationStruct(double x, double y, double z, string rotation)
        {
            X = x;
            Y = y;
            Z = z;
            Rotation = rotation;
        }
    }
}