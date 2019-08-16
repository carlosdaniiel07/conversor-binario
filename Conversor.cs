using System;
using System.Collections.Generic;
using System.Linq;

namespace conversor_binario
{
    class Conversor {

        /* Retorna a representação binária de um número decimal */
        public string ToBinario(int numero) {
            var representacaoBinaria = "";
            var binarios = new List<int>();
            var novoNumero = numero;

            while(novoNumero >= 1) {
                var resultadoDivisao = novoNumero / 2;
                var restoDivisao = novoNumero % 2;

                novoNumero = resultadoDivisao;
                binarios.Add(restoDivisao);
            }

            for(var c = (binarios.Count - 1); c >= 0; c--) {
                representacaoBinaria += binarios[c].ToString();
            }

            return representacaoBinaria;
        }

        /* Retorna a representação decimal de um número binário */
        public int ToDecimal(string binario) {
            var numeros = new List<int>();
            var expoente = 0;
            char[] valoresAceitos = {'1', '0'};

            binario = binario.Trim();

            foreach(var caracter in binario) {
                if(!valoresAceitos.Contains(caracter)) {
                    throw new SystemException("A representação binária não parece estar correta.");
                }
            }

            for(var c = (binario.Length - 1); c >= 0; c--) {
                if(binario[c].Equals('1')) {
                    var valor = (int) Math.Pow(2, expoente);
                    numeros.Add(valor);
                }

                expoente += 1;
            }

            return numeros.Sum();
        }
    }
}