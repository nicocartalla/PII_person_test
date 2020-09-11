using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            

            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void CiValid() // Cambiá el nombre para indicar qué estás probando
        {
           string ci = "48613239";
           IdUtils.IdIsValid(ci);
            // Insertá tu código  de pruebaaquí
        }



        [Test]
        public void PersonValid() // Cambiá el nombre para indicar qué estás probando
        {
           Person p = new Person("Nombre","48613239");

            // Insertá tu código  de pruebaaquí
        }

    }
}