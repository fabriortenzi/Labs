namespace Geometria
{
    public class Circulo
    {
        private float m_radio;

        public float Radio
        {
            get => m_radio;
            set => m_radio = value;
        }

        public float CalcularPerimetro()
        {
            return (float) (2 * Math.PI * m_radio);
        }

        public float CalcularSuperficie()
        {
            return (float) (Math.PI * Math.Pow(m_radio, 2));
        }
    }
}