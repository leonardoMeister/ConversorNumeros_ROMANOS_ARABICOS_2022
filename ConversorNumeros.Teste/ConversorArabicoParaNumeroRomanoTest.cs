using ConversorNumeros.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorNumeros.Teste
{
    [TestClass]
    public class ConversorArabicoParaNumeroRomanoTest
    {
        private NumerosParaRomanos conversor;

        public ConversorArabicoParaNumeroRomanoTest()
        {
            conversor = new NumerosParaRomanos();
        }

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        public void Deve_converter_numeros_romanos_do_1_ao_10(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XI", 11)]
        [DataRow("XII", 12)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XV", 15)]
        [DataRow("XVI", 16)]
        [DataRow("XVII", 17)]
        [DataRow("XVIII", 18)]
        [DataRow("XIX", 19)]
        [DataRow("XX", 20)]
        public void Deve_converter_numeros_romanos_do_11_ao_20(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("XXX", 30)]
        [DataRow("XL", 40)]
        [DataRow("L", 50)]
        [DataRow("LX", 60)]
        [DataRow("LXX", 70)]
        [DataRow("LXXX", 80)]
        [DataRow("XC", 90)]
        public void Deve_converter_numeros_romanos_do_30_ao_90(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("C", 100)]
        [DataRow("CC", 200)]
        [DataRow("CCC", 300)]
        [DataRow("CD", 400)]
        [DataRow("D", 500)]
        [DataRow("DC", 600)]
        [DataRow("DCC", 700)]
        [DataRow("DCCC", 800)]
        [DataRow("CM", 900)]
        [DataRow("M", 1000)]
        public void Deve_converter_numeros_romanos_do_100_ao_1000(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("CX", 110)]
        [DataRow("CXX", 120)]
        [DataRow("CXXX", 130)]
        [DataRow("CXL", 140)]
        [DataRow("CL", 150)]
        [DataRow("CLX", 160)]
        [DataRow("CLXX", 170)]
        [DataRow("CLXXX", 180)]
        [DataRow("CXC", 190)]
        public void Deve_converter_numeros_romanos_do_100_ao_200(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("CXC", 190)]
        [DataRow("CXCI", 191)]
        [DataRow("CXCII", 192)]
        [DataRow("CXCIII", 193)]
        [DataRow("CXCIV", 194)]
        [DataRow("CXCV", 195)]
        [DataRow("CXCVI", 196)]
        [DataRow("CXCVII", 197)]
        [DataRow("CXCVIII", 198)]
        [DataRow("CXCIX", 199)]
        public void Deve_converter_numeros_romanos_do_190_ao_199(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("M", 1000)]
        [DataRow("MM", 2000)]
        [DataRow("MMM", 3000)]
        public void Deve_converter_numeros_romanos_do_1000_ao_3000(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("MMMCM", 3900)]
        [DataRow("MMMCMXC", 3990)]
        [DataRow("MMMCMXCIX", 3999)]
        [DataRow("MMMIX", 3009)]
        [DataRow("MMMXCIX", 3099)]
        [DataRow("MMMXC", 3090)]
        public void Deve_converter_numeros_romanos_do_3900_ao_3999(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("MMCM", 2900)]
        [DataRow("MMCMXC", 2990)]
        [DataRow("MMCMXCIX", 2999)]
        [DataRow("MMIX", 2009)]
        [DataRow("MMXCIX", 2099)]
        [DataRow("MMXC", 2090)]
        public void Deve_converter_numeros_romanos_do_2900_ao_2999(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("MCM", 1900)]
        [DataRow("MCMXC", 1990)]
        [DataRow("MCMXCIX", 1999)]
        [DataRow("MIX", 1009)]
        [DataRow("MXCIX", 1099)]
        [DataRow("MXC", 1090)]
        public void Deve_converter_numeros_romanos_do_1900_ao_1999(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow("CM", 900)]
        [DataRow("CMXC", 990)]
        [DataRow("CMXCIX", 999)]
        [DataRow("IX", 009)]
        [DataRow("XCIX", 099)]
        [DataRow("XC", 090)]
        public void Deve_converter_numeros_romanos_do_900_ao_999(string resultadoEsperado, int numero)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterNumero(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
