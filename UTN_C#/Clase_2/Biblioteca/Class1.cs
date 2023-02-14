namespace Biblioteca
{
    public class ConversorDeTemperatura
    {

        private const float ceroAbsoluto = 273.15F;
        public static float ConvertirCelciusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;

            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;

            return temperaturaCelsius;
        }

    }
}