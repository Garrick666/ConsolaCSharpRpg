using ConsoleApp1.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MotorJuego
{
    public class ServicioJuego
    {
        public void NuevoJuego()
        {
            //Aquí se lee un archivo JSON de donde se tomarán las misiones, datos y atributos
            //Es interesante, pero un poco engorroso
            //Lo bueno es que el archivo puede editarse por separado.
            //SE AGREGÓ UN PLUGIN PARA USAR JSONCONVERT

            var ruta_archivo = $"{AppDomain.CurrentDomain.BaseDirectory}RPG Consola";
            var NuevaAventura = new Aventuras();

            if (File.Exists($"{ruta_archivo}\\archivo.json"))
            {
                var directorio = new DirectoryInfo(ruta_archivo);
                var archivoJson = directorio.GetFiles("archivo.json");

                using (StreamReader fi = File.OpenText(archivoJson[0].FullName))
                {
                    NuevaAventura = JsonConvert.DeserializeObject<Aventuras>(fi.ReadToEnd());
                }

                Console.WriteLine($"Titulo : {NuevaAventura.Titulo}");
                Console.WriteLine($"Descripcion : {NuevaAventura.Descripcion}");


            }
        }
    }
}
