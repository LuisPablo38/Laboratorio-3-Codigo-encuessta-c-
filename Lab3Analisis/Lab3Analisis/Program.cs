using System;
using System.Threading;
using System.IO; 

namespace Lab3Analisis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese su nombre
            Console.Write("Bienvenido al cuestionario de salud mental, ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Solicitar al usuario que ingrese su edad
            Console.Write("Ingrese su edad: ");
            // Intentar convertir la entrada a un número entero
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                // Mostrar el mensaje de bienvenida con la información ingresada
                Console.WriteLine($"Bienvenido, {nombre} de {edad} años. Gracias por participar en el cuestionario de salud mental.");
                Thread.Sleep(3000);
                Console.Clear();


                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Poco interés o placer en hacer cosas \n  ");
                int punteo = 0;
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();



                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Se ha sentido decaído(a), deprimido(a) o sin esperanzas \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();



                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Ha tenido dificultad para quedarse o permanecer dormido(a), o ha dormido demasiado \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();


                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Se ha sentido cansado(a) o con poca energía \n  ");
                
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();


                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Sin apetito o ha comido en exceso \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();


                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Se ha sentido mal con usted mismo(a) – o que es un fracaso o que ha quedado mal con usted mismo(a) o con su familia \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Ha tenido dificultad para concentrarse en ciertas actividades, tales como leer el periódico o ver la televisión \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n ¿Se ha movido o hablado tan lento que otras personas podrían haberlo notado? o lo contrario – muy inquieto(a) o agitado(a) que ha estado moviéndose mucho más de lo normal \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();


                Console.WriteLine("Ingrese según se identifica: \n 0 = Ningún día \n 1 = Varios Días \n 2 = Más de la mitad de los días \n 3 = Casi todos los días \n\n Pensamientos de que estaría mejor muerto(a) o de lastimarse de alguna manera \n  ");
                punteo += int.Parse(Console.ReadLine());
                Console.Clear();

                string resultado = "";

                switch (punteo)
                {
                    case int n when (n >= 0 && n <= 4):
                        resultado = "No hay depresion";
                        break;
                    case int n when (n >= 5 && n <= 9):
                        resultado = "Depresion leve";
                        break;
                    case int n when (n >= 10 && n <= 14):
                        resultado = "Depresion moderada";
                        break;
                    case int n when (n >= 15 && n <= 19):
                        resultado = "Depresion moderadamente severa";
                        break;
                    case int n when (n >= 20 && n <= 27):
                        resultado = "Depresion severa";
                        break;
                    default:
                        resultado = "Valor de punteo no valido";
                        break;
                }




                // Ruta del archivo CSV
                string filePath = "C:/Users/luisp/Desktop/Landivar/Quinto Año/Analisis y diseño/Teoria/Resultados_Encuesta.csv";

                // Verificar si el archivo CSV ya existe
                bool archivoExistente = File.Exists(filePath);

                // Crear o abrir el archivo CSV para escritura
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    // Si el archivo no existe, escribir encabezados
                    if (!archivoExistente)
                    {
                        sw.WriteLine("Nombre,Edad,Puntaje,Diagnostico");
                    }

                    // Escribir datos en el archivo CSV
                    sw.WriteLine($"{nombre},{edad}, {punteo},{resultado}" );
                }

                switch (punteo)
                {
                    case int n when (n >= 0 && n <= 4):
                        Console.WriteLine("\n Sigue adelante con tu vida y actividades, no olvides sonreír."); 
                        break;
                    case int n when (n >= 5 && n <= 9):
                        Console.WriteLine("Mejorar el mal humor puede ser un desafío, pero hay varias estrategias que podrían ayudarte a cambiar tu estado de ánimo. Aquí tienes cinco consejos: \n\n1. * Identifica la causa: *Reflexiona sobre lo que podría estar causando tu mal humor.Pregúntate a ti mismo si hay algo específico que te haya molestado o si es una acumulación de pequeñas tensiones.Identificar la causa puede ayudarte a abordar el problema de manera más efectiva. \n\n2. * Haz ejercicio: *La actividad física libera endorfinas, que son neurotransmisores que actúan como analgésicos naturales y generadores de bienestar.Incluso una breve caminata o sesión de ejercicios puede tener un impacto positivo en tu estado de ánimo.\n\n3. * Practica la respiración profunda: *Tómate unos minutos para practicar la respiración profunda.La respiración lenta y profunda puede ayudar a reducir el estrés y la ansiedad, aliviando el mal humor.Concéntrate en inhalar profundamente por la nariz y exhalar lentamente por la boca.\n\n4. * Cambia tu enfoque: *Intenta cambiar tu perspectiva sobre la situación que te está afectando.A veces, una actitud más positiva puede hacer una gran diferencia.En lugar de centrarte en lo negativo, trata de encontrar aspectos positivos o soluciones posibles. \n\n5. * Haz algo que disfrutes: *Dedica tiempo a actividades que te gusten y que te relajen.Puede ser leer un libro, escuchar música, ver una película divertida o salir con amigos.El disfrute de actividades placenteras puede ayudarte a desconectar y mejorar tu estado de ánimo.");
                        break;
                    case int n when (n >= 10 && n <= 14):
                        Console.WriteLine("Identificar la depresión puede ser difícil, ya que los síntomas pueden variar de una persona a otra. Sin embargo, aquí hay cinco señales comunes que podrían indicar la presencia de depresión: \n\n1. * Cambios en el estado de ánimo persistente: *La depresión se caracteriza por cambios significativos en el estado de ánimo que persisten durante un período prolongado.Esto puede incluir sentimientos de tristeza, desesperanza, irritabilidad o apatía que afectan negativamente la vida cotidiana.\n\n2. * Pérdida de interés o placer en actividades: *Las personas con depresión a menudo pierden interés en actividades que antes disfrutaban.La falta de motivación o placer en cosas que solían ser gratificantes puede ser un indicador importante.\n\n3. * Cambios en el sueño y el apetito: *La depresión puede afectar los patrones de sueño y apetito.Algunas personas experimentan insomnio o duermen demasiado, mientras que otras pueden experimentar cambios en el apetito, como la pérdida o el aumento de peso.\n\n4. * Fatiga y falta de energía: *Las personas deprimidas a menudo reportan sentirse constantemente cansadas, incluso después de un buen descanso.La fatiga y la falta de energía pueden interferir con la capacidad para realizar actividades diarias.\n\n5. * Sentimientos de inutilidad o culpa excesiva: *Las personas con depresión a menudo tienen pensamientos negativos sobre sí mismas y pueden experimentar sentimientos de inutilidad o culpa sin una razón aparente.Estos pensamientos pueden ser irracionales y desproporcionados a la situación.");
                        break;
                    case int n when (n >= 15 && n <= 19):
                        Console.WriteLine(" Tratar la depresión puede ser un proceso complejo y debe llevarse a cabo con el apoyo de profesionales de la salud mental. Aquí tienes cinco consejos generales que pueden ayudar como complemento al tratamiento profesional: \n\nBusca ayuda profesional: Un profesional de la salud mental, como un psicólogo, psiquiatra o consejero, puede proporcionar el apoyo necesario.La terapia cognitivo - conductual y la terapia farmacológica son enfoques comunes para tratar la depresión.\n\nEstablece rutinas saludables: La estructura en la vida diaria puede ser beneficiosa.Establece horarios regulares para dormir, comer y realizar actividades.La consistencia puede ayudar a mantener un sentido de normalidad.\n\nFomenta el apoyo social: Mantener conexiones sociales puede ser crucial.Comparte tus sentimientos con amigos y familiares de confianza.La soledad puede exacerbar la depresión, así que busca el apoyo de personas que te comprendan.\n\nPractica el autocuidado: Dedica tiempo a cuidar de ti mismo.Realiza actividades que disfrutes, descansa lo necesario y asegúrate de atender tus necesidades físicas y emocionales.\n\nIntroduce actividad física: El ejercicio regular ha demostrado tener efectos positivos en el estado de ánimo.Incluso pequeñas cantidades de actividad física pueden liberar endorfinas y contribuir a una sensación general de bienestar.");
                        break;
                    case int n when (n >= 20 && n <= 27):
                        Console.WriteLine("Nos preocupa su resultado, por favor comuníquese a los siguiente números \npara recibir ayuda: \n\nLinea prevención al suicidio: 5392-5953 \nLiga mental de higiene mental: 2232 - 6269 / 2238 - 3739 \nHospital Inside Health: 4500 - 5662 \nPaso a paso: 2332 - 0606 ");
                        break;
                    default:
                        resultado = "Valor de punteo no valido";
                        break;
                }

                Console.WriteLine("\nGracias por participar.");

                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("Error al ingresar la edad. Asegúrese de ingresar un número entero válido.");
            }

        }
    }
}
